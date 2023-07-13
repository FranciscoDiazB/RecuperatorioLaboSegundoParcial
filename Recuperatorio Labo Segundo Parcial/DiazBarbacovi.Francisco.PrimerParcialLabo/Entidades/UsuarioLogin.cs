using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioLogin : Usuario
    {
        public UsuarioLogin(string nombre, string contra) : base(nombre, contra)
        {

        }

        public override string MostrarUsuario()
        {
            throw new NotImplementedException();
        }
    }
}
