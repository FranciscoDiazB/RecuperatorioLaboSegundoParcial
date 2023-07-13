using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Entidades.Exceptions;

namespace TestingNBABet
{
    [TestClass]
    public class DevolverUsuario
    {
    
        [TestMethod]
        public void DevolverUsuarioExistenteEnLaLista()
        {
            List<Usuario> usas = new List<Usuario>();

            Usuario usario = new UsuarioLogin("Juan", "js190");
            Usuario usari2 = new UsuarioLogin("Jorge", "jr918");

            usas.Add(usario);
            usas.Add(usari2);

            Usuario user = new UsuarioJugador("Jorge", "jr918", "a@gmail.com", "1567091105678232", "Player");
            Usuario usuario;


            usuario = Usuario.DevolverUsuario(usas, (Usuario)user);

            Assert.AreEqual(usuario, usari2);

        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void DevolverExcepcionDeUsuarioInvalido()
        {
            List<Usuario> usas = new List<Usuario>();

            Usuario usario = new UsuarioLogin("Juan", "js190");
            Usuario usari2 = new UsuarioLogin("Jorge", "jr918");

            usas.Add(usario);
            usas.Add(usari2);

            Usuario user = new UsuarioJugador("Pedro", "2222", "basd@gmail.com", "19910091145618232", "Player");
            Usuario usuario;

            usuario = Usuario.DevolverUsuario(usas, (Usuario)user);

        }

    }
}
