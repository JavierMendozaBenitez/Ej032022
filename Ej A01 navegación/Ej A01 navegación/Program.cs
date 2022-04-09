using System;
using Biblioteca;

namespace Ej_A01_navegación
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Conductores[] conductoresLista = new Conductores[3];

            Conductores conductor1 = new Conductores("Javier");
            Conductores conductor2 = new Conductores("Pablo");
            Conductores conductor3 = new Conductores("Juan");

            conductoresLista[0] = conductor1;
            conductoresLista[1] = conductor2;
            conductoresLista[2] = conductor3;

            conductor1.cargarKilometros(1, 200);
            conductor1.cargarKilometros(2, 599);
            conductor1.cargarKilometros(3, 899);
            conductor1.cargarKilometros(4, 0);
            conductor1.cargarKilometros(5, 256);
            conductor1.cargarKilometros(6, 0);
            conductor1.cargarKilometros(7, 0);

            conductor2.cargarKilometros(1, 400);
            conductor2.cargarKilometros(2, 199);
            conductor2.cargarKilometros(3, 299);
            conductor2.cargarKilometros(4, 5000);
            conductor2.cargarKilometros(5, 0);
            conductor2.cargarKilometros(6, 0);
            conductor2.cargarKilometros(7, 0);

            conductor3.cargarKilometros(1, 100);
            conductor3.cargarKilometros(2, 0);
            conductor3.cargarKilometros(3, 99);
            conductor3.cargarKilometros(4, 110);
            conductor3.cargarKilometros(5, 777);
            conductor3.cargarKilometros(6, 0);
            conductor3.cargarKilometros(7, 0);


            Console.WriteLine("Mostrar conductor 1: \n{0}", conductoresLista[0].Mostrar());
            Console.WriteLine("Mostrar conductor 2: \n{0}", conductoresLista[1].Mostrar());
            Console.WriteLine("Mostrar conductor 3: \n{0}", conductoresLista[2].Mostrar());


            //El conductor que hizo más km en esta semana


            if (conductor1.ContadorDeKilometrosPorSemana() > conductor2.ContadorDeKilometrosPorSemana() && 
                conductor1.ContadorDeKilometrosPorSemana() > conductor3.ContadorDeKilometrosPorSemana())
            {
                Console.WriteLine("El conductor que hizo más km en esta semana es: \n{0}\nHizo {1} kilometros\n", conductor1.Mostrar(), conductor1.ContadorDeKilometrosPorSemana());
            }
            else if(conductor2.ContadorDeKilometrosPorSemana() > conductor1.ContadorDeKilometrosPorSemana() &&
                conductor2.ContadorDeKilometrosPorSemana() > conductor3.ContadorDeKilometrosPorSemana())
            {
                Console.WriteLine("El conductor que hizo más km en esta semana es: \n{0}\nHizo {1} kilometros\n", conductor2.Mostrar(), conductor2.ContadorDeKilometrosPorSemana());
            }
            else
            {
                Console.WriteLine("El conductor que hizo más km en esta semana es: \n{0}\nHizo {1} kilometros\n", conductor3.Mostrar(), conductor3.ContadorDeKilometrosPorSemana());
            }

            
            //El conductor que hizo más km el día 3

            if (conductor1.GetKilometros(3) > conductor2.GetKilometros(3) && conductor1.GetKilometros(3) > conductor3.GetKilometros(3))
            {
                Console.WriteLine("El conductor que hizo más km el día 3 es: \n{0}\nHizo: {1}\n", conductor1.Mostrar(), conductor1.GetKilometros(3));
            }
            else if(conductor2.GetKilometros(3) > conductor1.GetKilometros(3) && conductor1.GetKilometros(3) > conductor3.GetKilometros(3))
            {
                Console.WriteLine("El conductor que hizo más km el día 3 es: \n{0}\nHizo: {1}\n", conductor2.Mostrar(), conductor2.GetKilometros(3));
            }
            else
            {
                Console.WriteLine("El conductor que hizo más km el día 3 es: \n{0}\nHizo: {1}\n", conductor3.Mostrar(), conductor3.GetKilometros(3));
            }


            //El conductor que hizo más km el día 5

            if (conductor1.GetKilometros(5) > conductor2.GetKilometros(5) && conductor1.GetKilometros(5) > conductor3.GetKilometros(5))
            {
                Console.WriteLine("El conductor que hizo más km el día 5 es: \n{0}\nHizo: {1}\n", conductor1.Mostrar(), conductor1.GetKilometros(5));
            }
            else if (conductor2.GetKilometros(5) > conductor1.GetKilometros(5) && conductor1.GetKilometros(5) > conductor3.GetKilometros(5))
            {
                Console.WriteLine("El conductor que hizo más km el día 5 es: \n{0}\nHizo: {1}\n", conductor2.Mostrar(), conductor2.GetKilometros(5));
            }
            else
            {
                Console.WriteLine("El conductor que hizo más km el día 5 es: \n{0}\nHizo: {1}\n", conductor3.Mostrar(), conductor3.GetKilometros(5));
            }

            //Console.WriteLine("Conductor 1: \n{0}", conductor1.Mostrar());



        }
    }
}
