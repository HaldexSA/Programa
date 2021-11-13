using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class MetodoRubro
    {
        public string agrRubro(Rubro rubro)
        {
            RubroBD rubrobd = new RubroBD();
            string respuesta = "";


            if (string.IsNullOrEmpty(nombre.Nombre) || string.IsNullOrEmpty(codigo.Codigo))
            {
                respuesta = "Ingrese todos los datos";
            }

            class EliminarRubro
        {
            int codigo = int.Parse(txtCodigo.Text);
            string nombre = txtNombre.Text;
            
            string sql = "DELTE FROM rubro WHERE codigo='" + codigo + "' nombre= '" + nombre + "'";

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
class ModificarRubro
{
    int codigo = int.Parse(txtCedula.Text);
    string nombre = txtNombre.Text;

    string sql = "UPDATE rubro SET codigo='" + codigo + "'WHERE nombre='" + nombre + "'";

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
