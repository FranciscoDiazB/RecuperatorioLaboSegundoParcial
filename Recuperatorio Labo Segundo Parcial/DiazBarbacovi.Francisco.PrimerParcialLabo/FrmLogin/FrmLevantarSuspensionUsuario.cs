using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.SQL;

namespace Vista
{
    public partial class FrmLevantarSuspensionUsuario : Form
    {

        private UsuarioJugador usuarioJugador;
        private Administrador admin;

        public FrmLevantarSuspensionUsuario()
        {
            InitializeComponent();
        }

        public FrmLevantarSuspensionUsuario(UsuarioJugador user, Administrador a) : this()
        {
            usuarioJugador = user;
            admin = a;
        }

        private void FrmLevantarSuspensionUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            try
            {
                if(Administrador.LevantarSuspension(usuarioJugador))
                {
                    MessageBox.Show($"Se levanto la suspension del usuario con mail '{usuarioJugador.Email}'", "Suspension levantada");

                    LogsActividadDB dB = new LogsActividadDB();

                    dB.Agregar(admin, $"El admin levanto la suspension de un Usuario Suspendido");

                    this.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show($"Error", "Excepcion encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Accion cancelada. Se volvera al formulario de administrador", "Cancelado");
            this.Close();
        }
    }
}
