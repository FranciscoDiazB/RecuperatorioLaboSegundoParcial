using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Pdf;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using System.Drawing;
using System.IO;

namespace Entidades.Informes
{
    /// <summary>
    /// Exporta los datos de un archivo de texto, a un archivo PDF
    /// </summary>
    public static class ExportarPDF
    {
        public static void PDF(string path)
        {
            string text = File.ReadAllText(@"" + path);

            PdfDocument pdf = new PdfDocument();

            PdfPageBase page = pdf.Pages.Add();

            PdfFont font = new PdfFont(PdfFontFamily.Helvetica, 11);

            PdfTextLayout textLayout = new PdfTextLayout();
            textLayout.Break = PdfLayoutBreakType.FitPage;
            textLayout.Layout = PdfLayoutType.Paginate;

            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Justify;
            format.LineSpacing = 20f;

            PdfTextWidget textWidget = new PdfTextWidget(text, font, PdfBrushes.Black);

            textWidget.StringFormat = format;

            RectangleF bounds = new RectangleF(new PointF(10, 25), page.Canvas.ClientSize);
            textWidget.Draw(page, bounds, textLayout);

            pdf.SaveToFile("InformesTextoAPdf.pdf", FileFormat.PDF);
        }
    }
}
