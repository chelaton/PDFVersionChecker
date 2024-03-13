using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PDFVersionChecker.Logic.Interface
{
  public interface IRecordValidation
  {
    string Validate(Stream ms);
  }
}