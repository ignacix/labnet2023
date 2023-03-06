using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LabNet2023Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contOmni = 0;
            int contTaxi = 0;
            List<TransportePublico> lista = new List<TransportePublico>();

            while (contOmni < 5)
            {
                string omnibus;
                string cadena;
                int numero;
                bool esNumero;
                do
                {
                    omnibus = "Omnibus "+(contOmni + 1).ToString();
                    Console.WriteLine($"Cargue la Cantidad de pasajeros del {omnibus}");
                    Console.WriteLine("(mínimo 1 - máximo 30 pasajeros)");
                    cadena = Console.ReadLine();
                    esNumero = int.TryParse(cadena, out numero);
                    Console.Clear();
                } while ( (esNumero==false) || !((numero<=30)&&(numero>=1)) );
                Omnibus aux = new Omnibus(numero,omnibus);
                lista.Add(aux);

                contOmni++;
                
            }

            while (contTaxi < 5)
            {
                string taxi;
                string cadena;
                int numero;
                bool esNumero;
                do
                {
                    taxi = "Taxi " + (contTaxi + 1).ToString();
                    Console.WriteLine($"Cargue la Cantidad de pasajeros del {taxi}");
                    Console.WriteLine("(mínimo 1 - máximo 30 pasajeros)");
                    cadena = Console.ReadLine();
                    esNumero = int.TryParse(cadena, out numero);
                    Console.Clear();
                } while ((esNumero == false) || !((numero <= 30) && (numero >= 1)));
                Taxi aux = new Taxi(numero, taxi);
                lista.Add(aux);

                contTaxi++;

            }


            foreach (var x in lista)
            {
                Console.WriteLine(x.Informacion());
            }

            Console.ReadLine();


        }
    }
}
