using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Moto : Fabrica
    {
        public Moto(string Color, float Precio) 
        {
            Llanta = 2;
            this.Color = Color;
            this.Precio = Precio;
        }

        public void MostrarCaracteristicas() 
        {
            Console.WriteLine($"Esta moto tiene {Llanta} llantas, es de color: {Color} y cuenta: {Precio} dolares ");
        }
    }
}
