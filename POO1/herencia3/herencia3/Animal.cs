using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Animal
    {
        // Para que el metodo pueda ser overrride tiene que ser virtual
        public virtual string Comunicarse()
        {
            return "Ruido...";
        }
    }
}
