using System;
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



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ClaseNave disparo1 = new ClaseNave();


           

        }

        private void frmJuegos_KeyPress(object sender, KeyPressEventArgs e)
        {


            //ESte codigo funciona pa disparar
            if (e.KeyChar == (char)Keys.Space) // Si se presiona la tecla de espacio para disparar
            {
                // Crear y configurar el PictureBox del disparo
                PictureBox disparo = new PictureBox();
                disparo.ImageLocation = "https://e7.pngegg.com/pngimages/410/388/png-clipart-light-muzzle-flash-fire-flame-gun-fire-orange-flame-thumbnail.png";
                disparo.Size = new Size(20, 20); // Establece el tamaño adecuado
                disparo.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta la imagen al tamaño del PictureBox

                disparo.Location = new Point(ObjNavejuegador.imgNave.Location.X + ObjNavejuegador.imgNave.Width / 2 - disparo.Width / 2,
                                             ObjNavejuegador.imgNave.Location.Y);
                Controls.Add(disparo);


                //pictureBox1 = disparo;

                if (!timer1.Enabled)
                    timer1.Start();

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
                        break;
                    case > 2500:
                        ObjEnemigo.CrearEnemigo();
                        ObjEnemigo.imgNaveEnemiga2.Location = new Point(posX, posY);
                        Controls.Add(ObjEnemigo.imgNaveEnemiga2);
                        break;
                    case > 1000:
                        ObjEnemigo.CrearEnemigo();
                        ObjEnemigo.imgNaveEnemiga3.Location = new Point(posX, posY);
                        Controls.Add(ObjEnemigo.imgNaveEnemiga3);
                        break;
                    default:
                        break;
                }

                contador++; // Incrementar el contador para evitar un bucle infinito

            }
        }
    }
}
