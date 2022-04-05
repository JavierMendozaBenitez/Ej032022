using System;
using Biblioteca;

namespace Ej_I06_Cal_ár
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado;
            double areaCuadrado;
            double ancho;
            double altura;
            double areaTriangulo;
            double radio;
            double areaCirculo;

            Console.WriteLine("Ingrese un lado del cuadrado.");
            while (!double.TryParse(Console.ReadLine(), out lado))
            {
                Console.WriteLine("ERROR");

            }
            areaCuadrado = CalculadoraDeArea.CalcularAreaCuadrado(lado);
            Console.WriteLine("Area del cuadrado {0}\n", areaCuadrado);


            Console.WriteLine("Ingrese ancho del triangulo.");
            while (!double.TryParse(Console.ReadLine(), out ancho))
            {
                Console.WriteLine("ERROR");

            }
            Console.WriteLine("Ingrese altura del triangulo.");
            while (!double.TryParse(Console.ReadLine(), out altura))
            {
                Console.WriteLine("ERROR");

            }
            areaTriangulo = CalculadoraDeArea.CalcularAreaTriangulo(ancho, altura);
            Console.WriteLine("Area del triangulo {0}\n", areaTriangulo);


            Console.WriteLine("Ingrese radio del circulo.");
            while (!double.TryParse(Console.ReadLine(), out radio))
            {
                Console.WriteLine("ERROR");
            }
            areaCirculo = CalculadoraDeArea.CalcularAreaCirculo(radio);
            Console.WriteLine("Area del circulo {0}\n", areaCirculo);

            Console.ReadKey();
        }
    }
}
