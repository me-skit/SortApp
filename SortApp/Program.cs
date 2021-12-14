using System;
using System.Collections.Generic;

namespace SortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> clients = new List<string>();
            string nombre = null;
            char again;

            do
            {
                Console.Write("Ingrese el nombre de un cliente: ");
                nombre = Console.ReadLine();
                clients.Add(nombre.ToUpper());

                again = 'x';
                while (again != 'S' && again != 's' && again != 'N' && again != 'n')
                {
                    Console.Write("Desea ingresar otro nombre (S/N)?: ");
                    again = Console.ReadLine()[0];
                }

            } while (again == 'S' || again == 's');
            Console.WriteLine("");

            clients.ForEach(name =>
            {
                if (name.Contains("RE"))
                {
                    Console.WriteLine(name);
                }
            });

            Console.Write("Ejecución finalizada, precione cualquier tecla");
            Console.ReadKey();
        }
    }
}
