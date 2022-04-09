using System;
using System.Text;

namespace Biblioteca
{
    public class Conductores
    {
        private string nombre;
        private int[] kilometros;

        public Conductores(string nombre)
        {
            this.nombre = nombre;
            this.kilometros = new int[8];
        }

        public void cargarKilometros(int dia, int kilometro)
        {
            this.kilometros[dia] = kilometro;
        }

        public int ContadorDeKilometrosPorSemana()
        {
            int acumulador = 0;

            for (int i = 1; i < this.kilometros.Length; i++)
            {
                acumulador += this.kilometros[i];
            }
            return acumulador;
        }

        public int GetKilometros(int dia)
        {
            return this.kilometros[dia];
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*********************");
            sb.AppendLine("Datos del conductor");
            sb.AppendLine("Nombre: "+ this.nombre);

            for(int i = 1; i < this.kilometros.Length; i++)
            {               
                if(i != 6 && i != 7 && this.kilometros[i] == 0)
                {
                    sb.AppendLine($"Día {i}: {this.kilometros[i].ToString()} (tiene franco)");
                }
                else
                {
                    sb.AppendLine($"Día {i}: {this.kilometros[i].ToString()}");
                }
            }            

            return sb.ToString();
        }
    }
}
