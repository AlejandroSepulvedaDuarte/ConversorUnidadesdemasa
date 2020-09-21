using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidadesDeMasa
{
    public class Decagramos:Conversion
    {
        public double ConAdag()
        {
            return (this.getpeso() * 1e+2);
        }
    }
}
