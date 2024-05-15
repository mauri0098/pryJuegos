namespace pryJuegos
{
    partial class frmInicoDeJuego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            btnConfirmar = new Button();
            txtJugador = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(165, 32);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(44, 92);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(100, 23);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "button1";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtJugador
            // 
            txtJugador.AutoSize = true;
            txtJugador.Location = new Point(37, 32);
            txtJugador.Name = "txtJugador";
            txtJugador.Size = new Size(107, 15);
            txtJugador.TabIndex = 2;
            txtJugador.Text = "Ingrese Un jugador";
            // 
            // frmInicoDeJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 496);
            Controls.Add(txtJugador);
            Controls.Add(btnConfirmar);
            Controls.Add(txtUsuario);
            Name = "frmInicoDeJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInicoDeJuego";
            Load += frmInicoDeJuego_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private Button btnConfirmar;
        private Label txtJugador;
    }
}