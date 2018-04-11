using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class MessageBoxSnake : Form
    {
        int currentcolor = 0;
        int a = 0;
        List<Color> colores = new List<Color>();
        public MessageBoxSnake()
        {
            InitializeComponent();
            timer1.Start();
            colores.Add(Color.FromArgb(156, 39, 176));
            colores.Add(Color.FromArgb(33, 152, 243));
            colores.Add(Color.FromArgb(2, 169, 240));
            colores.Add(Color.FromArgb(8, 150, 156));
            colores.Add(Color.FromArgb(103, 58, 133));
            colores.Add(Color.FromArgb(255, 87, 32));
            colores.Add(Color.FromArgb(255, 223, 1));
            colores.Add(Color.FromArgb(220, 220, 53));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentcolor < colores.Count - 1)
            {
                this.BackColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(a, colores[currentcolor], colores[currentcolor + 1]);

                if (a < 100)
                {
                    a++;
                }
                else
                {
                    a = 0;
                    currentcolor++;
                }

            }
        }

        private void MessageBoxSnake_Load(object sender, EventArgs e)
        {

        }
    }
}
