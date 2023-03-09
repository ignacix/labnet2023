using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        [TestMethod()]
        public void DivisionTest()
        {
            int dividendo = 50;
            int divisor = 2;
            int resultado;
            int resultadoDeseado = 25;

            Calculadora calculadora = new Calculadora();

            resultado = calculadora.Division(dividendo, divisor);

            Assert.AreEqual(resultadoDeseado, resultado);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void SiDividoPorCeroTest() 
        {
            int dividendo = 50;
            int divisor = 0;           
            Calculadora calculadora = new Calculadora();
            calculadora.Division(dividendo,divisor);
        }
    }
}