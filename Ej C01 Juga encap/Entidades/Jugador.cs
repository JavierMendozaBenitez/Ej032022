using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        //private float promedioGoles;
        private int totalGoles;
                
        private Jugador()
        {
            this.partidosJugados = 0;
            //this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
            : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        //propiedades
            
            //solo lectura

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }


        public int TotalGoles
        {
            get { return this.totalGoles; }
        }

        public float PromedioGoles
        {
            get { return (float)this.totalGoles / this.partidosJugados; }
        }

        //lectura escritura

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }




       

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DNI: " + this.Dni);
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Partidos jugados: " + this.PartidosJugados);
            sb.AppendLine("Promedio de Goles: " + this.PromedioGoles.ToString());
            sb.AppendLine("Total de Goles: " + this.TotalGoles);

            return sb.ToString();
        }

        public static bool operator == (Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.dni == j2.dni);
        }
    }
}
