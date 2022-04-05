using System;
using Biblioteca;

namespace EjI08_tiempo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fechaIngresada;

            Console.WriteLine("Ingrese dia, mes y año de nacimiento: (mm/dd/aaaa)");
            fechaIngresada = Console.ReadLine();

            Console.WriteLine("Los numeros de dias vividos son: {0}", Fecha.calculadorDeDias(fechaIngresada));
        }
    }
}
