using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeAnimales
    
{
    class Animal
    {
        public string Nombre { get; set; }
    }
    class Mamifero:Animal
    {
        public int CantidadDeMamas { get; set; }
    }
    class Reptil:Animal
    {
        public bool ControlaTemperatura { get; set; }
    }
    class Ave:Animal
    {
        public bool TienePlumas { get; set; } = true;
    }
    class Pez:Animal
    {
        public int CantidadDeAletas { get; set; }
    }
}
