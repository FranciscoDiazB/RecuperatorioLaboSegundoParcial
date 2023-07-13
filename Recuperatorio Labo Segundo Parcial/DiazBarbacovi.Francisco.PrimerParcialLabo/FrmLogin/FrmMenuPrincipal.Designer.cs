namespace Vista
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.btnRealizarApuesta = new System.Windows.Forms.Button();
            this.btnProde = new System.Windows.Forms.Button();
            this.lblDatosUsuario = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPerfilUsuario = new System.Windows.Forms.Button();
            this.btnRefrescarDatos = new System.Windows.Forms.Button();
            this.btnJugadores = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.btnTrivia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRealizarApuesta
            // 
            this.btnRealizarApuesta.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRealizarApuesta.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRealizarApuesta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRealizarApuesta.Location = new System.Drawing.Point(102, 138);
            this.btnRealizarApuesta.Name = "btnRealizarApuesta";
            this.btnRealizarApuesta.Size = new System.Drawing.Size(500, 59);
            this.btnRealizarApuesta.TabIndex = 0;
            this.btnRealizarApuesta.Text = "Realizar Apuestas de los Juegos";
            this.btnRealizarApuesta.UseVisualStyleBackColor = false;
            this.btnRealizarApuesta.Click += new System.EventHandler(this.btnRealizarApuesta_Click);
            // 
            // btnProde
            // 
            this.btnProde.BackColor = System.Drawing.Color.IndianRed;
            this.btnProde.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnProde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProde.Location = new System.Drawing.Point(102, 202);
            this.btnProde.Name = "btnProde";
            this.btnProde.Size = new System.Drawing.Size(500, 59);
            this.btnProde.TabIndex = 1;
            this.btnProde.Text = "Ver Prode";
            this.btnProde.UseVisualStyleBackColor = false;
            this.btnProde.Click += new System.EventHandler(this.btnProde_Click);
            // 
            // lblDatosUsuario
            // 
            this.lblDatosUsuario.AutoSize = true;
            this.lblDatosUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblDatosUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDatosUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblDatosUsuario.Name = "lblDatosUsuario";
            this.lblDatosUsuario.Size = new System.Drawing.Size(18, 20);
            this.lblDatosUsuario.TabIndex = 4;
            this.lblDatosUsuario.Text = "...";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(102, 462);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(500, 59);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.NBA_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-146, -151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1071, 757);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Algerian", 46.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(159, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 86);
            this.label1.TabIndex = 7;
            this.label1.Text = "NBA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Algerian", 46.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(333, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 86);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bet";
            // 
            // btnPerfilUsuario
            // 
            this.btnPerfilUsuario.BackgroundImage = global::Vista.Properties.Resources.Perfil2;
            this.btnPerfilUsuario.Location = new System.Drawing.Point(762, 9);
            this.btnPerfilUsuario.Name = "btnPerfilUsuario";
            this.btnPerfilUsuario.Size = new System.Drawing.Size(81, 67);
            this.btnPerfilUsuario.TabIndex = 9;
            this.btnPerfilUsuario.UseVisualStyleBackColor = true;
            this.btnPerfilUsuario.Click += new System.EventHandler(this.btnPerfilUsuario_Click);
            // 
            // btnRefrescarDatos
            // 
            this.btnRefrescarDatos.BackgroundImage = global::Vista.Properties.Resources._12;
            this.btnRefrescarDatos.Location = new System.Drawing.Point(12, 59);
            this.btnRefrescarDatos.Name = "btnRefrescarDatos";
            this.btnRefrescarDatos.Size = new System.Drawing.Size(41, 40);
            this.btnRefrescarDatos.TabIndex = 10;
            this.btnRefrescarDatos.UseVisualStyleBackColor = true;
            this.btnRefrescarDatos.Click += new System.EventHandler(this.btnRefrescarDatos_Click);
            // 
            // btnJugadores
            // 
            this.btnJugadores.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnJugadores.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnJugadores.ForeColor = System.Drawing.Color.White;
            this.btnJugadores.Location = new System.Drawing.Point(102, 267);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Size = new System.Drawing.Size(500, 59);
            this.btnJugadores.TabIndex = 11;
            this.btnJugadores.Text = "Realizar Apuestas a Jugadores (Oeste)";
            this.btnJugadores.UseVisualStyleBackColor = false;
            this.btnJugadores.Click += new System.EventHandler(this.btnJugadores_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(102, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(500, 59);
            this.button1.TabIndex = 12;
            this.button1.Text = "Realizar Apuestas a Jugadores (Este)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblHorario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHorario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHorario.Location = new System.Drawing.Point(547, 19);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(55, 28);
            this.lblHorario.TabIndex = 13;
            this.lblHorario.Text = "Hora";
            // 
            // btnTrivia
            // 
            this.btnTrivia.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTrivia.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnTrivia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrivia.Location = new System.Drawing.Point(102, 397);
            this.btnTrivia.Name = "btnTrivia";
            this.btnTrivia.Size = new System.Drawing.Size(500, 59);
            this.btnTrivia.TabIndex = 14;
            this.btnTrivia.Text = "Trivia";
            this.btnTrivia.UseVisualStyleBackColor = false;
            this.btnTrivia.Click += new System.EventHandler(this.btnTrivia_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(857, 534);
            this.ControlBox = false;
            this.Controls.Add(this.btnTrivia);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnJugadores);
            this.Controls.Add(this.btnRefrescarDatos);
            this.Controls.Add(this.btnPerfilUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblDatosUsuario);
            this.Controls.Add(this.btnProde);
            this.Controls.Add(this.btnRealizarApuesta);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBABet";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnRealizarApuesta;
        public System.Windows.Forms.Button btnProde;
        private System.Windows.Forms.Label lblDatosUsuario;
        public System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnPerfilUsuario;
        public System.Windows.Forms.Button btnRefrescarDatos;
        public System.Windows.Forms.Button btnJugadores;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHorario;
        public System.Windows.Forms.Button btnTrivia;
    }
}