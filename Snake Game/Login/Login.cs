using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Ventana_Juego;
namespace Login
{
    public partial class Login : Form
    {
        SoundPlayer simpleSound = new SoundPlayer("Packy - Save The Pleasantries (mp3cut.net).wav");
        int contador = 0;
        int currentcolor = 0;
        int a = 0;
        List<Color> colores = new List<Color>();
        Login_XML lg_xml;
        public Login()
        {
            lg_xml = new Login_XML();
            contador = contador + 1;
            InitializeComponent();
            playSimpleSound();
            timer1.Start();
            colores.Add(Color.FromArgb(33, 150, 243));
            colores.Add(Color.FromArgb(3, 169, 244));
            colores.Add(Color.FromArgb(0, 150, 136));
            colores.Add(Color.FromArgb(103, 58, 183));
            colores.Add(Color.FromArgb(156, 39, 176));
            colores.Add(Color.FromArgb(255, 87, 34));
            colores.Add(Color.FromArgb(255, 193, 7));
            colores.Add(Color.FromArgb(205, 220, 57));
        }
        private void playSimpleSound()
        {
            simpleSound.PlayLooping();
        }
        private void stopSimpleSound()
        {
            simpleSound.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentcolor < colores.Count - 1)
            {
                this.BackColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(a, colores[currentcolor], colores[currentcolor + 1]);

                if (a < 100)a++;
                else
                {
                    a = 0;
                    currentcolor++;
                }

            }
        }
        private void password_Leave_1(object sender, EventArgs e)
        {
            if (password.Text.Equals(""))
            {
                password.Text = "password";
                contador = 1;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (contador == 1)
            {
                password.Text = null;
                contador++;
            }
            if (contador > 1)
            {
                password.Text = password.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = new DialogResult();
            Form mensaje = new MessageBoxSnake();

            dialogo = mensaje.ShowDialog();

            if (dialogo == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro re = new Registro();
            this.Hide();
            re.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (username.Text.Equals(String.Empty))
                errorProvider1.SetError(username, "Complete los campos requeridos!");
            else if (password.Text.Equals("password"))
                errorProvider1.SetError(password, "Complete los campos requeridos!");
            else
            {
                string id_user = lg_xml.Verificar_Usuario(username.Text, password.Text);
                if (!id_user.Equals(String.Empty))
                {
                    Form1 Ventana_Juego = new Form1(id_user);
                    Ventana_Juego.Show();
                    //Hide
                }
                else
                {
                    MessageBox.Show("La cuenta o clave son incorrectas","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    username.Text = String.Empty;
                    password.Text = String.Empty;
                }
            }
        }
    }
}
