using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Haldex
{
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load_1(object sender, EventArgs e)
        {

        }

        private void labelCerrar_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Desea Salir?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
              else
            {}
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea agregar usario?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            { }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("Desea modificar usario?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                { }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
                if (MessageBox.Show("Desea Eliminar usario?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                { }
           
        }
    }
}
