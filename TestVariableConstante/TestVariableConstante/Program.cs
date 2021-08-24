using System;

namespace TestVariableConstante
{
    class Program
    {
        static void Main(string[] args)
        {
            const string constante = "una constante que no cambia";

            if (args.Length == 0)
            {
                Console.WriteLine("Por favor informar un numero entero");
                return;
            }

            int entero;
            bool test = int.TryParse(args[0], out entero);

            if (test == false)
            {
                Console.WriteLine("El argumento informado no es un numero entero");
                return;
            }

            Console.WriteLine(constante);
            Console.WriteLine("El numero informado fue: " + entero);
        }
    }
}
