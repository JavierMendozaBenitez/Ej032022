using System;
using Biblioteca;

/*Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.

Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.*/

namespace Ej_I04_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double resultado;
            string simbolo;
            string continuar = "s";

            do
            {
                Console.WriteLine("Ingrese el primer numero.");
                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("ERROR.");
                }
                Console.WriteLine("Ingrese el segundo numero.");
                while (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("ERROR.");
                }

                Console.WriteLine("Ingrese la operacion.");
                simbolo = Console.ReadLine();
                while (simbolo != "/" && simbolo != "*" && simbolo != "-" && simbolo != "+")
                {
                    Console.WriteLine("ERROR. Reingrese");
                    simbolo = Console.ReadLine();
                }

                resultado = Calculadora.Calcular(a, b, simbolo);

                Console.WriteLine("Resultado {0}", resultado);

                Console.WriteLine("Continuar s/n");
                continuar = Console.ReadLine();
                while (continuar != "s" && continuar != "n")
                {
                    Console.WriteLine("ERROR. Reingrese");
                    continuar = Console.ReadLine();
                }

            } while (continuar == "s");


            Console.ReadKey();
        }
    }
}
