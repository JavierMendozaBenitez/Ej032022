using System;
using Biblioteca;

namespace Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float temperatuCalsius = 30f;

            float temperatuKelvin = ConversorDeTemperatura.ConvertirCelsiusAKelvin(temperatuCalsius);

            Math.Min(1, 4);



            Console.WriteLine("{0}", temperatuKelvin);
        }
    }
}
