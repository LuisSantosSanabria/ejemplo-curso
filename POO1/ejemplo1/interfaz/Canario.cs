using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz
{
    internal class Canario : AnimalDomestico, Volar
    {
        public string volar()
        {
            return "Vuela como todos los pajaros";
        }
    }
}
