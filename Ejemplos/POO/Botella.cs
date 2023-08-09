using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Botella
    {
        //Capacidad maxima: 100
        //Cantidad inicial: 0
        //Metodo de recarga: carga al 100 y devuelve el costo de recarga. 50 cada 100

        // botella: capacidad, color, material
        //Propiedades de la clase
        private int capacidad, cantidadActual;
        private string color, material;

        // Se setea y se obtienen los valores de los atributos de la clase usando metodos 
        public string Material { get; }
        public int Capacidad
        {
            get { return capacidad; }
        }
        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        //Se hace el constructor del objeto botella y se le da el color y el material
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }

        //Metodo
        public float recargar(int cantidadRecargar)
        {

            cantidadActual += cantidadRecargar;
            //100  50
            //canrec ? 
            float monto = cantidadRecargar * 50f / capacidad; 
            return monto;
        }

        
        
    }
}
