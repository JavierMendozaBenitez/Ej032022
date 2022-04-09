using System;

namespace Biblioteca
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo (short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if(this.GetTinta() + tinta >= 0 && this.GetTinta() + tinta <= cantidadTintaMaxima)
            {
                this.tinta += tinta;
            }
            else
            {
                this.tinta = cantidadTintaMaxima;
            }
        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            string auxDibujo = "";
            bool retorno = false;

            
            if(this.GetTinta() == 0)
            {
                dibujo = "Está vacio";
            }
            else
            {
                while(this.GetTinta() > 0 && gasto > 0)
                {
                    auxDibujo += "*";
                    gasto--;
                    this.SetTinta(-1);
                }

                dibujo = auxDibujo;
                retorno = true;
            }
            return retorno;
        }
    }
}
