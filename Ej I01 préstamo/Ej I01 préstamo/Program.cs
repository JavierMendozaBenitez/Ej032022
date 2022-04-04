using System;
using Biblioteca;

namespace Ej_I01_préstamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuentaNueva = new Cuenta("Javier", 10000);

            cuentaNueva.ingresar(500);

            Console.WriteLine(cuentaNueva.mostrar());

            cuentaNueva.retirar(5000);

            Console.WriteLine(cuentaNueva.mostrar());

            Console.ReadKey();
        }
    }
}
