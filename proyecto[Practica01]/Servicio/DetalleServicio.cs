using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto_Practica01_.Data;
using proyecto_Practica01_.Data.Implementacion;
using proyecto_Practica01_.Dominio;

namespace proyecto_Practica01_.Servicio
{
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
}
