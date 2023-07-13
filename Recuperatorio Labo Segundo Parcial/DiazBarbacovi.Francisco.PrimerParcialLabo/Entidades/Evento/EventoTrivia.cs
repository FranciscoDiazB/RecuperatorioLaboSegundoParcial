using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Evento
{
    public class EventoTrivia
    {

        public event Action respuestaTrivia;

        public event Action tiempoFinalizado;

        /// <summary>
        /// Invoca al delegado Respuesta Trivia
        /// </summary>
        public void NotificarRespuestaCorrecta()
        {
            respuestaTrivia?.Invoke();
        }

        /// <summary>
        /// Invoca al delegado Tiempo Finalizado
        /// </summary>
        public void NotificarTiempoFinalizado()
        {
            tiempoFinalizado?.Invoke();
        }

    }
}
