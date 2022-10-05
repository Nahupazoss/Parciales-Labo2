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
    public partial class Frm_Inicial : Form
    {
        public Frm_Inicial()
        {
            InitializeComponent();
        }

        private void Frm_Inicial_Load(object sender, EventArgs e)
        {
            lbl_Mensaje_Error.Visible = false;
            lbl_Mensaje_Error.Text = "ERROR, REINGRESE DATOS";
            pictureBox1.Image = Image.FromFile(@"C:\Users\Rodri\source\repos\Primer_Parcial_Labo2\Imagenes\giphy.gif");
            pictureBox4.Visible = false;     
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string usuario = this.txt_box_usuario.Text;
            string pass = this.txt_Password.Text;

            if (ValidarInformacionTexto(usuario, pass))
            {
                if (Sistema.LoguearVendedor(usuario, pass))
                {
                    FrmOpciones menuOpciones = new FrmOpciones($"¡Bienvenido {usuario}!");

                    menuOpciones.Show();
                    Hide();

                    lbl_Mensaje_Error.Visible = false;
                }
                else
                {
                    lbl_Mensaje_Error.Visible = true;
                }
            }
            else
            {
                lbl_Mensaje_Error.Text = "ERROR, REINGRESE DATOS";
                lbl_Mensaje_Error.Visible = true;
            }

        }

        private static bool ValidarInformacionTexto(string usuario, string pass)
        {
            return Validador.ValidarTexto(usuario) && Validador.ValidarTexto(pass);
        }

        private void btn_Regsitro_Click(object sender, EventArgs e)
        {
            FrmRegistro menuRegistro = new FrmRegistro();

            menuRegistro.Show();

            Hide();
        }

        private void txt_box_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir de la Aplicacion?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(opcion == DialogResult.Yes)
            {
                Close();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            txt_box_usuario.BackColor = Color.White;
            txt_Password.BackColor = Color.White;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            txt_box_usuario.BackColor = Color.Black;
            txt_Password.BackColor = Color.Black;
        }

        private void btn_AutoComplete_Click(object sender, EventArgs e)
        {
            txt_box_usuario.Text = "NahuPazos";
            txt_Password.Text = "123a";
            /*txt_box_usuario.Text = "Neiner";
            txt_Password.Text = "123aa";
            txt_box_usuario.Text = "ManuLagos";
            txt_Password.Text = "a123";
            txt_box_usuario.Text = "JeroMax";
            txt_Password.Text = "aa123";*/
        }

        /*private  AutoCompleteStringCollection CargarUsuario()
        {
            AutoCompleteStringCollection usuario = new AutoCompleteStringCollection();

            DataObject.Add("a");
        }*/


    }
}
