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
    public partial class Form4 : Form
    {
        bool abriendoOtraVentana = false;

        public Form4()
        {
            InitializeComponent();
        }

        void butConfirmarVentanaNickname1P_Click(object sender, EventArgs e)
        {
            string nickname = txtNickname1P.Text;

            if (string.IsNullOrWhiteSpace(nickname))
            {
                MessageBox.Show("Ingrese un nickname para continuar.", "Nickname requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNickname1P.Focus();
                return;
            }

            abriendoOtraVentana = true;
            Form6 interfazJuego = new Form6(nickname);
            interfazJuego.Show();
            this.Close();
        }

        void label1_Click(object sender, EventArgs e)
        {
        }

        void txtNickname1P_TextChanged(object sender, EventArgs e)
        {
        }

        void Form4_Load(object sender, EventArgs e)
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