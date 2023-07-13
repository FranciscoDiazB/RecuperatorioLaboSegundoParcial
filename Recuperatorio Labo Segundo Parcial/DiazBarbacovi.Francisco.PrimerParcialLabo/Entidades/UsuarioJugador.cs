using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Exceptions;
using Entidades.SQL;

namespace Entidades
{

    public class UsuarioJugador : Usuario
    {
        private string numeroTarjeta;
        private string tipoTarjeta;
        private int creditosApuestas;
        private bool estaBan;
        int id;

        public int CreditosApuestas { get => creditosApuestas; set => creditosApuestas = value; }
        public bool EstaBan { get => estaBan; set => estaBan = value; }
        public string NumeroTarjeta { get => numeroTarjeta; set => numeroTarjeta = value; }
        public string TipoTarjeta { get => tipoTarjeta; set => tipoTarjeta = value; }
        public int Id { get => id; set => id = value; }

        public UsuarioJugador()
        {

        }

        public UsuarioJugador(string nombre, string contra, string mail, string numeroT, string tipoT) : base(nombre, contra, mail, "Player")
        {
            numeroTarjeta = numeroT;
            TipoTarjeta = tipoT;
        }

        public UsuarioJugador(string nombre, string contra, string mail, string numeroT, string tipoT, int creditos, string tipo) : base(nombre, contra, mail, tipo)
        {
            numeroTarjeta = numeroT;
            tipoTarjeta = tipoT;
            creditosApuestas = creditos;
            estaBan = false;
        }

        public UsuarioJugador(string nombre, string contra, string mail, string numeroT, string tipoT, int creditos, string tipo, bool ban) : this(nombre, contra, mail, numeroT, tipoT, creditos, tipo)
        {
            estaBan = ban;
        }

        public UsuarioJugador(int iden, string nombre, string contra, string mail, string numeroT, string tipoT, int creditos, string tipo, bool ban) : this(nombre, contra, mail, numeroT, tipoT, creditos, tipo, ban)
        {
            id = iden;
        }

        /// <summary>
        /// Verifica los datos pasados por parametro. Si son datos validos, le resta al usuario del campo CreditosApuestas 
        /// la cantidad de creditos pasados por parametros y modifica la base de datos
        /// </summary>
        /// <param name="cantidadCreditos"></param>
        /// <returns>Devuelve true si se pudo, sino arroja excepciones</returns>
        /// <exception cref="CreditosInsuficientesException"></exception>
        /// <exception cref="MinimoCreditosException"></exception>
        public bool ExtraerCreditosEnCuenta(int cantidadCreditos)
        {
            if(cantidadCreditos >= 50)
            {
                if(this.CreditosApuestas >= 50 && cantidadCreditos <= this.CreditosApuestas)
                {
                    int totalCreditos = CreditosApuestas - cantidadCreditos;

                    JugadoresDB dB = new JugadoresDB();

                    dB.ModificarCreditos(this, totalCreditos);

                    this.CreditosApuestas = totalCreditos;
                    return true;
                }
                throw new CreditosInsuficientesException();
            }
            throw new MinimoCreditosException();
        }

        /// <summary>
        /// Verifica los datos pasados por parametro. Si son datos validos, le suma al usuario al campo CreditosApuestas 
        /// la cantidad de creditos pasados por parametros y modifica la base de datos
        /// </summary>
        /// <param name="cantidadCreditos"></param>
        /// <returns>Devuelve true si se pudo, sino arroja excepciones</returns>
        /// <exception cref="CreditosNegativosException"></exception>
        public bool RecargarCreditos(int cantidadCreditos)
        {
            if(cantidadCreditos > 0)
            {
                int sumaTotal = CreditosApuestas + cantidadCreditos;

                JugadoresDB dB = new JugadoresDB();

                dB.ModificarCreditos(this, sumaTotal);

                this.CreditosApuestas = sumaTotal;
                return true;
            }
            throw new CreditosNegativosException();
        }

        /// <summary>
        /// Sobrecarga del metodo RealizarApuesta, recibe una cadena de string y la parsea a tipo numerico
        /// </summary>
        /// <param name="cantidadCreditos"></param>
        /// <returns>Devuelve true si se pudo, sino arroja excepciones</returns>
        public bool RealizarApuesta(string cantidadCreditos)
        {
            try
            {
                int creditos = int.Parse(cantidadCreditos);

                if(creditos >= 50)
                {
                    if(this.creditosApuestas >= creditos)
                    {
                        int totalCreditos = CreditosApuestas - creditos;

                        JugadoresDB dB = new JugadoresDB();

                        dB.ModificarCreditos(this, totalCreditos);

                        this.CreditosApuestas = totalCreditos;

                        return true;
                    }
                    throw new CreditosInsuficientesException("Creditos insuficientes en cuenta");
                }
                throw new MinimoCreditosException("El minimo de creditos que se pueden apostar es de 50 creditos");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Recibe por parametros la cantidad de creditos que le tiene que restar al usuario, tanto en el sistema como en la base 
        /// de datos
        /// </summary>
        /// <param name="cantidadCreditos"></param>
        /// <returns>Devuelve true si se pudo, sino arroja excepciones</returns>
        public bool RealizarApuesta(int cantidadCreditos)
        {
            try 
            {              
                if (this.creditosApuestas >= cantidadCreditos)
                {
                    int totalCreditos = CreditosApuestas - cantidadCreditos;

                    JugadoresDB dB = new JugadoresDB();

                    dB.ModificarCreditos(this, totalCreditos);

                    this.CreditosApuestas = totalCreditos;

                    return true;
                }
                throw new CreditosInsuficientesException("Creditos insuficientes en cuenta");

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Sobreescritura del metodo MostrarUsuario base
        /// </summary>
        /// <returns>Devuelve un string</returns>
        public override string MostrarUsuario()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Usuario: {this.NombreUsuario}");
            stringBuilder.AppendLine($"Creditos: {this.CreditosApuestas}");

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Informa una cadena de strings, de una forma especifica
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Devuelve la cadena de string</returns>
        public string InformarTarjeta(string numero)
        {
            string ultimosNumeros = string.Empty;

            ultimosNumeros += numero[numero.Length - 4];
            ultimosNumeros += numero[numero.Length - 3];
            ultimosNumeros += numero[numero.Length - 2];
            ultimosNumeros += numero[numero.Length - 1];

            return $"{this.tipoTarjeta} finalizada en {ultimosNumeros}";
        }

        public override string ToString()
        {
            string retorno = $"ID: {this.Id} - Usuario: {this.NombreUsuario} - Email: {this.Email}";

            if (this.EstaBan)
            {
                retorno += $" - Usuario Suspendido";
            }

            return retorno;
        }


    }
}
