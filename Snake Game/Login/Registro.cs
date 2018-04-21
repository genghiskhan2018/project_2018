using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace Login
{
    public partial class Registro : Form
    {
        int contador = 1;
        int contador2 = 1;
        Login_XML lg_xml;
        public Registro()
        {
            InitializeComponent();
            lg_xml = new Login_XML();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            this.Hide();
            lo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = new DialogResult();
            Form mensaje = new MessageBoxRegistro();

            dialogo = mensaje.ShowDialog();

            if (dialogo == DialogResult.Yes)
                Application.Exit();
            else
                return;
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

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text.Equals(""))
            {
                password.Text = "password";
                contador = 1;
            }
        }

        private void confirmpassword_Enter(object sender, EventArgs e)
        {
            if (contador2 == 1)
            {
                confirmpassword.Text = null;
                contador2++;
            }
            if (contador2 > 1)
            {
                confirmpassword.Text = confirmpassword.Text;
            }
        }

        private void confirmpassword_Leave(object sender, EventArgs e)
        {
            if (confirmpassword.Text.Equals(String.Empty))
            {
                confirmpassword.Text = "confirm";
                contador2 = 1;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!password.Text.Equals(confirmpassword.Text))
            {
                errorProvider1.SetError(password, "No coinciden las contraseñas!");
                errorProvider1.SetError(confirmpassword, "No coinciden las contraseñas!");
            }
            else if (nombre.Text.Equals(String.Empty))
                errorProvider1.SetError(nombre, "Complete los campos!");
            else if (password.Text.Equals("password"))
                errorProvider1.SetError(password, "Complete los campos!");
            else if (confirmpassword.Text.Equals("confirm"))
                errorProvider1.SetError(confirmpassword, "Complete los campos!");
            else
            {
                bool agregado = lg_xml.AgregarUsuario(nombre.Text, password.Text);
                if (agregado)
                {
                    MessageBox.Show("Usuario Agregado");
                    Login lo = new Login();
                    this.Hide();
                    lo.Show();
                }
                else
                {
                    MessageBox.Show("El usuario está en uso");
                    nombre.Text = String.Empty;
                    password.Text = String.Empty;
                    confirmpassword.Text = String.Empty;
                }
            }
        }
    }
}
