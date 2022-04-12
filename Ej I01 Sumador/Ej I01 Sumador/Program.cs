using System;
using Biblioteca;

namespace Ej_I01_Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long a = 10;
            long b = 55;
            string uno = "Uno";
            string dos = "Dos";

            long c = 100;
            long d = 550;
            string tres = "Tres";
            string cuatro = "Cuatro";

            long e = 200;
            long f = 750;
            string cinco = "Cinco";
            string seis = "Seis";

            Sumador sumador1 = new Sumador();

            Console.WriteLine("Resultado de la cantidad de sumas de sumador1: {0}", ((int)sumador1));


            Console.WriteLine("Muestro la suma de enteros de sumador1: {0}", sumador1.Sumar(a, b));
            Console.WriteLine("Resultado de la cantidad de sumas de sumador1: {0}", ((int)sumador1));


            Console.WriteLine("Muestro la suma de string de sumador1: {0}", sumador1.Sumar(uno, dos));
            Console.WriteLine("Resultado de la cantidad de sumas de sumador1: {0}", ((int)sumador1));




            Sumador sumador2 = new Sumador();

            Console.WriteLine("\n\nResultado de la cantidad de sumas de sumador2: {0}", ((int)sumador2));


            Console.WriteLine("Muestro la suma de enteros de sumador2: {0}", sumador2.Sumar(c, d));
            Console.WriteLine("Resultado de la cantidad de sumas de sumador2: {0}", ((int)sumador2));

 
            Console.WriteLine("Muestro la suma de string de sumador2: {0}", sumador2.Sumar(tres, cuatro));
            Console.WriteLine("Resultado de la cantidad de sumas de sumador2: {0}", ((int)sumador2));



            //Sobrecargas

            Console.WriteLine("\nMuestro la sobrecarga del +, cuantas sumas tienen en total: {0}", sumador1 + sumador2);
            Console.WriteLine("Muestro la sobrecarga del |, muestros si tienen la misma cantidad de sumas: {0}", sumador1 | sumador2);


            Console.WriteLine("\nMuestro la suma de enteros de sumador2: {0}", sumador2.Sumar(e, f));
            Console.WriteLine("Resultado de la cantidad de sumas de sumador2: {0}", ((int)sumador2));
            Console.WriteLine("Muestro la suma de string de sumador2: {0}", sumador2.Sumar(cinco, seis));
            Console.WriteLine("Resultado de la cantidad de sumas de sumador2: {0}", ((int)sumador2));

            Console.WriteLine("\nMuestro la sobrecarga del +, cuantas sumas tienen en total: {0}", sumador1 + sumador2);
            Console.WriteLine("Muestro la sobrecarga del |, muestros si tienen la misma cantidad de sumas: {0}", sumador1 | sumador2);

        }
    }
}
