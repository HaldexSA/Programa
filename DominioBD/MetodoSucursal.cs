using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class MetodoSucursal
    {
        public string agrSucursal(Sucursal sucursal)
        {
            SucursalBD sucursalbd = new SucursalBD();
            string respuesta = "";


            if (string.IsNullOrEmpty(numero.Numero) || string.IsNullOrEmpty(cantidad.Cantidad))
            {
                respuesta = "Ingrese todos los datos";
            }
        }

        class EliminarSucursal
        {
            int numero = int.Parse(txtNumero.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            
            string sql = "DELTE FROM sucursal WHERE numero='" + numero + "'";

            MySqlConnection conexionBD = ConexionBD.conexion();
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
class ModificarSucursal
{
    int numero = int.Parse(txtNumero.Text);
    int cantidad = int.Parse(txtCantidad.Text);
    
    string sql = "UPDATE sucursal SET numero='" + numero + "'WHERE cantidad='" + cantidad + "'";

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
}
