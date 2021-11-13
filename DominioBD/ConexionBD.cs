using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class Conexion
    {

        string servidor = "localhost";
        string bd = "haldexbd"; 
        string usuario = ""; 
        string password = ""; 
        string datos = null;

        string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + password + "; database=mysql;";

        MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

            try
            {

               conexionBD.Open();

               MySqlDataReader reader = null;

        MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", conexionBD);
        reader = cmd.ExecuteReader();
 
                while (reader.Read()) 
                {
                    datos += reader.GetString(0) + "\n"; 
                }

                MessageBox.Show(datos); 
            }
            catch (MySqlException ex)
            {
              MessageBox.Show(ex.ToString());
            }
             finally
{
    conexionBD.Close(); 
}
        

}
}
