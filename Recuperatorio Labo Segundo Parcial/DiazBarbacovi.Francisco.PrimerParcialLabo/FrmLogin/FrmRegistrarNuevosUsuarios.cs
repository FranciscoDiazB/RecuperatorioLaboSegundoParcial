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

namespace Vista
{
    public partial class FrmRegistrarNuevosUsuarios : Form
    {

        private List<UsuarioJugador> listaUsuariosJugadorPendientes;
        private List<Usuario> listaUsuarios;

        public FrmRegistrarNuevosUsuarios()
        {
            InitializeComponent();
        }

        public FrmRegistrarNuevosUsuarios(List<UsuarioJugador> listaUsuariosPendientes, List<Usuario> listaU) : this()
        {
            listaUsuariosJugadorPendientes = listaUsuariosPendientes;
            listaUsuarios = listaU;
        }

        private void FrmRegistrarNuevosUsuarios_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }
        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {

            try
            {
                string email = $"{txtEmailUsuario.Text}{cmbTerminacionMail.SelectedItem as string}";
               
                string tarjetaTipo = cmbTipo.SelectedItem.ToString();

                if (Sistema.RegistrarUsuario(txtNombreUsuario.Text, email, txtContraUsuario.Text, txtNumeroTarjeta.Text,
                    tarjetaTipo, listaUsuarios, listaUsuariosJugadorPendientes))
                {
                    MessageBox.Show("Usuario registrado con exito. Ahora solo falta la aprobacion por parte de un administrador", "Exitos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    RefrescarDatos();
                }
                else
                {
                    MessageBox.Show("Ingresar los datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (NombreUsuarioExistenteException)
            {
                MessageBox.Show("El nombre de usuario ya existe, pruebe otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (EmailExistenteException)
            {
                MessageBox.Show("Ya se encuentra registrada otra cuenta utilizando el mismo mail. Ingrese otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CantidadDeNumerosIncorrectoException)
            {
                MessageBox.Show("El numero de tarjeta debe ser de 16 caracteres numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error en el sistema. Verifique el ingreso correcto de los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefrescarDatos()
        {
            cmbTerminacionMail.Items.Clear();
            cmbTerminacionMail.Items.Add("@gmail.com");
            cmbTerminacionMail.Items.Add("@hotmail.com");
            cmbTerminacionMail.Items.Add("@yahoo.com.ar");
            cmbTerminacionMail.SelectedIndex = 0;
            txtContraUsuario.Text = string.Empty;
            txtEmailUsuario.Text = string.Empty;
            txtNombreUsuario.Text = string.Empty;
            txtNumeroTarjeta.Text = string.Empty;
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Visa");
            cmbTipo.Items.Add("Master Card");
            cmbTipo.SelectedIndex = 0;
        }

    }
}
