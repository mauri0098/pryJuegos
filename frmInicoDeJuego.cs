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
    public partial class frmIniciodeJuego : Form
    {
        public frmIniciodeJuego()
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
            if (txtJugadorr.Text == "")
            {
                MessageBox.Show("Parece que no ingresaste un jugador.\nPor favor, ingresa un jugador válido.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Usuario = txtJugadorr.Text; // Asigna el texto ingresado a Usuario
                Usuario += Jugador; // Concatena Jugador a Usuario
                this.Hide();
                frmJuegos juegos = new frmJuegos();
                juegos.ShowDialog();



            }

            txtJugadorr.Text = "";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
