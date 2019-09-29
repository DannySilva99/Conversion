using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class RepoConversion
    {
        public void Convertir(double totalcentavos, out double pesos, out double centavos)
        {
            pesos = totalcentavos / 100;
            centavos = totalcentavos;
        }
    }
}
