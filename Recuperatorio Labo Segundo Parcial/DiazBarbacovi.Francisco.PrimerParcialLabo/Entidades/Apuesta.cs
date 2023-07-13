using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Apuesta
    {

        string nombreJugador;
        string equipoJugador;
        int creditosApostados;
        DateTime fecha;
        int idPartido;

        public Apuesta()
        {

        }

        public Apuesta(string nombre, string equipo, int creditos, DateTime fec, int id)
        {
            this.nombreJugador = nombre;
            this.equipoJugador = equipo;
            this.creditosApostados = creditos;
            this.fecha = fec;
            this.idPartido = id;
        }

        public string NombreJugador { get => nombreJugador; set => nombreJugador = value; }
        public string EquipoGanador { get => equipoJugador; set => equipoJugador = value; }
        public int CreditosApostados { get => creditosApostados; set => creditosApostados = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdPartido { get => idPartido; set => idPartido = value; }

        /// <summary>
        /// Sobreescritura del metodo heredado de Object de ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Partido Apostado Id: {idPartido} - Usuario: {nombreJugador} - Equipo Apostado: {equipoJugador} - " +
                $"Creditos Apostados: {creditosApostados} - Fecha: {fecha}";
        }

    }
}
