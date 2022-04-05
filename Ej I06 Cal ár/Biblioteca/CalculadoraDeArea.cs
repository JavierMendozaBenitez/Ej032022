using System;

namespace Biblioteca
{
    public static class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double area;
            area = Math.Pow(longitudLado, 2);
            return area;
        }

        public static double CalcularAreaTriangulo(double ancho, double altura)
        {
            double area;
            area = (ancho * altura) / 2;
            return area;
        }
        public static double CalcularAreaCirculo(double radio)
        {
            double area;
            area = Math.PI * Math.Pow(radio, 2);
            return area;
        }
    }
}
