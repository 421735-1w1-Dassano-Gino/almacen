using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto_Practica01_.Dominio;

namespace proyecto_Practica01_.Data.Implementacion
{
    public interface IFacturaRepository
    {
        List<Factura> GetAll();
        Factura GetById(int id);
        bool Save(Factura factura);
        bool Delete(Factura factura);
    }
}
