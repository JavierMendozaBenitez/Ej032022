using System;
using Biblioteca;

namespace Ej_C01_bin_recargado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string suma;

            //implicito
            NumeroDecimal decimalIngresado = 8;
            NumeroBinario binarioIngresado = "101111";

            //Console.WriteLine(binarioIngresado.numero);
            //Console.WriteLine(decimalIngresado.numero);

            ////explicito
            //Console.WriteLine((string)binarioIngresado.numero);
            //Console.WriteLine((double)decimalIngresado.numero) ;

            //suma
            Console.WriteLine("SUMA");
            Console.WriteLine(decimalIngresado + binarioIngresado);
            Console.WriteLine(binarioIngresado + decimalIngresado);

            //resta
            decimalIngresado = 8;
            binarioIngresado = "101111";

            Console.WriteLine("RESTA");
            Console.WriteLine("decimal - binario {0}", (decimalIngresado - binarioIngresado));
            decimalIngresado = 8;
            binarioIngresado = "101111";
            Console.WriteLine("binario - decimal {0} ", (binarioIngresado - decimalIngresado));



            Console.ReadKey();
        }
    }
}
