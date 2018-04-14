using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventana_Juego
{
    public partial class Menu_Juego : Form
    {
        string usuario;
        public Menu_Juego(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) groupBox2.Enabled = true;
            else groupBox2.Enabled = false;
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hacer que abra login de nuevo
            //this.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form1 ventana_juego = new Form1(usuario,false,1);
                ventana_juego.ShowDialog();
            }
            else if(radioButton2.Checked)
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
    }
}
