using System;
using System.Text;

namespace Mendoza.Javier._2C
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioRecidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public int Edad
        {
            get
            {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            } 
        }

        public string NombreCompleto
        {
            get
            {
                //return string.Format("Apellido {0},Nombre {1}", this.apellido, this.nombre);
                return string.Format($"{this.apellido}{this.nombre}");
            }
        }

        //internal abstract string FichaExtra();
        abstract internal string FichaExtra();

        public static string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();

            if (p is not null)
            {
                sb.AppendLine($"{p.ToString()}");
                sb.AppendLine($"Edad: {p.Edad}");
                sb.AppendLine(p.FichaExtra());
            }

            return sb.ToString();
        }

        public Persona (string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }

        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia)
            :this(nombre, apellido, nacimiento)
        {
            this.barrioRecidencia = barrioRecidencia;
        }

        public override string ToString()
        {
            return this.NombreCompleto;
        }


    }
}
