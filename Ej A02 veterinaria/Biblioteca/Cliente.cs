using System;
using System.Text;

namespace Biblioteca
{
    public class Cliente
    {
        private string Domicilio;
        private string nombre;
        private string apellido;
        private double telefono;
        private Mascotas[] mascotaLista;

        public Cliente (string domicilio, string nombre, string apellido, double telefono)
        {
            this.Domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.mascotaLista = new Mascotas[5];
        }

        public void agregarMascota(Mascotas mascotaAAgregar)
        {
            int contador = 0;

            for(int i = 0; i < this.mascotaLista.Length; i++)
            {
                //this.mascotaLista[i] != mascotaAAgregar && 
                if (contador == 0 && this.mascotaLista[i] is null)
                {
                    this.mascotaLista[i] = mascotaAAgregar;

                    contador = 1;
                }
            }
            contador = 0;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\n*****************************************");
            sb.AppendLine($"Domicilio: {this.Domicilio}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Telefono: " + this.telefono);
            sb.AppendLine($"\nDatos de la mascota");

            for (int i = 0; i < this.mascotaLista.Length; i++)
            {
                if(this.mascotaLista[i] is not null)
                {
                    sb.AppendLine($"\nMascota numero: {i}\n{this.mascotaLista[i].Mostrar()}");
                }
            }
            return sb.ToString();
        }
    }
}
