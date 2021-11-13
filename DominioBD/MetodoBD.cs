
using CasaRepuesto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuestos
{
    class MetodoBD
    {
            public Login porLogin(string login)
            {
                MySqlConnection conexion = conexionBD.getConexionBd();
                conexion.Open();

                string sql = "SELECT usuario,contrasenia FROM login WHERE usuario LIKE @usuario";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@usuario", login);

                reader = comando.ExecuteReader();

                Login log = null;

                while (reader.Read())
                {
                    log = new Login();
                    log.Usuario = reader["usuario"].ToString();
                    log.Contrasenia = reader["contrasenia"].ToString();

                }

                return log;

            }
        }
    }
}
