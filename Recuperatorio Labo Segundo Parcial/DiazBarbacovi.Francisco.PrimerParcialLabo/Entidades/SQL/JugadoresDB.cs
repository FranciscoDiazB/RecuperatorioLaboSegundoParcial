using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    public class JugadoresDB : ConsultaSQL, IManejadorSql<UsuarioJugador>
    {

        public JugadoresDB() : base()
        {

        }


        public void Agregar(UsuarioJugador entidad)
        {
            string query = "INSERT INTO Jugadores (Nombre, Contra, Email, Tipo, NumeroTarjeta, TipoTarjeta, Creditos, Ban) " +
                "VALUES (@nombre, @contra, @email, @tipo, @numeroTarjeta, @tipoTarjeta, @creditos, @ban)";

            using (var comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@nombre", entidad.NombreUsuario);
                comando.Parameters.AddWithValue("@contra", entidad.Contrasenia);
                comando.Parameters.AddWithValue("@email", entidad.Email);
                comando.Parameters.AddWithValue("@tipo", entidad.TipoIngreso);
                comando.Parameters.AddWithValue("@numeroTarjeta", entidad.NumeroTarjeta);
                comando.Parameters.AddWithValue("@tipoTarjeta", entidad.TipoTarjeta);
                comando.Parameters.AddWithValue("@creditos", entidad.CreditosApuestas);

                if (entidad.EstaBan)
                {
                    comando.Parameters.AddWithValue("@ban", 1);
                }
                else
                {
                    comando.Parameters.AddWithValue("@ban", 0);
                }

                comando.ExecuteNonQuery();
            };
        }



        public List<UsuarioJugador> Obtener()
        {
            List<UsuarioJugador> lista = new List<UsuarioJugador>();

            string query = $"SELECT * FROM Jugadores";

            using (var comando = CrearComando(query))
            {
                using (var dt = EjecutarConsulta(comando))
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        int id = Convert.ToInt32(row[0]);
                        string nombre = row[1].ToString();
                        string contra = row[2].ToString();
                        string email = row[3].ToString();
                        string tipo = row[4].ToString();
                        string numTarjeta = row[5].ToString();
                        string tipoTarjeta = row[6].ToString();
                        int creditos = Convert.ToInt32(row[7]);

                        var auxBan = Convert.ToBoolean(row[8]);

                        UsuarioJugador usuarioJugador = new UsuarioJugador(id, nombre, contra, email, numTarjeta, tipoTarjeta, creditos, tipo, auxBan);

                        if (usuarioJugador is not null)
                        {
                            lista.Add(usuarioJugador);
                        }
                    }
                }
            }
            return lista;
        }


        public UsuarioJugador ObtenerJugador(UsuarioJugador user)
        {
            string query = $"SELECT * FROM Jugadores where Id = @id";

            using (var comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@id", user.Id);

                using (var dt = EjecutarConsulta(comando))
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        int id = Convert.ToInt32(row[0]);
                        string nombre = row[1].ToString();
                        string contra = row[2].ToString();
                        string email = row[3].ToString();
                        string tipo = row[4].ToString();
                        string numTarjeta = row[5].ToString();
                        string tipoTarjeta = row[6].ToString();
                        int creditos = Convert.ToInt32(row[7]);

                        var auxBan = Convert.ToBoolean(row[8]);

                        UsuarioJugador usuarioJugador = new UsuarioJugador(id, nombre, contra, email, numTarjeta, tipoTarjeta, creditos, tipo, auxBan);

                        if (usuarioJugador is not null)
                        {
                            return usuarioJugador;
                        }
                    }
                }
            }
            return null;
        }

        public void ModificarCreditos(UsuarioJugador entidad, int cantidadCreditos)
        {
            try
            {
                string query = "UPDATE Jugadores SET Creditos = @credi WHERE id = @id";

                using (var comando = CrearComando(query))
                {
                    comando.Parameters.AddWithValue("@credi", cantidadCreditos);
                    comando.Parameters.AddWithValue("@id", entidad.Id);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ModificarEstado(UsuarioJugador entidad, int estado)
        {
            try
            {
                string query = "UPDATE Jugadores SET Ban = @ban WHERE id = @id";

                using (var comando = CrearComando(query))
                {
                    comando.Parameters.AddWithValue("@ban", estado);
                    comando.Parameters.AddWithValue("@id", entidad.Id);

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
