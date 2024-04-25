﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace pryJuegos
{
    public partial class frmJuegos : Form
    {
        public frmJuegos()
        {
            InitializeComponent();
        }
        ClaseNave ObjNavejuegador;
        ClaseNave ObjEnemigo;
        ClaseNave Disparo;
        PictureBox disparo;
        bool espacio = false;

        Random EnemigosAleatorios = new Random();
        Random PosicionX = new Random();
        Random PosicionY = new Random();
        private void frmJuegos_Load(object sender, EventArgs e)
        {
            ObjNavejuegador = new ClaseNave();//inicializo el objnavejugador 
            ObjNavejuegador.Crearjuegador();//utilizo el metodo 
            Controls.Add(ObjNavejuegador.imgNave);//Agregando la imagen de la nave al formulario
            ObjNavejuegador.imgNave.Location = new Point(500, 500);//establese los puntos donde esta la nave 
                                                                   //Esto Es De La Nave jugador 



            ////creacion de nave enemigas 
            ObjEnemigo = new ClaseNave();
            ////Enemigo3
            //ObjEnemigo.CrearEnemigo();
            //Controls.Add(ObjEnemigo.imgNaveEnemiga);
            //ObjEnemigo.imgNaveEnemiga.Location = new Point(300, 300);

            ////Enemigo2
            //ObjEnemigo.CrearEnemigo();
            //Controls.Add(ObjEnemigo.imgNaveEnemiga2);
            //ObjEnemigo.imgNaveEnemiga2.Location = new Point(100, 100);

            ////Enemigo3
            //ObjEnemigo.CrearEnemigo();
            //Controls.Add(ObjEnemigo.imgNaveEnemiga3);
            //ObjEnemigo.imgNaveEnemiga3.Location = new Point(400, 400);

            //Para q los enemigos salgan aleatorios

            ObjEnemigo = new ClaseNave(); //Inicialización del objeto ObjEnemigo




        }

        private void frmJuegos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)// Si se presiona la tecla de flecha derecha
            {
                ObjNavejuegador.imgNave.Location = new Point(ObjNavejuegador.imgNave.Location.X + 5, // Mueve la nave 5 píxeles hacia la derecha
                ObjNavejuegador.imgNave.Location.Y);
            }
            if (e.KeyCode == Keys.Left) // Si se presiona la tecla de flecha izquierda
            {
                ObjNavejuegador.imgNave.Location = new Point(ObjNavejuegador.imgNave.Location.X - 5, // Mueve la nave 5 píxeles hacia la izquierda
                ObjNavejuegador.imgNave.Location.Y);
            }
        }

        private void frmJuegos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) // Si se presiona la tecla de flecha arriba
            {

                ObjNavejuegador.imgNave.Location = new Point(ObjNavejuegador.imgNave.Location.X,
                                                              ObjNavejuegador.imgNave.Location.Y - 5);//es con el y
            }
            if (e.KeyCode == Keys.Down)
            {

                ObjNavejuegador.imgNave.Location = new Point(ObjNavejuegador.imgNave.Location.X,
                                                              ObjNavejuegador.imgNave.Location.Y + 5);//es con el y
            }
            if (e.KeyCode == Keys.Space)
            {
                espacio = false;
                timer2.Stop();

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (disparo != null && disparo.Location.Y > 0)
            {
                disparo.Location = new Point(
                    disparo.Location.X,
                    disparo.Location.Y - 10);

                // Colisión con los enemigos
                foreach (Control imagen in Controls)
                {
                    if (imagen.Tag == "enemigo")
                    {
                        if (disparo.Bounds.IntersectsWith(imagen.Bounds))
                        {
                            disparo.Dispose();
                            imagen.Dispose();
                            // Cambiar la imagen y cara el gif
                        }
                    }
                }
            }
            else
            {
                if (disparo != null)
                {
                    disparo.Dispose();
                    disparo = null;
                }
            }


        }

        private void frmJuegos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space && !espacio)
            {
                espacio = true;
                disparo = new PictureBox();
                disparo.ImageLocation = "https://e7.pngegg.com/pngimages/410/388/png-clipart-light-muzzle-flash-fire-flame-gun-fire-orange-flame-thumbnail.png";
                disparo.Size = new Size(20, 20);
                disparo.SizeMode = PictureBoxSizeMode.StretchImage;

                disparo.Location = new Point(ObjNavejuegador.imgNave.Location.X + ObjNavejuegador.imgNave.Width / 2 - disparo.Width / 2,
                                             ObjNavejuegador.imgNave.Location.Y);
                Controls.Add(disparo);
                GenerarNuevoEnemigo();
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int posX = 0;
            int posY = 0;
            int contador = 0;

            while (contador < 10) // cantidad de enemigos que se crean 
            {
                int codigoEnemigo = EnemigosAleatorios.Next(1000, 3000);// Generación de números aleatorios

                posX = PosicionX.Next(0, 800);
                posY = PosicionY.Next(0, 300); //la posicion random de donde estan ubicados los enemigos o utilizan para establecer la posición del enemigo en la ventana de juego

                switch (codigoEnemigo)//utilizamos a codigoenemigo y preguntamos si el numero random q genere  es mayor a 2000 crea un enenmigo, si es menor crea otro 
                {


                    case < 2000:
                        ObjEnemigo.CrearEnemigo();//creacion de un enemigo 
                        ObjEnemigo.imgNaveEnemiga.Location = new Point(posX, posY);//estableco la localizacion de la nave 
                        Controls.Add(ObjEnemigo.imgNaveEnemiga);//pongo la imagen 
                        ObjEnemigo.imgNaveEnemiga.Tag = "enemigo";
                        break;
                    case > 2500:
                        ObjEnemigo.CrearEnemigo();
                        ObjEnemigo.imgNaveEnemiga2.Location = new Point(posX, posY);
                        Controls.Add(ObjEnemigo.imgNaveEnemiga2);
                        ObjEnemigo.imgNaveEnemiga2.Tag = "enemigo";
                        break;
                    case > 1000:
                        ObjEnemigo.CrearEnemigo();
                        ObjEnemigo.imgNaveEnemiga3.Location = new Point(posX, posY);
                        Controls.Add(ObjEnemigo.imgNaveEnemiga3);
                        ObjEnemigo.imgNaveEnemiga3.Tag = "enemigo";
                        break;
                    default:
                        break;
                }

                contador++; // Incrementar el contador para evitar un bucle infinito
                timer2.Stop();

                if (ObjEnemigo.imgNaveEnemiga.Location == ObjEnemigo.imgNaveEnemiga2.Location)
                {

                    ObjEnemigo.imgNaveEnemiga.Dispose();
                    ObjEnemigo.imgNaveEnemiga2.Dispose();

                }
                if (ObjEnemigo.imgNaveEnemiga.Location == ObjEnemigo.imgNaveEnemiga.Location)
                {
                    ObjEnemigo.imgNaveEnemiga.Dispose();
                }
                else if (ObjEnemigo.imgNaveEnemiga2.Location == ObjEnemigo.imgNaveEnemiga2.Location)
                {
                    ObjEnemigo.imgNaveEnemiga2.Dispose();
                }
                else if (ObjEnemigo.imgNaveEnemiga3.Location == ObjEnemigo.imgNaveEnemiga3.Location)
                {
                    ObjEnemigo.imgNaveEnemiga3.Dispose();
                }
                else if (ObjEnemigo.imgNaveEnemiga2.Location == ObjEnemigo.imgNaveEnemiga3.Location)
                {
                    ObjEnemigo.imgNaveEnemiga2.Dispose();
                    ObjEnemigo.imgNaveEnemiga3.Dispose();
                }
                else if (ObjEnemigo.imgNaveEnemiga.Location == ObjEnemigo.imgNaveEnemiga3.Location)
                {
                    ObjEnemigo.imgNaveEnemiga.Dispose();
                    ObjEnemigo.imgNaveEnemiga3.Dispose();
                }
                else if (ObjEnemigo.imgNaveEnemiga3.Location == ObjEnemigo.imgNaveEnemiga2.Location)
                {
                    ObjEnemigo.imgNaveEnemiga3.Dispose();
                    ObjEnemigo.imgNaveEnemiga2.Dispose();
                }


            }
        }
        private void GenerarNuevoEnemigo()
        {
            int codigoEnemigo = EnemigosAleatorios.Next(1000, 3000);
            int posX = PosicionX.Next(0, 800);
            int posY = PosicionY.Next(0, 300);

            switch (codigoEnemigo)
            {
                case < 2000:
                    ObjEnemigo.CrearEnemigo();
                    ObjEnemigo.imgNaveEnemiga.Location = new Point(posX, posY);
                    Controls.Add(ObjEnemigo.imgNaveEnemiga);
                    ObjEnemigo.imgNaveEnemiga.Tag = "enemigo";
                    break;
                case > 2500:
                    ObjEnemigo.CrearEnemigo();
                    ObjEnemigo.imgNaveEnemiga2.Location = new Point(posX, posY);
                    Controls.Add(ObjEnemigo.imgNaveEnemiga2);
                    ObjEnemigo.imgNaveEnemiga2.Tag = "enemigo";
                    break;
                case > 1000:
                    ObjEnemigo.CrearEnemigo();
                    ObjEnemigo.imgNaveEnemiga3.Location = new Point(posX, posY);
                    Controls.Add(ObjEnemigo.imgNaveEnemiga3);
                    ObjEnemigo.imgNaveEnemiga3.Tag = "enemigo";
                    break;
                default:
                    break;
            }



        }

    }
}
