
namespace Primer_Parcial_Labo2
{
    partial class FrmAgregarViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarViaje));
            this.cmb_Origen = new System.Windows.Forms.ComboBox();
            this.cmb_Matricula = new System.Windows.Forms.ComboBox();
            this.cmb_Destino = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtn_ExtraRegional = new System.Windows.Forms.RadioButton();
            this.rbtn_Regional = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_MensajeError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picbtn_agregar = new System.Windows.Forms.PictureBox();
            this.dtp_FechaSalida = new System.Windows.Forms.DateTimePicker();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbtn_agregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Origen
            // 
            this.cmb_Origen.AccessibleDescription = "";
            this.cmb_Origen.AccessibleName = "";
            this.cmb_Origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Origen.FormattingEnabled = true;
            this.cmb_Origen.Location = new System.Drawing.Point(24, 236);
            this.cmb_Origen.Name = "cmb_Origen";
            this.cmb_Origen.Size = new System.Drawing.Size(210, 23);
            this.cmb_Origen.TabIndex = 0;
            this.cmb_Origen.Tag = "";
            this.cmb_Origen.SelectedIndexChanged += new System.EventHandler(this.cmb_Crucero_SelectedIndexChanged);
            // 
            // cmb_Matricula
            // 
            this.cmb_Matricula.AccessibleDescription = "";
            this.cmb_Matricula.AccessibleName = "";
            this.cmb_Matricula.FormattingEnabled = true;
            this.cmb_Matricula.Location = new System.Drawing.Point(24, 176);
            this.cmb_Matricula.Name = "cmb_Matricula";
            this.cmb_Matricula.Size = new System.Drawing.Size(210, 23);
            this.cmb_Matricula.TabIndex = 1;
            this.cmb_Matricula.Tag = "";
            // 
            // cmb_Destino
            // 
            this.cmb_Destino.AccessibleDescription = "";
            this.cmb_Destino.AccessibleName = "";
            this.cmb_Destino.FormattingEnabled = true;
            this.cmb_Destino.Location = new System.Drawing.Point(24, 300);
            this.cmb_Destino.Name = "cmb_Destino";
            this.cmb_Destino.Size = new System.Drawing.Size(210, 23);
            this.cmb_Destino.TabIndex = 2;
            this.cmb_Destino.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(302, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "ELEGIR TIPO DE VIAJE:";
            // 
            // rbtn_ExtraRegional
            // 
            this.rbtn_ExtraRegional.AutoSize = true;
            this.rbtn_ExtraRegional.ForeColor = System.Drawing.Color.White;
            this.rbtn_ExtraRegional.Location = new System.Drawing.Point(275, 237);
            this.rbtn_ExtraRegional.Name = "rbtn_ExtraRegional";
            this.rbtn_ExtraRegional.Size = new System.Drawing.Size(118, 19);
            this.rbtn_ExtraRegional.TabIndex = 28;
            this.rbtn_ExtraRegional.TabStop = true;
            this.rbtn_ExtraRegional.Text = "EXTRA REGIONAL";
            this.rbtn_ExtraRegional.UseVisualStyleBackColor = true;
            // 
            // rbtn_Regional
            // 
            this.rbtn_Regional.AutoSize = true;
            this.rbtn_Regional.ForeColor = System.Drawing.Color.White;
            this.rbtn_Regional.Location = new System.Drawing.Point(399, 236);
            this.rbtn_Regional.Name = "rbtn_Regional";
            this.rbtn_Regional.Size = new System.Drawing.Size(81, 19);
            this.rbtn_Regional.TabIndex = 27;
            this.rbtn_Regional.TabStop = true;
            this.rbtn_Regional.Text = "REGIONAL";
            this.rbtn_Regional.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Himalaya", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 35);
            this.label2.TabIndex = 31;
            this.label2.Text = "DRK CRUCEROS";
            // 
            // lbl_MensajeError
            // 
            this.lbl_MensajeError.AutoSize = true;
            this.lbl_MensajeError.ForeColor = System.Drawing.Color.Red;
            this.lbl_MensajeError.Location = new System.Drawing.Point(97, 134);
            this.lbl_MensajeError.Name = "lbl_MensajeError";
            this.lbl_MensajeError.Size = new System.Drawing.Size(344, 15);
            this.lbl_MensajeError.TabIndex = 32;
            this.lbl_MensajeError.Text = "DEBES COMPLETAR TODOS LOS CAMPOS PARA CREAR EL VIAJE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(186, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(24, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "DESTINO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(24, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "FECHA SALIDA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(24, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "MATRICULA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(24, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "ORIGEN:";
            // 
            // picbtn_agregar
            // 
            this.picbtn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbtn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("picbtn_agregar.Image")));
            this.picbtn_agregar.Location = new System.Drawing.Point(302, 278);
            this.picbtn_agregar.Name = "picbtn_agregar";
            this.picbtn_agregar.Size = new System.Drawing.Size(154, 113);
            this.picbtn_agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbtn_agregar.TabIndex = 46;
            this.picbtn_agregar.TabStop = false;
            this.picbtn_agregar.Click += new System.EventHandler(this.picbtn_agregar_Click);
            // 
            // dtp_FechaSalida
            // 
            this.dtp_FechaSalida.Location = new System.Drawing.Point(24, 368);
            this.dtp_FechaSalida.Name = "dtp_FechaSalida";
            this.dtp_FechaSalida.Size = new System.Drawing.Size(210, 23);
            this.dtp_FechaSalida.TabIndex = 47;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(399, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 48;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-464, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1114, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Himalaya", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(12, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 35);
            this.label6.TabIndex = 50;
            this.label6.Text = "=VIAJES=";
            // 
            // FrmAgregarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(492, 425);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbtn_Regional);
            this.Controls.Add(this.rbtn_ExtraRegional);
            this.Controls.Add(this.cmb_Origen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Destino);
            this.Controls.Add(this.picbtn_agregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_FechaSalida);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_MensajeError);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_Matricula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(508, 464);
            this.Name = "FrmAgregarViaje";
            this.Text = "AGREGAR VIAJE";
            this.Load += new System.EventHandler(this.FrmAgregarCrucero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbtn_agregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Origen;
        private System.Windows.Forms.ComboBox cmb_Matricula;
        private System.Windows.Forms.ComboBox cmb_Destino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtn_ExtraRegional;
        private System.Windows.Forms.RadioButton rbtn_Regional;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_MensajeError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picbtn_agregar;
        private System.Windows.Forms.DateTimePicker dtp_FechaSalida;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
    }
}