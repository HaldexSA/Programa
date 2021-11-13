using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class PersonalBD
    {
        public int registro(Personal personal)
        {
            MySqlConnection conexion = ConexionBD.getConexionBd();
            conexion.Open();

            string sql = "INSERT INTO personal (nombre, apellido, mail, telefono, cedula, direccion, rubro)
                VALUES(@nombre, @apellido, @mail, @telefono, @cedula, @direccion, @rubro)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", nombre.Nombre);
            comando.Parameters.AddWithValue("@apellido", apellido.Apellido);
            comando.Parameters.AddWithValue("@mail", mail.Mail);
            comando.Parameters.AddWithValue("@telefono", telefono.Telefono);
            comando.Parameters.AddWithValue("@cedula", cedula.Cedula);
            comando.Parameters.AddWithValue("@direccion", direccion.Direccion);
            comando.Parameters.AddWithValue("@rubro", rubro.Rubro);

            int resultado = comando.ExecuteNonQuery();

            return resultado;

        }
    }
}
