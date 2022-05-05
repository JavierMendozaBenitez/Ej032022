﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public long Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public Persona(long dni, string nombre)
            :this(nombre)
        {
            this.Dni = dni;            
        }

        public Persona (string nombre)
        {
            this.Nombre = nombre;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DNI: " + this.Dni);
            sb.AppendLine("Nombre: " + this.Nombre);

            return sb.ToString();
        }
    }
}
