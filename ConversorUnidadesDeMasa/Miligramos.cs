using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidadesDeMasa
{
   public class Miligramos:Conversion
    {
        public double ConAmg()
        {
            return (this.getpeso() * 1e+6);
        }
    }
}
