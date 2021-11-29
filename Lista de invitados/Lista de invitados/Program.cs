using System;

namespace Lista_de_invitados
{
    class Program
    {
        private static string[] ListaDeInvitados = {

        };
        static void Main(string[] args)
        {
            Console.WriteLine("Informe el nombre del invitado:");
            var nombre = Console.ReadLine();

            if (nombre == null || string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("El nombre no ha sido informado");
                return;
            }

            Console.WriteLine("Informe la edad del invitado");
            var edadString = Console.ReadLine();
            int edad;

            bool edadInformada = int.TryParse(edadString, out edad);

            if(edadInformada == false)
            {
                Console.WriteLine("Edad no informada o invalida");
                return;
            }

            bool estaInvitado;
            switch (nombre)
            {
                case "Geronimo": //0
                    estaInvitado = true;
                    break;
                case "Alejandro":
                    estaInvitado = true;
                    break;
                case "Tu Mama":
                    estaInvitado = true;
                    break;
                case "Freeman":
                    estaInvitado = true;
                    break;
                case "Tyrone":
                    estaInvitado = true;
                    break;
                case "Johnny":
                    estaInvitado = true;
                    break;
                case "Dude":
                    estaInvitado = true;
                    break;
                default:
                    estaInvitado = false;
                    break;
            }

            if(estaInvitado == true && edad > 18)
            {
                Console.WriteLine("Bienvendido");
            }
            else if(estaInvitado == false)
            {
                Console.WriteLine("No esta invitado");
            }
            else
            {
                Console.WriteLine("Edad no satisfactoria");
            }
        }
    }
}
