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
    public partial class FrmRegistro : Form
    {
        Frm_Inicial menuInicial;
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Rodri\source\repos\Primer_Parcial_Labo2\Imagenes\123.gif");
            pictureBox4.Visible = false;
            lbl_msjError.Visible = false;
            menuInicial = new Frm_Inicial();
        }

        private void btn_Registro_Click(object sender, EventArgs e)
        {  
            string nomb = this.txt_nombre.Text;
            string usuario = this.txt_pass.Text;
            string pass = this.txt_pass.Text;
            string apellido = this.txt_Apellido.Text;
            int edad = Convert.ToInt32(this.txt_Edad.Text);
            int dni = Convert.ToInt32(this.txt_Edad.Text);

            if (VerificarRegistro(nomb, usuario, pass) && dni > 20000000 && dni < 46000000 && edad > 17)
            {
                lbl_msjError.Visible = false;
                Sistema.ResgistrarEmpleados(nomb, usuario, pass,apellido,edad,dni);
                MessageBox.Show($"{nomb} Se ha registrado con exito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_msjError.Visible = true;
                MessageBox.Show("Verifique que tiene todos los datos bien ingresados (Debe ser mayor de edad y tener bien ingresado su dni)");
            }
        }

        private static bool VerificarRegistro(string nomb, string usuario, string pass)
        {
            return Validador.ValidarTexto(nomb) && Validador.ValidarTexto(usuario) && Validador.ValidarTexto(pass);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea volver a la pagina principal?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                menuInicial.Show();

                Close();
            }       
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            txt_nombre.BackColor = Color.White;
            txt_usuario.BackColor = Color.White;
            txt_pass.BackColor = Color.White;
            txt_Edad.BackColor = Color.White;
            txt_Apellido.BackColor = Color.White;
            txt_Dni.BackColor = Color.White;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            txt_nombre.BackColor = Color.Black;
            txt_usuario.BackColor = Color.Black;
            txt_pass.BackColor = Color.Black;
            txt_Edad.BackColor = Color.Black;
            txt_Apellido.BackColor = Color.Black;
            txt_Dni.BackColor = Color.Black;
        }

        public bool ValidarSoloNumeros(KeyPressEventArgs e)
        {
            return e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255;
        }

        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidarSoloNumeros(e))
            {
                MessageBox.Show("SOLO NUMEROS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
    }
}
