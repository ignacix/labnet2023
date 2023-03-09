using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LabNet2023Project02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1
            try
            {
                string input;
                int numero;
                bool esNumero=false;
                Calculadora calculadora = new Calculadora();
                do
                {
                    Console.WriteLine("Ingrese un número");
                    input = Console.ReadLine();
                    esNumero = int.TryParse(input, out numero);
                    Console.Clear();
                } while (esNumero == false);
                Console.WriteLine(calculadora.DividirPorCero(numero));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

            //Ejercicio 2
            int dividendo;
            int divisor;
            try
            {
                Console.WriteLine("ingrese el dividendo (el numero que quiere dividir)");
                dividendo = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el divisor (el número por el que va a dividir)");
                divisor = int.Parse(Console.ReadLine());
                Calculadora calculadora1 = new Calculadora();
                Console.WriteLine(calculadora1.Division(dividendo, divisor));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Seguro ingresó una letra o no ingresó nada - .-");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

            //Ejercicio 3
            try
            {
                Logic aux = new Logic();
                aux.DisparoEscepcion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name.ToString());
                Console.WriteLine(ex.Message);
            }                       
            Console.ReadLine();

            //Ejercicio 4
            try
            {
                Logic aux =new Logic();
                aux.DisparoExcepcionPersonalizada();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name.ToString());
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
