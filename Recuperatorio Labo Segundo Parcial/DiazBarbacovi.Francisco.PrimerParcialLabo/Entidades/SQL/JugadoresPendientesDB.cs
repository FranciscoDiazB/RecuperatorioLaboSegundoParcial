using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    public class JugadoresPendientesDB : ConsultaSQL, IManejadorSql<UsuarioJugador>
    {

        public JugadoresPendientesDB() : base()
        {

        }


        public void Agregar(UsuarioJugador entidad)
        {
            string query = "INSERT INTO JugadoresPendientes (Nombre, Contra, Email, Tipo, NumeroTarjeta, TipoTarjeta) " +
                "VALUES (@nombre, @contra, @email, @tipo, @numeroTarjeta, @tipoTarjeta)";

            using (var comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@nombre", entidad.NombreUsuario);
                comando.Parameters.AddWithValue("@contra", entidad.Contrasenia);
                comando.Parameters.AddWithValue("@email", entidad.Email);
                comando.Parameters.AddWithValue("@tipo", entidad.TipoIngreso);
                comando.Parameters.AddWithValue("@numeroTarjeta", entidad.NumeroTarjeta);
                comando.Parameters.AddWithValue("@tipoTarjeta", entidad.TipoTarjeta);

                comando.ExecuteNonQuery();
            };
        }


        public List<UsuarioJugador> Obtener()
        {
            List<UsuarioJugador> lista = new List<UsuarioJugador>();

            string query = $"SELECT * FROM JugadoresPendientes";

            using (var comando = CrearComando(query))
            {
                using (var dt = EjecutarConsulta(comando))
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string nombre = row[0].ToString();
                        string contra = row[1].ToString();
                        string email = row[2].ToString();
                        string tipo = row[3].ToString();
                        string numTarjeta = row[4].ToString();
                        string tipoTarjeta = row[5].ToString();

                        UsuarioJugador usuarioJugador = new UsuarioJugador(nombre, contra, email, numTarjeta, tipoTarjeta, 0, tipo, false);

                        if (usuarioJugador is not null)
                        {
                            lista.Add(usuarioJugador);
                        }
                    }
                }
            }
            return lista;
        }


        public void Eliminar(UsuarioJugador entidad)
        {
            try
            {
                string query = "DELETE FROM JugadoresPendientes WHERE Email = @mail";

                using (var comando = CrearComando(query))
                {
                    comando.Parameters.AddWithValue("@nombre", entidad.NombreUsuario);
                    comando.Parameters.AddWithValue("@mail", entidad.Email);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
