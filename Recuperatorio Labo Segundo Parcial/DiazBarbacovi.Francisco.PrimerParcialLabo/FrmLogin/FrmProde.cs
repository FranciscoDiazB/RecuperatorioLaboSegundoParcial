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
    public partial class FrmProde : Form
    {

        Equipo denver = new Equipo("Nuggets", Locacion.Denver);
        Equipo wolves = new Equipo("Timberwolves", Locacion.Minnesota);
        Equipo suns = new Equipo("Suns", Locacion.Phoenix);
        Equipo clips = new Equipo("Clippers", Locacion.LA);
        Equipo kings = new Equipo("Kings", Locacion.Sacramento);
        Equipo warriors = new Equipo("Warriors", Locacion.GS);
        Equipo lakers = new Equipo("Lakers", Locacion.LA);
        Equipo memphis = new Equipo("Grizzles", Locacion.Memphis);

        Equipo bucks = new Equipo("Bucks", Locacion.Milwaukee);
        Equipo miami = new Equipo("Heat", Locacion.Miami);
        Equipo cleveland = new Equipo("Cavaliers", Locacion.Cleveland);
        Equipo knicks = new Equipo("Knicks", Locacion.NY);
        Equipo sixers = new Equipo("76ers", Locacion.Philadelphia);
        Equipo nets = new Equipo("Nets", Locacion.Brooklyn);
        Equipo boston = new Equipo("Celtics", Locacion.Boston);
        Equipo hawks = new Equipo("Hawks", Locacion.Atlanta);

        UsuarioJugador user;

        public FrmProde()
        {
            InitializeComponent();
        }

        public FrmProde(UsuarioJugador usuario) : this()
        {
            user = usuario;
        }

        private void FrmProde_Load(object sender, EventArgs e)
        {
            denver = new Equipo("Nuggets", Locacion.Denver);
            wolves = new Equipo("Timberwolves", Locacion.Minnesota);
            suns = new Equipo("Suns", Locacion.Phoenix);
            clips = new Equipo("Clippers", Locacion.LA);
            kings = new Equipo("Kings", Locacion.Sacramento);
            warriors = new Equipo("Warriors", Locacion.GS);
            lakers = new Equipo("Lakers", Locacion.LA);
            memphis = new Equipo("Grizzles", Locacion.Memphis);

            bucks = new Equipo("Bucks", Locacion.Milwaukee);
            miami = new Equipo("Heat", Locacion.Miami);
            cleveland = new Equipo("Cavaliers", Locacion.Cleveland);
            knicks = new Equipo("Knicks", Locacion.NY);
            sixers = new Equipo("76ers", Locacion.Philadelphia);
            nets = new Equipo("Nets", Locacion.Brooklyn);
            boston = new Equipo("Celtics", Locacion.Boston);
            hawks = new Equipo("Hawks", Locacion.Atlanta);

            PrimeraRonda();
        }

        private void PrimeraRonda()
        {
            cmb1vs8O.Items.Add(denver);
            cmb1vs8O.Items.Add(wolves);
            cmb1vs8O.SelectedIndex = -1;
            cmb4vs5O.Items.Add(suns);
            cmb4vs5O.Items.Add(clips);
            cmb4vs5O.SelectedIndex = -1;
            cmb3vs6O.Items.Add(kings);
            cmb3vs6O.Items.Add(warriors);
            cmb3vs6O.SelectedIndex = -1;
            cmb2vs7O.Items.Add(lakers);
            cmb2vs7O.Items.Add(memphis);
            cmb2vs7O.SelectedIndex = -1;

            cmb1vs8E.Items.Add(bucks);
            cmb1vs8E.Items.Add(miami);
            cmb1vs8E.SelectedIndex = -1;
            cmb2vs7E.Items.Add(boston);
            cmb2vs7E.Items.Add(hawks);
            cmb2vs7E.SelectedIndex = -1;
            cmb3vs6E.Items.Add(sixers);
            cmb3vs6E.Items.Add(nets);
            cmb3vs6E.SelectedIndex = -1;
            cmb4vs5E.Items.Add(cleveland);
            cmb4vs5E.Items.Add(knicks);
            cmb4vs5E.SelectedIndex = -1;
        }

        private void cmb1vs8O_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipo e1 = (Equipo)cmb1vs8O.SelectedItem;

            cmbSemiO.Items.Add(e1);
        }

        private void cmb4vs5O_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipo e1 = (Equipo)cmb4vs5O.SelectedItem;

            cmbSemiO.Items.Add(e1);
        }

        private void cmb3vs6O_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipo e1 = (Equipo)cmb3vs6O.SelectedItem;

            cmbSemi2O.Items.Add(e1);
        }

        private void cmb2vs7O_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipo e1 = (Equipo)cmb2vs7O.SelectedItem;

            cmbSemi2O.Items.Add(e1);
        }

        private void cmb1vs8E_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipo e1 = (Equipo)cmb1vs8E.SelectedItem;

            cmbSemisE.Items.Add(e1);
        }

        private void cmb4vs5E_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipo e1 = (Equipo)cmb4vs5E.SelectedItem;

            cmbSemisE.Items.Add(e1);
        }

        private void cmb3vs6E_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipo e1 = (Equipo)cmb3vs6E.SelectedItem;

            cmbSemis2E.Items.Add(e1);
        }

        private void cmb2vs7E_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipo e1 = (Equipo)cmb2vs7E.SelectedItem;

            cmbSemis2E.Items.Add(e1);
        }

        private void cmbSemiO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipo e1 = (Equipo)cmbSemiO.SelectedItem;

            cmbFinalistaO.Items.Add(e1);
        }

        private void cmbSemi2O_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipo e1 = (Equipo)cmbSemi2O.SelectedItem;

            cmbFinalistaO.Items.Add(e1);
        }

        private void cmbSemisE_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipo e1 = (Equipo)cmbSemisE.SelectedItem;

            cmbFinalistaE.Items.Add(e1);
        }

        private void cmbSemis2E_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipo e1 = (Equipo)cmbSemis2E.SelectedItem;

            cmbFinalistaE.Items.Add(e1);
        }

        private void btnGanador_Click(object sender, EventArgs e)
        {
            Equipo e1 = (Equipo)cmbFinalistaO.SelectedItem;
            Equipo e2 = (Equipo)cmbFinalistaE.SelectedItem;

            if(e1 is not null && e2 is not null)
            {
                if (rbOeste.Checked == true && rbEste.Checked == false)
                {
                    rtbGanador.Text = $"EQUIPO GANADOR: {e1}";
                    
                    LogsActividadDB dB = new LogsActividadDB();

                    dB.Agregar(user, "El Usuario Realizo el Prode");
                }
                else if(rbOeste.Checked == false && rbEste.Checked == true)
                {
                    rtbGanador.Text = $"EQUIPO GANADOR: {e2}";

                    LogsActividadDB dB = new LogsActividadDB();

                    dB.Agregar(user, "El usuario Realizo el Prode");
                }
                else
                {
                    MessageBox.Show("Seleccione una opcion valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vaya completando los datos del prode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
