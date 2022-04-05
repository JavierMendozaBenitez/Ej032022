using System;

namespace Biblioteca
{
    public static class Factorial
    {
        public static double CalculadoraDeFactorial(double numero)
        {
            double factorial = 1;

            for(int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }
            
            return factorial;
        } 
    }
}
