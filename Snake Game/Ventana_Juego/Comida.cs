﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventana_Juego
{
    class Comida : objeto
    {

        public Comida(int a, int b)
        {
            this.x = generar(a);//79
            this.y = generar(b);//39
        }
        public void dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Red), this.x, this.y, this.espacio, this.espacio);
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
