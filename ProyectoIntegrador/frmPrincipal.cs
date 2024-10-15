using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        internal string? rol;
        internal string? usuario;

        private void btnInsciribrPostulante_Click(object sender, EventArgs e)
        {
            AltaSocio alta = new AltaSocio();
            alta.ShowDialog();
        }
    }
}
