using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }

        // redefino el metodo ToString
        public override string ToString()
        {
            return "Animal Domestico: " + Nombre; //de mio clase base devolve .toStrig

        }

    }
}
