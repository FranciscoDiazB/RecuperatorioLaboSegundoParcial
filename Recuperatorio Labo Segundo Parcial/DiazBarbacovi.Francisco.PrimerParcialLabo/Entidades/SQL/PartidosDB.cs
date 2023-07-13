using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades.SQL
{
    public class PartidosDB : ConsultaSQL, IManejadorSql<Partido>
    {

        public PartidosDB() : base()
        {

        }

        public void Agregar(Partido entidad)
        {
            string query = "INSERT INTO Partidos (EquipoLocal, EquipoVisitante, Fecha, NumeroJuego) VALUES (@equipoLocal, @equipoVisi, @fecha, @numero)";

            using (var comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@equipoLocal", entidad.JuegaEquipoLocal);
                comando.Parameters.AddWithValue("@equipoVisi", entidad.JuegaEquipoVisitante);
                comando.Parameters.AddWithValue("@fecha", entidad.FechaDeJuego);
                comando.Parameters.AddWithValue("@numero", entidad.NumeroDeJuego);

                comando.ExecuteNonQuery();
            }
        }

        public void Eliminar(Partido entidad)
        {
            try
            {
                string query = "DELETE FROM Partidos WHERE id = @id";

                using (var comando = CrearComando(query))
                {
                    comando.Parameters.AddWithValue("@id", entidad.IdPartido);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Partido> Obtener()
        {
            List<Partido> lista = new List<Partido>();
            string query = $"SELECT * FROM Partidos";

            using (var comando = CrearComando(query))
            {
                using (var dt = EjecutarConsulta(comando))
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        int id = Convert.ToInt32(row[0]);
                        string eL = row[1].ToString();
                        string ev = row[2].ToString();
                        DateTime fecha = Convert.ToDateTime(row[3]);
                        int numero = Convert.ToInt32(row[4]);

                        Partido partido = new Partido(id, eL, ev, fecha, numero);

                        if (partido is not null)
                        {
                            lista.Add(partido);
                        }
                    }
                }
            }
            return lista;
        }
    }
}
