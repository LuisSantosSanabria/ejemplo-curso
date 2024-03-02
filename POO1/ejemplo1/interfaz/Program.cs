using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // crear una lista de animales que puedan volar
            List<Volar> listavoladores = new List<Volar>();
            listavoladores.Add(new Canario());
            listavoladores.Add(new Aguila());
            //listavoladores.Add(new Perro());
            //no puedo agregar perro xq en mi arquitectura de clases mi perro no vuela
            
            // Acceder al primer elemento de la lista (el águila) y hacerla volar
            Volar volador = listavoladores[0];
            Console.WriteLine(volador.volar());

            Console.ReadKey();
        }
    }
}
