using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto_Practica01_.Data.Helpers;
using proyecto_Practica01_.Dominio;

namespace proyecto_Practica01_.Data.Implementacion
{
    public class DetalleFacturaRepository : IDetalleFacturasRepository
    {
        public List<DetalleFactura> GetAll()
        {
            List<DetalleFactura> lst = new List<DetalleFactura>();

            var dt = DataHelper.GetInstance().ExecuteSPQuery("SP_RECUPERAR_DETALLESFACTURAS");

            foreach (DataRow row in dt.Rows)
            {
                DetalleFactura df = new DetalleFactura();
                df.idDetalle = (int)row["idDetalle"];
                df.idFactura = (int)row["idFactura"];
                df.articulo = (string)row["nombre"];
                df.Cantidad = (int)row["cantidad"];
                lst.Add(df);
            }
            return lst;
        }

        public bool Delete(DetalleFactura detalleFactura)
        {
            throw new NotImplementedException();
        }
        public bool Save(DetalleFactura detalleFactura)
        {
            List<SPparametros> DFlst = new List<SPparametros>()
            {
                new SPparametros("@id", detalleFactura.idDetalle),
                new SPparametros("@factura",detalleFactura.idFactura),
                new SPparametros("@articulo",detalleFactura.id_articulo),
                new SPparametros("@cantidad",detalleFactura.Cantidad)
            };
            return DataHelper.GetInstance().ExecuteSpDml("SP_GUARDAR_DETALLE", DFlst);

        }
        public DetalleFactura GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
