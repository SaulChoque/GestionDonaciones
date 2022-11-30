
namespace GestionDonaciones
{
    partial class DonacionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonacionForm));
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxValia = new System.Windows.Forms.TextBox();
            this.comboBoxCampañas = new System.Windows.Forms.ComboBox();
            this.buttonCargarDonacion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRazonSocial
            // 
            this.textBoxRazonSocial.Location = new System.Drawing.Point(107, 93);
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.Size = new System.Drawing.Size(225, 23);
            this.textBoxRazonSocial.TabIndex = 0;
            this.textBoxRazonSocial.Text = "Razon Social";
            this.textBoxRazonSocial.Enter += new System.EventHandler(this.textBoxRazonSocial_Enter);
            this.textBoxRazonSocial.Leave += new System.EventHandler(this.textBoxRazonSocial_Leave);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(107, 262);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(225, 23);
            this.dateTimePickerFecha.TabIndex = 1;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(107, 149);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(225, 23);
            this.textBoxDescripcion.TabIndex = 2;
            this.textBoxDescripcion.Text = "Descripcion";
            this.textBoxDescripcion.Enter += new System.EventHandler(this.textBoxDescripcion_Enter);
            this.textBoxDescripcion.Leave += new System.EventHandler(this.textBoxDescripcion_Leave);
            // 
            // textBoxValia
            // 
            this.textBoxValia.Location = new System.Drawing.Point(107, 210);
            this.textBoxValia.Name = "textBoxValia";
            this.textBoxValia.Size = new System.Drawing.Size(225, 23);
            this.textBoxValia.TabIndex = 3;
            this.textBoxValia.Text = "Valia";
            this.textBoxValia.Enter += new System.EventHandler(this.textBoxValia_Enter);
            this.textBoxValia.Leave += new System.EventHandler(this.textBoxValia_Leave);
            // 
            // comboBoxCampañas
            // 
            this.comboBoxCampañas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampañas.FormattingEnabled = true;
            this.comboBoxCampañas.Location = new System.Drawing.Point(107, 317);
            this.comboBoxCampañas.Name = "comboBoxCampañas";
            this.comboBoxCampañas.Size = new System.Drawing.Size(225, 23);
            this.comboBoxCampañas.TabIndex = 4;
            // 
            // buttonCargarDonacion
            // 
            this.buttonCargarDonacion.Location = new System.Drawing.Point(501, 446);
            this.buttonCargarDonacion.Name = "buttonCargarDonacion";
            this.buttonCargarDonacion.Size = new System.Drawing.Size(131, 49);
            this.buttonCargarDonacion.TabIndex = 5;
            this.buttonCargarDonacion.Text = "Cargar ";
            this.buttonCargarDonacion.UseVisualStyleBackColor = true;
            this.buttonCargarDonacion.Click += new System.EventHandler(this.buttonCargarDonacion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-19, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1057, 94);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.Transparent;
            this.buttonSalir.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalir.Image")));
            this.buttonSalir.Location = new System.Drawing.Point(23, 12);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(42, 39);
            this.buttonSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonSalir.TabIndex = 10;
            this.buttonSalir.TabStop = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // DonacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 558);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCargarDonacion);
            this.Controls.Add(this.comboBoxCampañas);
            this.Controls.Add(this.textBoxValia);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.textBoxRazonSocial);
            this.Name = "DonacionForm";
            this.Text = "DonacionForm";
            this.Load += new System.EventHandler(this.DonacionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxValia;
        private System.Windows.Forms.ComboBox comboBoxCampañas;
        private System.Windows.Forms.Button buttonCargarDonacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox buttonSalir;
    }
}