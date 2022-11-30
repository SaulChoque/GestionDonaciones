using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionDonaciones
{
    public partial class Inicio : Plantilla
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void buttonDonante_Click(object sender, EventArgs e)
        {
            Form f1= new PrincipalDonante();
            f1.ShowDialog();
            
        }

        private void buttonEmpleado_Click(object sender, EventArgs e)
        {
            Form f1 = new PrincipalEmpleado();
            f1.ShowDialog();
        }
    }
}
