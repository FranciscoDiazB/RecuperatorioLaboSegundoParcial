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
using Entidades.Informes;
using Entidades.SQL;

namespace Vista
{
    public partial class FrmRealizarApuestas : Form
    {

        private List<Partido> partidos;
        private UsuarioJugador usuario;
        private List<UsuarioJugador> jugadoresSistema;

        public FrmRealizarApuestas()
        {
            InitializeComponent();
        }

        public FrmRealizarApuestas(Usuario usuarioJugador, List<Partido> partidosSistema, List<UsuarioJugador> jugadors) : this()
        {
            usuario = (UsuarioJugador) usuarioJugador;
            partidos = partidosSistema;
            jugadoresSistema = jugadors;
        }


        private void FrmRealizarApuestas_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
            RefrescarListado();
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Partido partidoNuevo = (Partido) lstPartidos.SelectedItem as Partido;
            
            if(partidoNuevo is not null)
            {
                txtEquipoL.Text = partidoNuevo.JuegaEquipoLocal.ToString();
                txtEquipoV.Text = partidoNuevo.JuegaEquipoVisitante.ToString();
            }
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMinimoApuestas.Text != string.Empty && (rbEquipoLocal.Checked || rbEquipoVisitante.Checked) && lstPartidos.SelectedIndex > -1)
                {
                    Partido partidoNuevo = (Partido) lstPartidos.SelectedItem as Partido;

                    if (partidoNuevo.PartidoFinalizado == false)
                    {
                        if (usuario.RealizarApuesta(txtMinimoApuestas.Text))
                        {
                            Sistema.RegistrarApuestaRealizada(usuario, txtMinimoApuestas.Text, DevolverEquipoGanador(), partidoNuevo);
                                                      
                            MessageBox.Show("La apuesta fue registrada con exito", "Exitos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Sistema.EliminarPartidoDeLista(partidoNuevo, partidos);
                            
                            LogsActividadDB dB = new LogsActividadDB();

                            dB.Agregar(usuario, "El Usuario Realizo una Apuesta");

                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pueden realizar apuestas de los partidos ya finalizados. Elegir un juego valido para apostar", "Error en la apuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Se tienen que completar todos los campos obligatorios antes de poder realizar la apuesta. Tambien se tiene que seleccionar un partido valido de la lista","Datos insuficientes. Completar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (MinimoCreditosException)
            {
                MessageBox.Show("No pueden ingresarse montos menores a 50 creditos; tampoco es valido el ingreso de numeros negativos. Verifique que los datos ingresados sean correctos", "Error: Numeros Negativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CreditosInsuficientesException)
            {
                MessageBox.Show($"No hay creditos suficientes en cuenta para realizar la apuesta de {txtMinimoApuestas.Text} creditos. Asegurese de que el monto sea acorde a la cantidad de creditos en cuenta", "Error: Creditos en cuenta insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en el sistema. Verifique que los datos ingresados sean correctos", "Error: Verifique datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                RefrescarDatos();
            }
        }


        private void RefrescarDatos()
        {
            RefrescarListado();
            lstPartidos.SelectedIndex = -1;
            rbEquipoLocal.Checked = false;
            rbEquipoVisitante.Checked = false;
            txtEquipoL.Text = string.Empty;
            txtEquipoV.Text = string.Empty;
            lblInfoUsuario.Text = usuario.MostrarUsuario();
        }

        private void RefrescarListado()
        {
            lstPartidos.DataSource = null;
            lstPartidos.DataSource = partidos;
        }

        private string DevolverEquipoGanador()
        {
            if (rbEquipoLocal.Checked)
            {
                return txtEquipoL.Text;
            }

            return txtEquipoV.Text;
        }
    }
}
