using proyecto_Practica01_.Data;
using proyecto_Practica01_.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_Practica01_.Servicio
{
    public class FacturaServicio
    {
        private IFacturaRepository _facturaRepository;
        public FacturaServicio()
        {
            _facturaRepository = new FacturaRepository();
        }
        public List<Factura> GetFacturas() 
        {
            return _facturaRepository.GetAll();
        }

        public bool SaveFactura(Factura factura)
        {
            return _facturaRepository.Save(factura);
        }
    }
    public class DetalleServicio
    {
        private IDetalleFacturasRepository _detalleFacturasRepository;
        public DetalleServicio()
        {
            _detalleFacturasRepository = new DetalleFacturaRepository();
        }
        public List<DetalleFactura> GetDetalleFacturas()
        {
            return _detalleFacturasRepository.GetAll();
        }
        public bool SaveDetalle(DetalleFactura detalleFactura)
        {
            return _detalleFacturasRepository.Save(detalleFactura);
        }
    }
    public class ArticuloServicio
    {
        private IArticuloRepository _articuloRepository;
        public ArticuloServicio()
        {
            _articuloRepository = new ArticuloRepository();
        }
        public List<Articulo> GetArticulos()
        {
            return _articuloRepository.GetAll();
        }
        public bool SaveArticulo(Articulo articulo)
        {
            return _articuloRepository.Save(articulo);
        }
    }
}
