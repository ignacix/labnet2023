using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;


namespace Dominio
{
    public class Calculadora
    {
        public int DividirPorCero(int numero)
        {
			try
			{
				return numero/0;
			}
			catch (DivideByZeroException ex)
			{ 
				throw new Exception(ex.Message);
			}
			finally
			{
				Funciones.MensajeFinal("Se terminó de Realiazar la operación");
			}
        }

		public int Division(int dividendo, int divisor)
		{
			try
			{
				return dividendo/divisor;
			}
			catch (DivideByZeroException ex)
			{
				Funciones.MensajeFinal("NI JISUS PUEDE DIVIDIR POR CERO - .-");
				throw new DivideByZeroException(ex.Message);
			}

			finally
			{
                Funciones.MensajeFinal("Se terminó de Realiazar la operación");
            }
		}
    }
}
