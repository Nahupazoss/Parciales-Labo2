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
    public partial class FrmVentaPasaje : Form
    {
        Cliente clienteaux;
        public FrmVentaPasaje()
        {
            InitializeComponent();
        }

        private void FrmVentaPasaje_Load(object sender, EventArgs e)
        {
            lbl_MensajeError.Visible = false;
            cbx_salida.DataSource = Enum.GetNames(typeof(Origen));
            cbx_viajeA.DataSource = Enum.GetNames(typeof(Destino));
            cmbx_matricula.DataSource = Sistema.Viajes;
            lbl_precio.Visible = false;
            //btn_AgregarFamiliar.Visible = false;
        }

        private void picture_AddPassenger_Click(object sender, EventArgs e)
        {

        }


        private void rbtn_Regional_CheckedChanged(object sender, EventArgs e)
        {
            rbtn_ExtraRegional.Checked = false;
        }

        private void rbtn_ExtraRegional_CheckedChanged(object sender, EventArgs e)
        {
            rbtn_Regional.Checked = false;
        }

        private void picture_AddPassenger_Click_1(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(txt_Dni.Text);
            string nomb = txt_Nombre.Text;
            string apellido = txt_Apellido.Text;
            string nacionalidad = txt_Nacionalidad.Text;
            int edad = Convert.ToInt32(txt_Edad.Text);
            int pesoValija = Convert.ToInt32(txt_valija.Text);
            bool esRegional = rbtn_Regional.Checked;
            Viaje viajes = (Viaje)cmbx_matricula.SelectedItem;
            Cliente nuevoCliente;

            if (ValidacionStrings(nomb, apellido, nacionalidad) && dni > 20000000 && dni < 46000000 && edad > 17 && pesoValija > 0)
            {
                clienteaux = Sistema.BuscarClientePorDni(dni);

                if (clienteaux is not null)
                {
                    MessageBox.Show($"{nomb} ya es un cliente y se vendio el pasaje!!!");
                    Sistema.Pasajeros.Add(new Pasajero(clienteaux, pesoValija, Sistema.GeneraSiNoRandom(),viajes));
                    limpiarTxtBox();
                }
                else
                {
                    nuevoCliente = new Cliente(nomb, apellido, edad, dni, nacionalidad);
                    Sistema.Clientes.Add(nuevoCliente);
                    MessageBox.Show($"{nomb} es un nuevo cliente!!! y su pasaje se vendio con exito");
                    Sistema.Pasajeros.Add(new Pasajero(nuevoCliente, pesoValija, Sistema.GeneraSiNoRandom(),viajes));
                    limpiarTxtBox();
                }
            }
            else
            {
                lbl_MensajeError.Visible = true;
            }
        }

        private void limpiarTxtBox()
        {
            txt_Apellido.Clear();
            txt_Edad.Clear();
            txt_Dni.Clear();
            txt_Nacionalidad.Clear();
            txt_Nombre.Clear();
        }

        static bool ValidacionStrings(string nomb, string apellido, string nacionalidad)
        {
            return Validador.ValidarTexto(nomb) && Validador.ValidarTexto(apellido) && Validador.ValidarTexto(nacionalidad);
        }

        private void txtboxNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidarSoloNumeros(e))
            {
                MessageBox.Show("SOLO NUMEROS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtboxLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidarSoloLetras(e))
            {
                MessageBox.Show("SOLO LETRAS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
        public bool ValidarSoloNumeros(KeyPressEventArgs e)
        {
            return e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255;
        }

        private static bool ValidarSoloLetras(KeyPressEventArgs e)
        {
            return e.KeyChar >= 32 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255;
        }

        private void cmbx_matricula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
