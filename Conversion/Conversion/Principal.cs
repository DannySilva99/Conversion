using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Principal
    {
        Valores valores = new Valores();
        RepoConversion repo = new RepoConversion();

        public void RealizarConversion()
        {
            double a;
            double b;
            Console.WriteLine("Ingrese los centavos para convertir: ");
            valores.TotalCentavos = Convert.ToDouble(Console.ReadLine());

            repo.Convertir(valores.TotalCentavos, out a, out b);
            valores.Pesos = a;
            valores.Centavos = b;
            Console.WriteLine(valores.Centavos.ToString() + " Centavos");
            Console.WriteLine(valores.Pesos.ToString() + " Pesos");
            Console.ReadKey();
        }
    }
}
