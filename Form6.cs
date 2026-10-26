
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PROGRA_2_VERSION_FINAL
{
    public partial class Form6 : Form
    {
        readonly Random rng = new Random();

        string[] nombresJugadores = new string[2];
        int[] contAciertos = new int[2];
        int[] contErrores = new int[2];
        int[] niveles = new int[2] { 1, 1 };

        bool modoDosJugadores = false;
        int jugadorActual = 0;
        bool partidaFinalizada = false;

        int num1;
        int num2;
        char operador;
        decimal resultado;

        public Form6()
        {
            InitializeComponent();
            nombresJugadores[0] = "";
        }

        public Form6(string nombre)
        {
            InitializeComponent();
            nombresJugadores[0] = nombre;
        }

        public Form6(string nombre1, string nombre2)
        {
            InitializeComponent();
            nombresJugadores[0] = nombre1;
            nombresJugadores[1] = nombre2;
            modoDosJugadores = true;
        }

        void Form6_Load(object sender, EventArgs e)
        {
            ActualizarDatosJugadorActual();
            NuevaOperacion();
        }

        void NuevaOperacion()
        {
            int limiteSuperior;

            if (niveles[jugadorActual] == 1)
            {
                limiteSuperior = 11;
            }
            else if (niveles[jugadorActual] == 2)
            {
                limiteSuperior = 101;
            }
            else
            {
                limiteSuperior = 1001;
            }

            num1 = rng.Next(1, limiteSuperior);
            num2 = rng.Next(1, limiteSuperior);

            int tipoOperacion = rng.Next(1, 5);
            switch (tipoOperacion)
            {
                case 1:
                    operador = '+';
                    break;
                case 2:
                    operador = '-';
                    break;
                case 3:
                    operador = '*';
                    break;
                default:
                    operador = '/';
                    break;
            }

            resultado = CalcularResultado();

            lblNum1.Text = num1.ToString();
            lblNum2.Text = num2.ToString();
            lblOp.Text = operador.ToString();
            txtRespuestaOperacion.Clear();
            txtRespuestaOperacion.Focus();
        }

        decimal CalcularResultado()
        {
            switch (operador)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return (decimal)num1 / num2;
                default:
                    return 0;
            }
        }

        void ActualizarDatosJugadorActual()
        {
            if (modoDosJugadores)
            {
                lblNickname.Text = "Turno de: " + nombresJugadores[jugadorActual];
            }
            else
            {
                lblNickname.Text = "Jugador: " + nombresJugadores[0];
            }

            lblNivel.Text = "Nivel: " + niveles[jugadorActual].ToString();
            lblAciertos.Text = "Aciertos: " + contAciertos[jugadorActual].ToString();
            lblErrores.Text = "Errores: " + contErrores[jugadorActual].ToString();
        }

        void ActualizarNivelSiCorresponde()
        {
            if (contAciertos[jugadorActual] == 3 && niveles[jugadorActual] == 1)
            {
                niveles[jugadorActual] = 2;
                MessageBox.Show("¡Has avanzado al nivel 2!", "Cambio de nivel");
            }
            else if (contAciertos[jugadorActual] == 6 && niveles[jugadorActual] == 2)
            {
                niveles[jugadorActual] = 3;
                MessageBox.Show("¡Has avanzado al nivel 3!", "Cambio de nivel");
            }
        }

        void butConfirmarVentanaInterfazJuego_Click(object sender, EventArgs e)
        {
            if (partidaFinalizada)
            {
                return;
            }

            decimal respuestaUsuario;
            if (!decimal.TryParse(txtRespuestaOperacion.Text, out respuestaUsuario))
            {
                MessageBox.Show("Ingrese una respuesta numérica válida.", "Respuesta no válida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRespuestaOperacion.Focus();
                return;
            }

            if (respuestaUsuario == resultado)
            {
                contAciertos[jugadorActual]++;
                MessageBox.Show("¡Respuesta correcta!");
                ActualizarNivelSiCorresponde();
            }
            else
            {
                contErrores[jugadorActual]++;
                MessageBox.Show("Respuesta incorrecta.");
            }

            txtRespuestaOperacion.Clear();

            if (!modoDosJugadores && contErrores[0] >= 3)
            {
                FinalizarPartida();
                return;
            }

            if (modoDosJugadores && contErrores[0] >= 3 && contErrores[1] >= 3)
            {
                FinalizarPartida();
                return;
            }

            if (modoDosJugadores)
            {
                int otroJugador = 1 - jugadorActual;

                if (contErrores[jugadorActual] >= 3)
                {
                    jugadorActual = otroJugador;
                }
                else if (contErrores[otroJugador] < 3)
                {
                    jugadorActual = otroJugador;
                }
            }

            ActualizarDatosJugadorActual();
            NuevaOperacion();
        }

        void FinalizarPartida()
        {
            if (partidaFinalizada)
            {
                return;
            }

            partidaFinalizada = true;
            int resultadosNecesarios = modoDosJugadores ? 2 : 1;
            bool hayEspacio = Form1.HayEspacio(resultadosNecesarios);

            if (hayEspacio)
            {
                Form1.GuardarResultado(nombresJugadores[0], contAciertos[0]);

                if (modoDosJugadores)
                {
                    Form1.GuardarResultado(nombresJugadores[1], contAciertos[1]);
                }
            }

            if (modoDosJugadores)
            {
                string mensaje;
                if (contAciertos[0] > contAciertos[1])
                {
                    mensaje = "¡Ganó " + nombresJugadores[0] + "!";
                }
                else if (contAciertos[1] > contAciertos[0])
                {
                    mensaje = "¡Ganó " + nombresJugadores[1] + "!";
                }
                else
                {
                    mensaje = "La partida terminó en empate.";
                }

                mensaje += "\n\nPuntuación de " + nombresJugadores[0] + ": " + contAciertos[0];
                mensaje += "\nPuntuación de " + nombresJugadores[1] + ": " + contAciertos[1];
                MessageBox.Show(mensaje, "Partida terminada");
            }
            else
            {
                MessageBox.Show("Partida terminada.\nPuntuación final: " + contAciertos[0],
                    "Partida terminada");
            }

            if (!hayEspacio)
            {
                MessageBox.Show(
                    "La partida terminó, pero no se pudo guardar el resultado porque la tabla " +
                    "alcanzó su capacidad de 100 resultados.",
                    "Tabla de marcadores llena", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (Form1.Instancia != null)
            {
                Form1.Instancia.Show();
                Form1.Instancia.Activate();
            }

            this.Close();
        }

        void label2_Click(object sender, EventArgs e)
        {
        }

        void label4_Click(object sender, EventArgs e)
        {
        }

        void txtRespuestaOperacion_TextChanged(object sender, EventArgs e)
        {
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            if (Form1.Instancia != null && !Form1.Instancia.Visible)
            {
                Form1.Instancia.Show();
                Form1.Instancia.Activate();
            }
        }
    }
}