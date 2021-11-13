using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class Sucursal
    {
        int numero;
        int cantidad;
        public int Numero { get => numero; set => numero = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public Sucursal(int numero)
        {
            this.numero = numero;
        }
    }
}
