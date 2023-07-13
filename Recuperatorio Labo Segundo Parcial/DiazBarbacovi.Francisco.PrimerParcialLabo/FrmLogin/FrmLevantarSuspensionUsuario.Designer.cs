namespace Vista
{
    partial class FrmLevantarSuspensionUsuario
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
            this.btnSi = new System.Windows.Forms.Button();
            this.btNo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSi
            // 
            this.btnSi.Location = new System.Drawing.Point(38, 109);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(204, 62);
            this.btnSi.TabIndex = 0;
            this.btnSi.Text = "Aceptar";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btNo
            // 
            this.btNo.Location = new System.Drawing.Point(269, 109);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(195, 62);
            this.btNo.TabIndex = 1;
            this.btNo.Text = "Cancelar";
            this.btNo.UseVisualStyleBackColor = true;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desea levantar la suspension del usuario seleccionado?";
            // 
            // FrmLevantarSuspensionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 214);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btnSi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLevantarSuspensionUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Levantar Suspension";
            this.Load += new System.EventHandler(this.FrmLevantarSuspensionUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Label label1;
    }
}