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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        void Form3_Load(object sender, EventArgs e)
        {
            CargarMarcadores();
        }

        void CargarMarcadores()
        {
            Form1.OrdenarMarcadores();

            dgvMarcadores.Columns.Clear();
            dgvMarcadores.Rows.Clear();
            dgvMarcadores.Columns.Add("colNickname", "Nickname del jugador");
            dgvMarcadores.Columns.Add("colPuntuacion", "Puntuación");

            dgvMarcadores.ReadOnly = true;
            dgvMarcadores.AllowUserToAddRows = false;
            dgvMarcadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMarcadores.RowHeadersVisible = false;
            dgvMarcadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMarcadores.MultiSelect = false;

            for (int i = 0; i < Form1.cantidadResultados; i++)
            {
                dgvMarcadores.Rows.Add(
                    Form1.nombresMarcadores[i],
                    Form1.puntuacionesMarcadores[i]);
            }
        }

        void butVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            if (Form1.Instancia != null)
            {
                Form1.Instancia.Show();
                Form1.Instancia.Activate();
            }
        }
    }
}