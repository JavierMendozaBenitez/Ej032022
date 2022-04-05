using System;
using Bilblioteca;

namespace Ej_I05_tablas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;

            Console.WriteLine("Ingrese un numero.");
            numeroIngresado = int.Parse(Console.ReadLine());
            
            Console.WriteLine("{0}", Tablas.multiplicando(numeroIngresado));
        }
    }
}
