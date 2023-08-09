using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConVentanas
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public DateTime AnioNacimiento { get; set; }
        public string Chocolate { get; set; }
        public string Estatus { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string TiempoEnElPais { get; set; }
        public Persona() 
        {
            Nombre = "sin datos";
            AnioNacimiento = DateTime.Now;
            Chocolate = "Sin Datos";
            Estatus = "sin datos";
            TipoDocumento = "sin datos";
            NumeroDocumento = "sin datos";
            TiempoEnElPais = "sin datos";
        }
    }
}
