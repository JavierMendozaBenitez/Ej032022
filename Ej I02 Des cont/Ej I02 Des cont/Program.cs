using System;
using Biblioteca;

/*Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.*/
namespace Ej_I02_Des_cont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string letraIngresada;
            int acumulador = 0;

            do
            {
                Console.WriteLine("Ingrese un numero entero");

                while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    Console.WriteLine("Error. Reingrese el numero");
                }

                acumulador += numeroIngresado;

                Console.WriteLine("¿Desea continuar? (S/N)");
                letraIngresada = Console.ReadLine();

            } while (Validador.ValidarRespuesta(letraIngresada, "S"));

            Console.WriteLine($"Numero acumulado {acumulador}");
        }
    }
}
