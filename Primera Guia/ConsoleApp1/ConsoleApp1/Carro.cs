using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Carro : Fabrica
    {
        public Carro(string Color, float Precio ) 
        {
            Llanta = 4;
            this.Color = Color;
            this.Precio = Precio;
        }
        public void MostrarCaracteristicas()
        {
            Console.WriteLine($"Esta carro tiene {Llanta} llantas, es de color: {Color} y cuenta: {Precio} dolares ");
        }
    }
}
