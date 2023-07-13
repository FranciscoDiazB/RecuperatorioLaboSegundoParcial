using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Informes
{
    public static class ExportarJSON<T>
    {
        /// <summary>
        /// Serializa un objeto determinado y lo guarda en un archivo con un path especifico
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="path"></param>
        public static void SerializarJSON(T objeto, string path)
        {
            try
            {
                string jsonString = GenerarStringJson(objeto);

                ManejadorArchivoTexto.GuardarEnArchivoDeTexto(path, jsonString, false);

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Serializa un objeto detereminado, convirtiendolo en un string de tipo Json
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public static string GenerarStringJson(T objeto)
        {
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string jsonString = JsonSerializer.Serialize(objeto, options);

            return jsonString;
        }
    }
}
