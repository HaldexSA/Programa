using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class MetodoMovimiento
    {
        public string agrMovimiento(Movimiento movimiento)
        {
            MovimientoBD movimientobd = new MovimientoBD();
            string respuesta = "";


            if (string.IsNullOrEmpty(fecha.Fecha) || (string.IsNullOrEmpty(codigo.Codigo) || (string.IsNullOrEmpty(nombre.Nombre))

            {
                respuesta = "Ingrese todos los datos";
            }

            class EliminarMovimiento
        {
            string fecha = txtFecha.Text;
            int codigo = int.Parse(txtCodigo.Text);
            string nombre = txtNombre.Text;

            string sql = "DELTE FROM movimiento WHERE fecha='" + fecha + "' codigo='" + codigo + "' nombre='" + nombre + "'";

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
class ModificarMovimineto
{
    string fecha = txtFecha.Text;
    int codigo = int.Parse(txtCodigo.Text);
    string nombre = txtNombre.Text;

    string sql = "UPDATE movimiento SET codigo='" + codigo + "'WHERE nombre='" + nombre + "'";

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
}
