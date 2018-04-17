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
    public partial class UltimoNivelSup : Form
    {
        Login_XML lg_xml;
        string tipo;
        public UltimoNivelSup(string tipo)
        {
            this.tipo = tipo;
            InitializeComponent();
            lg_xml = new Login_XML();
        }

        private void UltimoNivelSup_Load(object sender, EventArgs e)
        {
            if (tipo.Equals("Nivel"))
            {
                dataGridView1.DataSource = lg_xml.UltimoNivelSup();
            }
            else if (tipo.Equals("Sesiones"))
            {
                dataGridView1.DataSource = lg_xml.Inicios_Sesion();
            }
            
        }
    }
}
