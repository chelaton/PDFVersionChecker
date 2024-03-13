using PDFVersionChecker.Logic.Abstract;
using PDFVersionChecker.Logic.Interface;
using System.IO;

namespace PDFVersionChecker.Logic.Implementation
{
  public class RecordPdf : Record, IRecordValidation
  {
    public RecordPdf(string fileName)
    {
      FileName = fileName;
    }

    public string Validate(Stream ms)
    {
      using (var document = new Aspose.Pdf.Document(ms))
      {
        // Validate the PDF document
        var format = document.PdfFormat;
        bool isValid = document.IsPdfaCompliant;
        if (isValid)
        {
          return $"PDF is {format} compliant";
        }
        else
        {
          return "PDF is not PDF/A compliant";
        }
      }
    }

  }
}