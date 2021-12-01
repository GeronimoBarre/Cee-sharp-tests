using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeProductos
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear lista de productos que nuestro mercado tiene
            List<string> productosDisponibles = new List<string>()
            {
                "pan", "leche", "manteca", "queso", "gaseosa", "arroz", "lechuga", "tomate", "pollo", "dulce"
            };
            //validar si los argumentos fueron completados
            try
            {
                //listar cuales productos informados del argumento hay en la lista del mercado
                var productosSeleccionados = productosDisponibles.Where(producto => args.Contains(producto)).ToList();
                foreach(var productoSeleccionado in productosSeleccionados)
                {
                    Console.WriteLine($"Este producto tenemos: {productoSeleccionado}");
                }
                //listar cuales productos informados no estan disponibles
                var productosNoDisponibles = args.Where(args => !productosDisponibles.Contains(args)).ToList();
                foreach(var productoNoDisponible in productosNoDisponibles)
                {
                    Console.WriteLine($"Este producto no tenemos: {productoNoDisponible}");
                }
                //devolver la lista de productos disponibles del mercado ordenados alfabeticamente
                var productosDisponiblesOrdenadosAlfabeto = productosDisponibles.OrderBy(e => e).ToList();
                foreach(var productoOrdenado in productosDisponiblesOrdenadosAlfabeto)
                {
                    Console.WriteLine($"Productos: {productoOrdenado}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Argumentos invalidos");
            }

        }
    }
}
