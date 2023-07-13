namespace Vista
{
    partial class FrmAccionAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccionAdministrador));
            this.label1 = new System.Windows.Forms.Label();
            this.btnListarUsuariosEnElSistema = new System.Windows.Forms.Button();
            this.btnListarUsuariosPendientes = new System.Windows.Forms.Button();
            this.btnListarPartidos = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.listBoxListado = new System.Windows.Forms.ListBox();
            this.btnAltaUsuariosPendientes = new System.Windows.Forms.Button();
            this.btnSuspenderUsuario = new System.Windows.Forms.Button();
            this.btnAltaPartidos = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuarioPend = new System.Windows.Forms.Button();
            this.btnFinalizarPartido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInformes = new System.Windows.Forms.Button();
            this.rtbRegistroDeApuestas = new System.Windows.Forms.RichTextBox();
            this.lblInfoAdmin = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Algerian", 27F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador";
            // 
            // btnListarUsuariosEnElSistema
            // 
            this.btnListarUsuariosEnElSistema.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnListarUsuariosEnElSistema.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnListarUsuariosEnElSistema.ForeColor = System.Drawing.Color.White;
            this.btnListarUsuariosEnElSistema.Location = new System.Drawing.Point(29, 143);
            this.btnListarUsuariosEnElSistema.Name = "btnListarUsuariosEnElSistema";
            this.btnListarUsuariosEnElSistema.Size = new System.Drawing.Size(298, 58);
            this.btnListarUsuariosEnElSistema.TabIndex = 1;
            this.btnListarUsuariosEnElSistema.Text = "Listar Usuarios ";
            this.btnListarUsuariosEnElSistema.UseVisualStyleBackColor = false;
            this.btnListarUsuariosEnElSistema.Click += new System.EventHandler(this.btnListarUsuariosEnElSistema_Click);
            // 
            // btnListarUsuariosPendientes
            // 
            this.btnListarUsuariosPendientes.BackColor = System.Drawing.Color.IndianRed;
            this.btnListarUsuariosPendientes.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnListarUsuariosPendientes.ForeColor = System.Drawing.Color.White;
            this.btnListarUsuariosPendientes.Location = new System.Drawing.Point(29, 234);
            this.btnListarUsuariosPendientes.Name = "btnListarUsuariosPendientes";
            this.btnListarUsuariosPendientes.Size = new System.Drawing.Size(298, 58);
            this.btnListarUsuariosPendientes.TabIndex = 2;
            this.btnListarUsuariosPendientes.Text = "Listar Usuarios Pendientes";
            this.btnListarUsuariosPendientes.UseVisualStyleBackColor = false;
            this.btnListarUsuariosPendientes.Click += new System.EventHandler(this.btnListarUsuariosPendientes_Click);
            // 
            // btnListarPartidos
            // 
            this.btnListarPartidos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnListarPartidos.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnListarPartidos.ForeColor = System.Drawing.Color.White;
            this.btnListarPartidos.Location = new System.Drawing.Point(29, 319);
            this.btnListarPartidos.Name = "btnListarPartidos";
            this.btnListarPartidos.Size = new System.Drawing.Size(298, 58);
            this.btnListarPartidos.TabIndex = 3;
            this.btnListarPartidos.Text = "Listar Partidos";
            this.btnListarPartidos.UseVisualStyleBackColor = false;
            this.btnListarPartidos.Click += new System.EventHandler(this.btnListarPartidos_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.IndianRed;
            this.btnVolverMenu.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnVolverMenu.ForeColor = System.Drawing.Color.White;
            this.btnVolverMenu.Location = new System.Drawing.Point(746, 406);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(236, 58);
            this.btnVolverMenu.TabIndex = 4;
            this.btnVolverMenu.Text = "Salir";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // listBoxListado
            // 
            this.listBoxListado.FormattingEnabled = true;
            this.listBoxListado.HorizontalScrollbar = true;
            this.listBoxListado.ItemHeight = 20;
            this.listBoxListado.Location = new System.Drawing.Point(494, 22);
            this.listBoxListado.Name = "listBoxListado";
            this.listBoxListado.Size = new System.Drawing.Size(488, 364);
            this.listBoxListado.TabIndex = 5;
            // 
            // btnAltaUsuariosPendientes
            // 
            this.btnAltaUsuariosPendientes.BackColor = System.Drawing.SystemColors.Control;
            this.btnAltaUsuariosPendientes.BackgroundImage = global::Vista.Properties.Resources._01Agregar;
            this.btnAltaUsuariosPendientes.Location = new System.Drawing.Point(346, 234);
            this.btnAltaUsuariosPendientes.Name = "btnAltaUsuariosPendientes";
            this.btnAltaUsuariosPendientes.Size = new System.Drawing.Size(55, 58);
            this.btnAltaUsuariosPendientes.TabIndex = 6;
            this.btnAltaUsuariosPendientes.UseVisualStyleBackColor = false;
            this.btnAltaUsuariosPendientes.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnSuspenderUsuario
            // 
            this.btnSuspenderUsuario.BackgroundImage = global::Vista.Properties.Resources._01Eliminar;
            this.btnSuspenderUsuario.Location = new System.Drawing.Point(421, 143);
            this.btnSuspenderUsuario.Name = "btnSuspenderUsuario";
            this.btnSuspenderUsuario.Size = new System.Drawing.Size(55, 58);
            this.btnSuspenderUsuario.TabIndex = 8;
            this.btnSuspenderUsuario.UseVisualStyleBackColor = true;
            this.btnSuspenderUsuario.Click += new System.EventHandler(this.btnSuspenderUsuario_Click);
            // 
            // btnAltaPartidos
            // 
            this.btnAltaPartidos.BackColor = System.Drawing.SystemColors.Control;
            this.btnAltaPartidos.BackgroundImage = global::Vista.Properties.Resources._01Agregar;
            this.btnAltaPartidos.Location = new System.Drawing.Point(346, 317);
            this.btnAltaPartidos.Name = "btnAltaPartidos";
            this.btnAltaPartidos.Size = new System.Drawing.Size(55, 58);
            this.btnAltaPartidos.TabIndex = 9;
            this.btnAltaPartidos.UseVisualStyleBackColor = false;
            this.btnAltaPartidos.Click += new System.EventHandler(this.btnAltaPartidos_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackColor = System.Drawing.Color.White;
            this.btnModificarUsuario.BackgroundImage = global::Vista.Properties.Resources._01Modifica;
            this.btnModificarUsuario.Location = new System.Drawing.Point(346, 143);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(55, 58);
            this.btnModificarUsuario.TabIndex = 10;
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnEliminarUsuarioPend
            // 
            this.btnEliminarUsuarioPend.BackgroundImage = global::Vista.Properties.Resources._01Eliminar;
            this.btnEliminarUsuarioPend.Location = new System.Drawing.Point(421, 234);
            this.btnEliminarUsuarioPend.Name = "btnEliminarUsuarioPend";
            this.btnEliminarUsuarioPend.Size = new System.Drawing.Size(55, 58);
            this.btnEliminarUsuarioPend.TabIndex = 12;
            this.btnEliminarUsuarioPend.UseVisualStyleBackColor = true;
            this.btnEliminarUsuarioPend.Click += new System.EventHandler(this.btnEliminarUsuarioPend_Click);
            // 
            // btnFinalizarPartido
            // 
            this.btnFinalizarPartido.BackgroundImage = global::Vista.Properties.Resources._01Eliminar;
            this.btnFinalizarPartido.Location = new System.Drawing.Point(421, 317);
            this.btnFinalizarPartido.Name = "btnFinalizarPartido";
            this.btnFinalizarPartido.Size = new System.Drawing.Size(55, 58);
            this.btnFinalizarPartido.TabIndex = 14;
            this.btnFinalizarPartido.UseVisualStyleBackColor = true;
            this.btnFinalizarPartido.Click += new System.EventHandler(this.btnFinalizarPartido_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(104, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 55);
            this.label2.TabIndex = 15;
            this.label2.Text = "NBA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(224, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 55);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bet";
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.Color.IndianRed;
            this.btnInformes.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnInformes.ForeColor = System.Drawing.Color.White;
            this.btnInformes.Location = new System.Drawing.Point(29, 406);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(298, 58);
            this.btnInformes.TabIndex = 17;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = false;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // rtbRegistroDeApuestas
            // 
            this.rtbRegistroDeApuestas.Location = new System.Drawing.Point(494, 22);
            this.rtbRegistroDeApuestas.Name = "rtbRegistroDeApuestas";
            this.rtbRegistroDeApuestas.Size = new System.Drawing.Size(488, 364);
            this.rtbRegistroDeApuestas.TabIndex = 18;
            this.rtbRegistroDeApuestas.Text = "";
            this.rtbRegistroDeApuestas.Visible = false;
            // 
            // lblInfoAdmin
            // 
            this.lblInfoAdmin.AutoSize = true;
            this.lblInfoAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfoAdmin.ForeColor = System.Drawing.Color.White;
            this.lblInfoAdmin.Location = new System.Drawing.Point(346, 406);
            this.lblInfoAdmin.Name = "lblInfoAdmin";
            this.lblInfoAdmin.Size = new System.Drawing.Size(24, 25);
            this.lblInfoAdmin.TabIndex = 19;
            this.lblInfoAdmin.Text = "...";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(346, 461);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(24, 25);
            this.lblHorario.TabIndex = 21;
            this.lblHorario.Text = "...";
            // 
            // FrmAccionAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(996, 506);
            this.ControlBox = false;
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblInfoAdmin);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFinalizarPartido);
            this.Controls.Add(this.btnEliminarUsuarioPend);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnAltaPartidos);
            this.Controls.Add(this.btnSuspenderUsuario);
            this.Controls.Add(this.btnAltaUsuariosPendientes);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnListarPartidos);
            this.Controls.Add(this.btnListarUsuariosPendientes);
            this.Controls.Add(this.btnListarUsuariosEnElSistema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxListado);
            this.Controls.Add(this.rtbRegistroDeApuestas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAccionAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accion de Administrador";
            this.Load += new System.EventHandler(this.FrmAccionAdministrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListarUsuariosEnElSistema;
        private System.Windows.Forms.Button btnListarUsuariosPendientes;
        private System.Windows.Forms.Button btnListarPartidos;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.ListBox listBoxListado;
        private System.Windows.Forms.Button btnAltaUsuariosPendientes;
        private System.Windows.Forms.Button btnSuspenderUsuario;
        private System.Windows.Forms.Button btnAltaPartidos;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuarioPend;
        private System.Windows.Forms.Button btnFinalizarPartido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.RichTextBox rtbRegistroDeApuestas;
        private System.Windows.Forms.Label lblInfoAdmin;
        private System.Windows.Forms.Label lblHorario;
    }
}