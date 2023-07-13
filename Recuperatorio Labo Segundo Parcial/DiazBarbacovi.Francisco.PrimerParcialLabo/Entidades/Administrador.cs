using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.SQL;

namespace Entidades
{
    public class Administrador : Usuario
    {
        public Administrador(string nombre, string contra, string mail, Tipo tipo) : base(nombre, contra, mail, tipo)
        {
            
        }

        public Administrador(string nombre, string contra, string mail, string tipo) : base(nombre, contra, mail, tipo)
        {

        }

        public Administrador()
        {

        }

        /// <summary>
        /// Se muestran los datos de los administradores
        /// </summary>
        /// <returns></returns>
        public override string MostrarUsuario()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Administrador: {this.Email}");
            stringBuilder.AppendLine($"Fecha de Conexion: {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}");

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Agrega un objeto a una nueva base de datos, eliminandola de la anterior base de datos a la que pertenecia
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Devuelve true si se pudo, false si no. Puede tirar excepciones</returns>
        public static bool AgregarUsuarioPendiente(UsuarioJugador user)
        {
            try
            {
                if (user is not null)
                {
                    JugadoresDB db = new JugadoresDB();

                    db.Agregar(user);
                    EliminarUsuarioPendiente(user);

                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Modifica el estado de un objeto pasado por parametros, que se encuentra en una base de datos
        /// Cambia el estado de un atributo a 1
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Devuelve true si se pudo, false si no. Puede tirar excepciones</returns>
        public static bool SuspenderUsuario(UsuarioJugador user)
        {
            try
            {
                if(user is not null)
                {
                    JugadoresDB db = new JugadoresDB();

                    db.ModificarEstado(user, 1);

                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Modifica el estado de un objeto pasado por parametros, que se encuentra en una base de datos
        /// Cambia el estado de un atributo a 0
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Devuelve true si se pudo, false si no. Puede tirar excepciones</returns>
        public static bool LevantarSuspension(UsuarioJugador user)
        {
            try
            {
                if (user is not null)
                {
                    JugadoresDB db = new JugadoresDB();

                    db.ModificarEstado(user, 0);

                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Elimina al objeto pasado por parametros de una base de datos especifica
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Devuelve true si se pudo, false si no. Puede tirar excepciones</returns>
        public static bool EliminarUsuarioPendiente(UsuarioJugador user)
        {
            try
            {
                if (user is not null)
                {
                    JugadoresPendientesDB db = new JugadoresPendientesDB();

                    db.Eliminar(user);

                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Crea un objeto nuevo, con los parametros recibidos y se agrega es objeto creado a una base de datos especifica
        /// </summary>
        /// <param name="local"></param>
        /// <param name="visitante"></param>
        /// <param name="fecha"></param>
        /// <param name="numeroDeJuego"></param>
        /// <param name="lista"></param>
        /// <returns>Devuelve true si se pudo, false si no. Puede tirar excepciones</returns>
        public static bool AgregarPartido(string local, string visitante, DateTime fecha, int numeroDeJuego, List<Partido> lista)
        {

            try
            {
                if (local is not null && visitante is not null && (numeroDeJuego >= 1 || numeroDeJuego <= 7))
                {
                    Partido nuevoPartido = new Partido(local, visitante, fecha, numeroDeJuego);
                    
                    PartidosDB partidos = new PartidosDB();

                    partidos.Agregar(nuevoPartido);
                    lista = partidos.Obtener();

                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Elimina al objeto pasado por parametros de una base de datos especifica
        /// </summary>
        /// <param name="partidoSeleccionado"></param>
        /// <returns>Devuelve true si se pudo, false si no. Puede tirar excepciones</returns>
        public static bool CancelarPartido(Partido partidoSeleccionado)
        {

            try
            {
                if (partidoSeleccionado is not null)
                {
                    PartidosDB dB = new PartidosDB();

                    dB.Eliminar(partidoSeleccionado);

                    return true;
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
