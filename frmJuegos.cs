using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private void frmJuegos_Load(object sender, EventArgs e)
        {
            ObjNavejuegador = new ClaseNave();
            ObjNavejuegador.Crearjuegador();

            Controls.Add(ObjNavejuegador.imgNave);

            ObjNavejuegador.imgNave.Location = new Point(500, 500);
            
            //Enemigo3
            ObjNavejuegador.CrearEnemigo();
            Controls.Add(ObjNavejuegador.imgNaveEnemiga);
            ObjNavejuegador.imgNaveEnemiga.Location = new Point(300, 300);

            //Enemigo2
            ObjNavejuegador.CrearEnemigo();
            Controls.Add(ObjNavejuegador.imgNaveEnemiga2);
            ObjNavejuegador.imgNaveEnemiga2.Location = new Point(100, 100);

            //Enemigo3
            ObjNavejuegador.CrearEnemigo();
            Controls.Add(ObjNavejuegador.imgNaveEnemiga3);
            ObjNavejuegador.imgNaveEnemiga3.Location = new Point(400, 400);

            //Para q los enemigos salgan aleatorios
            int contador = 0;
            Random rnd = new Random(); // Inicializa el objeto Random fuera del bucle

            while (contador < 5)
            {
                ClaseNave ObjEnemigo = new ClaseNave(); // Crea una nueva instancia de ClaseNave

                ObjEnemigo.CrearEnemigo();

                int valorX = rnd.Next(0, 400); // Genera una coordenada X aleatoria
                int valorY = rnd.Next(0, 400); // Genera una coordenada Y aleatoria

                ObjEnemigo.imgNaveEnemiga.Location = new Point(valorX, valorY);
                Controls.Add(ObjEnemigo.imgNaveEnemiga); // Añade la imagen del enemigo al formulario
                contador++;
            }




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



    }
}
