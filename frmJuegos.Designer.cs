﻿namespace pryJuegos
{
    partial class frmJuegos
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
            components = new System.ComponentModel.Container();
            temporizadorDisparo = new System.Windows.Forms.Timer(components);
            temporizadorenemigos = new System.Windows.Forms.Timer(components);
            lblScore = new Label();
            SuspendLayout();
            // 
            // temporizadorDisparo
            // 
            temporizadorDisparo.Enabled = true;
            temporizadorDisparo.Tick += timer1_Tick;
            // 
            // temporizadorenemigos
            // 
            temporizadorenemigos.Enabled = true;
            temporizadorenemigos.Tick += timer2_Tick;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(715, 9);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(36, 15);
            lblScore.TabIndex = 1;
            lblScore.Text = "Score";
            lblScore.Click += label2_Click;
            // 
            // frmJuegos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 500);
            Controls.Add(lblScore);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmJuegos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Juegos";
            Load += frmJuegos_Load;
            KeyDown += frmJuegos_KeyDown;
            KeyPress += frmJuegos_KeyPress;
            KeyUp += frmJuegos_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer temporizadorDisparo;
        private System.Windows.Forms.Timer temporizadorenemigos;
        private Label label1;
        private Label lblScore;
    }
}