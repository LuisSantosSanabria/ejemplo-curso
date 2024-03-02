using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AnimalDomestico a1 = new AnimalDomestico();
            //a1.Nombre = "Pepe";
            Gato g1 = new Gato();
            g1.Nombre = "Pepe";

            Perro p1 = new Perro();
            p1.Nombre = "Canelo";

            // lista de animales
            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(g1);
            animales.Add(new Pez()); //la instacia que creo la estoy
            animales.Add(new Canario()); //ubicando directamente a una 
            animales.Add(new Aguila()); //ubicacion de la lista
            animales.Add(new Gato());
            animales.Add(new Tigre());
            // NO van a poder ser accedidos desde otro lado que no sea esta lista
            // a menos que cree una variable y la guarde ahi
            // Animal a1 = g1; // la jerarquia es de abajo para arriba
            // Gato g8 = (Gato)a1; // casteo explicito le aseguro que hay un gato
            // Console.WriteLine(g8);

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.Comunicarse()); //cada obj se va comunicar como sabe comunicarse
                //Polimorfismo
            }

            //Console.WriteLine(a1.ToString()); //ya redifi el contenido de ToString
            Console.WriteLine(g1.Comunicarse());
            Console.WriteLine(p1.Comunicarse());

            Console.ReadKey();
        }
    }
}
