using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_Parcial;

namespace Primer_Parcial_Labo2
{
    public partial class FrmListPasajeros : Form
    {
        public FrmListPasajeros()
        {
            InitializeComponent();
        }

        private void FrmListPasajeros_Load(object sender, EventArgs e)
        {
            dgtv_ListPasajareos.DataSource = null;
            dgtv_ListPasajareos.DataSource = Sistema.Pasajeros;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea volver al menu de viajes?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                Hide();
            }
        }
    }
}
