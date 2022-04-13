using System;

namespace Biblioteca
{
    public class NumeroBinario
    {
        public string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string GetNumeroBinario
        {
            get
            {
                return this.numero;
            }
        }


        public static explicit operator string(NumeroBinario nuBinario)//casteo a (string) los NumeroBinario que recibo, conviert
        {
            return nuBinario.numero;
        }

        public static implicit operator NumeroBinario(string nuBinario)//covierto a NumeroBinario los string que recibo
        {
            return new NumeroBinario(nuBinario);
        }


        public static string operator +(NumeroBinario nuBinario, NumeroDecimal nuDecimal)
        {
            return Conversor.ConvertirDecimalABinario((int)nuDecimal.numero + Conversor.ConvertirBinarioADecimal(nuBinario.numero));
        }

        public static string operator -(NumeroBinario nuBinario, NumeroDecimal nuDecimal)
        {
            return Conversor.ConvertirDecimalABinario((int)(Conversor.ConvertirBinarioADecimal(nuBinario.numero) - nuDecimal.numero));
        }
        public static bool operator ==(NumeroBinario nuBinario, NumeroDecimal nuDecimal)
        {
            return nuDecimal.numero == Conversor.ConvertirBinarioADecimal(nuBinario.numero);
        }

        public static bool operator !=(NumeroBinario nuBinario, NumeroDecimal nuDecimal)
        {
            return !(nuDecimal.numero == Conversor.ConvertirBinarioADecimal(nuBinario.numero));
        }
    }
}
