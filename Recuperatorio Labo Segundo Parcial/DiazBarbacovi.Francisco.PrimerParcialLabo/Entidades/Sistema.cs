using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Exceptions;
using Entidades.SQL;

namespace Entidades
{
    public static class Sistema
    {
        /// <summary>
        /// Calcula la conversion de creditos a dolares. El valor de la cantidad de creditos que recibe por parametros
        /// </summary>
        /// <param name="creditosExtraidos"></param>
        /// <returns></returns>
        public static float CalcularConversion(int creditosExtraidos)
        {
            return (float)(creditosExtraidos * 0.02);
        }

        /// <summary>
        /// Calcula el valor de la comision de extraccion.
        /// </summary>
        /// <param name="creditosExtraidos"></param>
        /// <returns></returns>
        public static float ComisionDeExtraccion(int creditosExtraidos)
        {
            return (float)(CalcularConversion(creditosExtraidos) * 0.1);
        }

        /// <summary>
        /// Calcula el valor total depositado.
        /// </summary>
        /// <param name="creditosExtraidos"></param>
        /// <returns></returns>
        public static float TotalDepositadoDinero(int creditosExtraidos)
        {
            return (float)(CalcularConversion(creditosExtraidos) - ComisionDeExtraccion(creditosExtraidos));
        }

        /// <summary>
        /// Crea un objeto de tipo Apuesta con las variables recibidas por parametros, y la agrega a una base de datos especifica
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="cantidadCreditosApostados"></param>
        /// <param name="equipoGanador"></param>
        /// <param name="partidoApostado"></param>
        /// <returns>Devuelve el objeto creado si pudo, sino devuelve null. Puede devolver excepciones</returns>
        public static Apuesta RegistrarApuestaRealizada(Usuario usuario, string cantidadCreditosApostados, string equipoGanador, Partido partidoApostado)
        {
            try
            {
                int creditos = int.Parse(cantidadCreditosApostados);

                if (usuario is not null && partidoApostado is not null && creditos >= 50)
                {
                    ApuestasDB dB = new ApuestasDB();
                    Apuesta nuevaApuesta = new Apuesta(usuario.NombreUsuario, equipoGanador, creditos, DateTime.Now, partidoApostado.IdPartido);

                    dB.Agregar(nuevaApuesta);
                    return nuevaApuesta;
                }

                return null;
            }
            catch(Exception)
            {
                throw;
            }
            
        }


        /// <summary>
        /// Crea una cadena de texto con los datos de la apuesta pasados por parametro y la devuelve
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="registro"></param>
        /// <returns></returns>
        public static string RegistrarApuestasAJugadores(Usuario usuario, string registro)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"El usuario con mail: '{usuario.Email}' realizo una apuesta en la fecha {DateTime.Now}. \n{registro}");

            return sb.ToString();
        }


        /// <summary>
        /// Verifica la suspension de un Usuario de la base de datos
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Devuelve true si se pudo, sino false. Tira excepciones si el objeto pasado por parametros es nulo</returns>
        /// <exception cref="Exception"></exception>
        public static bool VerificarSuspensionUsuario(UsuarioJugador user)
        {
            if(user is not null)
            {
                JugadoresDB db = new JugadoresDB();

                UsuarioJugador nuevoJugador = db.ObtenerJugador(user);

                if (nuevoJugador is not null && nuevoJugador.EstaBan == true)
                {
                    return true;
                }
                return false;
            }

            throw new Exception();
        }


        /// <summary>
        /// Recorre la lista de partidos buscando la iteracion del partido pasado por parametros y lo elimina de la lista.
        /// </summary>
        /// <param name="partido"></param>
        /// <param name="lista"></param>
        public static void EliminarPartidoDeLista(Partido partido, List<Partido> lista)
        {
            if (partido is not null && lista is not null)
            {
                foreach (Partido juego in lista)
                {
                    if (juego == partido)
                    {
                        lista.Remove(juego);
                        break;
                    }
                }
            }
        }


        /// <summary>
        /// Crea un nuevo usuario con los datos pasados por parametros. Si son datos validos, lo agrega a una base de datos 
        /// espefica. Puede arrojar excepciones si los datos ya existen.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="email"></param>
        /// <param name="contra"></param>
        /// <param name="numeroTarjeta"></param>
        /// <param name="tipo"></param>
        /// <param name="listaUsuarios"></param>
        /// <param name="listaRegistro"></param>
        /// <returns>Devuelve true si pudo, false si no pudo. Puede arrojar excepciones</returns>
        public static bool RegistrarUsuario(string nombre, string email, string contra, string numeroTarjeta,
            string tipo, List<Usuario> listaUsuarios, List<UsuarioJugador> listaRegistro)
        {
            try
            {
                if (nombre != string.Empty && email != string.Empty && contra != string.Empty && numeroTarjeta != string.Empty
                    && listaUsuarios is not null && listaRegistro is not null && listaUsuarios.Count > 0)
                {
                    foreach (Usuario jugador in listaUsuarios)
                    {
                        if (jugador.Email == email)
                        {
                            throw new EmailExistenteException();
                        }

                        if (jugador.NombreUsuario == nombre)
                        {
                            throw new NombreUsuarioExistenteException(); 
                        }
                    }

                    UsuarioJugador nuevoUsuarioRegistrado = new UsuarioJugador(nombre, contra, email, numeroTarjeta, tipo);

                    if (nuevoUsuarioRegistrado is not null)
                    {
                        JugadoresPendientesDB db = new JugadoresPendientesDB();

                        db.Agregar(nuevoUsuarioRegistrado);
                        return true;
                    }
                    return false;

                }
                return false;

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
