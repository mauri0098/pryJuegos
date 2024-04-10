using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace pryJuegos
{
    internal class ClaseNave
    {
        //Caracteristicas

        public int vida;
        public string nombre;
         int puntosDeDaños;
        public PictureBox imgNave;
        public void Crearjuegador()
        {
            vida = 100;
            nombre = "Jugador1";
            puntosDeDaños = 1;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.ImageLocation = "https://cdna.artstation.com/p/assets/images/images/017/509/756/large/rutger-slopsema-galaga.jpg?1556264895";  
        }
        public void CrearEnemigo()
        {

            vida = 30;
            nombre = "Enemigo1";
            puntosDeDaños = 1;

        }



    }

}
