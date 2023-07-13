using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestingNBABet
{
    [TestClass]
    public class TotalDepositado
    {
        [TestMethod]
        public void CalcularTotalDepositadoCon75Creditos()
        {
            float resultado = (float)1.35;
            int creditos = 75;
            float actual;

            actual = Sistema.TotalDepositadoDinero(creditos);

            Assert.AreEqual(resultado, actual);

        }

        [TestMethod]
        public void CalcularTotalDepositadoCon235Creditos()
        {
            float resultado = (float)4.23;
            int creditos = 235;
            float actual;

            actual = Sistema.TotalDepositadoDinero(creditos);

            Assert.AreEqual(resultado, actual);

        }

        [TestMethod]
        public void CalcularTotalDepositadoCon1009Creditos()
        {
            float resultado = (float)18.162;
            int creditos = 1009;
            float actual;

            actual = Sistema.TotalDepositadoDinero(creditos);

            Assert.AreEqual(resultado, actual);
        }
    }
}
