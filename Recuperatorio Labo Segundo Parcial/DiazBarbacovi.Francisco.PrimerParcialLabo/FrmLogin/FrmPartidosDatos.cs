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
    public partial class FrmPartidosDatos : Form
    {
        private List<Partido> listaPartidos;
        private FrmAccionAdministrador formAdmin;
        private Administrador admin;

        public FrmPartidosDatos()
        {
            InitializeComponent();
        }

        public FrmPartidosDatos(List<Partido> lista, FrmAccionAdministrador accion, Administrador user) : this()
        {
            this.listaPartidos = lista;
            this.formAdmin = accion;
            this.admin = user;
        }

        private void FrmPartidosDatos_Load(object sender, EventArgs e)
        {
            CompletarDatos();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbEquipoLocal.SelectedItem is not null && cmbEquipoVisitante.SelectedItem is not null && cmbDia.SelectedItem is not null
                    && cmbHora.SelectedItem is not null && cmbMes.SelectedItem is not null && cmbMinutos.SelectedItem is not null && cmbNumeroJuego is not null)
                {
                    string equipoLocal = cmbLocacionLocal.SelectedItem.ToString() + " " + cmbEquipoLocal.SelectedItem.ToString();
                    string equipoVisitante = cmbLocacionVisitante.SelectedItem.ToString() + " " + cmbEquipoVisitante.SelectedItem.ToString();

                    DateTime dateTime = new DateTime(int.Parse(txtYear.Text), (int)cmbMes.SelectedItem, (int)cmbDia.SelectedItem, (int)cmbHora.SelectedItem, (int)cmbMinutos.SelectedItem, 00);

                    if (Administrador.AgregarPartido(equipoLocal, equipoVisitante, dateTime, (int)cmbNumeroJuego.SelectedItem, listaPartidos))
                    {
                        MessageBox.Show("Partido agregado con exito", "Exito");

                        LogsActividadDB dB = new LogsActividadDB();

                        dB.Agregar(admin, $"El admin realizo una alta de un Partido Nuevo");
                    }
                }
                else
                {
                    MessageBox.Show("Se necesitan completar todos los datos para el registro del partido", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            CompletarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            formAdmin.Show();
            this.Close();
        }

        private void CompletarDatos()
        {
            cmbEquipoLocal.Items.Clear();
            cmbEquipoLocal.Items.Add("Bucks");
            cmbEquipoLocal.Items.Add("Cavaliers");
            cmbEquipoLocal.Items.Add("76ers");
            cmbEquipoLocal.Items.Add("Celtics");
            cmbEquipoLocal.Items.Add("Nuggets");
            cmbEquipoLocal.Items.Add("Suns");
            cmbEquipoLocal.Items.Add("Kings");
            cmbEquipoLocal.Items.Add("Grizzles");

            cmbEquipoVisitante.Items.Clear();
            cmbEquipoVisitante.Items.Add("Heat");
            cmbEquipoVisitante.Items.Add("Knicks");
            cmbEquipoVisitante.Items.Add("Nets");
            cmbEquipoVisitante.Items.Add("Hawks");
            cmbEquipoVisitante.Items.Add("Timberwolves");
            cmbEquipoVisitante.Items.Add("Clippers");
            cmbEquipoVisitante.Items.Add("Warriors");
            cmbEquipoVisitante.Items.Add("Lakers");

            txtYear.Text = "2023";

            AgregarDias();
            AgregarHoras();
            AgregarMeses();
            AgregarMinutos();
            AgregarNumeroJuegos();
        }

        private void AgregarNumeroJuegos()
        {
            cmbNumeroJuego.Items.Clear();

            for(int i = 1; i < 8; i++)
            {
                cmbNumeroJuego.Items.Add(i);
            }
        }

        private void AgregarDias()
        {
            cmbDia.Items.Clear();

            for(int i = 1; i < 32; i++)
            {
                cmbDia.Items.Add(i);
            }
        }

        private void AgregarMeses()
        {
            cmbMes.Items.Clear();
            cmbMes.Items.Add(05);
            cmbMes.Items.Add(06);
        }

        private void AgregarHoras()
        {
            cmbHora.Items.Clear();
            cmbHora.Items.Add(16);
            cmbHora.Items.Add(21);
            cmbHora.Items.Add(23);
        }

        private void AgregarMinutos()
        {
            cmbMinutos.Items.Clear();
            cmbMinutos.Items.Add(00);
            cmbMinutos.Items.Add(15);
            cmbMinutos.Items.Add(30);
        }

        private void DefinirLocalidadEquipoLocal(string variable)
        {
            switch (variable)
            {
                case "Bucks":
                    cmbLocacionLocal.Items.Clear();
                    cmbLocacionLocal.Items.Add(Locacion.Milwaukee);
                    cmbLocacionLocal.SelectedItem = Locacion.Milwaukee;
                    break;

                case "Cavaliers":
                    cmbLocacionLocal.Items.Clear();
                    cmbLocacionLocal.Items.Add(Locacion.Cleveland);
                    cmbLocacionLocal.SelectedItem = Locacion.Cleveland;
                    break;

                case "76ers":
                    cmbLocacionLocal.Items.Clear();
                    cmbLocacionLocal.Items.Add(Locacion.Philadelphia);
                    cmbLocacionLocal.SelectedItem = Locacion.Philadelphia;
                    break;

                case "Celtics":
                    cmbLocacionLocal.Items.Clear();
                    cmbLocacionLocal.Items.Add(Locacion.Boston);
                    cmbLocacionLocal.SelectedItem = Locacion.Boston;
                    break;

                case "Nuggets":
                    cmbLocacionLocal.Items.Clear();
                    cmbLocacionLocal.Items.Add(Locacion.Denver);
                    cmbLocacionLocal.SelectedItem = Locacion.Denver;
                    break;

                case "Suns":
                    cmbLocacionLocal.Items.Clear();
                    cmbLocacionLocal.Items.Add(Locacion.Phoenix);
                    cmbLocacionLocal.SelectedItem = Locacion.Phoenix;
                    break;

                case "Kings":
                    cmbLocacionLocal.Items.Clear();
                    cmbLocacionLocal.Items.Add(Locacion.Sacramento);
                    cmbLocacionLocal.SelectedItem = Locacion.Sacramento;
                    break;

                case "Grizzles":
                    cmbLocacionLocal.Items.Clear();
                    cmbLocacionLocal.Items.Add(Locacion.Memphis);
                    cmbLocacionLocal.SelectedItem = Locacion.Memphis;
                    break;

            }
        }

        private void DefinirLocalidadEquipoVisitante(string variable)
        {
            switch (variable)
            {
                case "Heat":
                    cmbLocacionVisitante.Items.Clear();
                    cmbLocacionVisitante.Items.Add(Locacion.Miami);
                    cmbLocacionVisitante.SelectedItem = Locacion.Miami;
                    break;

                case "Knicks":
                    cmbLocacionVisitante.Items.Clear();
                    cmbLocacionVisitante.Items.Add(Locacion.NY);
                    cmbLocacionVisitante.SelectedItem = Locacion.NY;
                    break;

                case "Nets":
                    cmbLocacionVisitante.Items.Clear();
                    cmbLocacionVisitante.Items.Add(Locacion.Brooklyn);
                    cmbLocacionVisitante.SelectedItem = Locacion.Brooklyn;
                    break;

                case "Hawks":
                    cmbLocacionVisitante.Items.Clear();
                    cmbLocacionVisitante.Items.Add(Locacion.Atlanta);
                    cmbLocacionVisitante.SelectedItem = Locacion.Atlanta;
                    break;

                case "Timberwolves":
                    cmbLocacionVisitante.Items.Clear();
                    cmbLocacionVisitante.Items.Add(Locacion.Minnesota);
                    cmbLocacionVisitante.SelectedItem = Locacion.Minnesota;
                    break;

                case "Clippers":
                    cmbLocacionVisitante.Items.Clear();
                    cmbLocacionVisitante.Items.Add(Locacion.LA);
                    cmbLocacionVisitante.SelectedItem = Locacion.LA;
                    break;

                case "Warriors":
                    cmbLocacionVisitante.Items.Clear();
                    cmbLocacionVisitante.Items.Add(Locacion.GS);
                    cmbLocacionVisitante.SelectedItem = Locacion.GS;
                    break;

                case "Lakers":
                    cmbLocacionVisitante.Items.Clear();
                    cmbLocacionVisitante.Items.Add(Locacion.LA);
                    cmbLocacionVisitante.SelectedItem = Locacion.LA;
                    break;

            }
        }

        private void cmbEquipoLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string variable = (string)cmbEquipoLocal.SelectedItem as string;

            DefinirLocalidadEquipoLocal(variable);
        }

        private void cmbEquipoVisitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            string variable = (string)cmbEquipoVisitante.SelectedItem as string;

            DefinirLocalidadEquipoVisitante(variable);
        }

    }
}
