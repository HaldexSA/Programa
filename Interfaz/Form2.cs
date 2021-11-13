using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Haldex
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 ventana = new Form5();
            ventana.Show();

            this.Hide();
        }

        private void lblAdministrador_Click(object sender, EventArgs e)
        {

        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            
    }

        private void Operador_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Administrador_Click(object sender, EventArgs e)
        {

            Form5 ventana = new Form5();
            ventana.Show();

            this.Hide();
        }
    }
}