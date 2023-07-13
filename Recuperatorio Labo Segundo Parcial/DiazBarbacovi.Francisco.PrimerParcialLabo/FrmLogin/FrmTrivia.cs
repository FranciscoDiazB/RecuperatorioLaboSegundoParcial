using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;
using Entidades.Evento;
using Entidades.SQL;

namespace Vista
{
    public partial class FrmTrivia : Form
    {
        int numero;
        int timerRegresivo;
        EventoTrivia evento;
        Task cuentaRegresiva;
        bool botonApretado;
        UsuarioJugador user;

        public FrmTrivia()
        {
            InitializeComponent();       
        }

        public FrmTrivia(int numeroForm, UsuarioJugador usuario) : this()
        {
            numero = numeroForm;
            timerRegresivo = 20;
            evento = new EventoTrivia();
            cuentaRegresiva = new Task(CuentaRegresiva);
            botonApretado = false;
            user = usuario;
        }

        private void FrmTrivia_Load(object sender, EventArgs e)
        {
            switch (numero)
            {
                case 1:
                    CuestionarioUno();
                    break;

                case 2:
                    CuestionarioDos();
                    break;

                case 3:
                    CuestionarioTres();
                    break;
            }
            evento.respuestaTrivia += ColorFondo;
            evento.respuestaTrivia += MensajeAviso;

            evento.tiempoFinalizado += TiempoFinalizado;
            
            cuentaRegresiva.Start();
        }

        private void CuestionarioUno()
        {
            lblPregunta.Text = $"Que jugador de los siguientes, nunca gano un campeonato?";
            rbRespuestaUno.Text = $"Micheal Jordan";
            rbRespuestaDos.Text = $"Kobe Bryant";
            rbRespuestaTres.Text = $"Charles Barkley";
            rbRespuestaCuatro.Text = $"Danny Green";
        }

        private void CuestionarioDos()
        {
            lblPregunta.Text = $"Con que Equipo gano el ultimo Campeonato Lebron James?";
            rbRespuestaUno.Text = $"Cleveland Cavaliers";
            rbRespuestaDos.Text = $"Los Angeles Lakers";
            rbRespuestaTres.Text = $"Miami Heat";
            rbRespuestaCuatro.Text = $"Boston Celtics";
        }

        private void CuestionarioTres()
        {
            lblPregunta.Text = $"Que equipos grupo de equipos nunca ganaron un Campeonato?";
            rbRespuestaUno.Text = $"Brooklyn Nets, Denver Nuggets y Boston Celtics";
            rbRespuestaDos.Text = $"Toronto Raptors, Phoenix Suns y Milwaukee Bucks";
            rbRespuestaTres.Text = $"Charlotte Hornets, Utah Jazz y Philadelphia 76ers";
            rbRespuestaCuatro.Text = $"Orlando Magic, Los Angeles Clippers y Indiana Pacers";
        }

        private void CuentaRegresiva()
        {
            Task.Run(() =>
            {
                do
                {
                    RealizarCuentaRegresiva();
                    Thread.Sleep(1000);

                } while (timerRegresivo > 0 && !botonApretado);

            });
        }

        private void RealizarCuentaRegresiva()
        {
            if (this.InvokeRequired)
            {
                Action delegadoCuentaRegresiva = RealizarCuentaRegresiva;
                this.Invoke(delegadoCuentaRegresiva);
            }
            else
            {
                timerRegresivo -= 1;
                lblHorario.Text = timerRegresivo.ToString();
            }
        }

       
        void ColorFondo()
        {
            cuentaRegresiva.Wait();

            switch (numero)
            {
                case 1:

                    rbRespuestaTres.BackColor = Color.LimeGreen;

                    if (rbRespuestaUno.Checked == true)
                    {
                        CambiarColorFondo(1);
                    }
                    if (rbRespuestaDos.Checked == true)
                    {
                        CambiarColorFondo(2);
                    }
                    if (rbRespuestaCuatro.Checked == true)
                    {
                        CambiarColorFondo(4);
                    }
                    break;

                case 2:

                    rbRespuestaDos.BackColor = Color.LimeGreen;

                    if (rbRespuestaUno.Checked == true)
                    {
                        CambiarColorFondo(1);
                    }
                    if (rbRespuestaTres.Checked == true)
                    {
                        CambiarColorFondo(3);
                    }
                    if (rbRespuestaCuatro.Checked == true)
                    {
                        CambiarColorFondo(4);
                    }

                    break;

                case 3:

                    rbRespuestaCuatro.BackColor = Color.LimeGreen;

                    if (rbRespuestaUno.Checked == true)
                    {
                        CambiarColorFondo(1);
                    }
                    if (rbRespuestaTres.Checked == true)
                    {
                        CambiarColorFondo(3);
                    }
                    if (rbRespuestaDos.Checked == true)
                    {
                        CambiarColorFondo(2);
                    }

                    break;

            }
        }

        void MensajeAviso()
        {
            

            switch (numero)
            {
                case 1:
                    if (rbRespuestaTres.Checked == true)
                    {
                        MessageBox.Show("Ha respondido Correctamente", "Respuesta Correcta, Felicitaciones");
                    }
                    else
                    {
                        MessageBox.Show("Incorrecto. La respuesta correcta es 'Charles Barkley'", "Respuesta Incorrecta");
                    }
                    break;

                case 2:
                    if (rbRespuestaDos.Checked == true)
                    {
                        MessageBox.Show("Ha respondido Correctamente", "Respuesta Correcta, Felicitaciones");
                    }
                    else
                    {
                        MessageBox.Show("Incorrecto. La respuesta correcta es 'Los Angeles Lakers'", "Respuesta Incorrecta");
                    }
                    break;

                case 3:
                    if (rbRespuestaCuatro.Checked == true)
                    {
                        MessageBox.Show("Ha respondido Correctamente", "Respuesta Correcta, Felicitaciones");
                    }
                    else
                    {
                        MessageBox.Show("Incorrecto. Los equipos que nunca ganaron un campeonato son 'Orlando Magic, Los Angeles Clippers y Indiana Pacers'", "Respuesta Incorrecta");
                    }
                    break;
            }          
        }

        private void CambiarColorFondo(int respuesta)
        {
            if (respuesta == 1)
            {
                rbRespuestaUno.BackColor = Color.Red;
            }
            
            if(respuesta == 2)
            {
                rbRespuestaDos.BackColor = Color.Red;
            }

            if (respuesta == 3)
            {
                rbRespuestaTres.BackColor = Color.Red;
            }

            if (respuesta == 4)
            {
                rbRespuestaCuatro.BackColor = Color.Red;
            }
        }

        void TiempoFinalizado()
        {
            MessageBox.Show("Se termino el tiempo disponible para realizar la respuesta", "Tiempo Agotado");

            switch (numero)
            {
                case 1:
                    
                    rbRespuestaTres.BackColor = Color.LimeGreen;
                    CambiarColorFondo(1);
                    CambiarColorFondo(2);
                    CambiarColorFondo(4);

                    break;

                case 2:

                    rbRespuestaDos.BackColor = Color.LimeGreen;
                    CambiarColorFondo(1);
                    CambiarColorFondo(3);
                    CambiarColorFondo(4);

                    break;

                case 3:

                    rbRespuestaCuatro.BackColor = Color.LimeGreen;
                    CambiarColorFondo(1);
                    CambiarColorFondo(2);
                    CambiarColorFondo(3);

                    break;
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            botonApretado = true;
            this.Close();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            evento.NotificarRespuestaCorrecta();

            LogsActividadDB dB = new LogsActividadDB();

            dB.Agregar(user, "El Usuario Realizo una Apuesta de Jugadores del Oeste");

            btnResponder.Enabled = false;
            botonApretado = true;
        }

        private void lblHorario_TextChanged(object sender, EventArgs e)
        {
            if(lblHorario.Text == "0")
            {
                evento.NotificarTiempoFinalizado();
            }
        }
    }
}
