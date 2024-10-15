using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class AltaSocio : Form
    {
        public AltaSocio()
        {
            InitializeComponent();

            cbGenero.Items.Add("Masculino");
            cbGenero.Items.Add("Femenino");

            cbGenero.SelectedIndex = 0;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Datos.Socio socio = new Datos.Socio(txtNombre.Text, txtApellido.Text, cbGenero.Text, int.Parse(txtEdad.Text), int.Parse(txtDni.Text), int.Parse(txtNroSocio.Text));

            lblDatos.Text = socio.ToString();

        }
    }
}
