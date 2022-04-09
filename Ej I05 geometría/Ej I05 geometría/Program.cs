using System;
using Bilioteca;
using System.Text;

namespace Ej_I05_geometría
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto punto1 = new Punto(5, 10);
            Punto punto2 = new Punto(7, 20);
            Punto punto3 = new Punto(2, 55);
            Punto punto4 = new Punto(10, 3);

            Rectangulo rec1 = new Rectangulo(punto1, punto3);
            Rectangulo rec2 = new Rectangulo(punto2, punto4);

            Console.WriteLine("Area rec1: {0}", rec1.Area());
            Console.WriteLine("Area rec2: {0}", rec2.Area());

            Console.WriteLine("Perimetro rec1: {0}", rec1.Perimetro());
            Console.WriteLine("Perimetro rec2: {0}", rec2.Perimetro());

            Console.WriteLine("Rec1");
            Console.WriteLine(Mostrar(rec1));
            Console.WriteLine("Rec2");
            Console.WriteLine(Mostrar(rec2));
        }

        public static string Mostrar(Rectangulo rectanguloIns)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Area: " + rectanguloIns.Area());
            sb.AppendLine("Perimetro: " + rectanguloIns.Perimetro());

            return sb.ToString();   
        }
    }
}
