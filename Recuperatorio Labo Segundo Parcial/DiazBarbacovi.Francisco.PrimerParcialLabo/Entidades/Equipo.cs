using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Locacion
    {
        LA, Boston, Miami, Minnesota, Sacramento, GS, Denver, Philadelphia, Milwaukee, NY, Brooklyn, Atlanta, Cleveland, Memphis, Phoenix
    }

    public class Equipo
    {
        string nombreEquipo;
        Locacion locacionEquipo; 

        public Equipo()
        {

        }
        
        public Equipo(string nombreDelEquipo, Locacion locacionDelEquipo)
        {
            nombreEquipo = nombreDelEquipo;
            locacionEquipo = locacionDelEquipo;
        }

        public string NombreEquipo { get => nombreEquipo; set => nombreEquipo = value; }
        public Locacion LocacionEquipo { get => locacionEquipo; set => locacionEquipo = value; }

        public override string ToString()
        {
            return $"{LocacionEquipo} {NombreEquipo}";
        }
    }
}
