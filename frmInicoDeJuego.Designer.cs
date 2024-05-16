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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIniciodeJuego));
            txtJugadorr = new TextBox();
            btnEmpezarJuego = new Button();
            lblNombredeUsuario = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtJugadorr
            // 
            txtJugadorr.BackColor = Color.White;
            txtJugadorr.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtJugadorr.Location = new Point(310, 51);
            txtJugadorr.Multiline = true;
            txtJugadorr.Name = "txtJugadorr";
            txtJugadorr.Size = new Size(81, 26);
            txtJugadorr.TabIndex = 0;
            // 
            // btnEmpezarJuego
            // 
            btnEmpezarJuego.BackColor = Color.White;
            btnEmpezarJuego.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmpezarJuego.ForeColor = SystemColors.ActiveCaptionText;
            btnEmpezarJuego.Location = new Point(159, 84);
            btnEmpezarJuego.Name = "btnEmpezarJuego";
            btnEmpezarJuego.Size = new Size(171, 35);
            btnEmpezarJuego.TabIndex = 1;
            btnEmpezarJuego.Text = "Empezar Nuevo Juego";
            btnEmpezarJuego.UseVisualStyleBackColor = false;
            btnEmpezarJuego.Click += btnConfirmar_Click;
            // 
            // lblNombredeUsuario
            // 
            lblNombredeUsuario.AutoSize = true;
            lblNombredeUsuario.BackColor = Color.Transparent;
            lblNombredeUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombredeUsuario.ForeColor = Color.WhiteSmoke;
            lblNombredeUsuario.Location = new Point(12, 46);
            lblNombredeUsuario.Name = "lblNombredeUsuario";
            lblNombredeUsuario.Size = new Size(292, 30);
            lblNombredeUsuario.TabIndex = 2;
            lblNombredeUsuario.Text = "Ingrese un nombre de usuario";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLightLight;
            btnSalir.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(23, 84);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(118, 34);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmIniciodeJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(429, 262);
            Controls.Add(btnSalir);
            Controls.Add(lblNombredeUsuario);
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
        private Label lblNombredeUsuario;
        private Button btnSalir;
    }
}