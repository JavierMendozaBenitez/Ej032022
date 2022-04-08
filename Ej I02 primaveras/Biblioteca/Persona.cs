using System;
using System.Text;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private double dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, double dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public DateTime GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }

        public void SetFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public double GetDni()
        {
            return this.dni;
        }

        public void SetDni(double dni)
        {
            this.dni = dni;
        }

        private double CalcularEdad()
        {
            DateTime hoy = DateTime.Today;

            double edad;

            edad = hoy.Year - this.fechaDeNacimiento.Year;
            
            return edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("***********************************");
            sb.AppendLine("Datos de la persona:\n");
            sb.AppendLine($"Nombre: {GetNombre()}");
            sb.AppendLine($"Fecha de nacimiento: {GetFechaDeNacimiento().ToString()}");
            sb.AppendLine($"Dni: {GetDni().ToString()}");
            sb.AppendLine($"Edad actual: {CalcularEdad().ToString()}");

            return sb.ToString();
        }

        public string EsMayorDeEdad()
        {
            if(CalcularEdad() >= 18)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor";
            }
        }
    }
}
