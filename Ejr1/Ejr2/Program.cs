using System;

/*Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
 *Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".*/
namespace Ejr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double cuadrado;
            double cubo;

            Console.WriteLine("Ingrese un numero\n");

            numero = int.Parse(Console.ReadLine());

            while (numero < 1)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                numero = int.Parse(Console.ReadLine());
            }

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("El cuadradado de {0} es {1} y el cubo es {2}", numero, cuadrado, cubo);

            Console.ReadKey();
        }
    }
}
