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
    public partial class Form5 : Form
    {
        bool abriendoOtraVentana = false;

        public Form5()
        {
            InitializeComponent();
        }

        void butConfirmarVentanaNickname1P_Click(object sender, EventArgs e)
        {
            string nickname1 = txtNickname1P.Text;
            string nickname2 = txtNickname2P.Text;

            if (string.IsNullOrWhiteSpace(nickname1))
            {
                MessageBox.Show("Ingrese el nickname del jugador 1.", "Nickname requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNickname1P.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(nickname2))
            {
                MessageBox.Show("Ingrese el nickname del jugador 2.", "Nickname requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNickname2P.Focus();
                return;
            }

            abriendoOtraVentana = true;
            Form6 interfazJuego = new Form6(nickname1, nickname2);
            interfazJuego.Show();
            this.Close();
        }

        void lblTituloVentanaNickname1P_Click(object sender, EventArgs e)
        {
        }

        void txtNickname1P_TextChanged(object sender, EventArgs e)
        {
        }

        void txtNickname2P_TextChanged(object sender, EventArgs e)
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