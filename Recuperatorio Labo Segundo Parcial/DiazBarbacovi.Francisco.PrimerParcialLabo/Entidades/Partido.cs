using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partido
    {
        DateTime fechaDeJuego;
        int numeroDeJuego;
        int idPartido;
        bool partidoFinalizado;
        string juegaEquipoLocal;
        string juegaEquipoVisitante;

        public DateTime FechaDeJuego { get => fechaDeJuego; set => fechaDeJuego = value; }
        public int NumeroDeJuego { get => numeroDeJuego; set => numeroDeJuego = value; }
        public int IdPartido { get => idPartido; set => idPartido = value; }
        public bool PartidoFinalizado { get => partidoFinalizado; set => partidoFinalizado = value; }
        public string JuegaEquipoLocal { get => juegaEquipoLocal; set => juegaEquipoLocal = value; }
        public string JuegaEquipoVisitante { get => juegaEquipoVisitante; set => juegaEquipoVisitante = value; }

        public Partido()
        {

        }


        public Partido(int id, string equipoL, string equipoV, DateTime fecha, int numeroJ) : this(equipoL, equipoV, fecha, numeroJ)
        {
            idPartido = id;
        }

        public Partido(string equipoL, string equipoV, DateTime fecha, int numeroJ)
        {
            juegaEquipoLocal = equipoL;
            juegaEquipoVisitante = equipoV;
            fechaDeJuego = fecha;
            numeroDeJuego = numeroJ;
            partidoFinalizado = false;
        }

        public override string ToString()
        {    
            return $"{idPartido} Juego {numeroDeJuego}: {juegaEquipoLocal} vs {juegaEquipoVisitante} - Fecha y Horario: {fechaDeJuego}";  
        }

        public static bool operator ==(Partido p1, Partido p2)
        {

            if (p1.idPartido == p2.idPartido)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Partido p1, Partido p2)
        {
            return !(p1 == p2);
        }

    }
}
