using System;
using System.Text;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comision = "2do C";
            int anio = 2022;

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Hola");
            stringBuilder.Append($" Mundo {Environment.NewLine}");
            stringBuilder.AppendLine("Programacion II");
            stringBuilder.AppendLine("Laboratorio II");
            stringBuilder.AppendFormat("Comision {1} {0}", comision, anio);

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
