using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            int posX = 0;
            int posY = 0;   
            int contador = 0;

            while (contador < 10) // cantidad de enemigos que se crean 
            {
                int codigoEnemigo = EnemigosAleatorios.Next(1000, 3000);// Generación de números aleatorios

                posX = PosicionX.Next(0, 400);//la posicion random de donde estan ubicados los enemigos o utilizan para establecer la posición del enemigo en la ventana de juego
                posY = PosicionY.Next(0, 400);
                switch (codigoEnemigo)//utilizamos a codigoenemigo y preguntamos si el numero random q genere  es mayor a 2000 crea un enenmigo, si es menor crea otro 
                {
                    case < 2000:
                        ObjEnemigo.CrearEnemigo();//creacion de un enemigo 
                        ObjEnemigo.imgNaveEnemiga.Location = new Point(posX, posY);//estableco la localizacion de la nave 
                        Controls.Add(ObjEnemigo.imgNaveEnemiga);//pongo la imagen 
                        break;
                    case > 2000:
                        ObjEnemigo.CrearEnemigo();
                        ObjEnemigo.imgNaveEnemiga.Location = new Point(posX, posY);
                        Controls.Add(ObjEnemigo.imgNaveEnemiga2);
                        break;
                    case > 1000:
                        ObjEnemigo.CrearEnemigo();
                        ObjEnemigo.imgNaveEnemiga.Location = new Point(posX, posY);
                        Controls.Add(ObjEnemigo.imgNaveEnemiga3);
                        break;
                    default:
                        break;
                }

                contador++; // Incrementar el contador para evitar un bucle infinito
            }
        }

        private void frmJuegos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)// Si se presiona la tecla de flecha derecha
            {
                ObjNavejuegador.imgNave.Location = new Point(ObjEnemigo.imgNave.Location.X + 5, // Mueve la nave 5 píxeles hacia la derecha
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



    }
}
