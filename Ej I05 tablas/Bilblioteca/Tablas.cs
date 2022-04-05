using System;
using System.Text;

namespace Bilblioteca
{
    public static class Tablas
    {
        public static string multiplicando(int a)
        {
            int resultado;

            StringBuilder sb = new StringBuilder();

            for(int i = 1; i <= 10; i++)
            {
                resultado = a * i;

                sb.AppendLine($"{a} x {i} = {resultado}");               

            }
            return sb.ToString();
        }
    }
}
