using CasaRepuestos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class CasaRepuesto
    {
        public string ctrlLogin(string usuario, string contrasenia)
        {
            MetodoBD mbd = new MetodoBD();
            string respuesta = "";
            Login datosLogin = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasenia))
            {
                respuesta = "Debe rellenar todos los campos";
            }
            else
            {
                datosLogin = CasaRepuesto.porLogin(usuario);

                if (datosLogin == null)
                {
                    respuesta = "El usuario no esta registrado";
                }

                return respuesta;
            }

            private void btnIngresar_Click(object sender, EventArgs e)
            {
                string usuario = txtUsuario.Text;
                string contrasenia = txtContrasenia.Text;

                try
                {
                    CasaRepuesto ctrl = new CasaRepuesto();
                    string respuesta = ctrlLogin(usuario, contrasenia);
                    if (respuesta.Length > 0)
                    {
                        MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        frmPrincipal frm = new frmPrincipal();
                        frm.Visible = true;
                        this.Visible = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}


    

