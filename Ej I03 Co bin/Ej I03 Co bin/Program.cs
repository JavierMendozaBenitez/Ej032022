using System;
using Biblioteca;

namespace Ej_I03_Co_bin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entero;
            string binario;

            Console.WriteLine("Ingrese un numero entero");
            entero = int.Parse(Console.ReadLine());
            //Conversor.ConvertirDecimalABinario(entero);
            Console.WriteLine($"El numero {entero} es en binario {Conversor.ConvertirDecimalABinario(entero)}");

            Console.WriteLine("Ingrese un numero binario");
            binario = Console.ReadLine();
            Console.WriteLine($"El numero binario {binario} es en decimal {Conversor.ConvertirBinarioADecimal(binario)}");
        }
    }
}
