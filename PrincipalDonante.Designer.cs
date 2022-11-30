
namespace GestionDonaciones
{
    partial class PrincipalDonante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalDonante));
            this.TabInicio = new System.Windows.Forms.TabControl();
            this.tabPageInicio = new System.Windows.Forms.TabPage();
            this.buttonHome = new System.Windows.Forms.PictureBox();
            this.buttonDonar = new System.Windows.Forms.Button();
            this.buttonCampañas = new System.Windows.Forms.Button();
            this.buttonUbicaciones = new System.Windows.Forms.Button();
            this.tabPageUbicaciones = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkCentrosComunitarios = new System.Windows.Forms.PictureBox();
            this.labelCentrosComunitarios = new System.Windows.Forms.Label();
            this.checkPuntosRecoleccion = new System.Windows.Forms.PictureBox();
            this.buttonMasPuntos = new System.Windows.Forms.Button();
            this.buttonMasCentros = new System.Windows.Forms.Button();
            this.dataGridViewUbicacionGran = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDirr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCampañas = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSalir = new System.Windows.Forms.PictureBox();
            this.comboBoxTitulos = new System.Windows.Forms.ComboBox();
            this.comboBoxFechas = new System.Windows.Forms.ComboBox();
            this.TabInicio.SuspendLayout();
            this.tabPageInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).BeginInit();
            this.tabPageUbicaciones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkCentrosComunitarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPuntosRecoleccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUbicacionGran)).BeginInit();
            this.tabPageCampañas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // TabInicio
            // 
            this.TabInicio.Controls.Add(this.tabPageInicio);
            this.TabInicio.Controls.Add(this.tabPageUbicaciones);
            this.TabInicio.Controls.Add(this.tabPageCampañas);
            this.TabInicio.Location = new System.Drawing.Point(-12, 24);
            this.TabInicio.Name = "TabInicio";
            this.TabInicio.SelectedIndex = 0;
            this.TabInicio.Size = new System.Drawing.Size(1043, 538);
            this.TabInicio.TabIndex = 0;
            this.TabInicio.SelectedIndexChanged += new System.EventHandler(this.TabInicio_SelectedIndexChanged);
            // 
            // tabPageInicio
            // 
            this.tabPageInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageInicio.BackgroundImage")));
            this.tabPageInicio.Controls.Add(this.buttonHome);
            this.tabPageInicio.Controls.Add(this.buttonDonar);
            this.tabPageInicio.Controls.Add(this.buttonCampañas);
            this.tabPageInicio.Controls.Add(this.buttonUbicaciones);
            this.tabPageInicio.Location = new System.Drawing.Point(4, 24);
            this.tabPageInicio.Name = "tabPageInicio";
            this.tabPageInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInicio.Size = new System.Drawing.Size(1035, 510);
            this.tabPageInicio.TabIndex = 0;
            this.tabPageInicio.Text = "tabPage1";
            this.tabPageInicio.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(40, 414);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(73, 75);
            this.buttonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonHome.TabIndex = 10;
            this.buttonHome.TabStop = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonDonar
            // 
            this.buttonDonar.Location = new System.Drawing.Point(115, 291);
            this.buttonDonar.Name = "buttonDonar";
            this.buttonDonar.Size = new System.Drawing.Size(320, 42);
            this.buttonDonar.TabIndex = 2;
            this.buttonDonar.Text = "Donar";
            this.buttonDonar.UseVisualStyleBackColor = true;
            this.buttonDonar.Click += new System.EventHandler(this.buttonDonar_Click);
            // 
            // buttonCampañas
            // 
            this.buttonCampañas.Location = new System.Drawing.Point(115, 188);
            this.buttonCampañas.Name = "buttonCampañas";
            this.buttonCampañas.Size = new System.Drawing.Size(320, 42);
            this.buttonCampañas.TabIndex = 1;
            this.buttonCampañas.Text = "Campañas";
            this.buttonCampañas.UseVisualStyleBackColor = true;
            this.buttonCampañas.Click += new System.EventHandler(this.buttonCampañas_Click);
            // 
            // buttonUbicaciones
            // 
            this.buttonUbicaciones.Location = new System.Drawing.Point(115, 89);
            this.buttonUbicaciones.Name = "buttonUbicaciones";
            this.buttonUbicaciones.Size = new System.Drawing.Size(320, 42);
            this.buttonUbicaciones.TabIndex = 0;
            this.buttonUbicaciones.Text = "Ubicaciones";
            this.buttonUbicaciones.UseVisualStyleBackColor = true;
            this.buttonUbicaciones.Click += new System.EventHandler(this.buttonUbicaciones_Click);
            // 
            // tabPageUbicaciones
            // 
            this.tabPageUbicaciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageUbicaciones.BackgroundImage")));
            this.tabPageUbicaciones.Controls.Add(this.panel1);
            this.tabPageUbicaciones.Controls.Add(this.dataGridViewUbicacionGran);
            this.tabPageUbicaciones.Location = new System.Drawing.Point(4, 24);
            this.tabPageUbicaciones.Name = "tabPageUbicaciones";
            this.tabPageUbicaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUbicaciones.Size = new System.Drawing.Size(1035, 510);
            this.tabPageUbicaciones.TabIndex = 1;
            this.tabPageUbicaciones.Text = "tabPage2";
            this.tabPageUbicaciones.UseVisualStyleBackColor = true;
            this.tabPageUbicaciones.Click += new System.EventHandler(this.tabPageUbicaciones_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkCentrosComunitarios);
            this.panel1.Controls.Add(this.labelCentrosComunitarios);
            this.panel1.Controls.Add(this.checkPuntosRecoleccion);
            this.panel1.Controls.Add(this.buttonMasPuntos);
            this.panel1.Controls.Add(this.buttonMasCentros);
            this.panel1.Location = new System.Drawing.Point(41, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 378);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(112, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Puntos de Recoleccion";
            // 
            // checkCentrosComunitarios
            // 
            this.checkCentrosComunitarios.Image = ((System.Drawing.Image)(resources.GetObject("checkCentrosComunitarios.Image")));
            this.checkCentrosComunitarios.Location = new System.Drawing.Point(36, 61);
            this.checkCentrosComunitarios.Name = "checkCentrosComunitarios";
            this.checkCentrosComunitarios.Size = new System.Drawing.Size(70, 68);
            this.checkCentrosComunitarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.checkCentrosComunitarios.TabIndex = 0;
            this.checkCentrosComunitarios.TabStop = false;
            this.checkCentrosComunitarios.Click += new System.EventHandler(this.checkCentrosComunitarios_Click);
            // 
            // labelCentrosComunitarios
            // 
            this.labelCentrosComunitarios.AutoSize = true;
            this.labelCentrosComunitarios.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCentrosComunitarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCentrosComunitarios.Location = new System.Drawing.Point(112, 75);
            this.labelCentrosComunitarios.Name = "labelCentrosComunitarios";
            this.labelCentrosComunitarios.Size = new System.Drawing.Size(274, 37);
            this.labelCentrosComunitarios.TabIndex = 7;
            this.labelCentrosComunitarios.Text = "Centros Comunitarios";
            // 
            // checkPuntosRecoleccion
            // 
            this.checkPuntosRecoleccion.Image = ((System.Drawing.Image)(resources.GetObject("checkPuntosRecoleccion.Image")));
            this.checkPuntosRecoleccion.Location = new System.Drawing.Point(36, 216);
            this.checkPuntosRecoleccion.Name = "checkPuntosRecoleccion";
            this.checkPuntosRecoleccion.Size = new System.Drawing.Size(70, 68);
            this.checkPuntosRecoleccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.checkPuntosRecoleccion.TabIndex = 1;
            this.checkPuntosRecoleccion.TabStop = false;
            this.checkPuntosRecoleccion.Click += new System.EventHandler(this.checkPuntosRecoleccion_Click);
            // 
            // buttonMasPuntos
            // 
            this.buttonMasPuntos.Location = new System.Drawing.Point(312, 285);
            this.buttonMasPuntos.Name = "buttonMasPuntos";
            this.buttonMasPuntos.Size = new System.Drawing.Size(104, 33);
            this.buttonMasPuntos.TabIndex = 5;
            this.buttonMasPuntos.Text = "Ver Mas";
            this.buttonMasPuntos.UseVisualStyleBackColor = true;
            // 
            // buttonMasCentros
            // 
            this.buttonMasCentros.Location = new System.Drawing.Point(312, 136);
            this.buttonMasCentros.Name = "buttonMasCentros";
            this.buttonMasCentros.Size = new System.Drawing.Size(104, 33);
            this.buttonMasCentros.TabIndex = 4;
            this.buttonMasCentros.Text = "Ver Mas";
            this.buttonMasCentros.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUbicacionGran
            // 
            this.dataGridViewUbicacionGran.AllowUserToAddRows = false;
            this.dataGridViewUbicacionGran.AllowUserToDeleteRows = false;
            this.dataGridViewUbicacionGran.AllowUserToResizeColumns = false;
            this.dataGridViewUbicacionGran.AllowUserToResizeRows = false;
            this.dataGridViewUbicacionGran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewUbicacionGran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.ColumnNombre,
            this.ColumnDirr});
            this.dataGridViewUbicacionGran.Location = new System.Drawing.Point(559, 36);
            this.dataGridViewUbicacionGran.Name = "dataGridViewUbicacionGran";
            this.dataGridViewUbicacionGran.RowTemplate.Height = 25;
            this.dataGridViewUbicacionGran.Size = new System.Drawing.Size(434, 406);
            this.dataGridViewUbicacionGran.TabIndex = 3;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnDirr
            // 
            this.ColumnDirr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDirr.HeaderText = "Dirr";
            this.ColumnDirr.Name = "ColumnDirr";
            // 
            // tabPageCampañas
            // 
            this.tabPageCampañas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageCampañas.BackgroundImage")));
            this.tabPageCampañas.Controls.Add(this.comboBoxFechas);
            this.tabPageCampañas.Controls.Add(this.comboBoxTitulos);
            this.tabPageCampañas.Location = new System.Drawing.Point(4, 24);
            this.tabPageCampañas.Name = "tabPageCampañas";
            this.tabPageCampañas.Size = new System.Drawing.Size(1035, 510);
            this.tabPageCampañas.TabIndex = 2;
            this.tabPageCampañas.Text = "tabPage3";
            this.tabPageCampañas.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1050, 154);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.Transparent;
            this.buttonSalir.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalir.Image")));
            this.buttonSalir.Location = new System.Drawing.Point(12, 3);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(42, 39);
            this.buttonSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonSalir.TabIndex = 9;
            this.buttonSalir.TabStop = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // comboBoxTitulos
            // 
            this.comboBoxTitulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTitulos.FormattingEnabled = true;
            this.comboBoxTitulos.Location = new System.Drawing.Point(134, 112);
            this.comboBoxTitulos.Name = "comboBoxTitulos";
            this.comboBoxTitulos.Size = new System.Drawing.Size(185, 23);
            this.comboBoxTitulos.Sorted = true;
            this.comboBoxTitulos.TabIndex = 0;
            this.comboBoxTitulos.SelectedIndexChanged += new System.EventHandler(this.comboBoxTitulos_SelectedIndexChanged);
            // 
            // comboBoxFechas
            // 
            this.comboBoxFechas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFechas.FormattingEnabled = true;
            this.comboBoxFechas.Location = new System.Drawing.Point(134, 175);
            this.comboBoxFechas.Name = "comboBoxFechas";
            this.comboBoxFechas.Size = new System.Drawing.Size(185, 23);
            this.comboBoxFechas.TabIndex = 1;
            this.comboBoxFechas.SelectedIndexChanged += new System.EventHandler(this.comboBoxFechas_SelectedIndexChanged);
            // 
            // PrincipalDonante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 558);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TabInicio);
            this.Name = "PrincipalDonante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PrincipalDonante";
            this.Load += new System.EventHandler(this.PrincipalDonante_Load);
            this.TabInicio.ResumeLayout(false);
            this.tabPageInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).EndInit();
            this.tabPageUbicaciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkCentrosComunitarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPuntosRecoleccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUbicacionGran)).EndInit();
            this.tabPageCampañas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabInicio;
        private System.Windows.Forms.TabPage tabPageInicio;
        private System.Windows.Forms.TabPage tabPageUbicaciones;
        private System.Windows.Forms.Button buttonDonar;
        private System.Windows.Forms.Button buttonCampañas;
        private System.Windows.Forms.Button buttonUbicaciones;
        private System.Windows.Forms.TabPage tabPageCampañas;
        private System.Windows.Forms.PictureBox checkCentrosComunitarios;
        private System.Windows.Forms.Label labelCentrosComunitarios;
        private System.Windows.Forms.Button buttonMasPuntos;
        private System.Windows.Forms.Button buttonMasCentros;
        private System.Windows.Forms.DataGridView dataGridViewUbicacionGran;
        private System.Windows.Forms.PictureBox checkPuntosRecoleccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDirr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox buttonSalir;
        private System.Windows.Forms.PictureBox buttonHome;
        private System.Windows.Forms.ComboBox comboBoxFechas;
        private System.Windows.Forms.ComboBox comboBoxTitulos;
    }
}