using System;

namespace ConsoleCalc
{
    class Program
    {
        static float RealizarOperacion(float primerNumero, float segundoNumero, string operador)
        {
            switch (operador)
            {
                case "+": return primerNumero + segundoNumero;
                case "-": return primerNumero - segundoNumero;
                case "*": return primerNumero * segundoNumero;
                case "/": return primerNumero / segundoNumero;
                case "%": return primerNumero % segundoNumero;
                default: return 0f;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe primer numero");
            var primerNumeroString = Console.ReadLine();
            float primerNumero;

            bool esPrimerNumeroValido = float.TryParse(primerNumeroString, out primerNumero);

            if(!esPrimerNumeroValido)
            {
                Console.WriteLine("Primer numero invalido");
                return;
            }

            Console.WriteLine("Informe segundo numero");
            var segundoNumeroString = Console.ReadLine();
            float segundoNumero;

            bool esSegundoNumeroValido = float.TryParse(segundoNumeroString, out segundoNumero);

            if (!esSegundoNumeroValido)
            {
                Console.WriteLine("Segundo numero invalido");
                return;
            }

            Console.WriteLine("Informe operador");
            var operador = Console.ReadLine();

            float resultado = RealizarOperacion(primerNumero, segundoNumero, operador);
            Console.WriteLine("Resultado: " + resultado);
        }

    }
}
