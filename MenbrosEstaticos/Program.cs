using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            {
                CultureInfo CI = CultureInfo.InvariantCulture;
                                          Console.Write("Entre o valor raio: ");
                double raio = double.Parse(Console.ReadLine(), CI);

                double circ = circunferencia(raio);
                double volume = Volume(raio);

                Console.WriteLine("Circuferencia: " + circ.ToString("F2", CI));
                Console.WriteLine("Volume: " + volume.ToString("F2", CI));
                Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CI));
            }

            static double circunferencia(double r)
            {
                return 2.0 * Pi  * r;
            }

            static double Volume(double r)
            {
                return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0); // return 4.0 / 3.0 * Pi *r * r * r;
            }
        }
    }
}