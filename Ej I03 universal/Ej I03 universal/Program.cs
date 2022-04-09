using System;
using Biblioteca;

namespace Ej_I03_universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante Estudiante1 = new Estudiante("Javier", "Mendoza", "100");
            Estudiante Estudiante2 = new Estudiante("Pedro", "Gonzales", "220");
            Estudiante Estudiante3 = new Estudiante("Laura", "Garcia", "333");

            Estudiante1.SetNotaPrimerParcial(7);
            Estudiante1.SetNotaSegundoParcial(10);

            Estudiante2.SetNotaPrimerParcial(9);
            Estudiante2.SetNotaSegundoParcial(6);

            Estudiante3.SetNotaPrimerParcial(3);
            Estudiante3.SetNotaSegundoParcial(2);

            Console.WriteLine("Estuudiante 1\n");
            Console.WriteLine("{0}", Estudiante1.Mostrar());

            Console.WriteLine("Etudiante 2\n");
            Console.WriteLine("{0}", Estudiante2.Mostrar());

            Console.WriteLine("Estuudiante 3\n");
            Console.WriteLine("{0}", Estudiante3.Mostrar());


        }
    }
}
