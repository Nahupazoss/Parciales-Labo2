
namespace Primer_Parcial_Labo2
{
    partial class FrmVentaPasaje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentaPasaje));
            this.picture_AddPassenger = new System.Windows.Forms.PictureBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_Nacionalidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_salida = new System.Windows.Forms.ComboBox();
            this.cbx_viajeA = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_MensajeError = new System.Windows.Forms.Label();
            this.rbtn_Regional = new System.Windows.Forms.RadioButton();
            this.rbtn_ExtraRegional = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_valija = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbx_matricula = new System.Windows.Forms.ComboBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_AddPassenger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_AddPassenger
            // 
            this.picture_AddPassenger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_AddPassenger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_AddPassenger.Image = ((System.Drawing.Image)(resources.GetObject("picture_AddPassenger.Image")));
            this.picture_AddPassenger.Location = new System.Drawing.Point(238, 433);
            this.picture_AddPassenger.Name = "picture_AddPassenger";
            this.picture_AddPassenger.Size = new System.Drawing.Size(144, 105);
            this.picture_AddPassenger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_AddPassenger.TabIndex = 1;
            this.picture_AddPassenger.TabStop = false;
            this.picture_AddPassenger.Click += new System.EventHandler(this.picture_AddPassenger_Click_1);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_Nombre.Location = new System.Drawing.Point(34, 76);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PlaceholderText = "NOMBRE";
            this.txt_Nombre.Size = new System.Drawing.Size(235, 23);
            this.txt_Nombre.TabIndex = 2;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxLetras_KeyPress);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_Apellido.Location = new System.Drawing.Point(34, 131);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.PlaceholderText = "APELLIDO";
            this.txt_Apellido.Size = new System.Drawing.Size(235, 23);
            this.txt_Apellido.TabIndex = 3;
            this.txt_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxLetras_KeyPress);
            // 
            // txt_Dni
            // 
            this.txt_Dni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_Dni.Location = new System.Drawing.Point(34, 189);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.PlaceholderText = "DNI";
            this.txt_Dni.Size = new System.Drawing.Size(235, 23);
            this.txt_Dni.TabIndex = 4;
            this.txt_Dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxNumeros_KeyPress);
            // 
            // txt_Nacionalidad
            // 
            this.txt_Nacionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_Nacionalidad.Location = new System.Drawing.Point(34, 297);
            this.txt_Nacionalidad.Name = "txt_Nacionalidad";
            this.txt_Nacionalidad.PlaceholderText = "NACIONALIDAD";
            this.txt_Nacionalidad.Size = new System.Drawing.Size(235, 23);
            this.txt_Nacionalidad.TabIndex = 5;
            this.txt_Nacionalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxLetras_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "FECHA DE NACIMIENTO:";
            // 
            // txt_Edad
            // 
            this.txt_Edad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_Edad.Location = new System.Drawing.Point(34, 244);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.PlaceholderText = "EDAD";
            this.txt_Edad.Size = new System.Drawing.Size(235, 23);
            this.txt_Edad.TabIndex = 8;
            this.txt_Edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxNumeros_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Himalaya", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "DRK CRUCEROS";
            // 
            // cbx_salida
            // 
            this.cbx_salida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbx_salida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_salida.FormattingEnabled = true;
            this.cbx_salida.Location = new System.Drawing.Point(434, 76);
            this.cbx_salida.Name = "cbx_salida";
            this.cbx_salida.Size = new System.Drawing.Size(121, 23);
            this.cbx_salida.TabIndex = 13;
            // 
            // cbx_viajeA
            // 
            this.cbx_viajeA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbx_viajeA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_viajeA.FormattingEnabled = true;
            this.cbx_viajeA.Location = new System.Drawing.Point(434, 189);
            this.cbx_viajeA.Name = "cbx_viajeA";
            this.cbx_viajeA.Size = new System.Drawing.Size(121, 23);
            this.cbx_viajeA.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(324, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Salis desde ------->";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(324, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Viajas a ---------->";
            // 
            // lbl_MensajeError
            // 
            this.lbl_MensajeError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MensajeError.AutoSize = true;
            this.lbl_MensajeError.ForeColor = System.Drawing.Color.Red;
            this.lbl_MensajeError.Location = new System.Drawing.Point(115, 44);
            this.lbl_MensajeError.Name = "lbl_MensajeError";
            this.lbl_MensajeError.Size = new System.Drawing.Size(330, 15);
            this.lbl_MensajeError.TabIndex = 19;
            this.lbl_MensajeError.Text = "DEBES COMPLETAR TODOS LOS CAMPOS PARA DAR DE ALTA";
            // 
            // rbtn_Regional
            // 
            this.rbtn_Regional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtn_Regional.AutoSize = true;
            this.rbtn_Regional.ForeColor = System.Drawing.Color.White;
            this.rbtn_Regional.Location = new System.Drawing.Point(346, 135);
            this.rbtn_Regional.Name = "rbtn_Regional";
            this.rbtn_Regional.Size = new System.Drawing.Size(81, 19);
            this.rbtn_Regional.TabIndex = 20;
            this.rbtn_Regional.TabStop = true;
            this.rbtn_Regional.Text = "REGIONAL";
            this.rbtn_Regional.UseVisualStyleBackColor = true;
            this.rbtn_Regional.CheckedChanged += new System.EventHandler(this.rbtn_Regional_CheckedChanged);
            // 
            // rbtn_ExtraRegional
            // 
            this.rbtn_ExtraRegional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtn_ExtraRegional.AutoSize = true;
            this.rbtn_ExtraRegional.ForeColor = System.Drawing.Color.White;
            this.rbtn_ExtraRegional.Location = new System.Drawing.Point(433, 135);
            this.rbtn_ExtraRegional.Name = "rbtn_ExtraRegional";
            this.rbtn_ExtraRegional.Size = new System.Drawing.Size(118, 19);
            this.rbtn_ExtraRegional.TabIndex = 21;
            this.rbtn_ExtraRegional.TabStop = true;
            this.rbtn_ExtraRegional.Text = "EXTRA REGIONAL";
            this.rbtn_ExtraRegional.UseVisualStyleBackColor = true;
            this.rbtn_ExtraRegional.CheckedChanged += new System.EventHandler(this.rbtn_ExtraRegional_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(324, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Peso valija ------->";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(293, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Crucero Disponible --->";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(376, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "ELEGIR TIPO DE VIAJE:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(324, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Precio del pasaje ->";
            // 
            // dtp_FechaNacimiento
            // 
            this.dtp_FechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtp_FechaNacimiento.Location = new System.Drawing.Point(34, 364);
            this.dtp_FechaNacimiento.MaxDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtp_FechaNacimiento.MinDate = new System.DateTime(1839, 1, 1, 0, 0, 0, 0);
            this.dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            this.dtp_FechaNacimiento.Size = new System.Drawing.Size(200, 23);
            this.dtp_FechaNacimiento.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-465, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1114, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(202, 388);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(587, 186);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // txt_valija
            // 
            this.txt_valija.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_valija.Location = new System.Drawing.Point(434, 297);
            this.txt_valija.Name = "txt_valija";
            this.txt_valija.Size = new System.Drawing.Size(121, 23);
            this.txt_valija.TabIndex = 22;
            this.txt_valija.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxNumeros_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(433, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "$";
            // 
            // cmbx_matricula
            // 
            this.cmbx_matricula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbx_matricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_matricula.FormattingEnabled = true;
            this.cmbx_matricula.Location = new System.Drawing.Point(434, 247);
            this.cmbx_matricula.Name = "cmbx_matricula";
            this.cmbx_matricula.Size = new System.Drawing.Size(121, 23);
            this.cmbx_matricula.TabIndex = 35;
            this.cmbx_matricula.SelectedIndexChanged += new System.EventHandler(this.cmbx_matricula_SelectedIndexChanged);
            // 
            // lbl_precio
            // 
            this.lbl_precio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.BackColor = System.Drawing.Color.Black;
            this.lbl_precio.ForeColor = System.Drawing.Color.Lime;
            this.lbl_precio.Location = new System.Drawing.Point(441, 367);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(37, 15);
            this.lbl_precio.TabIndex = 36;
            this.lbl_precio.Text = "55000";
            // 
            // FrmVentaPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(581, 559);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.cmbx_matricula);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_FechaNacimiento);
            this.Controls.Add(this.picture_AddPassenger);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbx_salida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_valija);
            this.Controls.Add(this.rbtn_ExtraRegional);
            this.Controls.Add(this.rbtn_Regional);
            this.Controls.Add(this.lbl_MensajeError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_viajeA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nacionalidad);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(597, 598);
            this.Name = "FrmVentaPasaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AGREGAR CLIENTE PASAJE";
            this.Load += new System.EventHandler(this.FrmVentaPasaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_AddPassenger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_AddPassenger;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.TextBox txt_Nacionalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_salida;
        private System.Windows.Forms.ComboBox cbx_viajeA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_MensajeError;
        private System.Windows.Forms.RadioButton rbtn_Regional;
        private System.Windows.Forms.RadioButton rbtn_ExtraRegional;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_FechaNacimiento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_valija;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbx_matricula;
        private System.Windows.Forms.Label lbl_precio;
    }
}