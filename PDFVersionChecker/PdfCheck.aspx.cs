using log4net;
using PDFVersionChecker.Logic.Implementation;
using System;
using System.IO;


namespace PDFVersionChecker
{
  public partial class PdfCheck : System.Web.UI.Page
  {
    private static ILog Log { get; set; }
    ILog log = log4net.LogManager.GetLogger(typeof(PdfCheck));
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDownload_Click(object sender, EventArgs e)
    {
      // Nastavení cesty k PDF souboru
      if (fileUpload.HasFile)
      {
        switch (Path.GetExtension(fileUpload.FileName).ToLower())
        {
          case ".txt":
            Response.Write("Je mi lito txt nema validaci!");
            break;
          case ".jpg":
          case ".jpeg":
            break;
          case ".png":
            break;
          case ".pdf":
            try
            {
              // Get uploaded file content
              byte[] fileBytes = fileUpload.FileBytes;

              // Create a PdfReader object from uploaded file content
              using (MemoryStream ms = new MemoryStream(fileBytes))
              {
                log.Info($"pdf zacatek {fileUpload.FileName}");
                var recordPdf = new RecordPdf(fileUpload.FileName);
                var result = recordPdf.Validate(ms);
                log.Info($"pdf konec {fileUpload.FileName} - {result}");
                Response.Write(result);
              }
            }
            catch (Exception ex)
            {
              // Handle the error
              log.Error(ex);
              Response.Write("Je mi lito soubor nejde zpracovat.");
            }
            break;

          default:
            break;
        }
        

      }
      else
      {
        Response.Write("Prosim vyberte soubor.");
      }
    }
  }
}