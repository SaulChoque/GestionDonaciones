using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionDonaciones
{
    public partial class PrincipalEmpleado : Plantilla
    {
        private int pers;
        
        public PrincipalEmpleado()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUbicaciones_Click(object sender, EventArgs e)
        {
            //tabControl1.SelectedTab = logTab;
            TabInicio.SelectedTab = tabPageAgrPersonal;
            
        }

        private void TabInicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCampañas_Click(object sender, EventArgs e)
        {
            TabInicio.SelectedTab = tabPageSeleccUbicacion;
        }

        private void buttonDonar_Click(object sender, EventArgs e)
        {
            TabInicio.SelectedTab = tabPageAgrCampaña;
        }

        private void tabPageUbicaciones_Click(object sender, EventArgs e)
        {

        }

        //LEER PERSONAL
        private void textBoxNombres_Enter(object sender, EventArgs e)
        {
            if (textBoxNombres.Text == "Nombres")
            {
                textBoxNombres.Text = "";
            }

        }

        private void textBoxNombres_Leave(object sender, EventArgs e)
        {
            if (textBoxNombres.Text == "")
            {
                textBoxNombres.Text = "Nombres";
            }
        }

        private void textBoxApellidos_Enter(object sender, EventArgs e)
        {
            if (textBoxApellidos.Text == "Apellidos")
            {
                textBoxApellidos.Text = "";
            }
        }

        private void textBoxApellidos_Leave(object sender, EventArgs e)
        {
            if (textBoxApellidos.Text == "")
            {
                textBoxApellidos.Text = "Apellidos";
            }
        }

        private void textBoxNacionalidad_Enter(object sender, EventArgs e)
        {
            if (textBoxNacionalidad.Text == "Nacionalidad")
            {
                textBoxNacionalidad.Text = "";
            }
        }

        private void textBoxNacionalidad_Leave(object sender, EventArgs e)
        {
            if (textBoxNacionalidad.Text == "")
            {
                textBoxNacionalidad.Text = "Nacionalidad";
            }
        }

        private void textBoxId_Enter(object sender, EventArgs e)
        {
            if (textBoxId.Text == "Id")
            {
                textBoxId.Text = "";
            }
        }

        private void textBoxId_Leave(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
            {
                textBoxId.Text = "Id";
            }
        }

        private void textBoxEdad_Enter(object sender, EventArgs e)
        {
            if (textBoxEdad.Text == "Edad")
            {
                textBoxEdad.Text = "";
            }
        }

        private void textBoxEdad_Leave(object sender, EventArgs e)
        {
            if (textBoxEdad.Text == "")
            {
                textBoxEdad.Text = "Edad";
            }
        }

        private void textBoxFuncion_Enter(object sender, EventArgs e)
        {
            if (textBoxFuncion.Text == "Funcion")
            {
                textBoxFuncion.Text = "";
            }
        }

        private void textBoxFuncion_Leave(object sender, EventArgs e)
        {
            if (textBoxFuncion.Text == "")
            {
                textBoxFuncion.Text = "Funcion";
            }
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            string nom,ape,nac,id,tip,func,codem;
		    int edad;
            nom=textBoxNombres.Text;
            ape=textBoxApellidos.Text;
            nac=textBoxNacionalidad.Text;
            id=textBoxId.Text;
            tip=comboBoxTipo.Text;
            func=textBoxFuncion.Text;
            edad=int.Parse(textBoxEdad.Text);
            codem=nom.Substring(0,2)+edad+ape.Substring(0,3);

            //string tip,string func,string cod,string nom,string ape,string nac,string id,int ed
            
            Personal p=new Personal(tip,func,codem,nom,ape,nac,id,edad);

            DialogResult d = MessageBox.Show("Se añadira a "+textBoxNombres.Text+" al registro de Empleados\n Esta Seguro?", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                base.archo.adicionarPersonal(tip,func,codem,nom,ape,nac,id,edad);
            }
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void buttonAgrCentroComunitario_Click(object sender, EventArgs e)
        {
            TabInicio.SelectedTab=tabPageAgrCentroComunitario;
        }

        private void buttonAgrPuntoRecc_Click(object sender, EventArgs e)
        {
            TabInicio.SelectedTab=tabPageAgrPuntoRecolecc;
        }

        //LEER CENTRO COMUNITARIO
        private void PrincipalEmpleado_Load(object sender, EventArgs e)
        {
            List<Personal> P=archo.getPersonal();
            for(int i=0; i<P.Count;i++){
                this.comboBoxPersonal.Items.Add(P[i].getNombres+" "+P[i].getApellidos);
            }
            /*
            foreach(Personal item in P){
                this.comboBoxPersonal.Items.Add(item.getNombres+" "+item.getApellidos);
            }*/
        }

        private void buttonCargarPrograma_Click(object sender, EventArgs e)
        {
            dataGridViewProgramas.Rows.Add(textBoxProgramas.Text);
            pers++;
            
        }

        private void textBoxNombre_Enter(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "Nombre")
            {
                textBoxNombre.Text = "";
            }
        }
        private void textBoxNombre_Leave(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "")
            {
                textBoxNombre.Text = "Nombre";
            }
        }
        private void textBoxProgramas_Enter(object sender, EventArgs e)
        {
            if (textBoxProgramas.Text == "Insertar Programas")
            {
                textBoxProgramas.Text = "";
            }
        }


        private void textBoxProgramas_Leave(object sender, EventArgs e)
        {
            if (textBoxProgramas.Text == "")
            {
                textBoxProgramas.Text = "Insertar Programas";
            }
        }

        private void textBoxCiudad_Enter(object sender, EventArgs e)
        {
            if (textBoxCiudad.Text == "Ciudad")
            {
                textBoxCiudad.Text = "";
            }
        }

        private void textBoxCiudad_Leave(object sender, EventArgs e)
        {
            if (textBoxCiudad.Text == "")
            {
                textBoxCiudad.Text = "Ciudad";
            }
        }

        private void textBoxZona_Enter(object sender, EventArgs e)
        {
            if (textBoxZona.Text == "Zona")
            {
                textBoxZona.Text = "";
            }
        }

        private void textBoxZona_Leave(object sender, EventArgs e)
        {
            if (textBoxZona.Text == "")
            {
                textBoxZona.Text = "Zona";
            }
        }

        private void textBoxCalle_Enter(object sender, EventArgs e)
        {
            if (textBoxCalle.Text == "Calle")
            {
                textBoxCalle.Text = "";
            }
        }

        private void textBoxCalle_Leave(object sender, EventArgs e)
        {
            if (textBoxCalle.Text == "")
            {
                textBoxCalle.Text = "Calle";
            }
        }

        private void textBoxDepartamento_Enter(object sender, EventArgs e)
        {
            if (textBoxDepartamento.Text == "Departamento")
            {
                textBoxDepartamento.Text = "";
            }
        }

        private void textBoxDepartamento_Leave(object sender, EventArgs e)
        {
            if (textBoxDepartamento.Text == "")
            {
                textBoxDepartamento.Text = "Departamento";
            }
        }

        private void textBoxNro_Enter(object sender, EventArgs e)
        {
            if (textBoxNro.Text == "Nro")
            {
                textBoxNro.Text = "";
            }
        }

        private void textBoxNro_Leave(object sender, EventArgs e)
        {
            if (textBoxNro.Text == "")
            {
                textBoxNro.Text = "Nro";
            }
        }
        private void buttonCargarDatosCentro_Click(object sender, EventArgs e)
        {
            string nom,ciu,zon,cal,dep,nro;
            nom=textBoxNombre.Text;
            ciu=textBoxCiudad.Text;
            zon=textBoxZona.Text;
            cal=textBoxCalle.Text;
            dep=textBoxDepartamento.Text;
            nro=textBoxNro.Text;
            List<Personal> p=archo.getPersonal();
            Personal pl=p[comboBoxPersonal.SelectedIndex];
            List<string> prgrm=new List<string>();
            for(int i=0; i<dataGridViewProgramas.RowCount; i++){
                prgrm.Add(dataGridViewProgramas.Rows[i].Cells[0].Value.ToString());
            }
            Ubicacion ub=new Ubicacion(ciu,zon,cal,dep,nro);
            DialogResult d = MessageBox.Show("Se añadira a "+textBoxNombre.Text+" al registro de Centros comunitarios\n Esta Seguro?", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                archo.adicionarCentroComunitario(nom,pl,ub,prgrm);
            }
        }

        private void textBoxInstitucion_Enter(object sender, EventArgs e)
        {
            if (textBoxInstitucion.Text == "Institucion")
            {
                textBoxInstitucion.Text = "";
            }
        }

        private void textBoxInstitucion_Leave(object sender, EventArgs e)
        {
            if (textBoxInstitucion.Text == "")
            {
                textBoxInstitucion.Text = "Institucion";
            }
        }

        private void buttonCargarDatosRecc_Click(object sender, EventArgs e)
        {
            string inst,ciu,zon,cal,dep,nro;
            DateTime d1=dateTimePickerFechaIni.Value;
            DateTime d2=dateTimePickerFechaFin.Value;

            ciu=textBoxCiudad.Text;
            inst=textBoxInstitucion.Text;
            zon=textBoxZona.Text;
            cal=textBoxCalle.Text;
            dep=textBoxDepartamento.Text;
            nro=textBoxNro.Text;
            Fecha f1=new Fecha(d1.Day,d1.Month,d1.Year);
            Fecha f2=new Fecha(d2.Day,d2.Month,d2.Year);
            Ubicacion ub=new Ubicacion(ciu,zon,cal,dep,nro);
            
            PuntoRecoleccion p=new PuntoRecoleccion(inst,ub,f1,f2);
            DialogResult d = MessageBox.Show("Se añadira a "+textBoxInstitucion.Text+" al registro de Puntos de recoleccion\n Esta Seguro?", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                archo.adicionarPuntoRecoleccion(p);
            }

        }

        private void textBoxTitulo_Enter(object sender, EventArgs e)
        {
            if (textBoxInstitucion.Text == "Institucion")
            {
                textBoxInstitucion.Text = "";
            }
        }

        private void textBoxTitulo_Leave(object sender, EventArgs e)
        {
            if (textBoxTitulo.Text == "")
            {
                textBoxTitulo.Text = "Titulo";
            }
        }

        private void textBoxMeta_Enter(object sender, EventArgs e)
        {
            if (textBoxMeta.Text == "Meta")
            {
                textBoxMeta.Text = "";
            }
        }

        private void textBoxMeta_Leave(object sender, EventArgs e)
        {
            if (textBoxMeta.Text == "")
            {
                textBoxMeta.Text = "Meta";
            }
        }
        private void buttonCargarCamp_Click(object sender, EventArgs e)
        {
            string tit=textBoxTitulo.Text;
            int met=int.Parse(textBoxMeta.Text);
            DateTime d1=dateTimePickerFechaIni.Value;
            DateTime d2=dateTimePickerFechaFin.Value;
            Fecha f1=new Fecha(d1.Day,d1.Month,d1.Year);
            Fecha f2=new Fecha(d2.Day,d2.Month,d2.Year);
            DialogResult d = MessageBox.Show("Se añadira a "+textBoxTitulo.Text+" al registro de Campañas\n Esta Seguro?", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                archo.adicionarCampaña(tit,met,f1,f2);
            }
        }

        private void buttonRegisDonacion_Click(object sender, EventArgs e)
        {
            Form f1 = new DonacionForm();
            f1.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            TabInicio.SelectedTab = tabPageInicio;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
