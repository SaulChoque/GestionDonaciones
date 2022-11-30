using System.Collections.Generic;
namespace GestionDonaciones
{
    partial class PrincipalEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalEmpleado));
            this.TabInicio = new System.Windows.Forms.TabControl();
            this.tabPageInicio = new System.Windows.Forms.TabPage();
            this.buttonRegisDonacion = new System.Windows.Forms.Button();
            this.buttonAgrCampaña = new System.Windows.Forms.Button();
            this.buttonAgrUbicacion = new System.Windows.Forms.Button();
            this.buttonAgrPersonal = new System.Windows.Forms.Button();
            this.tabPageAgrPersonal = new System.Windows.Forms.TabPage();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.textBoxFuncion = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNacionalidad = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.tabPageSeleccUbicacion = new System.Windows.Forms.TabPage();
            this.buttonAgrPuntoRecc = new System.Windows.Forms.Button();
            this.buttonAgrCentroComunitario = new System.Windows.Forms.Button();
            this.tabPageAgrCampaña = new System.Windows.Forms.TabPage();
            this.buttonCargarCamp = new System.Windows.Forms.Button();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.textBoxMeta = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.tabPageAgrCentroComunitario = new System.Windows.Forms.TabPage();
            this.buttonCargarDatosCentro = new System.Windows.Forms.Button();
            this.buttonCargarPrograma = new System.Windows.Forms.Button();
            this.textBoxProgramas = new System.Windows.Forms.TextBox();
            this.dataGridViewProgramas = new System.Windows.Forms.DataGridView();
            this.ColumnNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxPersonal = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.tabPageAgrPuntoRecolecc = new System.Windows.Forms.TabPage();
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaIni = new System.Windows.Forms.DateTimePicker();
            this.textBoxInstitucion = new System.Windows.Forms.TextBox();
            this.buttonCargarDatosRecc = new System.Windows.Forms.Button();
            this.panelUbicacionDatos = new System.Windows.Forms.Panel();
            this.textBoxNro = new System.Windows.Forms.TextBox();
            this.textBoxDepartamento = new System.Windows.Forms.TextBox();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.textBoxZona = new System.Windows.Forms.TextBox();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkCentrosComunitarios = new System.Windows.Forms.PictureBox();
            this.buttonSalir = new System.Windows.Forms.PictureBox();
            this.buttonHome = new System.Windows.Forms.PictureBox();
            this.TabInicio.SuspendLayout();
            this.tabPageInicio.SuspendLayout();
            this.tabPageAgrPersonal.SuspendLayout();
            this.tabPageSeleccUbicacion.SuspendLayout();
            this.tabPageAgrCampaña.SuspendLayout();
            this.tabPageAgrCentroComunitario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgramas)).BeginInit();
            this.tabPageAgrPuntoRecolecc.SuspendLayout();
            this.panelUbicacionDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkCentrosComunitarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).BeginInit();
            this.SuspendLayout();
            // 
            // TabInicio
            // 
            this.TabInicio.Controls.Add(this.tabPageInicio);
            this.TabInicio.Controls.Add(this.tabPageAgrPersonal);
            this.TabInicio.Controls.Add(this.tabPageSeleccUbicacion);
            this.TabInicio.Controls.Add(this.tabPageAgrCampaña);
            this.TabInicio.Controls.Add(this.tabPageAgrCentroComunitario);
            this.TabInicio.Controls.Add(this.tabPageAgrPuntoRecolecc);
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
            this.tabPageInicio.Controls.Add(this.buttonRegisDonacion);
            this.tabPageInicio.Controls.Add(this.buttonAgrCampaña);
            this.tabPageInicio.Controls.Add(this.buttonAgrUbicacion);
            this.tabPageInicio.Controls.Add(this.buttonAgrPersonal);
            this.tabPageInicio.Location = new System.Drawing.Point(4, 24);
            this.tabPageInicio.Name = "tabPageInicio";
            this.tabPageInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInicio.Size = new System.Drawing.Size(1035, 510);
            this.tabPageInicio.TabIndex = 0;
            this.tabPageInicio.Text = "tabPage1";
            this.tabPageInicio.UseVisualStyleBackColor = true;
            // 
            // buttonRegisDonacion
            // 
            this.buttonRegisDonacion.Location = new System.Drawing.Point(115, 274);
            this.buttonRegisDonacion.Name = "buttonRegisDonacion";
            this.buttonRegisDonacion.Size = new System.Drawing.Size(320, 42);
            this.buttonRegisDonacion.TabIndex = 3;
            this.buttonRegisDonacion.Text = "Registrar Donacion";
            this.buttonRegisDonacion.UseVisualStyleBackColor = true;
            this.buttonRegisDonacion.Click += new System.EventHandler(this.buttonRegisDonacion_Click);
            // 
            // buttonAgrCampaña
            // 
            this.buttonAgrCampaña.Location = new System.Drawing.Point(115, 214);
            this.buttonAgrCampaña.Name = "buttonAgrCampaña";
            this.buttonAgrCampaña.Size = new System.Drawing.Size(320, 42);
            this.buttonAgrCampaña.TabIndex = 2;
            this.buttonAgrCampaña.Text = "Agregar Campaña";
            this.buttonAgrCampaña.UseVisualStyleBackColor = true;
            this.buttonAgrCampaña.Click += new System.EventHandler(this.buttonDonar_Click);
            // 
            // buttonAgrUbicacion
            // 
            this.buttonAgrUbicacion.Location = new System.Drawing.Point(115, 152);
            this.buttonAgrUbicacion.Name = "buttonAgrUbicacion";
            this.buttonAgrUbicacion.Size = new System.Drawing.Size(320, 42);
            this.buttonAgrUbicacion.TabIndex = 1;
            this.buttonAgrUbicacion.Text = "Agregar Ubicacion";
            this.buttonAgrUbicacion.UseVisualStyleBackColor = true;
            this.buttonAgrUbicacion.Click += new System.EventHandler(this.buttonCampañas_Click);
            // 
            // buttonAgrPersonal
            // 
            this.buttonAgrPersonal.Location = new System.Drawing.Point(115, 89);
            this.buttonAgrPersonal.Name = "buttonAgrPersonal";
            this.buttonAgrPersonal.Size = new System.Drawing.Size(320, 42);
            this.buttonAgrPersonal.TabIndex = 0;
            this.buttonAgrPersonal.Text = "Agregar Personal";
            this.buttonAgrPersonal.UseVisualStyleBackColor = true;
            this.buttonAgrPersonal.Click += new System.EventHandler(this.buttonUbicaciones_Click);
            // 
            // tabPageAgrPersonal
            // 
            this.tabPageAgrPersonal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageAgrPersonal.BackgroundImage")));
            this.tabPageAgrPersonal.Controls.Add(this.buttonCargar);
            this.tabPageAgrPersonal.Controls.Add(this.textBoxEdad);
            this.tabPageAgrPersonal.Controls.Add(this.textBoxFuncion);
            this.tabPageAgrPersonal.Controls.Add(this.comboBoxTipo);
            this.tabPageAgrPersonal.Controls.Add(this.textBoxId);
            this.tabPageAgrPersonal.Controls.Add(this.textBoxNacionalidad);
            this.tabPageAgrPersonal.Controls.Add(this.textBoxApellidos);
            this.tabPageAgrPersonal.Controls.Add(this.textBoxNombres);
            this.tabPageAgrPersonal.Location = new System.Drawing.Point(4, 24);
            this.tabPageAgrPersonal.Name = "tabPageAgrPersonal";
            this.tabPageAgrPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAgrPersonal.Size = new System.Drawing.Size(1035, 510);
            this.tabPageAgrPersonal.TabIndex = 1;
            this.tabPageAgrPersonal.Text = "tabPage2";
            this.tabPageAgrPersonal.UseVisualStyleBackColor = true;
            this.tabPageAgrPersonal.Click += new System.EventHandler(this.tabPageUbicaciones_Click);
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(622, 373);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(123, 40);
            this.buttonCargar.TabIndex = 7;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(586, 126);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(87, 23);
            this.textBoxEdad.TabIndex = 6;
            this.textBoxEdad.Text = "Edad";
            this.textBoxEdad.Enter += new System.EventHandler(this.textBoxEdad_Enter);
            this.textBoxEdad.Leave += new System.EventHandler(this.textBoxEdad_Leave);
            // 
            // textBoxFuncion
            // 
            this.textBoxFuncion.Location = new System.Drawing.Point(459, 190);
            this.textBoxFuncion.Name = "textBoxFuncion";
            this.textBoxFuncion.Size = new System.Drawing.Size(228, 23);
            this.textBoxFuncion.TabIndex = 5;
            this.textBoxFuncion.Text = "Funcion";
            this.textBoxFuncion.Enter += new System.EventHandler(this.textBoxFuncion_Enter);
            this.textBoxFuncion.Leave += new System.EventHandler(this.textBoxFuncion_Leave);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Remunerado",
            "Voluntario"});
            this.comboBoxTipo.Location = new System.Drawing.Point(74, 191);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(222, 23);
            this.comboBoxTipo.TabIndex = 4;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(459, 126);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(87, 23);
            this.textBoxId.TabIndex = 3;
            this.textBoxId.Text = "Id";
            this.textBoxId.Enter += new System.EventHandler(this.textBoxId_Enter);
            this.textBoxId.Leave += new System.EventHandler(this.textBoxId_Leave);
            // 
            // textBoxNacionalidad
            // 
            this.textBoxNacionalidad.Location = new System.Drawing.Point(74, 126);
            this.textBoxNacionalidad.Name = "textBoxNacionalidad";
            this.textBoxNacionalidad.Size = new System.Drawing.Size(301, 23);
            this.textBoxNacionalidad.TabIndex = 2;
            this.textBoxNacionalidad.Text = "Nacionalidad";
            this.textBoxNacionalidad.Enter += new System.EventHandler(this.textBoxNacionalidad_Enter);
            this.textBoxNacionalidad.Leave += new System.EventHandler(this.textBoxNacionalidad_Leave);
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(459, 62);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(301, 23);
            this.textBoxApellidos.TabIndex = 1;
            this.textBoxApellidos.Text = "Apellidos";
            this.textBoxApellidos.Enter += new System.EventHandler(this.textBoxApellidos_Enter);
            this.textBoxApellidos.Leave += new System.EventHandler(this.textBoxApellidos_Leave);
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(74, 62);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(301, 23);
            this.textBoxNombres.TabIndex = 0;
            this.textBoxNombres.Text = "Nombres";
            this.textBoxNombres.Enter += new System.EventHandler(this.textBoxNombres_Enter);
            this.textBoxNombres.Leave += new System.EventHandler(this.textBoxNombres_Leave);
            // 
            // tabPageSeleccUbicacion
            // 
            this.tabPageSeleccUbicacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageSeleccUbicacion.BackgroundImage")));
            this.tabPageSeleccUbicacion.Controls.Add(this.buttonAgrPuntoRecc);
            this.tabPageSeleccUbicacion.Controls.Add(this.buttonAgrCentroComunitario);
            this.tabPageSeleccUbicacion.Location = new System.Drawing.Point(4, 24);
            this.tabPageSeleccUbicacion.Name = "tabPageSeleccUbicacion";
            this.tabPageSeleccUbicacion.Size = new System.Drawing.Size(1035, 510);
            this.tabPageSeleccUbicacion.TabIndex = 2;
            this.tabPageSeleccUbicacion.Text = "tabPage3";
            this.tabPageSeleccUbicacion.UseVisualStyleBackColor = true;
            // 
            // buttonAgrPuntoRecc
            // 
            this.buttonAgrPuntoRecc.Location = new System.Drawing.Point(118, 217);
            this.buttonAgrPuntoRecc.Name = "buttonAgrPuntoRecc";
            this.buttonAgrPuntoRecc.Size = new System.Drawing.Size(256, 69);
            this.buttonAgrPuntoRecc.TabIndex = 1;
            this.buttonAgrPuntoRecc.Text = "Añadir Punto Recoleccion";
            this.buttonAgrPuntoRecc.UseVisualStyleBackColor = true;
            this.buttonAgrPuntoRecc.Click += new System.EventHandler(this.buttonAgrPuntoRecc_Click);
            // 
            // buttonAgrCentroComunitario
            // 
            this.buttonAgrCentroComunitario.Location = new System.Drawing.Point(118, 100);
            this.buttonAgrCentroComunitario.Name = "buttonAgrCentroComunitario";
            this.buttonAgrCentroComunitario.Size = new System.Drawing.Size(256, 69);
            this.buttonAgrCentroComunitario.TabIndex = 0;
            this.buttonAgrCentroComunitario.Text = "Añadir Centro Comunitario";
            this.buttonAgrCentroComunitario.UseVisualStyleBackColor = true;
            this.buttonAgrCentroComunitario.Click += new System.EventHandler(this.buttonAgrCentroComunitario_Click);
            // 
            // tabPageAgrCampaña
            // 
            this.tabPageAgrCampaña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageAgrCampaña.BackgroundImage")));
            this.tabPageAgrCampaña.Controls.Add(this.buttonCargarCamp);
            this.tabPageAgrCampaña.Controls.Add(this.dateTimePickerFin);
            this.tabPageAgrCampaña.Controls.Add(this.dateTimePickerInicio);
            this.tabPageAgrCampaña.Controls.Add(this.textBoxMeta);
            this.tabPageAgrCampaña.Controls.Add(this.textBoxTitulo);
            this.tabPageAgrCampaña.Location = new System.Drawing.Point(4, 24);
            this.tabPageAgrCampaña.Name = "tabPageAgrCampaña";
            this.tabPageAgrCampaña.Size = new System.Drawing.Size(1035, 510);
            this.tabPageAgrCampaña.TabIndex = 3;
            this.tabPageAgrCampaña.Text = "tabPage4";
            this.tabPageAgrCampaña.UseVisualStyleBackColor = true;
            // 
            // buttonCargarCamp
            // 
            this.buttonCargarCamp.Location = new System.Drawing.Point(495, 368);
            this.buttonCargarCamp.Name = "buttonCargarCamp";
            this.buttonCargarCamp.Size = new System.Drawing.Size(165, 51);
            this.buttonCargarCamp.TabIndex = 4;
            this.buttonCargarCamp.Text = "Cargar";
            this.buttonCargarCamp.UseVisualStyleBackColor = true;
            this.buttonCargarCamp.Click += new System.EventHandler(this.buttonCargarCamp_Click);
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(71, 217);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(223, 23);
            this.dateTimePickerFin.TabIndex = 3;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(71, 167);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(223, 23);
            this.dateTimePickerInicio.TabIndex = 2;
            // 
            // textBoxMeta
            // 
            this.textBoxMeta.Location = new System.Drawing.Point(71, 117);
            this.textBoxMeta.Name = "textBoxMeta";
            this.textBoxMeta.Size = new System.Drawing.Size(185, 23);
            this.textBoxMeta.TabIndex = 1;
            this.textBoxMeta.Text = "Meta";
            this.textBoxMeta.Enter += new System.EventHandler(this.textBoxMeta_Enter);
            this.textBoxMeta.Leave += new System.EventHandler(this.textBoxMeta_Leave);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(71, 68);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(185, 23);
            this.textBoxTitulo.TabIndex = 0;
            this.textBoxTitulo.Text = "Titulo";
            this.textBoxTitulo.Enter += new System.EventHandler(this.textBoxTitulo_Enter);
            this.textBoxTitulo.Leave += new System.EventHandler(this.textBoxTitulo_Leave);
            // 
            // tabPageAgrCentroComunitario
            // 
            this.tabPageAgrCentroComunitario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageAgrCentroComunitario.BackgroundImage")));
            this.tabPageAgrCentroComunitario.Controls.Add(this.buttonCargarDatosCentro);
            this.tabPageAgrCentroComunitario.Controls.Add(this.buttonCargarPrograma);
            this.tabPageAgrCentroComunitario.Controls.Add(this.textBoxProgramas);
            this.tabPageAgrCentroComunitario.Controls.Add(this.dataGridViewProgramas);
            this.tabPageAgrCentroComunitario.Controls.Add(this.comboBoxPersonal);
            this.tabPageAgrCentroComunitario.Controls.Add(this.textBoxNombre);
            this.tabPageAgrCentroComunitario.Location = new System.Drawing.Point(4, 24);
            this.tabPageAgrCentroComunitario.Name = "tabPageAgrCentroComunitario";
            this.tabPageAgrCentroComunitario.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAgrCentroComunitario.Size = new System.Drawing.Size(1035, 510);
            this.tabPageAgrCentroComunitario.TabIndex = 4;
            this.tabPageAgrCentroComunitario.Text = "tabPage5";
            this.tabPageAgrCentroComunitario.UseVisualStyleBackColor = true;
            // 
            // buttonCargarDatosCentro
            // 
            this.buttonCargarDatosCentro.Location = new System.Drawing.Point(778, 436);
            this.buttonCargarDatosCentro.Name = "buttonCargarDatosCentro";
            this.buttonCargarDatosCentro.Size = new System.Drawing.Size(184, 41);
            this.buttonCargarDatosCentro.TabIndex = 6;
            this.buttonCargarDatosCentro.Text = "Cargar";
            this.buttonCargarDatosCentro.UseVisualStyleBackColor = true;
            this.buttonCargarDatosCentro.Click += new System.EventHandler(this.buttonCargarDatosCentro_Click);
            // 
            // buttonCargarPrograma
            // 
            this.buttonCargarPrograma.Location = new System.Drawing.Point(319, 115);
            this.buttonCargarPrograma.Name = "buttonCargarPrograma";
            this.buttonCargarPrograma.Size = new System.Drawing.Size(85, 23);
            this.buttonCargarPrograma.TabIndex = 5;
            this.buttonCargarPrograma.Text = "Cargar";
            this.buttonCargarPrograma.UseVisualStyleBackColor = true;
            this.buttonCargarPrograma.Click += new System.EventHandler(this.buttonCargarPrograma_Click);
            // 
            // textBoxProgramas
            // 
            this.textBoxProgramas.Location = new System.Drawing.Point(89, 115);
            this.textBoxProgramas.Name = "textBoxProgramas";
            this.textBoxProgramas.Size = new System.Drawing.Size(202, 23);
            this.textBoxProgramas.TabIndex = 4;
            this.textBoxProgramas.Text = "Insertar Programas";
            this.textBoxProgramas.Enter += new System.EventHandler(this.textBoxProgramas_Enter);
            this.textBoxProgramas.Leave += new System.EventHandler(this.textBoxProgramas_Leave);
            // 
            // dataGridViewProgramas
            // 
            this.dataGridViewProgramas.AllowUserToAddRows = false;
            this.dataGridViewProgramas.AllowUserToDeleteRows = false;
            this.dataGridViewProgramas.AllowUserToResizeColumns = false;
            this.dataGridViewProgramas.AllowUserToResizeRows = false;
            this.dataGridViewProgramas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProgramas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombres});
            this.dataGridViewProgramas.Location = new System.Drawing.Point(741, 115);
            this.dataGridViewProgramas.Name = "dataGridViewProgramas";
            this.dataGridViewProgramas.ReadOnly = true;
            this.dataGridViewProgramas.RowHeadersVisible = false;
            this.dataGridViewProgramas.RowTemplate.Height = 25;
            this.dataGridViewProgramas.Size = new System.Drawing.Size(221, 244);
            this.dataGridViewProgramas.TabIndex = 3;
            // 
            // ColumnNombres
            // 
            this.ColumnNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNombres.HeaderText = "Programas:";
            this.ColumnNombres.Name = "ColumnNombres";
            this.ColumnNombres.ReadOnly = true;
            this.ColumnNombres.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnNombres.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // comboBoxPersonal
            // 
            this.comboBoxPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPersonal.FormattingEnabled = true;
            this.comboBoxPersonal.Location = new System.Drawing.Point(89, 156);
            this.comboBoxPersonal.Name = "comboBoxPersonal";
            this.comboBoxPersonal.Size = new System.Drawing.Size(202, 23);
            this.comboBoxPersonal.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(89, 78);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(202, 23);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.Text = "Nombre";
            this.textBoxNombre.Enter += new System.EventHandler(this.textBoxNombre_Enter);
            this.textBoxNombre.Leave += new System.EventHandler(this.textBoxNombre_Leave);
            // 
            // tabPageAgrPuntoRecolecc
            // 
            this.tabPageAgrPuntoRecolecc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageAgrPuntoRecolecc.BackgroundImage")));
            this.tabPageAgrPuntoRecolecc.Controls.Add(this.dateTimePickerFechaFin);
            this.tabPageAgrPuntoRecolecc.Controls.Add(this.dateTimePickerFechaIni);
            this.tabPageAgrPuntoRecolecc.Controls.Add(this.textBoxInstitucion);
            this.tabPageAgrPuntoRecolecc.Controls.Add(this.buttonCargarDatosRecc);
            this.tabPageAgrPuntoRecolecc.Controls.Add(this.panelUbicacionDatos);
            this.tabPageAgrPuntoRecolecc.Location = new System.Drawing.Point(4, 24);
            this.tabPageAgrPuntoRecolecc.Name = "tabPageAgrPuntoRecolecc";
            this.tabPageAgrPuntoRecolecc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAgrPuntoRecolecc.Size = new System.Drawing.Size(1035, 510);
            this.tabPageAgrPuntoRecolecc.TabIndex = 5;
            this.tabPageAgrPuntoRecolecc.Text = "tabPage6";
            this.tabPageAgrPuntoRecolecc.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Checked = false;
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(97, 145);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(251, 23);
            this.dateTimePickerFechaFin.TabIndex = 5;
            // 
            // dateTimePickerFechaIni
            // 
            this.dateTimePickerFechaIni.Location = new System.Drawing.Point(97, 96);
            this.dateTimePickerFechaIni.Name = "dateTimePickerFechaIni";
            this.dateTimePickerFechaIni.Size = new System.Drawing.Size(251, 23);
            this.dateTimePickerFechaIni.TabIndex = 4;
            // 
            // textBoxInstitucion
            // 
            this.textBoxInstitucion.Location = new System.Drawing.Point(97, 50);
            this.textBoxInstitucion.Name = "textBoxInstitucion";
            this.textBoxInstitucion.Size = new System.Drawing.Size(193, 23);
            this.textBoxInstitucion.TabIndex = 3;
            this.textBoxInstitucion.Text = "Institucion";
            this.textBoxInstitucion.Enter += new System.EventHandler(this.textBoxInstitucion_Enter);
            this.textBoxInstitucion.Leave += new System.EventHandler(this.textBoxInstitucion_Leave);
            // 
            // buttonCargarDatosRecc
            // 
            this.buttonCargarDatosRecc.Location = new System.Drawing.Point(820, 424);
            this.buttonCargarDatosRecc.Name = "buttonCargarDatosRecc";
            this.buttonCargarDatosRecc.Size = new System.Drawing.Size(115, 47);
            this.buttonCargarDatosRecc.TabIndex = 0;
            this.buttonCargarDatosRecc.Text = "Cargar";
            this.buttonCargarDatosRecc.UseVisualStyleBackColor = true;
            this.buttonCargarDatosRecc.Click += new System.EventHandler(this.buttonCargarDatosRecc_Click);
            // 
            // panelUbicacionDatos
            // 
            this.panelUbicacionDatos.Controls.Add(this.textBoxNro);
            this.panelUbicacionDatos.Controls.Add(this.textBoxDepartamento);
            this.panelUbicacionDatos.Controls.Add(this.textBoxCalle);
            this.panelUbicacionDatos.Controls.Add(this.textBoxZona);
            this.panelUbicacionDatos.Controls.Add(this.textBoxCiudad);
            this.panelUbicacionDatos.Location = new System.Drawing.Point(61, 202);
            this.panelUbicacionDatos.Name = "panelUbicacionDatos";
            this.panelUbicacionDatos.Size = new System.Drawing.Size(365, 264);
            this.panelUbicacionDatos.TabIndex = 2;
            // 
            // textBoxNro
            // 
            this.textBoxNro.Location = new System.Drawing.Point(36, 222);
            this.textBoxNro.Name = "textBoxNro";
            this.textBoxNro.Size = new System.Drawing.Size(186, 23);
            this.textBoxNro.TabIndex = 4;
            this.textBoxNro.Text = "Nro";
            this.textBoxNro.Enter += new System.EventHandler(this.textBoxNro_Enter);
            this.textBoxNro.Leave += new System.EventHandler(this.textBoxNro_Leave);
            // 
            // textBoxDepartamento
            // 
            this.textBoxDepartamento.Location = new System.Drawing.Point(36, 181);
            this.textBoxDepartamento.Name = "textBoxDepartamento";
            this.textBoxDepartamento.Size = new System.Drawing.Size(186, 23);
            this.textBoxDepartamento.TabIndex = 3;
            this.textBoxDepartamento.Text = "Departamento";
            this.textBoxDepartamento.Enter += new System.EventHandler(this.textBoxDepartamento_Enter);
            this.textBoxDepartamento.Leave += new System.EventHandler(this.textBoxDepartamento_Leave);
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.Location = new System.Drawing.Point(36, 134);
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(186, 23);
            this.textBoxCalle.TabIndex = 2;
            this.textBoxCalle.Text = "Calle";
            this.textBoxCalle.Enter += new System.EventHandler(this.textBoxCalle_Enter);
            this.textBoxCalle.Leave += new System.EventHandler(this.textBoxCalle_Leave);
            // 
            // textBoxZona
            // 
            this.textBoxZona.Location = new System.Drawing.Point(36, 86);
            this.textBoxZona.Name = "textBoxZona";
            this.textBoxZona.Size = new System.Drawing.Size(186, 23);
            this.textBoxZona.TabIndex = 1;
            this.textBoxZona.Text = "Zona";
            this.textBoxZona.Enter += new System.EventHandler(this.textBoxZona_Enter);
            this.textBoxZona.Leave += new System.EventHandler(this.textBoxZona_Leave);
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(36, 35);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(186, 23);
            this.textBoxCiudad.TabIndex = 0;
            this.textBoxCiudad.Text = "Ciudad";
            this.textBoxCiudad.Enter += new System.EventHandler(this.textBoxCiudad_Enter);
            this.textBoxCiudad.Leave += new System.EventHandler(this.textBoxCiudad_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1057, 94);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // checkCentrosComunitarios
            // 
            this.checkCentrosComunitarios.BackColor = System.Drawing.Color.Transparent;
            this.checkCentrosComunitarios.Image = ((System.Drawing.Image)(resources.GetObject("checkCentrosComunitarios.Image")));
            this.checkCentrosComunitarios.Location = new System.Drawing.Point(41, -23);
            this.checkCentrosComunitarios.Name = "checkCentrosComunitarios";
            this.checkCentrosComunitarios.Size = new System.Drawing.Size(58, 56);
            this.checkCentrosComunitarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.checkCentrosComunitarios.TabIndex = 8;
            this.checkCentrosComunitarios.TabStop = false;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.Transparent;
            this.buttonSalir.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalir.Image")));
            this.buttonSalir.Location = new System.Drawing.Point(28, 3);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(42, 39);
            this.buttonSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonSalir.TabIndex = 8;
            this.buttonSalir.TabStop = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(36, 423);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(73, 75);
            this.buttonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonHome.TabIndex = 9;
            this.buttonHome.TabStop = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // PrincipalEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 558);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TabInicio);
            this.Name = "PrincipalEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PrincipalEmpleado";
            this.Load += new System.EventHandler(this.PrincipalEmpleado_Load);
            this.TabInicio.ResumeLayout(false);
            this.tabPageInicio.ResumeLayout(false);
            this.tabPageAgrPersonal.ResumeLayout(false);
            this.tabPageAgrPersonal.PerformLayout();
            this.tabPageSeleccUbicacion.ResumeLayout(false);
            this.tabPageAgrCampaña.ResumeLayout(false);
            this.tabPageAgrCampaña.PerformLayout();
            this.tabPageAgrCentroComunitario.ResumeLayout(false);
            this.tabPageAgrCentroComunitario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgramas)).EndInit();
            this.tabPageAgrPuntoRecolecc.ResumeLayout(false);
            this.tabPageAgrPuntoRecolecc.PerformLayout();
            this.panelUbicacionDatos.ResumeLayout(false);
            this.panelUbicacionDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkCentrosComunitarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabInicio;
        private System.Windows.Forms.TabPage tabPageInicio;
        private System.Windows.Forms.TabPage tabPageAgrPersonal;
        private System.Windows.Forms.Button buttonAgrCampaña;
        private System.Windows.Forms.Button buttonCampañas;
        private System.Windows.Forms.Button buttonAgrUbicacion;
        private System.Windows.Forms.TabPage tabPageSeleccUbicacion;
        private System.Windows.Forms.TabPage tabPageAgrCampaña;
        private System.Windows.Forms.Button buttonRegisDonacion;
        private System.Windows.Forms.Button buttonAgrPersonal;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNacionalidad;
        private System.Windows.Forms.TextBox textBoxFuncion;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.TabPage tabPageAgrCentroComunitario;
        private System.Windows.Forms.TabPage tabPageAgrPuntoRecolecc;
        private System.Windows.Forms.Button buttonAgrCentroComunitario;
        private System.Windows.Forms.Button buttonAgrPuntoRecc;
        private System.Windows.Forms.Panel panelUbicacionDatos;
        private System.Windows.Forms.TextBox textBoxZona;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.ComboBox comboBoxPersonal;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCalle;
        private System.Windows.Forms.TextBox textBoxDepartamento;
        private System.Windows.Forms.DataGridView dataGridViewProgramas;
        private System.Windows.Forms.Button buttonCargarPrograma;
        private System.Windows.Forms.TextBox textBoxProgramas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombres;
        private System.Windows.Forms.Button buttonCargarDatosCentro;
        private System.Windows.Forms.TextBox textBoxNro;
        private System.Windows.Forms.Button buttonCargarDatosRecc;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaIni;
        private System.Windows.Forms.TextBox textBoxInstitucion;
        private System.Windows.Forms.Button buttonCargarCamp;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.TextBox textBoxMeta;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox buttonHome;
        private System.Windows.Forms.PictureBox checkCentrosComunitarios;
        private System.Windows.Forms.PictureBox buttonSalir;
    }
}