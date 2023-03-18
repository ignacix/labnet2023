using Entities;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2023Project04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mostrarMenu = true;

            while (mostrarMenu)
            {               
                mostrarMenu = Menu();
            }
        }

        private static bool Menu()
        {           
            Console.Clear();

            string input;
            int numero;
            bool esNumero = false;
            do
            {
                Console.WriteLine("\n MENÚ" +
                        "\n 1)  1. Query para devolver objeto customer" +
                        "\n 2)  2. Query para devolver todos los productos sin stock" +
                        "\n 3)  3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad" +
                        "\n 4)  4. Query para devolver todos los customers de la Región WA" +
                        "\n 5)  5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789" +
                        "\n 6)  6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula." +
                        "\n 7)  7. Query para devolver Join entre Customers y Orders donde los customers sean de la Región WA y la fecha de orden sea mayor a 1/1/1997." +
                        "\n 8)  SALIR ");
                Console.WriteLine("Seleccione una opción:");             
                input = Console.ReadLine();
                esNumero = int.TryParse(input, out numero);
                Console.Clear();
            } while (esNumero == false);

            switch (numero)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("elegiste 1");

                    CustomersLogic customersLogic = new CustomersLogic();
                    IEnumerable<Customers> customer = customersLogic.GetAll();                    
                    var query = from cust in customer select cust;
                    
                    foreach (var item in query)
                    {
                        Console.WriteLine(item.CustomerID);
                    }
                    
                    Console.ReadLine();                     
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("elegiste 2");
                    
                    ProductsLogic productsLogic = new ProductsLogic();
                    IEnumerable<Products> products = productsLogic.GetAll();
                    var query2 = products.Where(p=>(p.UnitsInStock)==0);

                    foreach (var item in query2)
                    {
                        Console.WriteLine(item.ProductName);
                    }

                    Console.ReadLine();                    
                    break;
                case 3:
                    Console.WriteLine("elegiste3");

                    ProductsLogic productsLogic2 = new ProductsLogic();
                    IEnumerable<Products> products2 = productsLogic2.GetAll();

                    var query3 = products2.Where(p => (((p.UnitPrice) > 3) && ((p.UnitsInStock) >= 1 )));
                    
                    foreach (var item in query3)
                    {
                        Console.WriteLine(item.ProductName);
                    }

                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("elegiste4");

                    CustomersLogic customersLogic2 = new CustomersLogic();
                    IEnumerable<Customers> customer2 = customersLogic2.GetAll();
                    var query4 = from cust2 in customer2 where cust2.Region == "WA" select cust2;

                    foreach (var item in query4)
                    {
                        Console.WriteLine(item.ContactName);
                    }

                    Console.ReadLine();

                    break;

                case 5:
                    Console.WriteLine("elegiste3");
                    
                    ProductsLogic productsLogic3 = new ProductsLogic();
                    IEnumerable<Products> products3 = productsLogic3.GetAll();

                     
                     var query5 = products3.First();

                    foreach (var item in query5.ProductName)
                    {
                        Console.WriteLine(item);
                    }

                    break;
                case 6:
                    Console.WriteLine("elegiste3");

                    CustomersLogic customersLogic3 = new CustomersLogic();
                    IEnumerable<Customers> customer3 = customersLogic3.GetAll();
                    var query6 = from cust3 in customer3 select cust3;

                    for (int i = 0; i <2; i++)
                    {
                        foreach (var item in query6)
                        {
                            if(i==0)
                            {
                                Console.WriteLine(item.ContactName.ToUpper());                                
                            }
                            else{
                                Console.WriteLine(item.ContactName);
                            }                                                        
                        }
                    }                
                    Console.ReadLine();

                    break;

                case 7:
                    Console.WriteLine("elegiste3");
                    
                    break;

                case 8:
                    Console.WriteLine("elegiste3");
                    return false;
                    break;
            }     
            return true;
        }
    }
}
