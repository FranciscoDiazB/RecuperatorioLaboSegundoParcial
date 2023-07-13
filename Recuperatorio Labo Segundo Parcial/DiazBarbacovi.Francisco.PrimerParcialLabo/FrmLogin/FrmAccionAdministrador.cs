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
using Entidades.Exceptions;
using Entidades.SQL;
using System.Threading;

namespace Vista
{
    public partial class FrmAccionAdministrador : Form
    {
        private List<UsuarioJugador> usuariosJugadoresSistema;
        private List<UsuarioJugador> usuariosPend;
        private List<Partido> partidos;
        private FrmLoginUsuarios login;
        private Administrador admin;


        public FrmAccionAdministrador()
        {
            InitializeComponent();
        }

        public FrmAccionAdministrador(List<UsuarioJugador> usuariosEnSistema, List<UsuarioJugador> usuariosPendientes, List<Partido> listadoPartidos, FrmLoginUsuarios frmLogin, Usuario user) : this()
        {
            this.usuariosJugadoresSistema = usuariosEnSistema;
            this.usuariosPend = usuariosPendientes;
            this.partidos = listadoPartidos;
            this.login = frmLogin;
            this.admin = (Administrador) user;
        }

        private void FrmAccionAdministrador_Load(object sender, EventArgs e)
        {
            lblInfoAdmin.Text = admin.MostrarUsuario();
            DeshabilitarBotones();
            OcultarBotones();
            MostrarListados();
            ComenzarHorarioActual();
        }

        private void btnListarUsuariosEnElSistema_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarListados();
                HabilitarBotones(1);
                RefrescarListadoJugadores();
            }
            catch(Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnListarUsuariosPendientes_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarListados();
                HabilitarBotones(2);
                RefrescarListadoJugadoresPendientes();
            }
            catch(Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListarPartidos_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarListados();
                HabilitarBotones(3);
                RefrescarListadoPartidos();
            }
            catch(Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioJugador nuevoUsuario = (UsuarioJugador) listBoxListado.SelectedItem as UsuarioJugador;

                if(nuevoUsuario is not null)
                {
                    if (Administrador.AgregarUsuarioPendiente(nuevoUsuario))
                    {
                        RefrescarListadoJugadoresPendientes();
                        MessageBox.Show("Usuario agregado al sistema con exito", "Exitos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        LogsActividadDB dB = new LogsActividadDB();

                        dB.Agregar(admin, $"El admin realizo una alta de un Nuevo Usuario al Sistema");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un usuario de la lista para poder registrarlo en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminarUsuarioPend_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioJugador nuevoUsuario = (UsuarioJugador) listBoxListado.SelectedItem;

                if(nuevoUsuario is not null)
                {
                    if (Administrador.EliminarUsuarioPendiente(nuevoUsuario))
                    {
                        RefrescarListadoJugadoresPendientes();
                        MessageBox.Show("Usuario eliminado de la lista de registros pendientes", "Usuario eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        LogsActividadDB dB = new LogsActividadDB();

                        dB.Agregar(admin, $"El admin realizo la baja de un Usuario Pendiente");
                    }      
                }
                else
                {
                    MessageBox.Show($"Para poder realizar esta accion, tiene que seleccionar un usuario primero", "Seleccione un usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioJugador nuevoUsuario = (UsuarioJugador)listBoxListado.SelectedItem as UsuarioJugador;

                if (Sistema.VerificarSuspensionUsuario(nuevoUsuario))
                {
                    FrmLevantarSuspensionUsuario frm = new FrmLevantarSuspensionUsuario(nuevoUsuario, admin);

                    frm.Show();
                }
                else
                {
                    MessageBox.Show($"El usuario seleccionado no se encuentra baneado", "Usuario no baneado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {
                MessageBox.Show($"Hubo un error", "Excepcion encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuspenderUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioJugador nuevoUsuario = (UsuarioJugador)listBoxListado.SelectedItem as UsuarioJugador;
         
                if(Administrador.SuspenderUsuario(nuevoUsuario))
                {
                    MessageBox.Show($"El usuario '{nuevoUsuario.NombreUsuario}' fue suspendido con exito", "Usuario suspendido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    RefrescarListadoJugadores();

                    LogsActividadDB dB = new LogsActividadDB();

                    dB.Agregar(admin, $"El admin realizo la suspension de un Usuario en el Sistema");
                }
                else
                {
                    MessageBox.Show($"Para poder realizar esta accion, tiene que seleccionar un usuario primero", "Seleccione un usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFinalizarPartido_Click(object sender, EventArgs e)
        {
            try
            {
                Partido nuevoPartido = (Partido) listBoxListado.SelectedItem as Partido;
 
                if(Administrador.CancelarPartido(nuevoPartido))
                {
                    MessageBox.Show($"El partido con ID {nuevoPartido.IdPartido}, entre {nuevoPartido.JuegaEquipoLocal} vs {nuevoPartido.JuegaEquipoVisitante} fue finalizado/eliminado", "Partido finalizado/eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    RefrescarListadoPartidos();

                    LogsActividadDB dB = new LogsActividadDB();

                    dB.Agregar(admin, $"El admin realizo la baja de un Partido del Sistema");
                }
                else
                {
                    MessageBox.Show($"Para poder realizar esta accion, tiene que seleccionar un partido primero", "Seleccione un partido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }

        private void btnAbrirRegistroDeApuestas_Click(object sender, EventArgs e)
        {

        }

        private void btnAltaPartidos_Click(object sender, EventArgs e)
        {
            FrmPartidosDatos partidosDatos = new FrmPartidosDatos(partidos, this, admin);

            partidosDatos.Show();
            this.Hide();
        }

        private void RefrescarListadoJugadores()
        {
            JugadoresDB dB = new JugadoresDB();

            listBoxListado.DataSource = null;
            listBoxListado.DataSource = dB.Obtener();
            listBoxListado.SelectedIndex = -1;

        }

        private void RefrescarListadoJugadoresPendientes()
        {
            JugadoresPendientesDB dB = new JugadoresPendientesDB();

            listBoxListado.DataSource = null;
            listBoxListado.DataSource = dB.Obtener();
            listBoxListado.SelectedIndex = -1;

        }

        private void RefrescarListadoPartidos()
        {
            PartidosDB dB = new PartidosDB();

            listBoxListado.DataSource = null;
            listBoxListado.DataSource = dB.Obtener();
            listBoxListado.SelectedIndex = -1;

        }

        private void DeshabilitarBotones()
        {
            btnAltaPartidos.Enabled = false;
            btnFinalizarPartido.Enabled = false;
            btnAltaUsuariosPendientes.Enabled = false;
            btnEliminarUsuarioPend.Enabled = false;
            btnModificarUsuario.Enabled = false;
            btnSuspenderUsuario.Enabled = false;
        }

        private void OcultarBotones()
        {
            btnAltaPartidos.Visible = false;
            btnFinalizarPartido.Visible = false;
            btnAltaUsuariosPendientes.Visible = false;
            btnEliminarUsuarioPend.Visible = false;
            btnModificarUsuario.Visible = false;
            btnSuspenderUsuario.Visible = false;
        }

        private void HabilitarBotones(int numero)
        {
            if(numero == 1)
            {
                DeshabilitarBotones();
                OcultarBotones();
                btnSuspenderUsuario.Enabled = true;
                btnSuspenderUsuario.Visible = true;
                btnModificarUsuario.Enabled = true;
                btnModificarUsuario.Visible = true;
            }
            
            if(numero == 2)
            {
                DeshabilitarBotones();
                OcultarBotones();
                btnAltaUsuariosPendientes.Enabled = true;
                btnEliminarUsuarioPend.Enabled = true;
                btnAltaUsuariosPendientes.Visible = true;
                btnEliminarUsuarioPend.Visible = true;
            }

            if(numero == 3)
            {
                DeshabilitarBotones();
                OcultarBotones();
                btnAltaPartidos.Enabled = true;
                btnFinalizarPartido.Enabled = true;
                btnAltaPartidos.Visible = true;
                btnFinalizarPartido.Visible = true;
            }
        }

        private void RegistroDeApuestas()
        {
            rtbRegistroDeApuestas.Enabled = true;
            rtbRegistroDeApuestas.Visible = true;
            listBoxListado.Enabled = false;
            listBoxListado.Visible = false;
            DeshabilitarBotones();
            OcultarBotones();
        }

        private void MostrarListados()
        {
            listBoxListado.Enabled = true;
            listBoxListado.Visible = true;
            rtbRegistroDeApuestas.Enabled = false;
            rtbRegistroDeApuestas.Visible = false;

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.login.Close();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            FrmInformes frm = new FrmInformes(admin);

            frm.Show();
        }

        private void ComenzarHorarioActual()
        {
            Task.Run(() =>
            {
                do
                {
                    AsignarHorario();
                    Thread.Sleep(1000);

                } while (true);

            });
        }

        private void AsignarHorario()
        {
            if (this.InvokeRequired)
            {
                Action delegadoHorario = AsignarHorario;
                this.Invoke(delegadoHorario);
            }
            else
            {
                lblHorario.Text = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
            }
        }
    }
}
