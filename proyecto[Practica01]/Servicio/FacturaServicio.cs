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
}
