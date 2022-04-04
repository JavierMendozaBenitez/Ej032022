using System;
using Biblioteca;

namespace Ej_I01_Validador_de_rangos
{
    internal class Program
    {
        static int minimo = int.MaxValue;
        static int maximo = int.MinValue;
        static void Main(string[] args)
        {
            int numeroIngresado;
            
            int contador = 0;
            float promedio;
            int acumulador = 0;

            do
            {
                do
                {
                    Console.WriteLine("Ingrese un numero");
                    numeroIngresado = int.Parse(Console.ReadLine());
                } while (!Validador.Validar(numeroIngresado, -100, 100));

                ObtenerMinimo(numeroIngresado);
                ObtenerMaximo(numeroIngresado);

                contador++;
                acumulador += numeroIngresado;

            } while (contador < 10);

            promedio = acumulador / contador;

            Console.WriteLine("Valor minimo {0}, valor maximo {1}, promedio {2}", minimo, maximo, promedio);      

        }

        public static void ObtenerMinimo(int valor)
        {
            if(valor < minimo)
            {
                minimo = valor;
            }
        }

        public static void ObtenerMaximo(int valor)
        {
            if (valor > maximo)
            {
                maximo = valor;
            }
        }
    }
}
