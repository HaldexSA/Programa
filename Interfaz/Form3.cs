using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Haldex
{
    public partial class Menu : Form
    {     //  private Button currentButton;
           // private Random random;
           // private int tempIndex;
        public Menu()
        {
            
            InitializeComponent();
        }
        /*/private void AgregarUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuario ventana = new AgregarUsuario(); // Copiar en cada boton xd
            ventana.MdiParent = Menu.ActiveForm;
            ventana.Show();
        }/*/

        private void Menu_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
           // lblUser.Text = e.nombres;// Agregar Cuando tenga parte Programacion
        }

        private void PanelProbar_Paint(object sender, PaintEventArgs e)
        {
            AgregarUsuario ventana = new AgregarUsuario(); // Copiar en cada boton xd
            ventana.MdiParent = Menu.ActiveForm;
            ventana.Show();
        }
    }
}
