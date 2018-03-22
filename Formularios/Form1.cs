using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmHome : Form
    {


        Conexion c = new Conexion();
        public frmHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpGuardado.Visible = true;
            lbRut.Text = txtRut.Text;
            lbNombre.Text = txtNombre.Text;
            lbApellido.Text = txtApellido.Text;
            lbDireccion.Text = txtDireccion.Text;
            lbCiudad.Text = txtCiudad.Text;
            lbCiudad.Text = txtCiudad.Text;
            lbFecha.Text=dtpFecha.Text;

            {
                if (c.personaRegistrada(Convert.ToInt32(txtRut.Text)) == 0)
                {
                    MessageBox.Show(c.insertar(Convert.ToInt32(txtRut.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtCiudad.Text, dtpFecha.Text));
                    txtRut.Text = "";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtDireccion.Text = "";
                    txtCiudad.Text = "";
                    

                }
                else
                {
                    MessageBox.Show("El registro ya existe");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            grpGuardado.Visible = false;
            txtRut.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";

        }
    }
}
