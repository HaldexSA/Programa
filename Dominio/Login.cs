using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class Login
    {
        string usuario;
        string contrasenia;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        
        public Login(string usuario, string contrasenia)
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            
        }

      
    }
}
