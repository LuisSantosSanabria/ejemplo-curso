using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Gato : AnimalDomestico
    {
        // Para que el metodo pueda ser overrride tiene que ser virtual
        // Desde la clase Animal
        public override string Comunicarse()
        {
            return "miau miau";
        }
    }
}
