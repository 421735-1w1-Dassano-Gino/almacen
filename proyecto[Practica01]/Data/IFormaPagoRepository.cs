using proyecto_Practica01_.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_Practica01_.Data
{
    public interface IFormaPagoRepository
    {
        List<FormaPago> GetAll();
        FormaPago GetById(int id);
        bool Save (FormaPago formaPago);
        bool Delete (FormaPago formaPago);
    }
    public interface IFacturaRepository
    {
        List<Factura> GetAll();
        Factura GetById(int id);
        bool Save (Factura factura);
        bool Delete (Factura factura);
    }
    public interface IDetalleFacturasRepository
    {
        List <DetalleFactura> GetAll();

        DetalleFactura GetById(int id);

        bool Save (DetalleFactura factura);

        bool Delete (DetalleFactura factura);
    }
    public interface IArticuloRepository
    {
        List <Articulo> GetAll();
        Articulo GetById(int id);
        bool Save (Articulo articulo);

        bool Delete (Articulo articulo);
    }
}
