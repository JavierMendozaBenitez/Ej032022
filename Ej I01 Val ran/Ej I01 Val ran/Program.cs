using System;
using Biblioteca;

namespace Ej_I01_Val_ran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int contador = 0;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int acumulador = 0;
            float promedio;

            do
            {
                Console.WriteLine("Ingrese un numero entero");

                while (!int.TryParse(Console.ReadLine(), out numeroIngresado) || !Validador.Validar(numeroIngresado, -100, 100))
                {
                    Console.WriteLine("Error, reingrese");
                }
                contador++;
                acumulador += numeroIngresado;

                if(numeroIngresado < minimo)
                {
                    minimo = numeroIngresado;
                }

                if(numeroIngresado > maximo)
                {
                    maximo = numeroIngresado;
                }

            } while (contador < 10);

            promedio = acumulador / contador;

            Console.WriteLine($"El minimo es: {minimo}. El maximo es: {maximo}. El promedio es {promedio}.");
        }
    }
}
