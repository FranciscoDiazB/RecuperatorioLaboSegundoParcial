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

namespace Vista
{
    public partial class FrmLoginUsuarios : Form
    {

        List<Usuario> usuarios;
        List<Administrador> administradores;
        List<UsuarioJugador> usuariosRegistrados;
        List<UsuarioJugador> usuariosJugadoresEnSistema;
        List<Partido> partidos;

        public FrmLoginUsuarios()
        {
            InitializeComponent();
            usuarios = new List<Usuario>();
            usuariosRegistrados = new List<UsuarioJugador>();
            usuariosJugadoresEnSistema = new List<UsuarioJugador>();
            administradores = new List<Administrador>();
            partidos = new List<Partido>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarJugadoresRegistroPendiente();
            CargarPartidosSistema();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuarioIngresado = new UsuarioLogin(txtUsuario.Text, txtPassword.Text);
                Usuario usuarioDeLista = Usuario.DevolverUsuario(usuarios, usuarioIngresado);              

                if (usuarioDeLista.TipoIngreso == "Admin")
                {
                    FrmAccionAdministrador frmAccion = new FrmAccionAdministrador(usuariosJugadoresEnSistema, usuariosRegistrados, partidos, this, usuarioDeLista);

                    frmAccion.Show();
                }
                else if(usuarioDeLista.TipoIngreso == "Player")
                {
                    FrmMenuPrincipal nuevoMenuPrincipal = new FrmMenuPrincipal(usuariosJugadoresEnSistema, partidos, this, usuarioDeLista);

                    nuevoMenuPrincipal.Show();
                }

                LogsIngresoDB dB = new LogsIngresoDB();

                dB.Agregar(usuarioDeLista);

                this.Hide();
            }
            catch (UsuarioInvalidoException)
            {
                MessageBox.Show("Los datos no corresponden a ningun usuario registrado. De ser asi, puede registrarse oprimiendo el boton de mas abajo.", "Error en el Ingreso");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }


        private void btnRegistrarseUsuario_Click(object sender, EventArgs e)
        {
            FrmRegistrarNuevosUsuarios frmRegistrarNuevos = new FrmRegistrarNuevosUsuarios(usuariosRegistrados, usuarios);

            frmRegistrarNuevos.Show();
        }


        private void CargarJugadoresSistema()
        {
            try
            {
                usuariosJugadoresEnSistema.Clear();

                JugadoresDB dB = new JugadoresDB();

                usuariosJugadoresEnSistema = dB.Obtener();
            }
            catch(Exception)
            {
                throw;
            }
        }


        private void CargarJugadoresRegistroPendiente()
        {
            try
            {
                usuariosRegistrados.Clear();
                
                JugadoresPendientesDB dB = new JugadoresPendientesDB();

                usuariosRegistrados = dB.Obtener();

            }
            catch (Exception)
            {
                MessageBox.Show("Errror");
            }
        }


        private void CargarPartidosSistema()
        {
            try
            {
                partidos.Clear();

                PartidosDB dB = new PartidosDB();

                partidos = dB.Obtener();
            }
            catch (Exception)
            {
                MessageBox.Show("Errror");
            }
        }


        private void CargarAdminsSistema()
        {
            try
            {
                administradores.Clear();

                AdministradorDB dB = new AdministradorDB();

                administradores = dB.Obtener();

            }
            catch (Exception)
            {
                throw;
            }
        }


        private void CargarUsuarios()
        {

            try
            {
                usuarios.Clear();
                CargarAdminsSistema();
                CargarJugadoresSistema();

                foreach(UsuarioJugador jugador in usuariosJugadoresEnSistema)
                {
                    usuarios.Add(jugador);
                }

                foreach(Administrador admin in administradores)
                {
                    usuarios.Add(admin);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error");
            }
        }

        private void btnUsuario1_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "Melina";
            txtPassword.Text = "piratas08";
        }

        private void btnUsuario2_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "JotaRP";
            txtPassword.Text = "jotaRPGOD";
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "David";
            txtPassword.Text = "d2190admin";
        }
    }
}
