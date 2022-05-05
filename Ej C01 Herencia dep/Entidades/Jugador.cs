using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador: Persona
    {
        private int partidosJugados;
        private int totalGoles;
                
        public Jugador(int dni, string nombre)
            : base(dni, nombre)
        {
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre)
        {
            this.TotalGoles = totalGoles;
            this.PartidosJugados = totalPartidos;
        }

        //propiedades
            
            //solo lectura

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }


        public int TotalGoles
        {
            get { return this.totalGoles; }
            set
            {
                this.totalGoles = value;
            }
        }

        public float PromedioGoles
        {
            get { return (float)this.totalGoles / this.partidosJugados; }
        }

              

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Partidos jugados: " + this.PartidosJugados);
            sb.AppendLine("Promedio de Goles: " + this.PromedioGoles.ToString());
            sb.AppendLine("Total de Goles: " + this.TotalGoles);

            return sb.ToString();
        }

        public static bool operator == (Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.Dni == j2.Dni);
        }
    }
}
