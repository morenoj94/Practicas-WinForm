using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    internal class Producto
    {
        //- Codigo de articulo(3 digitos no correlativos)
        //- Precio
        //- Codigo de marca(del 1 al 10
        
        //declaro el atricuto codigo de articulo y el atributo preciocon la propiedad get y set.
        // forma reducida de escribir una propiedad estandar
        public int CodigoArticulo { get; set; }
        public float Precio { get; set; }

        //declaro el atributo codigo de marca de la forma normal
        private int CodigoMarca;
        //ahora declaro la propieda de la forma larga
        public int CodMarca 
        {
            get {return CodigoMarca;}
            //la propiedad set sera condicionada a que value tiene que estar entre 0 y 10
            //se puede hacer cualquier condicion o modificar la instruccion de get o de set como
            //se hara a continuacion.
            set 
            {
                if (value > 0 && value < 11)
                    CodigoMarca = value;
                else CodigoMarca = -1;
            }
        }
    }
}
