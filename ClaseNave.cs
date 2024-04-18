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
            imgNaveEnemiga2.ImageLocation = "https://gifdb.com/images/thumbnail/galaga-boss-1000-hit-wwrjpsiqh7cbi97u.gif";
            //Enemigo 3
            vida = 20;
            nombre = "Enemigo2";
            puntosDeDaños = 100;
            imgNaveEnemiga3 = new PictureBox();
            imgNaveEnemiga3.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga3.ImageLocation = "https://i.ytimg.com/vi/xEaqhhjqxLA/maxresdefault.jpg";


        }
        
    }

}
