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
using System.Threading;

namespace Vista
{
    public partial class FrmMenuPrincipal : Form
    {
        private FrmLoginUsuarios formulario;
        private UsuarioJugador nuevoUsuario;
        private List<UsuarioJugador> usuariosJugadorSistemas;
        private List<Partido> partidos;
        public bool seRealizoApuestaDeJugadores;
        public bool seRealizoApuestaDeJugadoresEste;
        public string jugadoresApostados;
        public string jugadoresApostadosEste;
        FrmProde frmProde;
        int numeroFrmTrivia = 0;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        public FrmMenuPrincipal(FrmLoginUsuarios form, Usuario user) : this()
        {
            formulario = form;
            nuevoUsuario = (UsuarioJugador) user;
        }

        public FrmMenuPrincipal(List<UsuarioJugador> jugadoresSistema, List<Partido> listaPartidos,
            FrmLoginUsuarios form, Usuario user) : this(form, user)
        {
            this.usuariosJugadorSistemas = jugadoresSistema;
            this.partidos = listaPartidos;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (nuevoUsuario.EstaBan)
            {
                MessageBox.Show("La cuenta se encuentra suspendida momentaneamente. Hable con soporte 'www.nbaBet.com/soporteBan' para mas informacion.\nEl formulario se va a cerrar", "Disculpe las molestias", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                formulario.Close();
            }

            Task.Run(() =>
            {
                ComenzarHorarioActual();
            });

            RefrescarDatos();
            seRealizoApuestaDeJugadores = false;
            seRealizoApuestaDeJugadoresEste = false;
            jugadoresApostados = string.Empty;
            jugadoresApostadosEste = string.Empty;
            frmProde = new FrmProde(nuevoUsuario);
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            formulario.Close();
        }

        private void btnRealizarApuesta_Click(object sender, EventArgs e)
        {
            FrmRealizarApuestas frmRealizarApuestas = new FrmRealizarApuestas(nuevoUsuario, partidos, usuariosJugadorSistemas);

            frmRealizarApuestas.Show();
        }

        private void btnPerfilUsuario_Click(object sender, EventArgs e)
        {
            FrmPerfilUsuario frmPerfilUsuario = new FrmPerfilUsuario(nuevoUsuario, this);

            frmPerfilUsuario.Show();
        }

        private void btnRefrescarDatos_Click(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void RefrescarDatos()
        {
            lblDatosUsuario.Text = string.Empty;
            lblDatosUsuario.Text = nuevoUsuario.MostrarUsuario();
        }

        private void btnProde_Click(object sender, EventArgs e)
        {
            frmProde.Show();
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            FrmRealizarApuestaJugadorEstrella frmJugadorEstrella = new FrmRealizarApuestaJugadorEstrella(nuevoUsuario, usuariosJugadorSistemas, this);
            
            frmJugadorEstrella.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRealizarApuestaJugadoresEstrellaEste frmJugadorEstrella = new FrmRealizarApuestaJugadoresEstrellaEste(nuevoUsuario, usuariosJugadorSistemas, this);

            frmJugadorEstrella.Show();
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
            try
            {
                if (this.InvokeRequired)
                {
                    Action delegadoHorario = AsignarHorario;
                    this.Invoke(delegadoHorario);
                }
                else
                {
                    lblHorario.Text = DateTime.Now.ToString();
                }
            }
            catch(Exception)
            {

            }
        }

        private void btnTrivia_Click(object sender, EventArgs e)
        {
            numeroFrmTrivia += 1;

            if(numeroFrmTrivia <= 3)
            {
                FrmTrivia frmTrivia = new FrmTrivia(numeroFrmTrivia, nuevoUsuario);

                frmTrivia.Show();
            }
            else
            {
                MessageBox.Show("Se puede entrar en esta opcion un maximo de tres veces. Disculpe las molestias", "Numero Maximo de Ingreso");
            }

        }
    }
}
