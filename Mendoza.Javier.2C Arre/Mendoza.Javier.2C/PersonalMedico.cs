using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendoza.Javier._2C
{
    public class PersonalMedico: Persona
    {
        private List<Consulta> consultas;
        private bool esRecidente;

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat("¿Finalizó residencia?: {0}{1}", this.esRecidente ? "NO" : "SI", Environment.NewLine);           

            sb.AppendLine("ATENCIONES:");

            foreach (Consulta consulta in this.consultas)
            {
                //sb.AppendLine(consulta.ToString());
                sb.AppendLine(Persona.FichaPersonal(consulta.Paciente));
            }

            return sb.ToString();
        }

        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta consultaOtro = null;

            if (doctor is not null && paciente is not null)
            {
                consultaOtro = new Consulta(DateTime.Now, paciente);
                doctor.consultas.Add(consultaOtro);
            }
            return consultaOtro;
        }

        public PersonalMedico (string nombre, string apellido, DateTime nacimiento, bool esRecidente)
            :base(nombre, apellido, nacimiento)
        {
            this.esRecidente = esRecidente;
            this.consultas = new List<Consulta>();
        }
    }
}
