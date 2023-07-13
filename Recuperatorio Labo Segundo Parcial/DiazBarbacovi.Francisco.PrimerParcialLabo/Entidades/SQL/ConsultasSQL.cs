using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades.SQL
{
    public class ConsultaSQL : ConexionDB
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase ConsultasSQL con la cadena de conexión especificada.
        /// </summary>
        /// <param name="connectionString">Cadena de conexión a la base de datos.</param>

        /// <summary>
        /// Inicializa una nueva instancia de la clase ConsultasSQL con una cadena de conexión predeterminada.
        /// </summary>
        public ConsultaSQL() : base()
        {
        }

        public SqlCommand CrearComando(string query)
        {
            Abrir();
            var comando = new SqlCommand(query, _connection);

            return comando;
        }

        /// <summary>
        /// Ejecuta una consulta SQL y devuelve los resultados como un DataTable.
        /// </summary>
        /// <param name="consulta">Consulta SQL a ejecutar.</param>
        /// <returns>DataTable con los resultados de la consulta.</returns>
        protected DataTable EjecutarConsulta(SqlCommand comando)
        {
            var reader = comando.ExecuteReader();

            var dataTable = new DataTable();

            dataTable.Load(reader);

            reader.Close();

            return dataTable;
        }
    }
}
