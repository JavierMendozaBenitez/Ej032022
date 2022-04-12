using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mascotas
    {
        private string especie;
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string[] vacunas;

        public Mascotas (string especie, string nombre, DateTime fechaDeNacimmiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimmiento;
            this.vacunas = new string[3];
    }
        public void SetVacunas(string vacunaAAgregar)
        {
            int contador = 0;

            for(int i = 0; i < this.vacunas.Length; i++)
            {
                //this.vacunas[i] != vacunaAAgregar && 
                if (contador == 0 && this.vacunas[i] is null)
                {
                    this.vacunas[i] = vacunaAAgregar;

                    contador = 1;
                }
            }  
        }
        public string Mostrar()
        {
            int contador = 0;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Especie: {this.especie}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Fecha de nacimiento: {this.fechaDeNacimiento}");
            
            for (int i = 0; i < this.vacunas.Length; i++)
            {
                if (this.vacunas[i] is not null)
                {
                    sb.AppendLine($"Vacunas: {this.vacunas[i]}");
                    contador = 1;
                }

            }

            if( contador == 0)
            {
                sb.AppendLine("Vacunas: No tiene.");
            }

            return sb.ToString();
        }

        /*public void CargarVacuna(string vavunaAAgregar)
        {
            this.
        }*/
        


    }
}
