using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaProductosConClasse.Clases
{
    class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public string ExhibirDatosProducto()
        {
            return $"Producto {Nombre} con valor de $ {Precio}";
        }
    }
}
