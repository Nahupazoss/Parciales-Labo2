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
    public partial class FrmOpciones : Form
    {
        FrmListClientes listaClientes;
        FrmPasaje menuPasaje;
        FrmViajes menuViajes;
        Frm_Inicial menuInicio;
        FrmEstadisticas menuEstadisticas;
        System.Media.SoundPlayer menuOpcionesMusica;
        public FrmOpciones()
        {
            InitializeComponent(); 
        }

        private void FrmOpciones_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Rodri\source\repos\Primer_Parcial_Labo2\Imagenes\44.gif");
            System.IO.Stream audio = Properties.Resources.Sonido;
            menuOpcionesMusica = new System.Media.SoundPlayer(audio);
            menuOpcionesMusica.Play();
            pictureBox3.Visible = false;
            listaClientes = new FrmListClientes();
            menuPasaje = new FrmPasaje();
            menuViajes = new FrmViajes();
            menuInicio = new Frm_Inicial();
            menuEstadisticas = new FrmEstadisticas();
            FechaTimer.Enabled = true;
            lbl_Fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_bienvenida_Click(object sender, EventArgs e)
        {

        }

        public FrmOpciones(string mensaje) : this()
        {
            this.lbl_bienvenida.Text = mensaje;
        }

        public string Mensaje
        {
            set { this.lbl_bienvenida.Text = value; }
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea volver al menu de inicio?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                menuInicio.Show();

                Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuPasaje.Show();
        }

        private void btn_ListaClientes_Click(object sender, EventArgs e)
        {
            listaClientes.ActualizarDataGrid();
            listaClientes.Show();
        }

        private void btn_Viajes_Click(object sender, EventArgs e)
        {
            menuViajes.ActualizarDataGridViajes();
            menuViajes.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            menuEstadisticas.ShowDialog();
        }
    }
}
