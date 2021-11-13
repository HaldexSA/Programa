using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class RubroBD
    {
        public int registro(Rubro rubro)
        {
            MySqlConnection conexion = ConexionBD.getConexionBd();
            conexion.Open();

            string sql = "INSERT INTO rubro (codigo, nombre)
                VALUES(@codigo,@nombre)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@codigo", codigo.Codigo);
            comando.Parameters.AddWithValue("@nombre", nombre.Nombre);
            
            int resultado = comando.ExecuteNonQuery();

            return resultado;

        }
        public bool existeRubro(int codigo)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = conexionBD.getConexionBD();
            conexion.Open();

            string sql = "SELECT id FROM rubro WHERE codigo LIKE @codigo";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@codigo", codigo);

            reader = comando.ExecuteReader();
            
            if (reader.HasRows)
            {
                return true;
            }else
            {
                return false;
            }
        }
        
    }

}
