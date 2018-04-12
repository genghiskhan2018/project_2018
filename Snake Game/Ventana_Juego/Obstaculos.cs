using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ventana_Juego
{
    class Obstaculos : objeto
    {

        public Obstaculos(int a, int b)
        {
            this.x = a;//79
            this.y = b;//39
        }
        public void dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Black), this.x, this.y, this.espacio, this.espacio);
        }

        public void colocar(int a, int b)
        {
            this.x = generar(a);//79
            this.y = generar(b);//39
        }

        public int generar(int n)
        {
            Random random = new Random();
            int num = random.Next(0, n) * 10;
            return num;
        }
    }
}