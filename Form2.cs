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
    public partial class Form2 : Form
    {
        bool abriendoOtraVentana = false;

        public Form2()
        {
            InitializeComponent();
        }

        void but1Jugador_Click(object sender, EventArgs e)
        {
            abriendoOtraVentana = true;
            Form4 ingresoNombre = new Form4();
            ingresoNombre.Show();
            this.Close();
        }

        void but2Jugadores_Click(object sender, EventArgs e)
        {
            abriendoOtraVentana = true;
            Form5 ingresoNombres = new Form5();
            ingresoNombres.Show();
            this.Close();
        }

        void label1_Click(object sender, EventArgs e)
        {
        }

        void button3_Click(object sender, EventArgs e)
        {
        }

        void Form2_Load(object sender, EventArgs e)
        {
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            if (!abriendoOtraVentana && Form1.Instancia != null)
            {
                Form1.Instancia.Show();
                Form1.Instancia.Activate();
            }
        }
    }
}