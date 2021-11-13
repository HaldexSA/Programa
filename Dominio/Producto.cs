using System;
using System.Collections.Generic;
using System.Text;

namespace CasaRepuesto
{
    class Producto
    {
        string nombre;
        int codigo;
        string destino;
        int cantidad;
        string origen;
        
        public string Nombre { get => nombre; set => nombre = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Destino { get => destino; set => destino = value;}
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Origen { get => origen; set => origen = value; }
        
        public Producto(string nombre, int codigo,string destino,int cantidad,string origen)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.destino = destino;
            this.cantidad = cantidad;
            this.origen = origen;
        
        }
    }
}
