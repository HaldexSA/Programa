using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class Personal
    {
        string nombre;
        string apellido;
        string mail;
        string telefono;
        int cedula;
        string direccion;
        string rubro;
     

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Cedula { get => cedula; set => cedula = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Rubro { get => rubro; set => rubro = value; }

        public Personal(string nombre, string apellido, string mail, string telefono, int cedula, string direccion, string rubro)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.telefono = telefono;
            this.cedula = cedula;
            this.direccion = direccion;
            this.rubro = rubro;
        }
    }
}
