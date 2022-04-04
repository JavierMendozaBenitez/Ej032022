using System;
using Biblioteca;

namespace Ej_I01_Val_ran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;

            Console.WriteLine("Ingrese un numero entero");

            while(!int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                Console.WriteLine("Error, reingrese");
            }
        }
    }
}
