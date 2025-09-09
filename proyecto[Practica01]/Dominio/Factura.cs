using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace proyecto_Practica01_.Dominio
{
    public class Factura
    {
        public int nro_factura {  get; set; } 
        public DateTime Fecha { get; set; }

        public string FormaPago {  get; set; }

        public int id_formapago { get; set; }

        public string Cliente { get; set; }

        public override string ToString()
        {
            return nro_factura + " - " + Fecha + " - " + FormaPago + " - " + Cliente;
        }

    }
}
