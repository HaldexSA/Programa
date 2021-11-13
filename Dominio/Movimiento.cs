using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class Movimiento
    {
        string fecha;
        int codigo;
        string nombre;

        public string Fecha { get => fecha; set => fecha = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Movimiento(string fecha, int codigo, string nombre)
        {
            this.fecha = fecha;
            this.codigo = codigo;
            this.nombre = nombre;
        }
    }
}
