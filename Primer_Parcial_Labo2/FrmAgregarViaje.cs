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
    public partial class FrmAgregarViaje : Form
    {
        public FrmAgregarViaje()
        {
            InitializeComponent();
        }

        private void FrmAgregarCrucero_Load(object sender, EventArgs e)
        {
            lbl_MensajeError.Visible = false;
            cmb_Origen.DataSource = Enum.GetNames(typeof(Origen));
            cmb_Destino.DataSource = Enum.GetNames(typeof(Destino));
            cmb_Matricula.DataSource = Sistema.Cruceros;
        }

        private void picbtn_agregar_Click(object sender, EventArgs e)
        {
            string origen = cmb_Origen.SelectedItem.ToString();
            string destino = cmb_Destino.SelectedItem.ToString();
            DateTime fecha = dtp_FechaSalida.Value;
            DateTime fechaLlegada = dtp_FechaSalida.Value;
            bool esRegional = rbtn_Regional.Checked;
            string tipoViaje = " ";
            Crucero crucero = (Crucero)cmb_Matricula.SelectedItem;
            int horasViaje;
            Random random = new Random();
            float precio;
            //HACER METODO EN CLASE VIAJE
            if (esRegional)
            {
                tipoViaje = "Regional";
                horasViaje = random.Next(72, 360);
                precio = horasViaje * 57f;
                fechaLlegada = fecha.Add(TimeSpan.FromHours(horasViaje));
            }
            else
            {
                tipoViaje = "ExtraRegional";  
                horasViaje = random.Next(480, 720);
                precio = horasViaje * 120f;
                fechaLlegada = fecha.Add(TimeSpan.FromHours(horasViaje));
            }

            if (ValidarViaje(origen, destino, tipoViaje))
            {
                Sistema.Viajes.Add(new Viaje(crucero, horasViaje, tipoViaje, origen, destino, fecha, fechaLlegada,precio));
                MessageBox.Show("El Viaje se cargo correctamente..");
            }
            else
            {
                lbl_MensajeError.Visible = true;
                MessageBox.Show("El viaje no se pudo cargar correctamente..");
            }

        }

        private static bool ValidarViaje(string origen, string destino, string tipoViaje)
        {
            return Validador.ValidarTexto(origen) && Validador.ValidarTexto(destino) && Validador.ValidarTexto(tipoViaje);
        }

        private void cmb_Crucero_SelectedIndexChanged(object sender, EventArgs e)
        {
               
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
