﻿using System;
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
    public partial class FrmViajes : Form
    {
        FrmAgregarViaje agregarViaje;
        FrmListPasajeros listPasajeros;
        public FrmViajes()
        {
            InitializeComponent();
        }

        private void dtgv_ListaViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmViajes_Load(object sender, EventArgs e)
        {
            ActualizarDataGridViajes();
            pictureBox3.Visible = false;
            agregarViaje = new FrmAgregarViaje();
            listPasajeros = new FrmListPasajeros();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
            
        }

        private void btn_AgregarViaje_Click(object sender, EventArgs e)
        {
            agregarViaje.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //int index = dtgv_ListaViajes.CurrentRow.Index;
            //Crucero aCrucero = Sistema.Cruceros[index];

            /*oreach (Sistema crucero in )
            {

            }*/
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea volver al menu de inicio?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                Hide();
            }
        }

        public void ActualizarDataGridViajes()
        {
            dtgv_ListaViajes.DataSource = null;
            dtgv_ListaViajes.DataSource = Sistema.Viajes;

        }

        private void btn_ListPasajeros_Click(object sender, EventArgs e)
        {
            listPasajeros.ActualizarDataGrid();
            listPasajeros.Show();
        }
    }
}
