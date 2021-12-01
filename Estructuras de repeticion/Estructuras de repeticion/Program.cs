using System;

namespace Estructuras_de_repeticion
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Informar palabra argumento");
                return;
            }
            //for
            for(var indice = 0; indice < args.Length; indice++)
            {
                Console.WriteLine($"Estructura fue, indice y valor: {indice}, {args[indice]}");
            }

            //while
            var argumentoLeido = 0;
             while(argumentoLeido < args.Length)
            {
                Console.WriteLine($"Estructura while, argumentosLeidos y valor leido: {argumentoLeido}, {args[argumentoLeido]}"); argumentoLeido++;
            }

            //do while
            var loopefectuado = 0;
            do
            {
                Console.WriteLine($"Estructura do while, loopefectuado {loopefectuado} y valor leido {args[loopefectuado]}");
                loopefectuado++;
            } while (loopefectuado < args.Length);

            //foreach
            foreach(var arg in args)
            {
                Console.WriteLine($"Estructura foreach, valor leido {arg}");
            }
        }
    }
}
