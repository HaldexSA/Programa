using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class MovimientoBD
    {
        public int registro(Movimiento movimiento)
        {
            MySqlConnection conexion = ConexionBD.getConexionBd();
            conexion.Open();

            string sql = "INSERT INTO movimiento (fecha, codigo, nombre)
                VALUES(@fecha, @codigo, @nombre)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@fecha", fecha.Fecha);
            comando.Parameters.AddWithValue("@codigo", codigo.Codigo);
            comando.Parameters.AddWithValue("@nombre", nombre.Nombre);

            int resultado = comando.ExecuteNonQuery();

            return resultado;

        }
    }
}
