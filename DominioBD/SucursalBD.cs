using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class SucursalBD
    {
        public int registro(Sucursal sucursal)
        {
            MySqlConnection conexion = ConexionBD.getConexionBd();
            conexion.Open();

            string sql = "INSERT INTO sucursal (numero, cantidad)"
                VALUES(@numero, @cantidad)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@numero", numero.Numero);
            comando.Parameters.AddWithValue("@cantidad", cantidad.Cantidad);

            int resultado = comando.ExecuteNonQuery();

            return resultado;

        }
    }
}
