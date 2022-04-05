using System;

namespace Biblioteca
{
    public static class Pitagoras
    {
        public static float Calculando(float ancho, float altura)
        {
            float hipotenusa;

            return hipotenusa = (float)Math.Sqrt(Math.Pow(ancho, 2) + Math.Pow(altura, 2));
        }
    }
}
