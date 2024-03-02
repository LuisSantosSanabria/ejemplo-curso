using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        //valores iniciales por ubica vez al principio
        public Botella(string color, string material)
        {
            this.color = color; // this es un apuntador que hace ref a la clase
            this.material = material; // yo punto material igual a material
        }

        //sobrecarga el contructor
        //creo el mismo contructor con diferentes caractristicas
        public Botella() { } // no recibe parametros y no contiene logica

        //Botella: Capacidad, Color, Material
        private int capacidad;
        private string color;
        private string material;
        public string Material
        {
            get { return material; }
        } 

        //Propiedad reemplaza get y el otro
        public int Capacidad
        {
            get { return capacidad; } //devolucion de ese valor
            set { capacidad = value; } //recepcion de ese valor y su pos asignacion
        }



    }
}