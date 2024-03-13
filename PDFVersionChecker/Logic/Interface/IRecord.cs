namespace PDFVersionChecker.Logic.Interface
{
  public interface IRecord
  {
    string FileName { get; set; }

    string GetExtension();
  }
}