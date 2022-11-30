using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionDonaciones
{
    public partial class DonacionForm : Plantilla
    {
        public DonacionForm()
        {
            InitializeComponent();
        }

        private void textBoxRazonSocial_Enter(object sender, EventArgs e)
        {
            if (textBoxRazonSocial.Text == "RazonSocial")
            {
                textBoxRazonSocial.Text = "";
            }
        }

        private void textBoxRazonSocial_Leave(object sender, EventArgs e)
        {
            if (textBoxRazonSocial.Text == "")
            {
                textBoxRazonSocial.Text = "RazonSocial";
            }
        }

        private void textBoxDescripcion_Enter(object sender, EventArgs e)
        {
            if (textBoxDescripcion.Text == "Descripcion")
            {
                textBoxDescripcion.Text = "";
            }
        }

        private void textBoxDescripcion_Leave(object sender, EventArgs e)
        {
            if (textBoxDescripcion.Text == "")
            {
                textBoxDescripcion.Text = "Descripcion";
            }
        }

        private void textBoxValia_Enter(object sender, EventArgs e)
        {
            if (textBoxValia.Text == "Valia")
            {
                textBoxValia.Text = "";
            }
        }

        private void textBoxValia_Leave(object sender, EventArgs e)
        {
            if (textBoxValia.Text == "")
            {
                textBoxValia.Text = "Valia";
            }
        }

        private void buttonCargarDonacion_Click(object sender, EventArgs e)
        {
            string rz,desc;
            desc=textBoxDescripcion.Text;
            rz=textBoxRazonSocial.Text;
            int vall=int.Parse(textBoxValia.Text);
            int pl=comboBoxCampañas.SelectedIndex;
            DateTime d1=dateTimePickerFecha.Value;
            List<string> prgrm=new List<string>();
            Fecha f1=new Fecha(d1.Day,d1.Month,d1.Year);
            Donacion dn=new Donacion(rz,desc,vall,f1);
            DialogResult d = MessageBox.Show("Se añadira la donacion de "+textBoxRazonSocial+" al registro de Donaciones\n Esta Seguro?", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                archo.adicionarDonaciones(dn,pl);
            }
        }

        private void DonacionForm_Load(object sender, EventArgs e)
        {
            List<string> P=archo.getTitulosCampañas();
            for(int i=0; i<P.Count;i++){
                this.comboBoxCampañas.Items.Add(P[i]);
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
