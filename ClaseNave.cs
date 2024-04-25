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
        public PictureBox imgNaveEnemiga;
        public PictureBox imgNaveEnemiga2;
        public PictureBox imgNaveEnemiga3;
        public PictureBox imgdisparo;
        public void Crearjuegador()
        {
            vida = 100;
            nombre = "Jugador1";
            puntosDeDaños = 1;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.ImageLocation = "https://art.pixilart.com/ae81e5e14ff674d.gif";
        }
        public void CrearEnemigo()
        {
            vida = 30;
            nombre = "Enemigo1";
            puntosDeDaños = 1;
            imgNaveEnemiga = new PictureBox();
            imgNaveEnemiga.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga.ImageLocation = "https://i.gifer.com/MvA.gif";
            //Enemigo 2
            vida = 20;
            nombre = "Enemigo2";
            puntosDeDaños = 100;
            imgNaveEnemiga2 = new PictureBox();
            imgNaveEnemiga2.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga2.ImageLocation = "https://i.gifer.com/origin/cf/cf75a94995efd5a532afe5b4f08f6007_w200.gif";
            //Enemigo 3
            vida = 20;
            nombre = "Enemigo3";
            puntosDeDaños = 100;
            imgNaveEnemiga3 = new PictureBox();
            imgNaveEnemiga3.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga3.ImageLocation = "https://i.ytimg.com/vi/xEaqhhjqxLA/maxresdefault.jpg";


        }
        public void Disparo()
        {
            // Crear y configurar el PictureBox del disparo
            imgdisparo = new PictureBox();
            imgdisparo.ImageLocation = "https://e7.pngegg.com/pngimages/410/388/png-clipart-light-muzzle-flash-fire-flame-gun-fire-orange-flame-thumbnail.png";
            imgdisparo.Size = new Size(20, 20); // Establece el tamaño adecuado
            imgdisparo.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta la imagen al tamaño del PictureBox

        }


    }

}
