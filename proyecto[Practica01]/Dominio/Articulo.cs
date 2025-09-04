using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_Practica01_.Dominio
{
    public class Articulo
    {
        public int id_articulo {  get; set; }
        public string Nombre {  get; set; }

        public int PrecioUnitario { get; set; }

        public override string ToString()
        {
            return id_articulo + " - " + Nombre + " - " + PrecioUnitario;
        }

    }
}
