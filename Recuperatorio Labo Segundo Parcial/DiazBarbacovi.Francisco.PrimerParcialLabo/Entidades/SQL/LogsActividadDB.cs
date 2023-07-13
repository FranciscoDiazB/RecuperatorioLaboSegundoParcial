using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    public class LogsActividadDB : ConsultaSQL
    {
        public void Agregar(Usuario entidad, string actividad)
        {
            string query = "INSERT INTO LogsActividad (Usuario, TipoUsuario, Actividad, FechaActividad) VALUES (@nombre, @tipo, @actividad, @fecha)";

            using (var comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@nombre", entidad.NombreUsuario);
                comando.Parameters.AddWithValue("@tipo", entidad.TipoIngreso);
                comando.Parameters.AddWithValue("@actividad", actividad);
                comando.Parameters.AddWithValue("@fecha", DateTime.Now);

                comando.ExecuteNonQuery();
            }
        }
    }
}
