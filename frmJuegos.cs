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
        private void frmJuegos_Load(object sender, EventArgs e)
        {
            ObjNavejuegador = new ClaseNave();
            ObjNavejuegador.Crearjuegador();

            Controls.Add(ObjNavejuegador.imgNave);

            ObjNavejuegador.imgNave.Location = new Point(500, 500);

        }

        private void frmJuegos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { 
                
                ObjNavejuegador.imgNave.Location = new Point(ObjNavejuegador.imgNave.Location.X+5, 
                ObjNavejuegador.imgNave.Location.Y);   
            }
            if (e.KeyCode == Keys.Left)
            {

                ObjNavejuegador.imgNave.Location = new Point(ObjNavejuegador.imgNave.Location.X - 5,
                ObjNavejuegador.imgNave.Location.Y);
            }
        }
    }
}
