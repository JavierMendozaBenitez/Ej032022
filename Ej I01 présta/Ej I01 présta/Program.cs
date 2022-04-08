using System;
using Biblioteca;

namespace Ej_I01_présta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta Cuenta1 = new Cuenta("Javier", 10);

            Console.WriteLine("Muestro la cuenta:\n{0}", Cuenta1.Mostrar());

            Cuenta1.Ingresar(55);

            Console.WriteLine("Agrego a la cuenta 55:\n{0}", Cuenta1.Mostrar());

            Cuenta1.Retirar(60);

            Console.WriteLine("Retiro de la cuenta 60:\n{0}", Cuenta1.Mostrar());

            Console.WriteLine("Muestro con Append:\n{0}", Cuenta1.Mostrar2());
        }
    }
}
