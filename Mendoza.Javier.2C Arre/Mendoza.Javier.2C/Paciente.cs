using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendoza.Javier._2C
{
    public enum Diagnostico
    {
        Curado, Gripe, Covid
    }
    public class Paciente:Persona
    {
        private Diagnostico diagnostico;

        public Diagnostico Diagnostico
        {
            get
            {
                return this.diagnostico;
            }
            set
            {
                this.diagnostico = value;
            }
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Recide en {this.barrioRecidencia}");
            sb.AppendLine($"{this.Diagnostico}");

            return sb.ToString();
        }

        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia)
            : base(nombre, apellido, nacimiento, barrioRecidencia)
        {
        }
    }
}
