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

            if (VerificarRegistro(nomb, usuario, pass))
            {
                lbl_msjError.Visible = false;
                Sistema.ResgistrarEmpleados(nomb, usuario, pass);
                MessageBox.Show($"{nomb} Se ha registrado con exito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_msjError.Visible = true;
            }
        }

        private static bool VerificarRegistro(string nomb, string usuario, string pass)
        {
            return Validador.ValidarTexto(nomb) && Validador.ValidarTexto(usuario) && Validador.ValidarTexto(pass);
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

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
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            txt_nombre.BackColor = Color.Black;
            txt_usuario.BackColor = Color.Black;
            txt_pass.BackColor = Color.Black;
        }
    }
}
