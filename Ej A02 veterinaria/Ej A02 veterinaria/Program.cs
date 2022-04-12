using System;
using Biblioteca;

namespace Ej_A02_veterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Cliente cliente1 = new Cliente("Av. Corrientes", "Javier", "Mendoza", 123456789);
            Mascotas perro1 = new Mascotas("Perro", "Coco", new DateTime(2020, 03, 11));

            Cliente cliente2 = new Cliente("Oslo 555", "Ana", "Peres", 554466);
            Mascotas gato1 = new Mascotas("Gato", "Lilu", new DateTime(2021, 02, 01));

            Cliente cliente3 = new Cliente("Camerún 45777", "Jorge", "Garcia", 99887744);
            Mascotas gato2 = new Mascotas("Gato", "Pedro", new DateTime(2000, 10, 22));
            Mascotas perro2 = new Mascotas("Perro", "Lobito", new DateTime(2010, 04, 30));


            cliente1.agregarMascota(perro1);

            cliente2.agregarMascota(gato1);
            gato1.SetVacunas("Vacuna Triple Felina");

            cliente3.agregarMascota(gato2);
            cliente3.agregarMascota(perro2);
            perro2.SetVacunas("Vacuna Contra La Rabia 1");
            perro2.SetVacunas("Vacuna Contra La Rabia 2");
            perro2.SetVacunas("Vacuna Contra La Rabia 3");


            Console.WriteLine("MOSTRANDO DATOS:\n");           

           
            Console.WriteLine("Clientes {0}\n{1}\n{2}", cliente1.Mostrar(), cliente2.Mostrar(), cliente3.Mostrar());
            
        }
    }
}
