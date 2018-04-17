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
using Objetos;

namespace Ventana_Juego
{
    public partial class Menu_Juego : Form
    {
        string usuario;
        Login_XML lg_xml;
        public Menu_Juego(string usuario)
        {
            InitializeComponent();
            lg_xml = new Login_XML();
            this.usuario = usuario;
            groupBox2.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked) groupBox2.Visible = true;
            else groupBox2.Visible = false;
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login.Login lo = new Login.Login();
            lo.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Form1 ventana_juego = new Form1(usuario, false, 1);
                ventana_juego.ShowDialog();
            }
            else if (radioButton1.Checked)
            {
                Form1 ventana_juego = new Form1(usuario, false, 2);
                ventana_juego.ShowDialog();
            }
            else if (radioButton3.Checked)
            {
                if (radioButton4.Checked)
                {
                    Form1 ventana_juego = new Form1(usuario, true, 3);
                    ventana_juego.ShowDialog();
                }
                else
                {
                    Form1 ventana_juego = new Form1(usuario, false, 3);
                    ventana_juego.ShowDialog();
                }
            }
        }

        private void Menu_Juego_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reporte1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Records_Top rt = new Records_Top();
            rt.ShowDialog();
        }

        private void reporte2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El modo más jugado es el: " + lg_xml.Modo_Jugado());
        }
    }
}
