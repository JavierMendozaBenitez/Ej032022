using System;
using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return titular;
        }

        public decimal GetCantidad()
        {
            return cantidad;
        }

        public string mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(GetTitular());
            sb.AppendLine(GetCantidad().ToString());

            return sb.ToString();
        }

        public void ingresar(decimal monto)
        {
            if (monto > 0)
            {
                this.cantidad += monto;
            }
        }

        public void retirar(decimal monto)
        {
            this.cantidad -= monto;
        }
    }
}
