using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Perro
    {
        private string nombre;
        private string color;
        private string origrn;

        public string Nombre
        {
            get { return nombre; } //devolucion de ese valor
            set { nombre = value; } //recepcion de ese valor y su pos asignacion
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
