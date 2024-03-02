using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona: Edad, Sueldo, Nombre
            Persona p1 = new Persona();
            p1.setEdad(20);
            Console.WriteLine("La edad de la persona es:" + p1.getEdad());

            Botella b1 = new Botella("Rojo","Plastico"); // new cosntructor
            b1.Capacidad = 200; //asigno a sed en la clase botella
            int algo = b1.Capacidad; //leer el valor de la capacidad y guardarlo en esa varible
            string alguito = b1.Material; // me guarda solo el get de botella
            Console.WriteLine("La capacidad de la botella es de: " + algo);

            Botella b2 = new Botella(); // botella con el constructor vacio


            Perro c1 = new Perro();
            c1.Nombre = "Canelo";
            string es = c1.Nombre;
            Console.WriteLine("El nombre de mi perro es: " + es);

            c1.Color = "Canela";
            //string col = c1.Color;
            Console.WriteLine("Su color es: " + c1.Color);


            Console.ReadKey();


        }
    }
}
