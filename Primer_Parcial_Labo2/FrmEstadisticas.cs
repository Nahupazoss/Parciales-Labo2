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
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void picture_salir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea volver al menu de opciones?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            label3.Text = Sistema.Clientes.Count.ToString();
            label4.Text = Sistema.Viajes.Count.ToString();
            label5.Text = Sistema.Pasajeros.Count.ToString();
            label2.Text = Sistema.CalcularRecaudacion().ToString();
        }
    }
}
