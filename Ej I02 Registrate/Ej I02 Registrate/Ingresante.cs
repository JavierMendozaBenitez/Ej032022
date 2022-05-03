using System;
using System.Text;

namespace Ej_I02_Registrate
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.edad = edad;
            //this.cursos = new string[3];
            this.cursos = cursos;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Genero: {this.genero}");
            sb.AppendLine($"Pais: {this.pais}");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine($"Edad: { this.edad}");
            sb.AppendLine($"Curso/s:");
            for (int i = 0; i < this.cursos.Length; i++)
            {
                sb.AppendLine(this.cursos[i]);
            }
            

            return sb.ToString();
        }
    }
}
