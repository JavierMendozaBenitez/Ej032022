using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico: Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(string nombre)
            :base(nombre)
        {            
        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento)
            : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
        }
        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Fecha de nacimiento: " + this.FechaNacimiento);

            return sb.ToString();
        }

        public static bool operator == (DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return string.Compare(dt1.Nombre, dt2.Nombre) == 0 && DateTime.Compare(dt1.FechaNacimiento, dt2.FechaNacimiento) == 0;
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
