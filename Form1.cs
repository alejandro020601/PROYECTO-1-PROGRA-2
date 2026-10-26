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
    public partial class Form1 : Form
    {
        public static Form1 Instancia { get; set; }

        public static string[] nombresMarcadores = new string[100];
        public static int[] puntuacionesMarcadores = new int[100];
        public static int cantidadResultados = 0;

        public Form1()
        {
            InitializeComponent();
            Instancia = this;
        }

        void butJugar_Click(object sender, EventArgs e)
        {
            Form2 seleccionModo = new Form2();
            seleccionModo.Show();
            this.Hide();
        }

        void butTablaMarcadores_Click(object sender, EventArgs e)
        {
            Form3 tablaMarcadores = new Form3();
            tablaMarcadores.Show();
            this.Hide();
        }

        public static bool HayEspacio(int cantidadNecesaria)
        {
            return cantidadResultados + cantidadNecesaria <= nombresMarcadores.Length;
        }

        public static bool GuardarResultado(string nombre, int puntuacion)
        {
            if (!HayEspacio(1))
            {
                return false;
            }

            nombresMarcadores[cantidadResultados] = nombre;
            puntuacionesMarcadores[cantidadResultados] = puntuacion;
            cantidadResultados++;
            return true;
        }

        public static void OrdenarMarcadores()
        {
            for (int i = 0; i < cantidadResultados - 1; i++)
            {
                for (int j = 0; j < cantidadResultados - 1 - i; j++)
                {
                    if (puntuacionesMarcadores[j] < puntuacionesMarcadores[j + 1])
                    {
                        int puntuacionTemporal = puntuacionesMarcadores[j];
                        puntuacionesMarcadores[j] = puntuacionesMarcadores[j + 1];
                        puntuacionesMarcadores[j + 1] = puntuacionTemporal;

                        string nombreTemporal = nombresMarcadores[j];
                        nombresMarcadores[j] = nombresMarcadores[j + 1];
                        nombresMarcadores[j + 1] = nombreTemporal;
                    }
                }
            }
        }

        void label1_Click(object sender, EventArgs e)
        {
        }

        void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}