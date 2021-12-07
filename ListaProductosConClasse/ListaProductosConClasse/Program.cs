using ListaProductosConClasse.Clases;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaProductosConClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productosDisponibles = new List<Producto>();
            productosDisponibles.Add(new Producto() { Nombre = "Pan", Precio = 0.5});
            productosDisponibles.Add(new Producto() { Nombre = "Shampoo", Precio = 19.90 });
            productosDisponibles.Add(new Producto() { Nombre = "Aceite", Precio = 8 });
            productosDisponibles.Add(new Producto() { Nombre = "Fernet", Precio = 90.90 });
            productosDisponibles.Add(new Producto() { Nombre = "Alverjas", Precio = 10 });
            productosDisponibles.Add(new Producto() { Nombre = "Chocolate", Precio = 14.70 });
            productosDisponibles.Add(new Producto() { Nombre = "Gaseosa", Precio = 9.99 });

            if(args.Length == 0)
            {
                Console.WriteLine("Cuales productos querés pibe?");
                return;
            }
            var productosSeleccionadosDisponibles = productosDisponibles.Where(producto => args.Any(args => producto.Nombre.ToUpper() == args.ToUpper()));
                
            foreach(var producto in productosSeleccionadosDisponibles)
            {
                Console.WriteLine($"Tenemos el {producto.ExhibirDatosProducto()}");
            }
            var productosSeleccionadosNoDisponibles = args.Where(args => !productosDisponibles.Any(producto => producto.Nombre.ToUpper() == args.ToUpper()));

            foreach(var productoNoDisponible in productosSeleccionadosNoDisponibles)
            {
                Console.WriteLine($"No tenemos {productoNoDisponible}");
            }
            var productosOrdenadosPorNombre = productosDisponibles.OrderBy(producto => producto.Nombre).ToList();
            foreach(var productoOrdenado in productosOrdenadosPorNombre)
            {
                Console.WriteLine(productoOrdenado.ExhibirDatosProducto());
            }
        }
    }
}
