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
using Entidades.Informes;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;

namespace Vista
{
    public partial class FrmInformes : Form
    {

        List<Apuesta> listadoDeApuestas;
        Administrador admin;

        public FrmInformes(Administrador user)
        {
            InitializeComponent();
            admin = user;
        }

        private void FrmInformes_Load(object sender, EventArgs e)
        {
            listadoDeApuestas = new List<Apuesta>();
            btnExportarCSV.Enabled = false;
            btnExportarJson.Enabled = false;
            btnExportarPDF.Enabled = false;
            btnExportarXml.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListarApuestas_Click(object sender, EventArgs e)
        {
            try
            {
                ApuestasDB dB = new ApuestasDB();

                listadoDeApuestas.Clear();
                listadoDeApuestas = dB.Obtener();

                RefrescarLista();

                btnExportarCSV.Enabled = true;
                btnExportarJson.Enabled = true;
                btnExportarPDF.Enabled = true;
                btnExportarXml.Enabled = true;

            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void RefrescarLista()
        {
            lstListadoApuestas.DataSource = null;
            lstListadoApuestas.DataSource = listadoDeApuestas;
        }

        private void btnExportarJson_Click(object sender, EventArgs e)
        {
            try
            {
                ExportarJSON<List<Apuesta>>.SerializarJSON(listadoDeApuestas, "InformesJSON.json");
                ExportarJSON<List<Apuesta>>.SerializarJSON(listadoDeApuestas, "InformeJson.txt");

                LogsActividadDB dB = new LogsActividadDB();

                dB.Agregar(admin, "El admin Exporto las Apuestas realizadas a un archivo Json");

                MessageBox.Show("Informe generado con exito", "Exito");

            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            try
            {
                ExportarCSV.GenerarExportacionCSV(listadoDeApuestas, "InformeCSV.csv");
                MessageBox.Show("Informe generado con exito", "Exito");

                LogsActividadDB dB = new LogsActividadDB();

                dB.Agregar(admin, "El admin Exporto las Apuestas realizadas a un archivo CSV");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {

                ExportarPDF.PDF("InformeJson.txt");

                LogsActividadDB dB = new LogsActividadDB();

                dB.Agregar(admin, "El admin Exporto las Apuestas realizadas a un archivo PDF");

                MessageBox.Show("Informe generado con exito", "Exito");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btnExportarXml_Click(object sender, EventArgs e)
        {
            try
            {
                SerializadorXml<List<Apuesta>>.GenerarXml(listadoDeApuestas, "InformeXml.xml");

                LogsActividadDB dB = new LogsActividadDB();

                dB.Agregar(admin, "El admin Exporto las Apuestas realizadas a un archivo XML");

                MessageBox.Show("Informe generado con exito", "Exito");

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
