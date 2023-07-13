namespace Vista
{
    partial class FrmRealizarApuestas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRealizarApuestas));
            this.lstPartidos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEquipoL = new System.Windows.Forms.TextBox();
            this.txtEquipoV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbEquipoLocal = new System.Windows.Forms.RadioButton();
            this.rbEquipoVisitante = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnApostar = new System.Windows.Forms.Button();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMinimoApuestas = new System.Windows.Forms.TextBox();
            this.lblInfoUsuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPartidos
            // 
            this.lstPartidos.FormattingEnabled = true;
            this.lstPartidos.ItemHeight = 20;
            this.lstPartidos.Location = new System.Drawing.Point(453, 96);
            this.lstPartidos.Name = "lstPartidos";
            this.lstPartidos.Size = new System.Drawing.Size(531, 244);
            this.lstPartidos.TabIndex = 0;
            this.lstPartidos.SelectedIndexChanged += new System.EventHandler(this.lstPartidos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(605, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Partidos";
            // 
            // txtEquipoL
            // 
            this.txtEquipoL.Location = new System.Drawing.Point(30, 125);
            this.txtEquipoL.Name = "txtEquipoL";
            this.txtEquipoL.ReadOnly = true;
            this.txtEquipoL.Size = new System.Drawing.Size(249, 27);
            this.txtEquipoL.TabIndex = 2;
            // 
            // txtEquipoV
            // 
            this.txtEquipoV.Location = new System.Drawing.Point(30, 236);
            this.txtEquipoV.Name = "txtEquipoV";
            this.txtEquipoV.ReadOnly = true;
            this.txtEquipoV.Size = new System.Drawing.Size(249, 27);
            this.txtEquipoV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Equipo Local";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Equipo Visitante";
            // 
            // rbEquipoLocal
            // 
            this.rbEquipoLocal.AutoSize = true;
            this.rbEquipoLocal.BackColor = System.Drawing.SystemColors.Highlight;
            this.rbEquipoLocal.ForeColor = System.Drawing.Color.White;
            this.rbEquipoLocal.Location = new System.Drawing.Point(30, 158);
            this.rbEquipoLocal.Name = "rbEquipoLocal";
            this.rbEquipoLocal.Size = new System.Drawing.Size(154, 24);
            this.rbEquipoLocal.TabIndex = 6;
            this.rbEquipoLocal.TabStop = true;
            this.rbEquipoLocal.Text = "Gana Equipo Local";
            this.rbEquipoLocal.UseVisualStyleBackColor = false;
            // 
            // rbEquipoVisitante
            // 
            this.rbEquipoVisitante.AutoSize = true;
            this.rbEquipoVisitante.BackColor = System.Drawing.SystemColors.Highlight;
            this.rbEquipoVisitante.ForeColor = System.Drawing.Color.White;
            this.rbEquipoVisitante.Location = new System.Drawing.Point(30, 269);
            this.rbEquipoVisitante.Name = "rbEquipoVisitante";
            this.rbEquipoVisitante.Size = new System.Drawing.Size(176, 24);
            this.rbEquipoVisitante.TabIndex = 7;
            this.rbEquipoVisitante.TabStop = true;
            this.rbEquipoVisitante.Text = "Gana Equipo Visitante";
            this.rbEquipoVisitante.UseVisualStyleBackColor = false;
            // 
            // btnApostar
            // 
            this.btnApostar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnApostar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnApostar.ForeColor = System.Drawing.Color.White;
            this.btnApostar.Location = new System.Drawing.Point(29, 362);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(448, 83);
            this.btnApostar.TabIndex = 17;
            this.btnApostar.Text = "APOSTAR";
            this.btnApostar.UseVisualStyleBackColor = false;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.BackColor = System.Drawing.Color.IndianRed;
            this.btnVolverAtras.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnVolverAtras.ForeColor = System.Drawing.Color.White;
            this.btnVolverAtras.Location = new System.Drawing.Point(536, 362);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(448, 83);
            this.btnVolverAtras.TabIndex = 18;
            this.btnVolverAtras.Text = "Volver al Menu Principal";
            this.btnVolverAtras.UseVisualStyleBackColor = false;
            this.btnVolverAtras.Click += new System.EventHandler(this.btnVolverAtras_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.IndianRed;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Creditos para apostar (minimo 50):";
            // 
            // txtMinimoApuestas
            // 
            this.txtMinimoApuestas.Location = new System.Drawing.Point(276, 317);
            this.txtMinimoApuestas.Name = "txtMinimoApuestas";
            this.txtMinimoApuestas.Size = new System.Drawing.Size(69, 27);
            this.txtMinimoApuestas.TabIndex = 24;
            // 
            // lblInfoUsuario
            // 
            this.lblInfoUsuario.AutoSize = true;
            this.lblInfoUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInfoUsuario.ForeColor = System.Drawing.Color.White;
            this.lblInfoUsuario.Location = new System.Drawing.Point(309, 102);
            this.lblInfoUsuario.Name = "lblInfoUsuario";
            this.lblInfoUsuario.Size = new System.Drawing.Size(18, 20);
            this.lblInfoUsuario.TabIndex = 25;
            this.lblInfoUsuario.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Algerian", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 46);
            this.label4.TabIndex = 26;
            this.label4.Text = "APUESTAS NBA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.Font = new System.Drawing.Font("Algerian", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(347, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 46);
            this.label5.TabIndex = 27;
            this.label5.Text = "BET";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Vista.Properties.Resources._1_3;
            this.pictureBox1.Location = new System.Drawing.Point(-38, -44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1296, 628);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRealizarApuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 473);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInfoUsuario);
            this.Controls.Add(this.txtMinimoApuestas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.rbEquipoVisitante);
            this.Controls.Add(this.rbEquipoLocal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEquipoV);
            this.Controls.Add(this.txtEquipoL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPartidos);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRealizarApuestas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBABet";
            this.Load += new System.EventHandler(this.FrmRealizarApuestas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPartidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEquipoL;
        private System.Windows.Forms.TextBox txtEquipoV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbEquipoLocal;
        private System.Windows.Forms.RadioButton rbEquipoVisitante;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.Button btnVolverAtras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMinimoApuestas;
        private System.Windows.Forms.Label lblInfoUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}