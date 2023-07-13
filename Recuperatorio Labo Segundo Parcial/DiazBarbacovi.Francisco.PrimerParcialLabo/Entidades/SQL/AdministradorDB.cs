using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    public class AdministradorDB : ConsultaSQL, IManejadorSql<Administrador>
    {

        public AdministradorDB() : base()
        {

        }

        public void Agregar(Administrador entidad)
        {
            string query = "INSERT INTO Admins (Nombre, Contra, Email, Tipo) VALUES (@nombre, @contra, @email, @tipo)";

            using (var comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@nombre", entidad.NombreUsuario);
                comando.Parameters.AddWithValue("@contra", entidad.Contrasenia);
                comando.Parameters.AddWithValue("@email", entidad.Email);
                comando.Parameters.AddWithValue("@tipo", entidad.TipoIngreso);

                comando.ExecuteNonQuery();
            };
        }

        public List<Administrador> Obtener()
        {
            List<Administrador> lista = new List<Administrador>();
            
            string query = $"SELECT * FROM Admins";

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

                        Administrador administrador = new Administrador(nombre, contra, email, tipo);

                        if (administrador is not null)
                        {
                            lista.Add(administrador);
                        }
                    }
                }
            }
            return lista;
        }
    }
}
