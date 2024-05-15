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
    public partial class frmInicoDeJuego : Form
    {
        public frmInicoDeJuego()
        {
            InitializeComponent();
        }
        string Usuario = "";
        string Jugador = "";

        private void frmInicoDeJuego_Load(object sender, EventArgs e)
        {
           

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Parece que no ingresaste un jugador.\nPor favor, ingresa un jugador válido.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Usuario = txtUsuario.Text; // Asigna el texto ingresado a Usuario
                Usuario += Jugador; // Concatena Jugador a Usuario

                frmJuegos juegos = new frmJuegos();
                juegos.ShowDialog();

                
                this.Close();
            }

            txtUsuario.Text = "";

        }
    }
}
