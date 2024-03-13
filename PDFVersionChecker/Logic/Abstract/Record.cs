using PDFVersionChecker.Logic.Interface;
using System.IO;

namespace PDFVersionChecker.Logic.Abstract
{
  public abstract class Record : IRecord
  {
    public string FileName { get; set; }

    public string GetExtension() 
    { 
      return Path.GetExtension(FileName).ToLower(); 
    }

  }
}