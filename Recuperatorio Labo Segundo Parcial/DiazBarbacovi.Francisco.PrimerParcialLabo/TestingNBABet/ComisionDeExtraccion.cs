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
    public class ComisionDeExtraccion
    {
        [TestMethod]
        public void ComisionDeExtraccionDe100Creditos()
        {
            float resultado = (float)0.2;
            int creditos = 100;
            float actual;

            actual = Sistema.ComisionDeExtraccion(creditos);

            Assert.AreEqual(resultado, actual);
        }

        [TestMethod]
        public void ComisionDeExtraccionDe275Creditos()
        {
            float resultado = (float)0.55;
            int creditos = 275;
            float actual;

            actual = Sistema.ComisionDeExtraccion(creditos);

            Assert.AreEqual(resultado, actual);
        }


        [TestMethod]
        public void ComisionDeExtraccionDe1358Creditos()
        {
            float resultado = (float)2.716;
            int creditos = 1358;
            float actual;

            actual = Sistema.ComisionDeExtraccion(creditos);

            Assert.AreEqual(resultado, actual);
        }
    }
}
