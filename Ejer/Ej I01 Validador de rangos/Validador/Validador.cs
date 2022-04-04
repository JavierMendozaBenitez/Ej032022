using System;

namespace Biblioteca
{
    public static class Validador
    {
        //public static bool Validar(int valor, int min, int max)
        //{
        //    bool retorno = false;

        //    if(valor >= min && valor <= max)
        //    {
        //        retorno = true;
        //    }
        //    return retorno;
        //}

        /// <summary>
        /// Valida que el valor este dentro del rango
        /// </summary>
        /// <param name="valor">valor a validar</param>
        /// <param name="min">valor minimo</param>
        /// <param name="max">valor maximo</param>
        /// <returns>true si esta dentro del rango</returns>
        public static bool Validar(int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }
    }
}
