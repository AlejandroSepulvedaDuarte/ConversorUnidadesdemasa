using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidadesDeMasa
{
    public class Gramos:Conversion
    {
        public double ConAg()
        {
            return (this.getpeso() * 1e+3);
        }
    }
}
