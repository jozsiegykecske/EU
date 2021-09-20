using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU
{
  class Orszagok
  {
    private string orszag;

    public string Orszag
    {
      get { return orszag; }
      set { orszag = value; }
    }
    private DateTime datum;

    public DateTime Datum
    {
      get { return datum; }
      set { datum = value; }
    }

    public Orszagok(string orszag, DateTime datum)
    {
      this.orszag = orszag;
      this.datum = datum;
    }
  }
}
