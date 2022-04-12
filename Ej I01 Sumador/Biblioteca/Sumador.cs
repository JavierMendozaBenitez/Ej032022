using System;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador() : this(0)
        {}

        public long Sumar(long a, long b)
        {
            this.cantidadSumas += 1;

            return a + b;
        }

        public string Sumar (string a, string b)
        {
            this.cantidadSumas += 1;

            return string.Format($"{a}{b}");
        }

        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
        }

        public static long operator +(Sumador a, Sumador b)
        {
            return (int)a.cantidadSumas + (int)b.cantidadSumas;
        }

        public static bool operator | (Sumador a, Sumador b)
        {
            bool retorno = false;

            if (a.cantidadSumas == b.cantidadSumas)
            {
                retorno = true;
            }

            return retorno;
        }

        
    }
}
