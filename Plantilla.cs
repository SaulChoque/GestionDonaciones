using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionDonaciones
{
    public partial class Plantilla : Form
    {
        protected ArchOrganizacion archo = new ArchOrganizacion(@"C:\Users\saulc\source\repos\GestionDonaciones\ORG.dat");

        public Plantilla()
        {
            InitializeComponent();
        }

    }
}
