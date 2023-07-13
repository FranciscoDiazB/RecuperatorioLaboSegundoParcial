using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Entidades
{
    public static class SerializadorXml<T>
    {
        /// <summary>
        /// Serializa el tipo T recibido por parametros en determinado path, estilo Xml
        /// </summary>
        /// <param name="usuarios"></param>
        /// <param name="path"></param>
        public static void GenerarXml(T entidad, string path)
        {
            try
            {
                using (StreamWriter sm = new StreamWriter(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    serializer.Serialize(sm, entidad);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
