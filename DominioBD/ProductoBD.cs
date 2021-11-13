using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class ProductoBD
    {
        public int agregar(Producto producto)
        {
            MySqlConnection conexion = ConexionBD.getConexionBd();
            conexion.Open();

            string sql = "INSERT INTO producto (nombre, codigo, destino, cantidad, origen)
                VALUES(@nombre, @codigo, @destino, @cantidad, @origen )";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", nombre.Nombre);
            comando.Parameters.AddWithValue("@codigo", codigo.Codigo);
            comando.Parameters.AddWithValue("@destino", destino.Destino);
            comando.Parameters.AddWithValue("@cantidad", cantidad.Cantidad);
            comando.Parameters.AddWithValue("@origen", origen.Origen);

            int resultado = comando.ExecuteNonQuery();

            return resultado;

        }
    }
}
