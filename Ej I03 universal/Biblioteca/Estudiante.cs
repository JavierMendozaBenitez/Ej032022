using System;
using System.Text;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante ()
        {
            random = new Random ();
        }

        public Estudiante (string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        private float CalcularPromedio()
        {
            return (float)(this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        public int CalcularNotaFinal()
        {
            int ran;

            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                return random.Next(6, 10);
            }
            else
            {
                return -1;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*****************************");
            sb.AppendLine("Datos del alumno\n");
            sb.AppendLine($"Nombre: {this.nombre}. Apellido: {this.apellido}. Legajo: {this.legajo}");
            sb.AppendLine($"Nota del primer parcial: {this.notaPrimerParcial}. Nota del segundo parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio()}");

            if(this.CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"Nota Final: {this.CalcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }

            return sb.ToString();            
        }
    }
}
