using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace atividadeeemariiii
{
    internal class Program
    {
        static double pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("entre com o valor do raio: ");

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Circuferencia(raio);
            double volume = Volume (raio);

            Console.WriteLine("Circuferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("valor de PI: " + pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        static double Circuferencia(double r)
        {
            return 2.0 * pi * r;
        }
        static double Volume (double r)
        {
            return 4.0 / 3.0 * pi * r * r * r;
        
        }
    }
}
