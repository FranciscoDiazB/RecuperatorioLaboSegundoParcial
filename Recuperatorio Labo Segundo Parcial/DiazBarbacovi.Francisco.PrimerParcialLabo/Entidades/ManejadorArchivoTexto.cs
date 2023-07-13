using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class ManejadorArchivoTexto
    {
        /// <summary>
        /// Guarda una cadena de texto pasada por parametros en el path que se recibe por parametros
        /// Si la condicion bool es verdadera, se va a concatenar al archivo existente
        /// </summary>
        /// <param name="path"></param>
        /// <param name="texto"></param>
        /// <param name="concatenar"></param>
        public static void GuardarEnArchivoDeTexto(string path, string texto, bool concatenar)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, concatenar))
                {
                    sw.WriteLine(texto);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Lee el archivo de texto, con el path recibido por parametros y devuelve el string de texto del archivo
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string LeerArchivoDeTexto(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
