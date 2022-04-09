using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilioteca
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
        }

        public float GetArea()
        {
            int ancho = Math.Abs(vertice1.GetX() - vertice3.GetX()); // CALCULAMOS LA BASE
            int alto = Math.Abs(vertice1.GetY() - vertice3.GetY()); // CALCULAMOS LA ALTURA
            
            return ancho * alto;
        }

        public float GetPerimetro()
        {
            int ancho = Math.Abs(vertice1.GetX() - vertice3.GetX()); // CALCULAMOS LA BASE
            int alto = Math.Abs(vertice1.GetY() - vertice3.GetY()); // CALCULAMOS LA ALTURA
            
            return (ancho + alto) * 2;
        }

        public float Area()
        {
            if (this.area == 0)
            {
                this.area = this.GetArea();
            }
            return this.area;
        }

        public float Perimetro()
        {
            if (this.perimetro == 0)
            {
                this.perimetro = GetPerimetro();
            }
            return this.perimetro;
        }

    }
}
