using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_Practica01_.Dominio
{
    public class DetalleFactura
    {
        public int idDetalle { get; set; }
        public int idFactura {  get; set; }

        public string articulo { get; set; }

        public int Cantidad { get; set; }

        public override string ToString()
        {
            return idDetalle + " - " + idFactura + " - " + articulo + " - " + Cantidad;
        }
    }
}
