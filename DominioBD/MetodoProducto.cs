using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class MetodoProducto
    {
        public string agrProducto(Producto producto)
        {
            ProductoBD productobd = new ProductoBD();
            string respuesta = "";


            if (string.IsNullOrEmpty(nombre.Nombre) || (string.IsNullOrEmpty(codigo.Codigo) || (string.IsNullOrEmpty(destino.Destino) || (string.IsNullOrEmpty(cantidad.Cantidad) || (string.IsNullOrEmpty(origen.Origen))

            {
                respuesta = "Ingrese todos los datos";
            }
            class EliminarProducto
        {
            string nombre = txtNombre.Text;
            int codigo = int.Parse(txtCodigo.Text);
            string destino = txtDestino.Text;
            int cantidad = int.Parse(txtCantidad.Text);
            string origen = txtOrigen.Text;

            string sql = "DELTE FROM producto WHERE nombre='" + nombre + "' codigo= '" + codigo + "' destino='" + destino +"' cantidad='" + cantidad + "' origen= '" + origen + "'";

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
    class ModificarProducto
        {
          string nombre = txtNombre.Text;
          int cedula = int.Parse(txtCedula.Text);
          string destino = txtDestino.Text;
          int cantidad = int.Parse(txtCantidad.Text);
          string origen = txtOrigen.Text;

          string sql = "UPDATE producto SET nombre='" + nombre + "'WHERE cedula='" + cedula + "'";

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
