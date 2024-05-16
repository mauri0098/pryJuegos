namespace pryJuegos
{
    partial class frmIniciodeJuego
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
            txtJugadorr = new TextBox();
            btnEmpezarJuego = new Button();
            lblNombredeJugador = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtJugadorr
            // 
            txtJugadorr.BackColor = Color.White;
            txtJugadorr.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtJugadorr.Location = new Point(209, 39);
            txtJugadorr.Name = "txtJugadorr";
            txtJugadorr.Size = new Size(84, 23);
            txtJugadorr.TabIndex = 0;
            // 
            // btnEmpezarJuego
            // 
            btnEmpezarJuego.BackColor = Color.WhiteSmoke;
            btnEmpezarJuego.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmpezarJuego.ForeColor = SystemColors.ActiveCaptionText;
            btnEmpezarJuego.Location = new Point(82, 81);
            btnEmpezarJuego.Name = "btnEmpezarJuego";
            btnEmpezarJuego.Size = new Size(211, 44);
            btnEmpezarJuego.TabIndex = 1;
            btnEmpezarJuego.Text = "Empezar Nuevo Juego";
            btnEmpezarJuego.UseVisualStyleBackColor = false;
            btnEmpezarJuego.Click += btnConfirmar_Click;
            // 
            // lblNombredeJugador
            // 
            lblNombredeJugador.AutoSize = true;
            lblNombredeJugador.BackColor = Color.Transparent;
            lblNombredeJugador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombredeJugador.ForeColor = Color.WhiteSmoke;
            lblNombredeJugador.Location = new Point(51, 37);
            lblNombredeJugador.Name = "lblNombredeJugador";
            lblNombredeJugador.Size = new Size(152, 21);
            lblNombredeJugador.TabIndex = 2;
            lblNombredeJugador.Text = "Nombre de Jugador:";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.WhiteSmoke;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(318, 182);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(83, 28);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmIniciodeJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources._8ac8d7ea3cc304b0181ff186a88d3691;
            ClientSize = new Size(402, 211);
            Controls.Add(btnSalir);
            Controls.Add(lblNombredeJugador);
            Controls.Add(btnEmpezarJuego);
            Controls.Add(txtJugadorr);
            Name = "frmIniciodeJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Juego";
            Load += frmInicoDeJuego_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtJugadorr;
        private Button btnEmpezarJuego;
        private Label lblNombredeJugador;
        private Button btnSalir;
    }
}