using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        //Persona: Edad, Sueldo, Nombre
        //Atributos o miembros: guardar inf de esa persona
        private int edad;
        private float sueldo;
      

        public void setEdad(int e)
        {
            edad = e;
        }
        
        //obtener el valor
        public int getEdad()
        {
            return edad;
        }
        // modificadores: private y public
    }
}
