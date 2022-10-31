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
    public partial class FrmListClientes : Form
    {
        private List<Cliente> mostrar;
        public FrmListClientes()
        {
            InitializeComponent();
        }

        private void FrmListClientes_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            cmbx_ordenaaa.DataSource = Enum.GetNames(typeof(Ordenar));
            mostrar = Sistema.Clientes;
        }

        private void dgb_listClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void btn_eliminarCliente_Click(object sender, EventArgs e)
        {
            if (this.dgb_listClientes.CurrentRow is not null)
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminar el cliente?", "Eliminación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    int aux = dgb_listClientes.CurrentRow.Index;
                    Sistema.EliminarCliente(aux);
                    this.dgb_listClientes.DataSource = null;
                    this.dgb_listClientes.DataSource = Sistema.ObtenerClientes();
                }
            }
            else
            {
                MessageBox.Show("No posee ningún cliente cargado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void ActualizarDataGrid()
        {
            dgb_listClientes.DataSource = null;
            dgb_listClientes.DataSource = Sistema.Clientes;
        }

        private void btn_ModificarCliente_Click(object sender, EventArgs e)
        {
            string ordenamiento = cmbx_ordenaaa.SelectedItem.ToString();

            OrdenarSegunRequisito(ordenamiento);

        }

        private static void OrdenarSegunRequisito(string ordenamiento)
        {

            if (ordenamiento == "EdadMenor")
            {
                Sistema.OrdenarEdadMenor(Sistema.Clientes);
            }
            else
            {
                if (ordenamiento == "EdadMayor")
                {
                    Sistema.OrdenarEdadMayor(Sistema.Clientes);
                }
                else
                {
                    if (ordenamiento == "Nombre")
                    {
                        //Sistema.Clientes.Sort();
                    }
                    else
                    {
                        if (ordenamiento == "Apellido")
                        {
                            //Sistema.Clientes.Sort();
                        }
                    }
                }
            }
        }
    }
}
