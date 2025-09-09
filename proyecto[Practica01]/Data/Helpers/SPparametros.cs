using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_Practica01_.Data.Helpers
{
    public class SPparametros
    {
        public string Nombre { get; set; }
        public object Valor { get; set; }

        public SPparametros() { }

        public SPparametros(string nombre, object valor)
        {
            Nombre = nombre;
            Valor = valor;
        }
    }
}
