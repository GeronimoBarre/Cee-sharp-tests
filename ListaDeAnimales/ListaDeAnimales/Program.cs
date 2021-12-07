using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeAnimales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe nombre de un animal");
            var nombreAnimal = Console.ReadLine();
            if(string.IsNullOrEmpty(nombreAnimal) || string.IsNullOrWhiteSpace(nombreAnimal))
            {
                Console.WriteLine("Pase un nombre de animal vertebrado valido");
                return;
            }
            var listaDeAnimales = new List<Animal>();
            listaDeAnimales.Add(new Mamifero() { Nombre = "Vaca", CantidadDeMamas = 4 });
            listaDeAnimales.Add(new Reptil() { Nombre = "Cobra", ControlaTemperatura = false });
            listaDeAnimales.Add(new Ave() { Nombre = "Gaviota" });
            listaDeAnimales.Add(new Pez() { Nombre = "Tiburon", CantidadDeAletas = 2 });
            var animalSeleccionado = listaDeAnimales.FirstOrDefault(animal => animal.Nombre.ToUpper() == nombreAnimal.ToUpper());
            if(animalSeleccionado == null)
            {
                Console.WriteLine("El animal no esta en la lista");
                return;
            }
            if(animalSeleccionado is Mamifero)
            {
                Console.WriteLine($"El animal encontrado es un mamifero con nombre {animalSeleccionado.Nombre} y cantidad de mamas es {((Mamifero)animalSeleccionado).CantidadDeMamas}");
            }else if(animalSeleccionado is Reptil)
            {
                Console.WriteLine($"El animal encontrado es un reptil con nombre {animalSeleccionado.Nombre} y su control de temperatura es {((Reptil)animalSeleccionado).ControlaTemperatura}");
            }
            else if (animalSeleccionado is Ave)
            {
                Console.WriteLine($"El animal encontrado es una ave con nombre {animalSeleccionado.Nombre} y su plumaje es {((Ave)animalSeleccionado).TienePlumas}");
            }
            else if (animalSeleccionado is Pez)
            {
                Console.WriteLine($"El animal encontrado es un pez con nombre {animalSeleccionado.Nombre} y su cantidad de aletas es {((Pez)animalSeleccionado).CantidadDeAletas}");
            }
            else
            {
                Console.WriteLine($"El animal encontrado es un animal llamado {animalSeleccionado.Nombre}");
            }
        }
    }
}
