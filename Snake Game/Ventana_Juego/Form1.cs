using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace Ventana_Juego
{
    public partial class Form1 : Form
    {
        SoundPlayer boom = new SoundPlayer("boom.wav");
        SoundPlayer com = new SoundPlayer("pop.wav");
       
        int paso = 0;
        int atravesar = 0;
        bool obstaculos = true;
        int modo = 3;
        int s = 0;
        int m = 0;
        int lev = 1;
        int velocidad = 100;
        Graphics juego;
        Cola cabeza;
        Comida comida;
        Obstaculos obstaculo;
        Obstaculos obstaculo1;
        Obstaculos obstaculo2;
        Obstaculos obstaculo3;
        Obstaculos obstaculo4;
        Obstaculos obstaculo5;
        Obstaculos obstaculo6;
        Obstaculos obstaculo7;
        Obstaculos obstaculo8;
        Obstaculos obstaculo9;
        Obstaculos obstaculo10;
        int espacio;
        int xdir = 0, ydir = 0;
        string id_user;
        int puntaje = 1,movimientos = 0;
        string tipomovimiento = "";
        string tipomovimientotemp = "";
        Boolean ejex = true, ejey = true;
        Login_XML lg = new Login_XML();
        List<int> lista = new List<int>();
        public Form1(string id_user, bool obstaculos, int modo)
        {
            this.id_user = id_user;
            this.obstaculos = obstaculos;
            this.modo = modo;
            espacio = 10;
            InitializeComponent();
            juego = canvas.CreateGraphics();
            serialPort1.Open();
            if (modo == 1)
            {
                pasarniv1_modo1();
                bucle.Interval = velocidad;
            }
            if (modo == 2)
            {
                pasarniv1_modo2();
                bucle.Interval = velocidad;
            }
            if (modo == 3 && obstaculos == true)
            {
                pasarniv1_modo3_con();
                bucle.Interval = velocidad;
            }
            if (modo == 3 && obstaculos == false)
            {
                pasarniv1_modo3_sin();
                bucle.Interval = velocidad;
            }

        }
        public void pasarniv1_modo1()
        {
            reloj.Enabled = true;
            this.canvas.Size = new System.Drawing.Size(800, 400);
            xdir = 0;
            ydir = 0;
            puntaje = 0;
            puntos.Text = puntaje.ToString();
            ejex = true;
            ejey = true;
            cabeza = new Cola(10, 10);
            comida = new Comida(79, 39);

        }

        public void pasarniv1_modo2()
        {
            reloj.Enabled = true;
            Random random = new Random();
            paso = 0;
            this.canvas.Size = new System.Drawing.Size(800, 400);
            xdir = 0;
            ydir = 0;
            puntaje = 0;
            puntos.Text = puntaje.ToString();
            ejex = true;
            ejey = true;
            cabeza = new Cola(10, 10);
            comida = new Comida(79, 39);
            lista.Clear();
            
            for (int i = 0; i < 10; i++)
            {
                if ((i % 2) == 0)
                {
                    int a = random.Next(0, 79) * 10;
                    lista.Add(a);
                }
                else
                {
                    int b = random.Next(0, 39) * 10;
                    lista.Add(b);
                }
            }

            obstaculo = new Obstaculos(lista[0], lista[1]);
            obstaculo1 = new Obstaculos(lista[2], lista[3]);
            obstaculo2 = new Obstaculos(lista[4], lista[5]);
            obstaculo3 = new Obstaculos(lista[6], lista[7]);
            obstaculo4 = new Obstaculos(lista[8], lista[9]);


            while (true)
            {
                if (comida.interseccion(obstaculo) || comida.interseccion(obstaculo1) || comida.interseccion(obstaculo2)
                  || comida.interseccion(obstaculo3) || comida.interseccion(obstaculo4))
                {
                    comida = new Comida(79, 39);
                }
                else
                {
                    break;
                }
            }

        }

        public void pasarniv1_modo3_con()
        {
            gift.Visible = true;
            comodin.Visible = true;
            cajacomodin.Visible = true;
            atravesar = 0;
            reloj.Enabled = true;
            Random random = new Random();
            this.canvas.Size = new System.Drawing.Size(800, 400);
            ydir = 0;
            puntaje = 0;
            puntos.Text = puntaje.ToString();
            ejex = true;
            ejey = true;
            cabeza = new Cola(10, 10);
            comida = new Comida(79, 39);
            lista.Clear();
            for (int i = 0; i < 10; i++)
            {
                if ((i % 2) == 0)
                {
                    int a = random.Next(0, 79) * 10;
                    lista.Add(a);
                }
                else
                {
                    int b = random.Next(0, 39) * 10;
                    lista.Add(b);
                }
            }

            obstaculo = new Obstaculos(lista[0], lista[1]);
            obstaculo1 = new Obstaculos(lista[2], lista[3]);
            obstaculo2 = new Obstaculos(lista[4], lista[5]);


            while (true)
            {
                if (comida.interseccion(obstaculo) || comida.interseccion(obstaculo1) || comida.interseccion(obstaculo2))
                {
                    comida = new Comida(79, 39);
                }
                else
                {
                    break;
                }
            }

        }

        public void pasarniv1_modo3_sin()
        {
            reloj.Enabled = true;
            this.canvas.Size = new System.Drawing.Size(800, 400);
            xdir = 0;
            ydir = 0;
            puntaje = 0;
            puntos.Text = puntaje.ToString();
            ejex = true;
            ejey = true;
            cabeza = new Cola(10, 10);
            comida = new Comida(79, 39);
        }

        public void pasarniv2_modo1()
        {
            xdir = 0;
            ydir = 0;
            puntos.Text = puntaje.ToString();
            ejex = true;
            ejey = true;
            cabeza = new Cola(10, 10);
            comida = new Comida(59, 29);
        }

        public void pasarniv2_modo2()
        {
            paso = 0;
            xdir = 0;
            ydir = 0;
            puntos.Text = puntaje.ToString();
            ejex = true;
            ejey = true;
            cabeza = new Cola(10, 10);
            comida = new Comida(59, 29);

            Random random = new Random();
            lista.Clear();
            for (int i = 0; i < 18; i++)
            {
                if ((i % 2) == 0)
                {
                    int a = random.Next(0, 59) * 10;
                    lista.Add(a);
                }
                else
                {
                    int b = random.Next(0, 29) * 10;
                    lista.Add(b);
                }
            }

            obstaculo = new Obstaculos(lista[0], lista[1]);
            obstaculo1 = new Obstaculos(lista[2], lista[3]);
            obstaculo2 = new Obstaculos(lista[4], lista[5]);
            obstaculo3 = new Obstaculos(lista[6], lista[7]);
            obstaculo4 = new Obstaculos(lista[8], lista[9]);
            obstaculo5 = new Obstaculos(lista[10], lista[11]);
            obstaculo6 = new Obstaculos(lista[12], lista[13]);
            obstaculo7 = new Obstaculos(lista[14], lista[15]);
            obstaculo8 = new Obstaculos(lista[16], lista[17]);

            while (true)
            {
                if (comida.interseccion(obstaculo) || comida.interseccion(obstaculo1) || comida.interseccion(obstaculo2)
                    || comida.interseccion(obstaculo3) || comida.interseccion(obstaculo4) || comida.interseccion(obstaculo5)
                     || comida.interseccion(obstaculo6) || comida.interseccion(obstaculo7) || comida.interseccion(obstaculo8))
                {
                    comida = new Comida(49, 19);
                }
                else
                {
                    break;
                }
            }
        }

        public void pasarniv2_modo3_con()
        {
            xdir = 0;
            ydir = 0;
            puntos.Text = puntaje.ToString();
            ejex = true;
            ejey = true;
            cabeza = new Cola(10, 10);
            comida = new Comida(59, 29);

            Random random = new Random();
            lista.Clear();
            for (int i = 0; i < 12; i++)
            {
                if ((i % 2) == 0)
                {
                    int a = random.Next(0, 59) * 10;
                    lista.Add(a);
                }
                else
                {
                    int b = random.Next(0, 29) * 10;
                    lista.Add(b);
                }
            }

            obstaculo = new Obstaculos(lista[0], lista[1]);
            obstaculo1 = new Obstaculos(lista[2], lista[3]);
            obstaculo2 = new Obstaculos(lista[4], lista[5]);
            obstaculo3 = new Obstaculos(lista[6], lista[7]);
            obstaculo4 = new Obstaculos(lista[8], lista[9]);
            obstaculo5 = new Obstaculos(lista[10], lista[11]);

            while (true)
            {
                if (comida.interseccion(obstaculo) || comida.interseccion(obstaculo1) || comida.interseccion(obstaculo2)
                    || comida.interseccion(obstaculo3) || comida.interseccion(obstaculo4) || comida.interseccion(obstaculo5))
                {
                    comida = new Comida(49, 19);
                }
                else
                {
                    break;
                }
            }
        }

        public void pasarniv2_modo3_sin()
        {
            xdir = 0;
            ydir = 0;
            puntos.Text = puntaje.ToString();
            ejex = true;
            ejey = true;
            cabeza = new Cola(10, 10);
            comida = new Comida(59, 29);
        }

        public void pasarniv3_modo1()
        {
            xdir = 0;
            ydir = 0;
            puntos.Text = puntaje.ToString();
            ejex = true;
            ejey = true;
            cabeza = new Cola(10, 10);
            comida = new Comida(49, 19);
        }

        public void pasarniv3_modo2()
        {
            paso = 0;
            xdir = 0;
            ydir = 0;
            puntos.Text = puntaje.ToString();
            ejex = true;
            ejey = true;
            cabeza = new Cola(10, 10);
            comida = new Comida(49, 19);
            Random random = new Random();
            lista.Clear();
            for (int i = 0; i < 22; i++)
            {
                if ((i % 2) == 0)
                {
                    int a = random.Next(0, 49) * 10;
                    lista.Add(a);
                }
                else
                {
                    int b = random.Next(0, 19) * 10;
                    lista.Add(b);
                }
            }

            obstaculo = new Obstaculos(lista[0], lista[1]);
            obstaculo1 = new Obstaculos(lista[2], lista[3]);
            obstaculo2 = new Obstaculos(lista[4], lista[5]);
            obstaculo3 = new Obstaculos(lista[6], lista[7]);
            obstaculo4 = new Obstaculos(lista[8], lista[9]);
            obstaculo5 = new Obstaculos(lista[10], lista[11]);
            obstaculo6 = new Obstaculos(lista[12], lista[13]);
            obstaculo7 = new Obstaculos(lista[14], lista[15]);
            obstaculo8 = new Obstaculos(lista[16], lista[17]);
            obstaculo9 = new Obstaculos(lista[18], lista[19]);
            obstaculo10 = new Obstaculos(lista[20], lista[21]);

            while (true)
            {
                if (comida.interseccion(obstaculo) || comida.interseccion(obstaculo1) || comida.interseccion(obstaculo2) || comida.interseccion(obstaculo3)
                    || comida.interseccion(obstaculo4) || comida.interseccion(obstaculo5) || comida.interseccion(obstaculo6)
                    || comida.interseccion(obstaculo7) || comida.interseccion(obstaculo8) || comida.interseccion(obstaculo9)
                    || comida.interseccion(obstaculo10))
                {
                    comida = new Comida(49, 19);
                }
                else
                {
                    break;
                }
            }
        }

        public void pasarniv3_modo3_con()
        {
            xdir = 0;
            ydir = 0;
            puntos.Text = puntaje.ToString();
            ejex = true;
            ejey = true;
            cabeza = new Cola(10, 10);
            comida = new Comida(49, 19);
            Random random = new Random();
            lista.Clear();
            for (int i = 0; i < 20; i++)
            {
                if ((i % 2) == 0)
                {
                    int a = random.Next(0, 49) * 10;
                    lista.Add(a);
                }
                else
                {
                    int b = random.Next(0, 19) * 10;
                    lista.Add(b);
                }
            }

            obstaculo = new Obstaculos(lista[0], lista[1]);
            obstaculo1 = new Obstaculos(lista[2], lista[3]);
            obstaculo2 = new Obstaculos(lista[4], lista[5]);
            obstaculo3 = new Obstaculos(lista[6], lista[7]);
            obstaculo4 = new Obstaculos(lista[8], lista[9]);
            obstaculo5 = new Obstaculos(lista[10], lista[11]);
            obstaculo6 = new Obstaculos(lista[12], lista[13]);
            obstaculo7 = new Obstaculos(lista[14], lista[15]);
            obstaculo8 = new Obstaculos(lista[16], lista[17]);
            obstaculo9 = new Obstaculos(lista[18], lista[19]);

            while (true)
            {
                if (comida.interseccion(obstaculo) || comida.interseccion(obstaculo1) || comida.interseccion(obstaculo2) || comida.interseccion(obstaculo3)
                    || comida.interseccion(obstaculo4) || comida.interseccion(obstaculo5) || comida.interseccion(obstaculo6)
                    || comida.interseccion(obstaculo7) || comida.interseccion(obstaculo8) || comida.interseccion(obstaculo9))
                {
                    comida = new Comida(49, 19);
                }
                else
                {
                    break;
                }
            }
        }

        public void pasarniv3_modo3_sin()
        {
            xdir = 0;
            ydir = 0;
            puntos.Text = puntaje.ToString();
            ejex = true;
            ejey = true;
            cabeza = new Cola(10, 10);
            comida = new Comida(49, 19);
        }
        public void findeJuego()
        {
            if (modo == 1)
            {
                lg.AgregarRecord(id_user, int.Parse(lblMovimientos.Text), modo, lev, puntos.Text, m + ":" + s);
                xdir = 0;
                ydir = 0;
                movimientos = 0;
                puntos.Text = "0";
                lblMovimientos.Text = "0";
                ejex = true;
                ejey = true;
                velocidad = 100;
                puntaje = 0;
                puntos.Text = "0";
                lev = 1;
                reloj.Stop();
                s = 0;
                m = 0;
                boom.Play();
                this.Dispose();  
                MessageBox.Show("Perdiste");
                
            }
            if (modo == 2)
            {
                lg.AgregarRecord(id_user, movimientos, modo, lev, puntos.Text, m + ":" + s);
                xdir = 0;
                ydir = 0;
                movimientos = 0;
                puntos.Text = "0";
                lblMovimientos.Text = "0";
                ejex = true;
                ejey = true;
                velocidad = 100;
                puntaje = 0;
                puntos.Text = "0";
                lev = 1;
                reloj.Stop();
                s = 0;
                m = 0;
                boom.Play();
                this.Dispose();
                MessageBox.Show("Perdiste");
                
            }
            if (modo == 3 && obstaculos == true)
            {
                lg.AgregarRecord(id_user, movimientos, modo, lev, puntos.Text, m + ":" + s);
                gift.Visible = false;
                cajacomodin.Visible = false;
                comodin.Visible = false;
                xdir = 0;
                ydir = 0;
                movimientos = 0;
                puntos.Text = "0";
                lblMovimientos.Text = "0";
                ejex = true;
                ejey = true;
                velocidad = 100;
                puntaje = 0;
                puntos.Text = "0";
                lev = 1;
                reloj.Stop();
                s = 0;
                m = 0;
                boom.Play();
                this.Dispose();
                MessageBox.Show("Perdiste");
                
            }
            if (modo == 3 && obstaculos == false)
            {
                lg.AgregarRecord(id_user, movimientos, modo, lev, puntos.Text, m + ":" + s);
                velocidad = 100;
                puntaje = 0;
                puntos.Text = "0";
                lev = 1;
                reloj.Stop();
                s = 0;
                m = 0;
                boom.Play();
                this.Dispose();
                MessageBox.Show("Perdiste");
                
            }
        }
        public void choqueCuerpo()
        {
            Cola temp;
            if (!(cabeza.verSiguiente() == null))
            {
                temp = cabeza.verSiguiente().verSiguiente();
            }
            else
            {
                temp = null;
            }

            while (temp != null)
            {
                if (cabeza.interseccion(temp))
                {
                    findeJuego();
                    MessageBox.Show("Choque de cuerpo");
                    break;
                }
                else
                {
                    temp = temp.verSiguiente();
                }
            }
            
        }

        public void choquePared()
        {
            if (modo == 1)
            {

                if (lev == 1)
                {
                    if ((cabeza.getX() < 0 || cabeza.getX() > 790 || cabeza.getY() < 0 || cabeza.getY() > 390))
                    {
                        findeJuego();
                    }
                }


                if (lev == 2)
                {
                    if ((cabeza.getX() < 0 || cabeza.getX() > 590 || cabeza.getY() < 0 || cabeza.getY() > 290))
                    {
                        findeJuego();
                    }
                }

                if (lev == 3)
                {
                    if ((cabeza.getX() < 0 || cabeza.getX() > 490 || cabeza.getY() < 0 || cabeza.getY() > 190))
                    {
                        findeJuego();
                    }
                }
            }

            if (modo == 2)
            {

                if (lev == 1)
                {
                    if ((cabeza.getX() < 0))
                    {
                        paso = paso + 1;
                        xdir = 800;
                        cabeza.setxy(cabeza.getX() + xdir, cabeza.getY() + ydir);
                        xdir = -10;
                    }
                    if ((cabeza.getX() > 790))
                    {
                        paso = paso + 1;
                        xdir = 800;
                        cabeza.setxy(cabeza.getX() - xdir, cabeza.getY() + ydir);
                        xdir = 10;
                    }
                    if ((cabeza.getY() < 0))
                    {
                        paso = paso + 1;
                        ydir = 400;
                        cabeza.setxy(cabeza.getX() + xdir, cabeza.getY() + ydir);
                        ydir = -10;
                    }
                    if ((cabeza.getY() > 390))
                    {
                        paso = paso + 1;
                        ydir = 400;
                        cabeza.setxy(cabeza.getX() + xdir, cabeza.getY() - ydir);
                        ydir = 10;
                    }
                    if (paso >= 6)
                    {
                        paso = 5;
                    }
                    if (paso == 1)
                    {
                        if (cabeza.interseccion(obstaculo))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 2)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 3)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 4)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                            || (cabeza.interseccion(obstaculo3)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 5)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                            || (cabeza.interseccion(obstaculo3)) || (cabeza.interseccion(obstaculo4)))
                        {
                            findeJuego();
                        }
                    }

                }


                if (lev == 2)
                {
                    if ((cabeza.getX() < 0))
                    {
                        paso = paso + 1;
                        xdir = 600;
                        cabeza.setxy(cabeza.getX() + xdir, cabeza.getY() + ydir);
                        xdir = -10;
                    }
                    if ((cabeza.getX() > 590))
                    {
                        paso = paso + 1;
                        xdir = 600;
                        cabeza.setxy(cabeza.getX() - xdir, cabeza.getY() + ydir);
                        xdir = 10;
                    }
                    if ((cabeza.getY() < 0))
                    {
                        paso = paso + 1;
                        ydir = 300;
                        cabeza.setxy(cabeza.getX() + xdir, cabeza.getY() + ydir);
                        ydir = -10;
                    }
                    if ((cabeza.getY() > 290))
                    {
                        paso = paso + 1;
                        ydir = 300;
                        cabeza.setxy(cabeza.getX() + xdir, cabeza.getY() - ydir);
                        ydir = 10;
                    }
                    if (paso >= 10)
                    {
                        paso = 9;
                    }
                    if (paso == 1)
                    {
                        if (cabeza.interseccion(obstaculo))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 2)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 3)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 4)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                            || (cabeza.interseccion(obstaculo3)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 5)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                            || (cabeza.interseccion(obstaculo3)) || (cabeza.interseccion(obstaculo4)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 6)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                            || (cabeza.interseccion(obstaculo3)) || (cabeza.interseccion(obstaculo4)) || (cabeza.interseccion(obstaculo5)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 7)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                            || (cabeza.interseccion(obstaculo3)) || (cabeza.interseccion(obstaculo4)) || (cabeza.interseccion(obstaculo5))
                            || (cabeza.interseccion(obstaculo6)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 8)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                            || (cabeza.interseccion(obstaculo3)) || (cabeza.interseccion(obstaculo4)) || (cabeza.interseccion(obstaculo5))
                            || (cabeza.interseccion(obstaculo6)) || (cabeza.interseccion(obstaculo7)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 9)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                            || (cabeza.interseccion(obstaculo3)) || (cabeza.interseccion(obstaculo4)) || (cabeza.interseccion(obstaculo5))
                            || (cabeza.interseccion(obstaculo6)) || (cabeza.interseccion(obstaculo7)) || (cabeza.interseccion(obstaculo8)))
                        {
                            findeJuego();
                        }
                    }



                }

                if (lev == 3)
                {
                    if ((cabeza.getX() < 0))
                    {
                        paso = paso + 1;
                        xdir = 500;
                        cabeza.setxy(cabeza.getX() + xdir, cabeza.getY() + ydir);
                        xdir = -10;
                    }
                    if ((cabeza.getX() > 490))
                    {
                        paso = paso + 1;
                        xdir = 500;
                        cabeza.setxy(cabeza.getX() - xdir, cabeza.getY() + ydir);
                        xdir = 10;
                    }
                    if ((cabeza.getY() < 0))
                    {
                        paso = paso + 1;
                        ydir = 200;
                        cabeza.setxy(cabeza.getX() + xdir, cabeza.getY() + ydir);
                        ydir = -10;
                    }
                    if ((cabeza.getY() > 190))
                    {
                        paso = paso + 1;
                        ydir = 200;
                        cabeza.setxy(cabeza.getX() + xdir, cabeza.getY() - ydir);
                        ydir = 10;
                    }
                    if (paso >= 12)
                    {
                        paso = 11;
                    }
                    if (paso == 1)
                    {
                        if (cabeza.interseccion(obstaculo))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 2)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 3)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 4)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                            || (cabeza.interseccion(obstaculo3)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 5)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                            || (cabeza.interseccion(obstaculo3)) || (cabeza.interseccion(obstaculo4)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 6)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                            || (cabeza.interseccion(obstaculo3)) || (cabeza.interseccion(obstaculo4)) || (cabeza.interseccion(obstaculo5)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 7)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                            || (cabeza.interseccion(obstaculo3)) || (cabeza.interseccion(obstaculo4)) || (cabeza.interseccion(obstaculo5))
                            || (cabeza.interseccion(obstaculo6)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 8)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                            || (cabeza.interseccion(obstaculo3)) || (cabeza.interseccion(obstaculo4)) || (cabeza.interseccion(obstaculo5))
                            || (cabeza.interseccion(obstaculo6)) || (cabeza.interseccion(obstaculo7)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 9)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                            || (cabeza.interseccion(obstaculo3)) || (cabeza.interseccion(obstaculo4)) || (cabeza.interseccion(obstaculo5))
                            || (cabeza.interseccion(obstaculo6)) || (cabeza.interseccion(obstaculo7)) || (cabeza.interseccion(obstaculo8)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 10)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                            || (cabeza.interseccion(obstaculo3)) || (cabeza.interseccion(obstaculo4)) || (cabeza.interseccion(obstaculo5))
                            || (cabeza.interseccion(obstaculo6)) || (cabeza.interseccion(obstaculo7)) || (cabeza.interseccion(obstaculo8))
                            || (cabeza.interseccion(obstaculo9)))
                        {
                            findeJuego();
                        }
                    }
                    if (paso == 11)
                    {
                        if (cabeza.interseccion(obstaculo) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                            || (cabeza.interseccion(obstaculo3)) || (cabeza.interseccion(obstaculo4)) || (cabeza.interseccion(obstaculo5))
                            || (cabeza.interseccion(obstaculo6)) || (cabeza.interseccion(obstaculo7)) || (cabeza.interseccion(obstaculo8))
                            || (cabeza.interseccion(obstaculo9)) || (cabeza.interseccion(obstaculo10)))
                        {
                            findeJuego();
                        }
                    }



                }
            }

            if (modo == 3 && obstaculos == true)
            {
                comodin.Text = atravesar.ToString();

                if (lev == 1)
                {
                    if ((cabeza.getX() < 0 || cabeza.getX() > 790 || cabeza.getY() < 0 || cabeza.getY() > 390)
                        || ((cabeza.interseccion(obstaculo)) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))))
                    {
                        findeJuego();
                    }
                }


                if (lev == 2)
                {
                    if ((cabeza.getX() < 0 || cabeza.getX() > 590 || cabeza.getY() < 0 || cabeza.getY() > 290)
                        || ((cabeza.interseccion(obstaculo)) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                        || (cabeza.interseccion(obstaculo3)) || (cabeza.interseccion(obstaculo4)) || (cabeza.interseccion(obstaculo5)))
                        && atravesar == 0)
                    {
                        findeJuego();
                    }

                    if ((cabeza.getX() < 0 || cabeza.getX() > 590 || cabeza.getY() < 0 || cabeza.getY() > 290)
                        || ((cabeza.interseccion(obstaculo)) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                        || (cabeza.interseccion(obstaculo3)) || (cabeza.interseccion(obstaculo4)) || (cabeza.interseccion(obstaculo5)))
                        && atravesar > 0)
                    {
                        atravesar = atravesar - 1;
                    }

                }

                if (lev == 3)
                {
                    if ((cabeza.getX() < 0 || cabeza.getX() > 490 || cabeza.getY() < 0 || cabeza.getY() > 190)
                        || ((cabeza.interseccion(obstaculo)) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                        || (cabeza.interseccion(obstaculo3)) || (cabeza.interseccion(obstaculo4)) || (cabeza.interseccion(obstaculo5))
                        || (cabeza.interseccion(obstaculo6)) || (cabeza.interseccion(obstaculo7)) || (cabeza.interseccion(obstaculo8))
                        || (cabeza.interseccion(obstaculo9))) && atravesar <= 0)
                    {
                        findeJuego();
                    }

                    if ((cabeza.getX() < 0 || cabeza.getX() > 490 || cabeza.getY() < 0 || cabeza.getY() > 190)
                        || ((cabeza.interseccion(obstaculo)) || (cabeza.interseccion(obstaculo1)) || (cabeza.interseccion(obstaculo2))
                        || (cabeza.interseccion(obstaculo3)) || (cabeza.interseccion(obstaculo4)) || (cabeza.interseccion(obstaculo5))
                        || (cabeza.interseccion(obstaculo6)) || (cabeza.interseccion(obstaculo7)) || (cabeza.interseccion(obstaculo8))
                        || (cabeza.interseccion(obstaculo9))) && atravesar > 0)
                    {
                        atravesar = atravesar - 1;
                    }
                }

            }

            if (modo == 3 && obstaculos == false)
            {

                if (lev == 1)
                {
                    if ((cabeza.getX() < 0 || cabeza.getX() > 790 || cabeza.getY() < 0 || cabeza.getY() > 390))
                    {
                        findeJuego();
                    }
                }


                if (lev == 2)
                {
                    if ((cabeza.getX() < 0 || cabeza.getX() > 590 || cabeza.getY() < 0 || cabeza.getY() > 290))
                    {
                        findeJuego();
                    }
                }

                if (lev == 3)
                {
                    if ((cabeza.getX() < 0 || cabeza.getX() > 490 || cabeza.getY() < 0 || cabeza.getY() > 190))
                    {
                        findeJuego();
                    }
                }

            }
        }

        public void dibujar()
        {
            if (modo == 1)
            {
                if (lev == 1)
                {
                    juego.Clear(Color.ForestGreen);
                    cabeza.dibujar(juego);
                    comida.dibujar(juego);
                    bucle.Interval = velocidad;
                }

                if (lev == 2)
                {
                    juego.Clear(Color.ForestGreen);
                    cabeza.dibujar(juego);
                    comida.dibujar(juego);
                    bucle.Interval = velocidad;
                }

                if (lev == 3)
                {
                    juego.Clear(Color.ForestGreen);
                    cabeza.dibujar(juego);
                    comida.dibujar(juego);
                    bucle.Interval = velocidad;
                }
            }

            if (modo == 2)
            {
                if (lev == 1)
                {
                    juego.Clear(Color.ForestGreen);
                    cabeza.dibujar(juego);
                    comida.dibujar(juego);
                    if (paso == 1)
                    {
                        obstaculo.dibujar(juego);
                    }
                    if (paso == 2)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                    }
                    if (paso == 3)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                    }
                    if (paso == 4)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                        obstaculo3.dibujar(juego);
                    }
                    if (paso == 5)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                        obstaculo3.dibujar(juego);
                        obstaculo4.dibujar(juego);
                    }
                    bucle.Interval = velocidad;
                }

                if (lev == 2)
                {
                    juego.Clear(Color.ForestGreen);
                    cabeza.dibujar(juego);
                    comida.dibujar(juego);
                    juego.Clear(Color.ForestGreen);
                    cabeza.dibujar(juego);
                    comida.dibujar(juego);
                    if (paso == 1)
                    {
                        obstaculo.dibujar(juego);
                    }
                    if (paso == 2)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                    }
                    if (paso == 3)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                    }
                    if (paso == 4)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                        obstaculo3.dibujar(juego);
                    }
                    if (paso == 5)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                        obstaculo3.dibujar(juego);
                        obstaculo4.dibujar(juego);
                    }
                    if (paso == 6)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                        obstaculo3.dibujar(juego);
                        obstaculo4.dibujar(juego);
                        obstaculo5.dibujar(juego);
                    }
                    if (paso == 7)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                        obstaculo3.dibujar(juego);
                        obstaculo4.dibujar(juego);
                        obstaculo5.dibujar(juego);
                        obstaculo6.dibujar(juego);
                    }
                    if (paso == 8)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                        obstaculo3.dibujar(juego);
                        obstaculo4.dibujar(juego);
                        obstaculo5.dibujar(juego);
                        obstaculo6.dibujar(juego);
                        obstaculo7.dibujar(juego);
                    }
                    if (paso == 9)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                        obstaculo3.dibujar(juego);
                        obstaculo4.dibujar(juego);
                        obstaculo5.dibujar(juego);
                        obstaculo6.dibujar(juego);
                        obstaculo7.dibujar(juego);
                        obstaculo8.dibujar(juego);
                    }
                    bucle.Interval = velocidad;
                }

                if (lev == 3)
                {
                    juego.Clear(Color.ForestGreen);
                    cabeza.dibujar(juego);
                    comida.dibujar(juego);
                    if (paso == 1)
                    {
                        obstaculo.dibujar(juego);
                    }
                    if (paso == 2)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                    }
                    if (paso == 3)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                    }
                    if (paso == 4)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                        obstaculo3.dibujar(juego);
                    }
                    if (paso == 5)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                        obstaculo3.dibujar(juego);
                        obstaculo4.dibujar(juego);
                    }
                    if (paso == 6)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                        obstaculo3.dibujar(juego);
                        obstaculo4.dibujar(juego);
                        obstaculo5.dibujar(juego);
                    }
                    if (paso == 7)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                        obstaculo3.dibujar(juego);
                        obstaculo4.dibujar(juego);
                        obstaculo5.dibujar(juego);
                        obstaculo6.dibujar(juego);
                    }
                    if (paso == 8)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                        obstaculo3.dibujar(juego);
                        obstaculo4.dibujar(juego);
                        obstaculo5.dibujar(juego);
                        obstaculo6.dibujar(juego);
                        obstaculo7.dibujar(juego);
                    }
                    if (paso == 9)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                        obstaculo3.dibujar(juego);
                        obstaculo4.dibujar(juego);
                        obstaculo5.dibujar(juego);
                        obstaculo6.dibujar(juego);
                        obstaculo7.dibujar(juego);
                        obstaculo8.dibujar(juego);
                    }
                    if (paso == 10)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                        obstaculo3.dibujar(juego);
                        obstaculo4.dibujar(juego);
                        obstaculo5.dibujar(juego);
                        obstaculo6.dibujar(juego);
                        obstaculo7.dibujar(juego);
                        obstaculo8.dibujar(juego);
                        obstaculo9.dibujar(juego);
                    }
                    if (paso == 11)
                    {
                        obstaculo.dibujar(juego);
                        obstaculo1.dibujar(juego);
                        obstaculo2.dibujar(juego);
                        obstaculo3.dibujar(juego);
                        obstaculo4.dibujar(juego);
                        obstaculo5.dibujar(juego);
                        obstaculo6.dibujar(juego);
                        obstaculo7.dibujar(juego);
                        obstaculo8.dibujar(juego);
                        obstaculo9.dibujar(juego);
                        obstaculo10.dibujar(juego);
                    }
                    bucle.Interval = velocidad;
                }
            }

            if (modo == 3 && obstaculos == true)
            {
                if (lev == 1)
                {
                    juego.Clear(Color.ForestGreen);
                    cabeza.dibujar(juego);
                    comida.dibujar(juego);
                    obstaculo.dibujar(juego);
                    obstaculo1.dibujar(juego);
                    obstaculo2.dibujar(juego);
                    bucle.Interval = velocidad;
                }

                if (lev == 2)
                {
                    juego.Clear(Color.ForestGreen);
                    cabeza.dibujar(juego);
                    comida.dibujar(juego);
                    obstaculo.dibujar(juego);
                    obstaculo1.dibujar(juego);
                    obstaculo2.dibujar(juego);
                    obstaculo3.dibujar(juego);
                    obstaculo4.dibujar(juego);
                    obstaculo5.dibujar(juego);
                    bucle.Interval = velocidad;
                }

                if (lev == 3)
                {
                    juego.Clear(Color.ForestGreen);
                    cabeza.dibujar(juego);
                    comida.dibujar(juego);
                    obstaculo.dibujar(juego);
                    obstaculo1.dibujar(juego);
                    obstaculo2.dibujar(juego);
                    obstaculo3.dibujar(juego);
                    obstaculo4.dibujar(juego);
                    obstaculo5.dibujar(juego);
                    obstaculo6.dibujar(juego);
                    obstaculo7.dibujar(juego);
                    obstaculo8.dibujar(juego);
                    obstaculo9.dibujar(juego);
                    bucle.Interval = velocidad;
                }
            }

            if (modo == 3 && obstaculos == false)
            {
                if (lev == 1)
                {
                    juego.Clear(Color.ForestGreen);
                    cabeza.dibujar(juego);
                    comida.dibujar(juego);
                    bucle.Interval = velocidad;
                }

                if (lev == 2)
                {
                    juego.Clear(Color.ForestGreen);
                    cabeza.dibujar(juego);
                    comida.dibujar(juego);
                    bucle.Interval = velocidad;
                }

                if (lev == 3)
                {
                    juego.Clear(Color.ForestGreen);
                    cabeza.dibujar(juego);
                    comida.dibujar(juego);
                    bucle.Interval = velocidad;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (ejex)
            {
                if (e.KeyCode == Keys.Up)
                {
                    ydir = -espacio;
                    xdir = 0;
                    ejex = false;
                    ejey = true;
                }
                if (e.KeyCode == Keys.Down)
                {
                    ydir = espacio;
                    xdir = 0;
                    ejex = false;
                    ejey = true;
                }
            }
            if (ejey)
            {
                if (e.KeyCode == Keys.Right)
                {
                    ydir = 0;
                    xdir = espacio;
                    ejex = true;
                    ejey = false;
                }
                if (e.KeyCode == Keys.Left)
                {
                    ydir = 0;
                    xdir = -espacio;
                    ejex = true;
                    ejey = false;
                }
            }
            verificarMovimientos();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {

                tipomovimiento = serialPort1.ReadLine().ToString();
                if (ejex)
                {
                    if (serialPort1.ReadLine().Equals("UP"))
                    {
                        ydir = -espacio;
                        xdir = 0;
                        ejex = false;
                        ejey = true;
                    }
                    if (serialPort1.ReadLine().Equals("DOWN"))
                    {
                        ydir = espacio;
                        xdir = 0;
                        ejex = false;
                        ejey = true;
                    }
                }
                if (ejey)
                {
                    if (serialPort1.ReadLine().Equals("RIGHT"))
                    {
                        ydir = 0;
                        xdir = espacio;
                        ejex = true;
                        ejey = false;
                    }
                    if (serialPort1.ReadLine().Equals("LEFT"))
                    {
                        ydir = 0;
                        xdir = -espacio;
                        ejex = true;
                        ejey = false;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            s++;
            if (s > 0 && s <= 59)
            {
                rel.Text = m.ToString() + ":" + s.ToString();

            }
            else
            {
                s = 0;
                m = m + 1;
                rel.Text = m.ToString() + ":" + s.ToString();
            }
        }

        private void bucle_Tick(object sender, EventArgs e)
        {
            verificarMovimientos();
            dibujar();
            movimiento();
            choqueCuerpo();
            choquePared();
            if (modo == 1)
            {
                if (cabeza.interseccion(comida))
                {
                    com.Play();
                    comida.colocar(((canvas.Size.Width / 10) - 10), ((canvas.Size.Height / 10) - 10));

                    cabeza.meter();

                    puntaje = puntaje + 1;
                    puntos.Text = puntaje.ToString();
                    velocidad_despl();


                    if (puntaje == 2 && lev == 1)
                    {

                        lev = lev + 1;
                        this.canvas.Size = new System.Drawing.Size(600, 300);
                        pasarniv2_modo1();

                    }

                    if (puntaje == 5 && lev == 2)
                    {

                        lev = lev + 1;
                        this.canvas.Size = new System.Drawing.Size(500, 200);
                        pasarniv3_modo1();

                    }
                    if (puntaje == 10 && lev == 3)
                    {
                        lg.AgregarRecord(id_user, int.Parse(lblMovimientos.Text), modo, lev, puntos.Text, m + ":" + s);
                        this.Dispose();
                        Pasado pas = new Pasado();
                        pas.ShowDialog();
                    }
                }
            }

            if (modo == 2)
            {
                if (cabeza.interseccion(comida))
                {
                    com.Play();
                    comida.colocar(((canvas.Size.Width / 10) - 10), ((canvas.Size.Height / 10) - 10));

                    cabeza.meter();

                    puntaje = puntaje + 1;
                    puntos.Text = puntaje.ToString();
                    velocidad_despl();


                    if (puntaje == 2 && lev == 1)
                    {

                        lev = lev + 1;
                        this.canvas.Size = new System.Drawing.Size(600, 300);
                        pasarniv2_modo2();

                    }

                    if (puntaje == 5 && lev == 2)
                    {

                        lev = lev + 1;
                        this.canvas.Size = new System.Drawing.Size(500, 200);
                        pasarniv3_modo2();

                    }
                    if (puntaje == 10 && lev == 3)
                    {
                        lg.AgregarRecord(id_user, int.Parse(lblMovimientos.Text), modo, lev, puntos.Text, m + ":" + s);
                        this.Dispose();
                        Pasado pas = new Pasado();
                        pas.ShowDialog();
                    }
                }
            }

            if (modo == 3 && obstaculos == true)
            {
                if (cabeza.interseccion(comida))
                {
                    com.Play();
                    comida.colocar(((canvas.Size.Width / 10) - 10), ((canvas.Size.Height / 10) - 10));

                    cabeza.meter();

                    puntaje = puntaje + 1;
                    puntos.Text = puntaje.ToString();
                    velocidad_despl();


                    if (puntaje == 2 && lev == 1)
                    {
                        atravesar = atravesar + 1;
                        lev = lev + 1;
                        this.canvas.Size = new System.Drawing.Size(600, 300);
                        pasarniv2_modo3_con();

                    }

                    if (puntaje == 5 && lev == 2)
                    {

                        lev = lev + 1;
                        this.canvas.Size = new System.Drawing.Size(500, 200);
                        pasarniv3_modo3_con();

                    }

                    if (puntaje == 4)
                    {
                        atravesar = atravesar + 1;
                    }

                    if (puntaje == 10 && lev == 3)
                    {
                        lg.AgregarRecord(id_user, int.Parse(lblMovimientos.Text), modo, lev, puntos.Text, m + ":" + s);
                        this.Dispose();
                        Pasado pas = new Pasado();
                        pas.ShowDialog();
                    }
                }
            }

            if (modo == 3 && obstaculos == false)
            {
                if (cabeza.interseccion(comida))
                {
                    com.Play();
                    comida.colocar(((canvas.Size.Width / 10) - 10), ((canvas.Size.Height / 10) - 10));

                    cabeza.meter();

                    puntaje = puntaje + 1;
                    puntos.Text = puntaje.ToString();
                    velocidad_despl();


                    if (puntaje == 2 && lev == 1)
                    {

                        lev = lev + 1;
                        this.canvas.Size = new System.Drawing.Size(600, 300);
                        pasarniv2_modo3_sin();

                    }

                    if (puntaje == 5 && lev == 2)
                    {

                        lev = lev + 1;
                        this.canvas.Size = new System.Drawing.Size(500, 200);
                        pasarniv3_modo3_sin();

                    }
                    if (puntaje == 10 && lev == 3)
                    {
                        lg.AgregarRecord(id_user, int.Parse(lblMovimientos.Text), modo, lev, puntos.Text, m + ":" + s);
                        this.Dispose();
                        Pasado pas = new Pasado();
                        pas.ShowDialog();
                    }
                }
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void verificarMovimientos()
        {
            if (!tipomovimiento.Equals(tipomovimientotemp))
            {
                lblMovimientos.Text = (movimientos++).ToString();
                tipomovimientotemp = tipomovimiento;
            }
        }
        public void velocidad_despl()
        {
            if (modo == 1)
            {
                velocidad = velocidad - 2;
                if (velocidad <= 0)
                {
                    velocidad = 1;
                }
                bucle.Interval = velocidad;
            }
            if (modo == 2)
            {
                velocidad = velocidad - 3;
                if (velocidad <= 0)
                {
                    velocidad = 1;
                }
                bucle.Interval = velocidad;
            }
            if (modo == 3)
            {
                velocidad = velocidad - 5;
                if (velocidad <= 0)
                {
                    velocidad = 1;
                }
                bucle.Interval = velocidad;
            }
        }
        public void movimiento()
        {
            cabeza.setxy(cabeza.getX() + xdir, cabeza.getY() + ydir);
        }

    }
}