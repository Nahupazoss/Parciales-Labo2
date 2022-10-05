using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Parcial_Labo2
{
    public partial class FrmPasaje : Form
    {
        public FrmPasaje()
        {
            InitializeComponent();
        }

        private void picture_exit_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea volver al menu de inicio?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                Hide();
            }
        }

        private void btn_VenderPasaje_Click(object sender, EventArgs e)
        {
            FrmVentaPasaje menuAltaPasajero = new FrmVentaPasaje();

            menuAltaPasajero.Show(); 
            

        }

        private void FrmPasaje_Load(object sender, EventArgs e)
        {
            
        }
    }
}
