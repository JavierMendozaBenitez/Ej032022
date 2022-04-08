using System;
using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta (string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        //Devuelve el atributo
        public string GetTitular()
        {
            return this.titular;
        }

        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(GetTitular());
            sb.AppendLine(GetCantidad().ToString());

            return sb.ToString();
        }

        public string Mostrar2()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(GetTitular());
            sb.Append(GetCantidad().ToString());

            return sb.ToString();
        }

        public void Ingresar(decimal montoAAcreditar)
        {
            if(montoAAcreditar > 0)
            {
                this.cantidad += montoAAcreditar;
            }
        }

        public void Retirar(decimal montoADebitar)
        {
            this.cantidad -= montoADebitar;
        }
    }
}
