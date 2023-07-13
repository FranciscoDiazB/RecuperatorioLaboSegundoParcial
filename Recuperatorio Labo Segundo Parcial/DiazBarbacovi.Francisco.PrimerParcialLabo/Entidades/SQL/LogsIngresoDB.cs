using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    public class LogsIngresoDB : ConsultaSQL, IManejadorSql<Usuario>
    {
        public LogsIngresoDB() : base()
        {

        }

        public void Agregar(Usuario entidad)
        {
            string query = "INSERT INTO LogsIngreso (NombreUsuario, TipoUsuario, FechaIngreso) VALUES (@nombre, @tipo, @fecha)";

            using (var comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@nombre", entidad.NombreUsuario);
                comando.Parameters.AddWithValue("@tipo", entidad.TipoIngreso);
                comando.Parameters.AddWithValue("@fecha", DateTime.Now);

                comando.ExecuteNonQuery();
            }
        }

        public List<Usuario> Obtener()
        {
            throw new NotImplementedException();
        }
    }
}
