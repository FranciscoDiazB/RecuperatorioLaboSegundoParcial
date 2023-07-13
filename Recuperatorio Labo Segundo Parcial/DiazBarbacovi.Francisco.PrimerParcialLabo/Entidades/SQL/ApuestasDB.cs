using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    public class ApuestasDB : ConsultaSQL, IManejadorSql<Apuesta>
    {
        public void Agregar(Apuesta entidad)
        {
            string query = "INSERT INTO Apuestas (NombreUsuario, CreditosApostados, EquipoGanador, Fecha, IdPartidoJugado) VALUES (@nombre, @creditos, @equipo, @fecha, @id)";

            using (var comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@nombre", entidad.NombreJugador);
                comando.Parameters.AddWithValue("@creditos", entidad.CreditosApostados);
                comando.Parameters.AddWithValue("@equipo", entidad.EquipoGanador);
                comando.Parameters.AddWithValue("@fecha", DateTime.Now);
                comando.Parameters.AddWithValue("@id", entidad.IdPartido);

                comando.ExecuteNonQuery();
            }
        }

        public List<Apuesta> Obtener()
        {
            List<Apuesta> lista = new List<Apuesta>();

            string query = $"SELECT * FROM Apuestas";

            using (var comando = CrearComando(query))
            {
                using (var dt = EjecutarConsulta(comando))
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string nombre = row[0].ToString();
                        int creditos = Convert.ToInt32(row[1]);
                        string equipo = row[2].ToString();
                        DateTime fecha = Convert.ToDateTime(row[3]);
                        int id = Convert.ToInt32(row[4]);

                        Apuesta nuevaApuesta = new Apuesta(nombre, equipo, creditos, fecha, id);

                        if (nuevaApuesta is not null)
                        {
                            lista.Add(nuevaApuesta);
                        }
                    }
                }
            }
            return lista;
        }
    }
}
