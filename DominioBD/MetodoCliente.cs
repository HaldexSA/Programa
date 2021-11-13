using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class MetodoCliente
    {
        public string agrRegistro(Cliente cliente) 
        {
            ClienteBD clientebd = new ClienteBD();
            string respuesta = "";


            if(string.IsNullOrEmpty(cedula.Cedula))
            {
                respuesta = "Ingrese todos los datos";
            }
        
        }
        class EliminarCliente
        {
            int cedula = int.Parse(txtCedula.Text);

            string sql = "DELTE FROM cliente WHERE cedula='" + cedula + "'";

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
class ModificarCliente
{   
    int cedula = int.Parse(txtCedula.Text);
  
    string sql = "UPDATE cliente SET cedula='" + cedula + "'WHERE codigo='" + codigo + "'";

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
