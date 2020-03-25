using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string[] posibles = { "Gala", "Carlos", "Juan", "Silvio", "Suyai"};

            Console.WriteLine("Ingrese su nombre: ");
                nombre = Console.ReadLine();

            if (posibles.Contains(nombre)) {

                Console.WriteLine("Hola " + nombre);

            } else
            {
                Console.WriteLine("No te conozco");
            }

            Console.ReadKey();
        }
    }
}
