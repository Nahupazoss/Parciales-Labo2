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
            ActualizarDataGrid();
        }

        public void ActualizarDataGrid()
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

        private void btn_eliminarPasajero_Click(object sender, EventArgs e)
        {
            if (this.dgtv_ListPasajareos.CurrentRow is not null)
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminar el pasajero?", "Eliminación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    int aux = dgtv_ListPasajareos.CurrentRow.Index;
                    Sistema.EliminarPasajero(aux);
                    this.dgtv_ListPasajareos.DataSource = null;
                    this.dgtv_ListPasajareos.DataSource = Sistema.ObtenerPasajeros();
                }
            }
            else
            {
                MessageBox.Show("No posee ningún pasaje cargado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
