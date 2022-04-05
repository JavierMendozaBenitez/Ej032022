using System;

namespace Biblioteca
{
    public static class Fecha
    {
        public static string calculadorDeDias(string fechaNacimiento)
        {
            TimeSpan diasVividos;

            diasVividos = DateTime.Now - Convert.ToDateTime(fechaNacimiento);

            return diasVividos.ToString();
        }
    }
}
