using System;

namespace Biblioteca
{
    public static class Calculadora
    {
        public static double Calcular(double a, double b, string simbolo)
        {
            double resultado = 0;

            switch (simbolo)
            {
                case "-":
                    resultado = a - b;
                    break;
                case "+":
                    resultado = a + b;
                    break;
                case "*":
                    resultado = a * b;
                    break;
                case "/":
                    if (Calculadora.Validar(b))
                    {
                        resultado = a / b;
                    }
                    break;
                default:
                    break;
            }
            return resultado;
        }

        private static bool Validar(double b)
        {
            return (b != 0);
        }
    }
}
