using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Perro
    {
        //Perro: Nombre, Color, Origen
        //Propiedades de la clase
        private string nombre;
        private string color;
        private string origen;

        // Se setea y se obtienen los valores de los atributos de la clase u objeto usando propiedades
        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Color 
        {
            get { return color; }
            set { color = value; }
        }
        public string Origen 
        {
            get { return origen; }
            set { origen = value; }
        }


    }
}
