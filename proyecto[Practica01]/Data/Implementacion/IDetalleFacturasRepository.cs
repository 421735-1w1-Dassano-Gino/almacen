using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto_Practica01_.Dominio;

namespace proyecto_Practica01_.Data.Implementacion
{
    public interface IDetalleFacturasRepository
    {
        List<DetalleFactura> GetAll();

        DetalleFactura GetById(int id);

        bool Save(DetalleFactura factura);

        bool Delete(DetalleFactura factura);
    }
}
