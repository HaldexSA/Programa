using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class Rubro
    {
        int codigo;
        string nombre;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Rubro(int codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }
    }
}
