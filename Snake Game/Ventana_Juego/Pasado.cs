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
    public partial class Pasado : Form
    {
        int contador = 0;
        public Pasado()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (contador == 0)
            {
                label1.ForeColor = Color.Red;
            }
            if (contador == 1)
            {
                label1.ForeColor = Color.Blue;
            }
            if (contador == 2)
            {
                label1.ForeColor = Color.Green;
            }
            if (contador == 3)
            {
                label1.ForeColor = Color.Yellow;
            }
            if (contador == 4)
            {
                label1.ForeColor = Color.Black;
                contador = 0;
            }
            contador = contador + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            this.Dispose();
        }
    }
}
