using Entities;
using Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2023Project03
{
    internal class Program
    {       
        static void Main(string[] args)
        {            
            int opcion = pidoUnNumero();

            while (opcion != 4) 
            {
                switch (opcion)
                {
                    case 1:
                        mostrarCategories();
                        break;
                    case 2:
                        mostrarShippers();
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                }                
                opcion = pidoUnNumero();
            }            
        }
        static void mostrarCategories()
        {
            CategoriesLogic categories = new CategoriesLogic();

            foreach (var category in categories.GetAll())
            {
                Console.WriteLine($"{category.CategoryName}: {category.Description}");
            }
        }
        static void mostrarShippers()
        {
            ShippersLogic shippers = new ShippersLogic();

            foreach (var Shipper in shippers.GetAll())
            {
                Console.WriteLine($"{Shipper.CompanyName} , {Shipper.Phone}");
            }
        }

        static string mostrarMenu()
        {
            string menu = "\n\tMENÚ\n" +
                "\n1)  TRAEME LAS CATEGORIES \n" +
                "2)  TRAEME LOS SHIPPERS \n" +
                "4)  SALIR \n" +
                "\nSeleccione una opción";
            return menu;
        }

        static int  pidoUnNumero()
        {
            int opcion;
            string stringNumero;
            bool esNumero = false;
            do
            {
                Console.WriteLine(mostrarMenu());
                stringNumero = Console.ReadLine();
                esNumero = int.TryParse(stringNumero, out opcion);
                Console.Clear();
            } while (esNumero == false);
            return opcion;
        }

    }
}
