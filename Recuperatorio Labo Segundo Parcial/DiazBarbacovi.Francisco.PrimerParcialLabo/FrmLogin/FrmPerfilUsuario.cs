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
    public partial class FrmPerfilUsuario : Form
    {
        private UsuarioJugador usuario;
        private FrmMenuPrincipal menu;
        private List<UsuarioJugador> jugadores;

        public FrmPerfilUsuario()
        {
            InitializeComponent();
        }

        public FrmPerfilUsuario(UsuarioJugador user, FrmMenuPrincipal menuPrincipal, List<UsuarioJugador> usuarioJugadors) : this()
        {
            usuario = user;
            this.menu = menuPrincipal;
            this.jugadores = usuarioJugadors;
        }

        private void FrmPerfilUsuario_Load(object sender, EventArgs e)
        {
            ActualizarDatos();
            menu.Hide();
        }

        private void btnRecargarCreditos_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCreditosIngreso.Text != string.Empty)
                {
                    int cantidadCreditos = int.Parse(txtCreditosIngreso.Text);

                    if (usuario.RecargarCreditos(cantidadCreditos))
                    {
                        MessageBox.Show($"Se realizo la recarga de {cantidadCreditos} creditos en cuenta, con un valor de {Sistema.CalcularConversion(cantidadCreditos)} $USD", "Recarga de Creditos Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        LogsActividadDB dB = new LogsActividadDB();

                        dB.Agregar(usuario, $"El usuario realizo la Recarga de {cantidadCreditos}");

                    }
                }
                else
                {
                    MessageBox.Show($"Error al realizar la recarga de creditos. Completar la caja de texto con la cantidad de creditos que desea recargar", "Error en la Recarga de Creditos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (CreditosNegativosException)
            {
                MessageBox.Show("No se pueden ingresar numeros negativos. Verifique que los datos ingresados sean correctos", "Error: Numeros Negativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Hubo un error en la recarga de creditos. Verifique que los datos ingresados sean correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ActualizarDatos();
        }

        private void btnDepositarCreditos_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCreditosIngreso.Text != string.Empty)
                {
                    int cantidadCreditos = int.Parse(txtCreditosIngreso.Text);

                    if (usuario.ExtraerCreditosEnCuenta(cantidadCreditos))
                    {
                        MessageBox.Show($"Se depositaron {Sistema.TotalDepositadoDinero(cantidadCreditos)} $USD en el metodo de pago asociado. Servicio de extraccion: {Sistema.ComisionDeExtraccion(cantidadCreditos)} $USD.\nSe retiraron de la cuenta {cantidadCreditos} creditos", "Extraccion de dinero Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        LogsActividadDB dB = new LogsActividadDB();

                        dB.Agregar(usuario, $"El usuario realizo la Extraccion de {cantidadCreditos}");
                    }
                }
                else
                {
                    MessageBox.Show($"Error al realizar la extraccion de creditos. Completar la caja de texto con la cantidad de creditos que desea extraer", "Error en la Extraccion de Creditos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (MinimoCreditosException)
            {
                MessageBox.Show("No pueden retirarse montos menores a 50 creditos; tampoco es valido el ingreso de numeros negativos. Verifique que los datos ingresados sean correctos", "Error: Numeros Negativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CreditosInsuficientesException)
            {
                MessageBox.Show("No hay creditos suficientes en cuenta para realizar la extraccion de los creditos. Asegurese de que el monto sea acorde a la cantidad de creditos en cuenta", "Error: Creditos en cuenta insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error en la extraccion de creditos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            txtNombreUsuario.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPago.Text = string.Empty;
            txtCreditos.Text = string.Empty;
            txtCreditosIngreso.Text = string.Empty;

            txtNombreUsuario.Text = " " + usuario.NombreUsuario;
            txtCreditos.Text = " " + usuario.CreditosApuestas.ToString() + " Creditos";
            txtPago.Text = " " + usuario.InformarTarjeta(usuario.NumeroTarjeta);
            txtEmail.Text = " " + usuario.Email.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        private void txtCreditosIngreso_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int cantidadCreditos = int.Parse(txtCreditosIngreso.Text);

                if(cantidadCreditos > 0)
                {
                    txtValorCreditos.Text = Sistema.CalcularConversion(cantidadCreditos).ToString();
                }

            }
            catch(Exception)
            {
                txtValorCreditos.Text = "";
            }
        }
    }
}
