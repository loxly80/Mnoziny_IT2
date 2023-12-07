using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnoziny_IT2
{
  public class Vycet : Mnozina
  {
    public double[] Prvky;

    public override Mnozina? Prunik(Mnozina mnozina)
    {
      if(mnozina.GetType() == typeof(Vycet))
      {
        Vycet vycet = (Vycet)mnozina;
        List<double> prunik = new List<double>();
        foreach(var prvek in vycet.Prvky)
        {
          if (this.Prvky.Contains(prvek))
          {
            prunik.Add(prvek);
          }
        }
        return new Vycet() { Prvky = prunik.ToArray() }; 
      }
      else if (mnozina.GetType() == typeof(Interval))
      {

      }
      return null;
    }
  }
}
