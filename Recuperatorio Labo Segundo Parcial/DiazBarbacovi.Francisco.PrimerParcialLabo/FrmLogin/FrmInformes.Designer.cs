namespace Vista
{
    partial class FrmInformes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstListadoApuestas = new System.Windows.Forms.ListBox();
            this.btnListarApuestas = new System.Windows.Forms.Button();
            this.btnExportarJson = new System.Windows.Forms.Button();
            this.btnExportarCSV = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExportarPDF = new System.Windows.Forms.Button();
            this.btnExportarXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(72, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 55);
            this.label2.TabIndex = 16;
            this.label2.Text = "NBA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(191, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 55);
            this.label3.TabIndex = 17;
            this.label3.Text = "Bet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Font = new System.Drawing.Font("Algerian", 27F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(76, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 50);
            this.label4.TabIndex = 18;
            this.label4.Text = "INFORMES";
            // 
            // lstListadoApuestas
            // 
            this.lstListadoApuestas.FormattingEnabled = true;
            this.lstListadoApuestas.HorizontalScrollbar = true;
            this.lstListadoApuestas.ItemHeight = 20;
            this.lstListadoApuestas.Location = new System.Drawing.Point(432, 45);
            this.lstListadoApuestas.Name = "lstListadoApuestas";
            this.lstListadoApuestas.Size = new System.Drawing.Size(410, 364);
            this.lstListadoApuestas.TabIndex = 19;
            // 
            // btnListarApuestas
            // 
            this.btnListarApuestas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnListarApuestas.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnListarApuestas.ForeColor = System.Drawing.Color.White;
            this.btnListarApuestas.Location = new System.Drawing.Point(492, 433);
            this.btnListarApuestas.Name = "btnListarApuestas";
            this.btnListarApuestas.Size = new System.Drawing.Size(298, 58);
            this.btnListarApuestas.TabIndex = 20;
            this.btnListarApuestas.Text = "Importar Apuestas";
            this.btnListarApuestas.UseVisualStyleBackColor = false;
            this.btnListarApuestas.Click += new System.EventHandler(this.btnListarApuestas_Click);
            // 
            // btnExportarJson
            // 
            this.btnExportarJson.BackColor = System.Drawing.Color.IndianRed;
            this.btnExportarJson.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnExportarJson.ForeColor = System.Drawing.Color.White;
            this.btnExportarJson.Location = new System.Drawing.Point(50, 148);
            this.btnExportarJson.Name = "btnExportarJson";
            this.btnExportarJson.Size = new System.Drawing.Size(298, 58);
            this.btnExportarJson.TabIndex = 21;
            this.btnExportarJson.Text = "Exportar Json";
            this.btnExportarJson.UseVisualStyleBackColor = false;
            this.btnExportarJson.Click += new System.EventHandler(this.btnExportarJson_Click);
            // 
            // btnExportarCSV
            // 
            this.btnExportarCSV.BackColor = System.Drawing.Color.IndianRed;
            this.btnExportarCSV.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnExportarCSV.ForeColor = System.Drawing.Color.White;
            this.btnExportarCSV.Location = new System.Drawing.Point(50, 212);
            this.btnExportarCSV.Name = "btnExportarCSV";
            this.btnExportarCSV.Size = new System.Drawing.Size(298, 58);
            this.btnExportarCSV.TabIndex = 22;
            this.btnExportarCSV.Text = "Exportar CSV";
            this.btnExportarCSV.UseVisualStyleBackColor = false;
            this.btnExportarCSV.Click += new System.EventHandler(this.btnExportarCSV_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(50, 433);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(298, 58);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.BackColor = System.Drawing.Color.IndianRed;
            this.btnExportarPDF.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnExportarPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportarPDF.Location = new System.Drawing.Point(50, 276);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(298, 58);
            this.btnExportarPDF.TabIndex = 24;
            this.btnExportarPDF.Text = "Exportar PDF";
            this.btnExportarPDF.UseVisualStyleBackColor = false;
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click);
            // 
            // btnExportarXml
            // 
            this.btnExportarXml.BackColor = System.Drawing.Color.IndianRed;
            this.btnExportarXml.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnExportarXml.ForeColor = System.Drawing.Color.White;
            this.btnExportarXml.Location = new System.Drawing.Point(50, 340);
            this.btnExportarXml.Name = "btnExportarXml";
            this.btnExportarXml.Size = new System.Drawing.Size(298, 58);
            this.btnExportarXml.TabIndex = 25;
            this.btnExportarXml.Text = "Exportar Xml";
            this.btnExportarXml.UseVisualStyleBackColor = false;
            this.btnExportarXml.Click += new System.EventHandler(this.btnExportarXml_Click);
            // 
            // FrmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(884, 531);
            this.ControlBox = false;
            this.Controls.Add(this.btnExportarXml);
            this.Controls.Add(this.btnExportarPDF);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnExportarCSV);
            this.Controls.Add(this.btnExportarJson);
            this.Controls.Add(this.btnListarApuestas);
            this.Controls.Add(this.lstListadoApuestas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInformes";
            this.Load += new System.EventHandler(this.FrmInformes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstListadoApuestas;
        private System.Windows.Forms.Button btnListarApuestas;
        private System.Windows.Forms.Button btnExportarJson;
        private System.Windows.Forms.Button btnExportarCSV;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExportarPDF;
        private System.Windows.Forms.Button btnExportarXml;
    }
}