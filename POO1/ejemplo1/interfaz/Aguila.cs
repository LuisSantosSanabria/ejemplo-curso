using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz
{
    internal class Aguila : AnimalSalvaje, Volar
    {
        public string volar()
        {
            return "Vuela como un pajaro";
        }
    }
}
