using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Foca : Marino
    {
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
            
        }
        public Foca() 
        {
            mensaje = "Hola... Soy una foca";
        }
    }
}
