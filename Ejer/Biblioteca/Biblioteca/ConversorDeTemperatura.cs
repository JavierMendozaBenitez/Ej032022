using System;

namespace Biblioteca
{
    public static class ConversorDeTemperatura
    {
        
        private const float ceroAbsoluto = 273.15f;//atributo

        /// <summary>
        /// Convierte la temperatura que recibe en Kelvin
        /// </summary>
        /// <param name="temperatuCalsius"></param>
        /// <returns> retorna temperatura en Kelvin </returns>
        public static float ConvertirCelsiusAKelvin(float temperatuCalsius)//metodo
        {
            return temperatuCalsius + ceroAbsoluto;
        }

        public static float ConvertirKelvinACelsius(float temperaturaKelvin)//metodo
        {
            return temperaturaKelvin - ceroAbsoluto;
        }
    }
}
