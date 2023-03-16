using Entities;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2023Project03
{
    internal class Program
    {       
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("\n MENÚ" +
                    "\n 1)  TRAEME LAS CATEGORIES " +
                    "\n 2)  TRAEME LOS SHIPPERS " +
                    "\n 4)  SALIR ");
            Console.WriteLine("Seleccione una opción");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            while (opcion != 4) 
            {
                switch (opcion)
                {
                    case 1:
                        logica1 ();
                        break;
                    case 2:
                        logica2();
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                }

                Console.WriteLine("\n MENÚ" +
                        "\n 1)  TRAEME LAS CATEGORIES " +
                        "\n 2)  TRAEME LOS SHIPPERS " +
                        "\n 4)  SALIR ");
                Console.WriteLine("Seleccione una opción");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
            }            
        }
        static void logica1()
        {
            CategoriesLogic categories = new CategoriesLogic();

            foreach (var category in categories.GetAll())
            {
                Console.WriteLine($"{category.CategoryName}: {category.Description}");
            }
        }
        static void logica2()
        {
            ShippersLogic shippers = new ShippersLogic();

            foreach (var Shipper in shippers.GetAll())
            {
                Console.WriteLine($"{Shipper.CompanyName} , {Shipper.Phone}");
            }
        }

    }
}
