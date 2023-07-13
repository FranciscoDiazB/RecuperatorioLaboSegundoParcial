using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Exceptions;

namespace Entidades
{

    public enum Tipo { Jugador, Administrador };

    public abstract class Usuario
    {

        private string nombreUsuario;
        private string contrasenia;
        private string email;
        private string tipoIngreso;
        private Tipo tipo;
        
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string Email { get => email; set => email = value; }
        public Tipo Tipo { get => tipo; set => tipo = value; }
        public string TipoIngreso { get => tipoIngreso; set => tipoIngreso = value; }

        public Usuario()
        {

        }

        public Usuario(string nombre, string contra, string mail, string tipo) : this(nombre, contra, mail)
        {
            tipoIngreso = tipo;
        }

        public Usuario(string nombre, string contra, string mail, Tipo tipoU) : this(nombre, contra, mail)
        {
            tipo = tipoU;
        }

        public Usuario(string nombre, string contra, string mail) : this(nombre, contra)
        {
            email = mail;
        }

        public Usuario(string nombre, string contra)
        {
            nombreUsuario = nombre;
            contrasenia = contra;
        }

        /// <summary>
        /// Recorre la lista de usuarios buscando la iteracion del usuario pasado por parametros.
        /// Devuelve desde la lista el usuario.
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="usuarioParaIngresar"></param>
        /// <returns></returns>
        /// <exception cref="UsuarioInvalidoException"></exception>
        public static Usuario DevolverUsuario(List<Usuario> lista, Usuario usuarioParaIngresar)
        {
            foreach(Usuario usuario in lista)
            {
                if(usuario == usuarioParaIngresar)
                {
                    return usuario;
                }
            }
            throw new UsuarioInvalidoException();
        }

        public abstract string MostrarUsuario();

        public static bool operator ==(Usuario u1, Usuario u2)
        {

            if(u1.NombreUsuario == u2.NombreUsuario && u1.contrasenia == u2.contrasenia)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);
        }

    }
}
