using System;
/*Ingresar 5 números por consola, guardándolos en una variable escalar. 
 * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.*/

namespace Ejr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int numeroMax = int.MinValue;
            int numeroMin = int.MaxValue;
            int contador = 0;
            int acumulador = 0;
            float promedio = 0;

            while(contador < 5)
            {
                Console.WriteLine("Ingrese un numero.\0");

                numero = int.Parse(Console.ReadLine());

                if(numero > numeroMax)
                {
                    numeroMax = numero;
                }
                else if(numero < numeroMin)
                {
                    numeroMin = numero;
                }

                acumulador += numero;
                contador++;
            }

            promedio = acumulador / contador;

            Console.WriteLine("El numero maximo es: {0}", numeroMax);
            Console.WriteLine("El numero minimo es: {0}", numeroMin);
            Console.WriteLine("El promedio es: {0}", promedio);

            Console.ReadKey();
        }
    }
}
