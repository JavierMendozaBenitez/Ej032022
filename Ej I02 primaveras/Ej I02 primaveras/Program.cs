using System;
using Biblioteca;

namespace Ej_I02_primaveras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona Persona1 = new Persona("Javier", new DateTime(1992, 03, 11), 12345678);
            Persona Persona2 = new Persona("Ana", new DateTime(2000, 06, 01), 87654321);
            Persona Persona3 = new Persona("MArta", new DateTime(2021, 12, 31), 12123458);

            Console.WriteLine("{0}", Persona1.Mostrar());
            Console.WriteLine("Persona 1 es: {0}", Persona1.EsMayorDeEdad());

            Console.WriteLine("{0}", Persona2.Mostrar());
            Console.WriteLine("Persona 2 es: {0}", Persona2.EsMayorDeEdad());

            Console.WriteLine("{0}", Persona3.Mostrar());
            Console.WriteLine("Persona 3 es: {0}", Persona3.EsMayorDeEdad());
        }
    }
}
