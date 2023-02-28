using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2023Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Por favor, Ingrese su nombre.");
            nombre = Console.ReadLine();
            Console.Clear();
            while (nombre == "")
            {
                Console.WriteLine("Por favor, Ingrese su nombre.");
                nombre = Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine($"Hello, {nombre}!!");
            Console.ReadLine();
        }
    }
}
