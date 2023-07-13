namespace Vista
{
    partial class FrmPerfilUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfilUsuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.lblMedioPago = new System.Windows.Forms.Label();
            this.btnRecargarCreditos = new System.Windows.Forms.Button();
            this.btnDepositarCreditos = new System.Windows.Forms.Button();
            this.txtCreditosIngreso = new System.Windows.Forms.TextBox();
            this.lblRecarga = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.txtValorCreditos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Vista.Properties.Resources._111111111111111;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(23, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 221);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(215, 124);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(146, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Nombre de Usuario: ";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(215, 167);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(53, 20);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "Email: ";
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblCreditos.ForeColor = System.Drawing.Color.White;
            this.lblCreditos.Location = new System.Drawing.Point(215, 246);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(153, 20);
            this.lblCreditos.TabIndex = 3;
            this.lblCreditos.Text = "Creditos Disponibles: ";
            // 
            // lblMedioPago
            // 
            this.lblMedioPago.AutoSize = true;
            this.lblMedioPago.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblMedioPago.ForeColor = System.Drawing.Color.White;
            this.lblMedioPago.Location = new System.Drawing.Point(215, 208);
            this.lblMedioPago.Name = "lblMedioPago";
            this.lblMedioPago.Size = new System.Drawing.Size(117, 20);
            this.lblMedioPago.TabIndex = 5;
            this.lblMedioPago.Text = "Medio de Pago: ";
            // 
            // btnRecargarCreditos
            // 
            this.btnRecargarCreditos.BackColor = System.Drawing.Color.IndianRed;
            this.btnRecargarCreditos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRecargarCreditos.ForeColor = System.Drawing.Color.White;
            this.btnRecargarCreditos.Location = new System.Drawing.Point(23, 359);
            this.btnRecargarCreditos.Name = "btnRecargarCreditos";
            this.btnRecargarCreditos.Size = new System.Drawing.Size(280, 57);
            this.btnRecargarCreditos.TabIndex = 6;
            this.btnRecargarCreditos.Text = "Recargar Creditos";
            this.btnRecargarCreditos.UseVisualStyleBackColor = false;
            this.btnRecargarCreditos.Click += new System.EventHandler(this.btnRecargarCreditos_Click);
            // 
            // btnDepositarCreditos
            // 
            this.btnDepositarCreditos.BackColor = System.Drawing.Color.IndianRed;
            this.btnDepositarCreditos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDepositarCreditos.ForeColor = System.Drawing.Color.White;
            this.btnDepositarCreditos.Location = new System.Drawing.Point(330, 359);
            this.btnDepositarCreditos.Name = "btnDepositarCreditos";
            this.btnDepositarCreditos.Size = new System.Drawing.Size(280, 57);
            this.btnDepositarCreditos.TabIndex = 7;
            this.btnDepositarCreditos.Text = "Extraccion de los Creditos";
            this.btnDepositarCreditos.UseVisualStyleBackColor = false;
            this.btnDepositarCreditos.Click += new System.EventHandler(this.btnDepositarCreditos_Click);
            // 
            // txtCreditosIngreso
            // 
            this.txtCreditosIngreso.Location = new System.Drawing.Point(426, 282);
            this.txtCreditosIngreso.Name = "txtCreditosIngreso";
            this.txtCreditosIngreso.Size = new System.Drawing.Size(45, 27);
            this.txtCreditosIngreso.TabIndex = 8;
            this.txtCreditosIngreso.TextChanged += new System.EventHandler(this.txtCreditosIngreso_TextChanged);
            // 
            // lblRecarga
            // 
            this.lblRecarga.AutoSize = true;
            this.lblRecarga.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblRecarga.ForeColor = System.Drawing.Color.White;
            this.lblRecarga.Location = new System.Drawing.Point(215, 285);
            this.lblRecarga.Name = "lblRecarga";
            this.lblRecarga.Size = new System.Drawing.Size(205, 20);
            this.lblRecarga.TabIndex = 9;
            this.lblRecarga.Text = "Creditos a recargar/extraer? : ";
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::Vista.Properties.Resources._16_160927_flecha_hacia_la_izquierda_hd_png_download;
            this.btnVolver.Location = new System.Drawing.Point(568, 21);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(45, 39);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Algerian", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 46);
            this.label3.TabIndex = 15;
            this.label3.Text = "PERFIL NBA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Font = new System.Drawing.Font("Algerian", 25.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(269, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 46);
            this.label4.TabIndex = 16;
            this.label4.Text = "BET";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BackgroundImage = global::Vista.Properties.Resources._1_2;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(626, 507);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(367, 121);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.ReadOnly = true;
            this.txtNombreUsuario.Size = new System.Drawing.Size(229, 27);
            this.txtNombreUsuario.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(274, 164);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(322, 27);
            this.txtEmail.TabIndex = 19;
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(338, 205);
            this.txtPago.Name = "txtPago";
            this.txtPago.ReadOnly = true;
            this.txtPago.Size = new System.Drawing.Size(258, 27);
            this.txtPago.TabIndex = 20;
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(374, 243);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.ReadOnly = true;
            this.txtCreditos.Size = new System.Drawing.Size(222, 27);
            this.txtCreditos.TabIndex = 21;
            // 
            // txtValorCreditos
            // 
            this.txtValorCreditos.Location = new System.Drawing.Point(536, 282);
            this.txtValorCreditos.Name = "txtValorCreditos";
            this.txtValorCreditos.ReadOnly = true;
            this.txtValorCreditos.Size = new System.Drawing.Size(60, 27);
            this.txtValorCreditos.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(489, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "USD:";
            // 
            // FrmPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(625, 433);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorCreditos);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblRecarga);
            this.Controls.Add(this.txtCreditosIngreso);
            this.Controls.Add(this.btnDepositarCreditos);
            this.Controls.Add(this.btnRecargarCreditos);
            this.Controls.Add(this.lblMedioPago);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPerfilUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil NBABet";
            this.Load += new System.EventHandler(this.FrmPerfilUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.Label lblMedioPago;
        private System.Windows.Forms.Button btnRecargarCreditos;
        private System.Windows.Forms.Button btnDepositarCreditos;
        private System.Windows.Forms.TextBox txtCreditosIngreso;
        private System.Windows.Forms.Label lblRecarga;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.TextBox txtValorCreditos;
        private System.Windows.Forms.Label label5;
    }
}