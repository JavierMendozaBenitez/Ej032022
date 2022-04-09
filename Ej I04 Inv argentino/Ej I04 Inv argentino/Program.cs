using System;
using Biblioteca;

namespace Ej_I04_Inv_argentino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dibuAzul;
            string dibuRojo;

            ConsoleColor colorReal = Console.ForegroundColor;

            Boligrafo BoligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo BoligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

            Console.WriteLine($"GetColor del azul: {BoligrafoAzul.GetColor()}");
            Console.WriteLine($"GetColor del rojo: {BoligrafoRojo.GetColor()}");

            Console.WriteLine($"GetTinta del azul, debe ser 100: {BoligrafoAzul.GetTinta()}");
            Console.WriteLine($"GetTinta del rojo, debe ser 50: {BoligrafoRojo.GetTinta()}");

            Console.WriteLine("Pinto con el azul");
            Console.ForegroundColor = BoligrafoAzul.GetColor();
            BoligrafoAzul.Pintar(40, out dibuAzul);            
            Console.WriteLine(dibuAzul);
            Console.WriteLine($"Nivel de tinta después de pintar: {BoligrafoAzul.GetTinta()}");

            Console.ForegroundColor = colorReal;

            BoligrafoAzul.Recargar();
            Console.WriteLine($"Recargo la tinta del azul, debe ser 100: {BoligrafoAzul.GetTinta()}");



            //ROJO



            Console.WriteLine("Pinto con el rojo");
            Console.ForegroundColor = BoligrafoRojo.GetColor();
            BoligrafoRojo.Pintar(30, out dibuRojo);
            Console.WriteLine(dibuRojo);
            Console.WriteLine($"Nivel de tinta después de pintar: {BoligrafoRojo.GetTinta()}");

            Console.ForegroundColor = colorReal;

            BoligrafoRojo.Recargar();
            Console.WriteLine($"Recargo la tinta del rojo, debe ser 50: {BoligrafoRojo.GetTinta()}");

        }
    }
}
