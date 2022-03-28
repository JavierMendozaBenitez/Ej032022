using System;

/*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
Validar que el dato ingresado por el usuario sea un número.
Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
Si ingresa "salir", cerrar la consola.
Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. 
De lo contrario, cerrar la consola.*/

namespace Ej_I03_Los_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int salir = 2;
            int operar = 2;
            float acumuDivi = 0;

            

            while (operar == 2)
            {
                Console.WriteLine("Ingrese un numero");

                while (!int.TryParse(Console.ReadLine(), out numero) || salir == 2)
                {
                    Console.WriteLine("Desea salir: si 1, no 2?");
                    salir = int.Parse(Console.ReadLine());
                    if (salir == 1)
                    {
                        break;
                    }
                    Console.WriteLine("Reingrese el dato");                   
                                        
                }

                for (int i = 2; i < numero; i++)
                {
                    acumuDivi = 0;

                    for (int j = 2; j < i; j++) //así chequea todos los que tengan un divisor
                    {
                        if ((i % j) == 0)
                        {
                            acumuDivi++;
                        }
                    }
                    if (acumuDivi == 0)
                    {
                        Console.WriteLine("Numero primo {0}", i);
                    }
                }

                Console.WriteLine("Desea volver a operar: no 1, si 2?");
                operar = int.Parse(Console.ReadLine());
            }


            Console.ReadKey();
        }
    }
}
