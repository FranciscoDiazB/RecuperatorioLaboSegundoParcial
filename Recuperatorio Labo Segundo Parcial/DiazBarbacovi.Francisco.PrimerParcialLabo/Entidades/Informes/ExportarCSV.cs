using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration.Attributes;
using System.Globalization;
using System.IO;

namespace Entidades.Informes
{
    public static class ExportarCSV
    {
        /// <summary>
        /// Exporta un listado de objetos de tipo Apuesta con formato CSV a un path determinado
        /// </summary>
        /// <param name="apuestas"></param>
        /// <param name="path"></param>
        public static void GenerarExportacionCSV(List<Apuesta> apuestas, string path)
        {
            try
            {
                using var writer = new StreamWriter(path);
                using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);


                csv.WriteHeader<Apuesta>();
                csv.NextRecord();
                foreach (var apue in apuestas)
                {
                    csv.WriteRecord(apue);
                    csv.NextRecord();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
