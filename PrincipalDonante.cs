using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionDonaciones
{
    public partial class PrincipalDonante : Plantilla
    {
        private bool t= true, v=true;
        public PrincipalDonante()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUbicaciones_Click(object sender, EventArgs e)
        {
            int a=0,b=0;
            List<PuntoRecoleccion> ptr=archo.getPuntoRecoleccions();

            for(int j=b;j<ptr.Count;j++){
                //this.comboBoxPersonal.Items.Add(P[i].getNombres+" "+P[i].getApellidos);
                dataGridViewUbicacionGran.Rows[j].Cells[0].Value="Punto Recoleccion";
                dataGridViewUbicacionGran.Rows[j].Cells[1].Value=ptr[a].getInstitucion;
                dataGridViewUbicacionGran.Rows[j].Cells[2].Value=ptr[a].getDireccion;
                a++;
            }
            //tabControl1.SelectedTab = logTab;
            TabInicio.SelectedTab = tabPageUbicaciones;

            
        }

        private void TabInicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCampañas_Click(object sender, EventArgs e)
        {
            TabInicio.SelectedTab = tabPageCampañas;
        }

        private void buttonDonar_Click(object sender, EventArgs e)
        {
            Form f1 = new DonacionForm();
            f1.ShowDialog();
        }

        private void tabPageUbicaciones_Click(object sender, EventArgs e)
        {

        }

        private void checkCentrosComunitarios_Click(object sender, EventArgs e)
        {
            List<CentroComunitario> ctr=archo.getCentroComunitarios();
            for(int i=0;i<ctr.Count;i++){
                //this.comboBoxPersonal.Items.Add(P[i].getNombres+" "+P[i].getApellidos);
                dataGridViewUbicacionGran.Rows[i].Cells[0].Value=("Centro Comunitario");
                dataGridViewUbicacionGran.Rows[i].Cells[1].Value=ctr[i].getNombre;
                dataGridViewUbicacionGran.Rows[i].Cells[2].Value=ctr[i].getDireccion;
            }
         

            if(t==true){
                checkCentrosComunitarios.Image=Properties.Resources.bien;
                t=false;
            }else{
                checkCentrosComunitarios.Image=Properties.Resources.tache;
                t=true;
            }

        }
        private void checkPuntosRecoleccion_Click(object sender, EventArgs e)
        {
            if(v==true){
                checkPuntosRecoleccion.Image=Properties.Resources.bien;
                v=false;
            }else{
                checkPuntosRecoleccion.Image=Properties.Resources.tache;
                v=true;
            }
            
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            TabInicio.SelectedTab=tabPageInicio;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxTitulos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBoxFechas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrincipalDonante_Load(object sender, EventArgs e)
        {
            List<DateTime> dt=new List<DateTime>();
            for (int i=0; i<dt.Count; i++)
            {
                this.comboBoxFechas.Items.Add(dt[i]);
            }
            List<string> td= new List<string>();
            for (int i=0; i<td.Count; i++)
            {
                this.comboBoxTitulos.Items.Add(td[i]);
            }
        }




    }
}
