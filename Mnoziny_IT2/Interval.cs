using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnoziny_IT2
{
  public class Interval : Mnozina
  {
    public double Zacatek;
    public double Konec;

    public override Mnozina Prunik(Mnozina mnozina)
    {
      return this;  
    }
  }
}
