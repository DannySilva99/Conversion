using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Valores
    {
        double pesos;
        double centavos;
        double totalcentavos;

        public double Pesos
        {
            get { return pesos; }
            set { pesos = value; }
        }
        public double Centavos
        {
            get { return centavos; }
            set { centavos = value; }
        }
        public double TotalCentavos
        {
            get { return totalcentavos; }
            set { totalcentavos = value; }
        }
    }
}
