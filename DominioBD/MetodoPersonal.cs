using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class MetodoPersonal
    {
        public string agrPersonal(Personal personal)
        {
            PersonalBD personalbd = new PersonalBD();
            string respuesta = "";


            if (string.IsNullOrEmpty(nombre.Nombre) || (string.IsNullOrEmpty(apellido.Apellido) || (string.IsNullOrEmpty(mail.Mail) || (string.IsNullOrEmpty(telefono.Telefono) || (string.IsNullOrEmpty(cedula.Cedula) || (string.IsNullOrEmpty(direccion.Direccion) || (string.IsNullOrEmpty(rubro.Rubro))

            {
                respuesta = "Ingrese todos los datos";
            }
        }
        class EliminarPersonal
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string mail = txtMail.Text;
            string telefono = txtTelefono.Text;
            int cedula = int.Parse(txtCedula.Text);
            string direccion = txtDireccion.Text;
            string rubro = txtRubro.Text;

            string sql = "DELTE FROM personal WHERE nombre='" + nombre + "' apellido='" + apellido + "' mail='" + mail + "' telefono= '" + telefono + "' cedula= '" + cedula + "' direccion= '" + direccion + "' rubro='" + rubro + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try 
	    {	        
		MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            comando.ExecuteNonQuery();
        MessageBox.Show("Registro eliminado");
	    
                }
        
        catch (MySqlException ex)
	    {
             MessageBox.Show("Error al eliminar: "+ ex.Message);    
        }
        finally
        {
        conexionBD.Close();
        }
class ModificarPersonal
{
    string nombre = txtNombre.Text;
    string apellido = txtApellido.Text;
    string mail = txtMail.Text;
    string telefono = txtTelefono.Text;
    int cedula = int.Parse(txtCedula.Text);
    string direccion = txtDireccion.Text;
    string rubro = txtRubro.Text;

    string sql = "UPDATE personal SET nombre='" + nombre + "'WHERE cedula='" + cedula + "'";

    MySqlConnection conexionBD = Conexion.conexion();
    conexionBD.Open();

            try 
	{	        
		MySqlCommand comando = new MySqlCommand(sql, conexionBD);
    comando.ExecuteNonQuery();
        MessageBox.Show("Modificación exitosa");
	}
    catch (MySqlException ex)
{
    MessageBox.Show("Error al modificar: " + ex.Message);
}
finally
{
    conexionBD.Close();
}

 
     }
  }
}

