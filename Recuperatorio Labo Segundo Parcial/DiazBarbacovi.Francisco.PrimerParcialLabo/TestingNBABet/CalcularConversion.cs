using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestingNBABet
{
    [TestClass]
    public class CalcularConversion
    {
        [TestMethod]
        public void CalcularConversionCon100Creditos()
        {
            float resultado = 2;
            int creditos = 100;
            float actual;

            actual = Sistema.CalcularConversion(creditos);

            Assert.AreEqual(resultado, actual);

        }

        [TestMethod]
        public void CalcularConversionCon154Creditos()
        {
            float resultado = (float)3.08;
            int creditos = 154;
            float actual;

            actual = Sistema.CalcularConversion(creditos);

            Assert.AreEqual(resultado, actual);

        }

        [TestMethod]
        public void CalcularConversionCon766Creditos()
        {
            float resultado = (float)15.32;
            int creditos = 766;
            float actual;

            actual = Sistema.CalcularConversion(creditos);

            Assert.AreEqual(resultado, actual);
        }
    }
}
