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
    public partial class FrmRealizarApuestaJugadorEstrella : Form
    {
        private UsuarioJugador usuario;
        private List<UsuarioJugador> listaUsuarios;
        private int acumuladorCreditos;
        FrmMenuPrincipal principal;

        public FrmRealizarApuestaJugadorEstrella()
        {
            InitializeComponent();
        }

        public FrmRealizarApuestaJugadorEstrella(UsuarioJugador user, List<UsuarioJugador> lista, FrmMenuPrincipal menuPrincipal) : this()
        {
            this.usuario = user;
            this.listaUsuarios = lista;
            this.acumuladorCreditos = 0;
            this.principal = menuPrincipal;
        }

        private void FrmRealizarApuestaJugadorEstrella_Load(object sender, EventArgs e)
        {
            if(principal.seRealizoApuestaDeJugadores == true)
            {
                MessageBox.Show($"Ya realizo la apuestas de los jugadores del Oeste\n{principal.jugadoresApostados}", "Apuesta Realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                RefrescarDatos();
            }
        }

        private void pbJokic_Click(object sender, EventArgs e)
        {          
            DeshabilitarKat();
            pbJokic.Enabled = false;
            acumuladorCreditos += 25;
        }

        private void pbKAT_Click(object sender, EventArgs e)
        {

            DeshabilitarJokic();
            pbKAT.Enabled = false;
            acumuladorCreditos += 25;
        }

        private void pbJA_Click(object sender, EventArgs e)
        {

            DeshabilitarLebron();
            pbJA.Enabled = false;
            acumuladorCreditos += 25;

        }

        private void pbLebron_Click(object sender, EventArgs e)
        {

            DeshabilitarJa();
            pbLebron.Enabled = false;
            acumuladorCreditos += 25;

        }

        private void pbFox_Click(object sender, EventArgs e)
        {

            DeshabilitarCurry();
            pbFox.Enabled = false;
            acumuladorCreditos += 25;

        }

        private void pbCurry_Click(object sender, EventArgs e)
        {

            DeshabilitarFox();
            pbCurry.Enabled = false;
            acumuladorCreditos += 25;

        }

        private void pbKD_Click(object sender, EventArgs e)
        {

            DeshabilitarLeonard();
            pbKD.Enabled = false;
            acumuladorCreditos += 25;

        }

        private void pbLeonard_Click(object sender, EventArgs e)
        {

            DeshabilitarKD();
            pbLeonard.Enabled = false;
            acumuladorCreditos += 25;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para poder realizar la apuesta de los jugadores, debe hacer click en alguna de las imagenes de los jugadores que se enfrentan. Como maximo va a poder realizar 4 selecciones. Como minimo se va a poder realizar 1 seleccion.\nEl costo de seleccion es de 25 creditos cada una", "Seleccionar Jugadores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefrescarDatos_Click(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void RefrescarDatos()
        {
            pbKAT.Visible = true;
            pbKAT.Enabled = true;
            lblKat.Visible = true;
            pbJokic.Visible = true;
            pbJokic.Enabled = true;
            lblJokic.Visible = true;
            pbLebron.Visible = true;
            pbLebron.Enabled = true;
            lblLebron.Visible = true;
            pbJA.Visible = true;
            pbJA.Enabled = true;
            lblJa.Visible = true;
            pbCurry.Visible = true;
            pbCurry.Enabled = true;
            lblCurry.Visible = true;
            pbFox.Visible = true;
            pbFox.Enabled = true;
            lblFox.Visible = true;
            pbLeonard.Visible = true;
            pbLeonard.Enabled = true;
            lblLeonard.Visible = true;
            pbKD.Visible = true;
            pbKD.Enabled = true;
            lblKD.Visible = true;
            acumuladorCreditos = 0;
        }


        private void DeshabilitarKat()
        {
            pbKAT.Visible = false;
            pbKAT.Enabled = false;
            lblKat.Visible = false;
        }

        private void DeshabilitarJokic()
        {
            pbJokic.Visible = false;
            pbJokic.Enabled = false;
            lblJokic.Visible = false;
        }

        private void DeshabilitarLebron()
        {
            pbLebron.Visible = false;
            pbLebron.Enabled = false;
            lblLebron.Visible = false;
        }

        private void DeshabilitarJa()
        {
            pbJA.Visible = false;
            pbJA.Enabled = false;
            lblJa.Visible = false;
        }

        private void DeshabilitarCurry()
        {
            pbCurry.Visible = false;
            pbCurry.Enabled = false;
            lblCurry.Visible = false;
        }

        private void DeshabilitarFox()
        {
            pbFox.Visible = false;
            pbFox.Enabled = false;
            lblFox.Visible = false;
        }

        private void DeshabilitarLeonard()
        {
            pbLeonard.Visible = false;
            pbLeonard.Enabled = false;
            lblLeonard.Visible = false;
        }

        private void DeshabilitarKD()
        {
            pbKD.Visible = false;
            pbKD.Enabled = false;
            lblKD.Visible = false;
        }

        private void btnRealizarApuestaJugador_Click(object sender, EventArgs e)
        {
            try
            {
                if(acumuladorCreditos > 0)
                {
                    if (usuario.RealizarApuesta(acumuladorCreditos))
                    {
                        ManejadorArchivoTexto.GuardarEnArchivoDeTexto("RegistroDeApuestas.txt", Sistema.RegistrarApuestasAJugadores(usuario, RegistrarJugadoresApostados()), true);
                        principal.seRealizoApuestaDeJugadores = true;
                        principal.jugadoresApostados = RegistrarJugadoresApostados();
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
            catch(CreditosInsuficientesException)
            {
                MessageBox.Show("Creditos insuficientes, realice una recarga de creditos o seleccione menos jugadores", "Error: creditos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error en el sistema. Disculpe las molestias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string RegistrarJugadoresApostados()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Cada apuesta fueron 25 creditos:");

            if (pbCurry.Visible && pbCurry.Enabled == false)
            {
                sb.AppendLine($"1. Stephen Curry va a anotar mas puntos que Dearon Fox");
            }
            if (pbFox.Visible && pbFox.Enabled == false)
            {
                sb.AppendLine($"1. Dearon Fox va a anotar mas puntos que Stephen Curry");
            }
            if (pbJA.Visible && pbJA.Enabled == false)
            {
                sb.AppendLine($"2. Ja Morant va a anotar mas puntos que Lebron James");
            }
            if (pbLebron.Visible && pbLebron.Enabled == false)
            {
                sb.AppendLine($"2. Lebron James va a anotar mas puntos que Ja Morant");
            }
            if (pbJokic.Visible && pbJokic.Enabled == false) 
            {
                sb.AppendLine($"3. Nikola Jokic va a anotar mas puntos que Karl-Anthony Towns");
            }
            if (pbKAT.Visible && pbKAT.Enabled == false)
            {
                sb.AppendLine($"3. Karl-Anthony Towns va a anotar mas puntos que Nikola Jokic");
            }
            if (pbKD.Visible && pbKD.Enabled == false)
            {
                sb.AppendLine($"4. Kevin Durant va a anotar mas puntos que Kawhi Leonard");
            }
            if (pbLeonard.Visible && pbLeonard.Enabled == false)
            {
                sb.AppendLine($"4. Kawhi Leonard va a anotar mas puntos que Kevin Durant");
            }

            return sb.ToString();
        }


        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
