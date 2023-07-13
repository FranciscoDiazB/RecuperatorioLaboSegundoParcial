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
    public partial class FrmRealizarApuestaJugadoresEstrellaEste : Form
    {

        private UsuarioJugador usuario;
        private List<UsuarioJugador> listaUsuarios;
        private int acumuladorCreditos;
        FrmMenuPrincipal principal;

        public FrmRealizarApuestaJugadoresEstrellaEste()
        {
            InitializeComponent();
        }

        public FrmRealizarApuestaJugadoresEstrellaEste(UsuarioJugador user, List<UsuarioJugador> lista, FrmMenuPrincipal form) : this()
        {
            this.usuario = user;
            this.listaUsuarios = lista;
            this.principal = form;
            this.acumuladorCreditos = 0;
        }


        private void FrmRealizarApuestaJugadoresEstrellaEste_Load(object sender, EventArgs e)
        {
            if (principal.seRealizoApuestaDeJugadoresEste == true)
            {
                MessageBox.Show($"Ya realizo la apuestas de los jugadores del Este\n{principal.jugadoresApostadosEste}", "Apuesta Realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                RefrescarDatos();
            }
        }

        private void pbGiannis_Click(object sender, EventArgs e)
        {
            DeshabilitarJimmy();
            pbGiannis.Enabled = false;
            acumuladorCreditos += 25;
        }

        private void pbJimmy_Click(object sender, EventArgs e)
        {
            DeshabilitarGiannis();
            pbJimmy.Enabled = false;
            acumuladorCreditos += 25;
        }

        private void pbTatum_Click(object sender, EventArgs e)
        {
            DeshabilitarTrae();
            pbTatum.Enabled = false;
            acumuladorCreditos += 25;
        }

        private void pbTrae_Click(object sender, EventArgs e)
        {
            DeshabilitarTatum();
            pbTrae.Enabled = false;
            acumuladorCreditos += 25;
        }

        private void pbEmbid_Click(object sender, EventArgs e)
        {
            DeshabilitarBridges();
            pbEmbid.Enabled = false;
            acumuladorCreditos += 25;
        }

        private void pbBridges_Click(object sender, EventArgs e)
        {
            DeshabilitarEmbid();
            pbBridges.Enabled = false;
            acumuladorCreditos += 25;
        }

        private void pbDonovan_Click(object sender, EventArgs e)
        {
            DeshabilitarBrunson();
            pbDonovan.Enabled = false;
            acumuladorCreditos += 25;
        }

        private void pbBrunson_Click(object sender, EventArgs e)
        {
            DeshabilitarDonovan();
            pbBrunson.Enabled = false;
            acumuladorCreditos += 25;
        }

        private void DeshabilitarJimmy()
        {
            pbJimmy.Visible = false;
            pbJimmy.Enabled = false;
            lblJimmy.Visible = false;
        }

        private void DeshabilitarGiannis()
        {
            pbGiannis.Visible = false;
            pbGiannis.Enabled = false;
            lblGiannis.Visible = false;
        }

        private void DeshabilitarTrae()
        {
            pbTrae.Visible = false;
            pbTrae.Enabled = false;
            lblTrae.Visible = false;
        }

        private void DeshabilitarTatum()
        {
            pbTatum.Visible = false;
            pbTatum.Enabled = false;
            lblTatum.Visible = false;
        }

        private void DeshabilitarBridges()
        {
            pbBridges.Visible = false;
            pbBridges.Enabled = false;
            lblBridges.Visible = false;
        }

        private void DeshabilitarEmbid()
        {
            pbEmbid.Visible = false;
            pbEmbid.Enabled = false;
            lblEmbid.Visible = false;
        }

        private void DeshabilitarBrunson()
        {
            pbBrunson.Visible = false;
            pbBrunson.Enabled = false;
            lblBrunson.Visible = false;
        }

        private void DeshabilitarDonovan()
        {
            pbDonovan.Visible = false;
            pbDonovan.Enabled = false;
            lblDonovan.Visible = false;
        }

        private void RefrescarDatos()
        {
            pbJimmy.Visible = true;
            pbJimmy.Enabled = true;
            lblJimmy.Visible = true;
            pbGiannis.Visible = true;
            pbGiannis.Enabled = true;
            lblGiannis.Visible = true;
            pbTrae.Visible = true;
            pbTrae.Enabled = true;
            lblTrae.Visible = true;
            pbTatum.Visible = true;
            pbTatum.Enabled = true;
            lblTatum.Visible = true;
            pbBridges.Visible = true;
            pbBridges.Enabled = true;
            lblBridges.Visible = true;
            pbEmbid.Visible = true;
            pbEmbid.Enabled = true;
            lblEmbid.Visible = true;
            pbBrunson.Visible = true;
            pbBrunson.Enabled = true;
            lblBrunson.Visible = true;
            pbDonovan.Visible = true;
            pbDonovan.Enabled = true;
            lblDonovan.Visible = true;
            acumuladorCreditos = 0;
        }

        private void btnRealizarApuestaJugador_Click(object sender, EventArgs e)
        {
            try
            {
                if (acumuladorCreditos > 0)
                {
                    if (usuario.RealizarApuesta(acumuladorCreditos))
                    {
                        ManejadorArchivoTexto.GuardarEnArchivoDeTexto("RegistroDeApuestas.txt", Sistema.RegistrarApuestasAJugadores(usuario, RegistrarJugadoresApostados()), true);
                        principal.seRealizoApuestaDeJugadoresEste = true;
                        principal.jugadoresApostadosEste = RegistrarJugadoresApostados();
                        btnRefrescarDatos.Enabled = false;
                        btnRealizarApuestaJugador.Enabled = false;
                        MessageBox.Show($"Apuesta realizada y registrada con exitos!!", "Exitos", MessageBoxButtons.OK);

                        LogsActividadDB dB = new LogsActividadDB();

                        dB.Agregar(usuario, "El Usuario Realizo una Apuesta de Jugadores del Oeste");

                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar almenos un jugador para poder realizar la apuesta", "Seleccione jugadores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (CreditosInsuficientesException)
            {
                MessageBox.Show("Creditos insuficientes, realice una recarga de creditos o seleccione menos jugadores", "Error: creditos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error en el sistema. Disculpe las molestias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescarDatos_Click(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para poder realizar la apuesta de los jugadores, debe hacer click en alguna de las imagenes de los jugadores que se enfrentan. Como maximo va a poder realizar 4 selecciones. Como minimo se va a poder realizar 1 seleccion.\nEl costo de seleccion es de 25 creditos cada una", "Seleccionar Jugadores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private string RegistrarJugadoresApostados()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Cada apuesta fueron 25 creditos:");

            if (pbGiannis.Visible && pbGiannis.Enabled == false)
            {
                sb.AppendLine($"1. Giannis Antetokuompo va a anotar mas puntos que Jimmy Butler");
            }
            if (pbJimmy.Visible && pbJimmy.Enabled == false)
            {
                sb.AppendLine($"1. Jimmy Butler va a anotar mas puntos que Giannis Antetokuompo");
            }
            if (pbTatum.Visible && pbTatum.Enabled == false)
            {
                sb.AppendLine($"2. Jayson Tatum va a anotar mas puntos que Trae Young");
            }
            if (pbTrae.Visible && pbTrae.Enabled == false)
            {
                sb.AppendLine($"2. Trae Young va a anotar mas puntos que Jayson Tatum");
            }
            if (pbEmbid.Visible && pbEmbid.Enabled == false)
            {
                sb.AppendLine($"3. Joel Embid va a anotar mas puntos que Mikal Bridges");
            }
            if (pbBridges.Visible && pbBridges.Enabled == false)
            {
                sb.AppendLine($"3. Mikal Bridges va a anotar mas puntos que Joel Embid");
            }
            if (pbDonovan.Visible && pbDonovan.Enabled == false)
            {
                sb.AppendLine($"4. Donovan Mitchell va a anotar mas puntos que Jalen Brunson");
            }
            if (pbBrunson.Visible && pbBrunson.Enabled == false)
            {
                sb.AppendLine($"4. Jalen Brunson va a anotar mas puntos que Donovan Mitchell");
            }

            return sb.ToString();
        }

    }
}
