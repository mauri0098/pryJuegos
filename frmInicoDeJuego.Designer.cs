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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicoDeJuego));
            txtJugadorr = new TextBox();
            btnEmpezarJuego = new Button();
            lblNombredeUsuario = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtJugadorr
            // 
            txtJugadorr.BackColor = Color.White;
            txtJugadorr.Location = new Point(427, 157);
            txtJugadorr.Multiline = true;
            txtJugadorr.Name = "txtJugadorr";
            txtJugadorr.Size = new Size(104, 20);
            txtJugadorr.TabIndex = 0;
            // 
            // btnEmpezarJuego
            // 
            btnEmpezarJuego.BackColor = Color.White;
            btnEmpezarJuego.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmpezarJuego.ForeColor = SystemColors.ActiveCaptionText;
            btnEmpezarJuego.Location = new Point(112, 197);
            btnEmpezarJuego.Name = "btnEmpezarJuego";
            btnEmpezarJuego.Size = new Size(244, 53);
            btnEmpezarJuego.TabIndex = 1;
            btnEmpezarJuego.Text = "Empezar Nuevo Juego";
            btnEmpezarJuego.UseVisualStyleBackColor = false;
            btnEmpezarJuego.Click += btnConfirmar_Click;
            // 
            // lblNombredeUsuario
            // 
            lblNombredeUsuario.AutoSize = true;
            lblNombredeUsuario.BackColor = Color.Transparent;
            lblNombredeUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombredeUsuario.ForeColor = Color.WhiteSmoke;
            lblNombredeUsuario.Location = new Point(112, 147);
            lblNombredeUsuario.Name = "lblNombredeUsuario";
            lblNombredeUsuario.Size = new Size(309, 30);
            lblNombredeUsuario.TabIndex = 2;
            lblNombredeUsuario.Text = "Ingrese un nombre de usuario";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(570, 467);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(93, 25);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmInicoDeJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(664, 494);
            Controls.Add(btnSalir);
            Controls.Add(lblNombredeUsuario);
            Controls.Add(btnEmpezarJuego);
            Controls.Add(txtJugadorr);
            Name = "frmInicoDeJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInicoDeJuego";
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