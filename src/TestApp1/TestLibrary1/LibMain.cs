using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary1
{
  public class LibMain
  {
    public void DoSomeThing()
    {
      string sTest = "Write something";
      if (string.IsNullOrEmpty(sTest))
      {
        
      }
      // Schvalne chyba
      // int i = "a";
      int i = 0;
      i += 1;
    }
  }
}
