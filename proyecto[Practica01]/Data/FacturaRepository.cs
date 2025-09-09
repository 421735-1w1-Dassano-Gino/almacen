using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using proyecto_Practica01_.Dominio;
using proyecto_Practica01_.Data.Helpers;


namespace proyecto_Practica01_.Data
{
    public class FacturaRepository : IFacturaRepository
    {
        public List<Factura> GetAll()
        {
            List<Factura> lst = new List<Factura>();

            var dt = DataHelper.GetInstance().ExecuteSPQuery("SP_RECUPERAR_FACTURAS");

            foreach (DataRow row in dt.Rows) 
            {
                Factura f = new Factura();
                f.nro_factura = (int)row["nro_factura"];
                f.Fecha = (DateTime)row["fecha"];
                f.FormaPago = (string)row["nombre"];
                f.Cliente = (string)row["cliente"]; 
                lst.Add(f);
            }
            return lst;
        }

        public bool Delete(Factura factura) 
        {
            throw new NotImplementedException();
        }
        public bool Save(Factura factura)
        {
            List<SPparametros> sp = new List<SPparametros>()
            {
                new SPparametros("@ID", factura.nro_factura),
                new SPparametros("@fecha",factura.Fecha),
                new SPparametros("@formapago",factura.id_formapago),
                new SPparametros("@cliente",factura.Cliente)
            };
            return DataHelper.GetInstance().ExecuteSpDml("SP_GUARDAR_FACTURA", sp);

        }
        public Factura GetById(int id) 
        {
            throw new NotImplementedException(); 
        }
    }
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
                new SPparametros("@ID", detalleFactura.idDetalle),
                new SPparametros("@factura",detalleFactura.idFactura),
                new SPparametros("@articulo",detalleFactura.articulo),
                new SPparametros("@cantidad",detalleFactura.Cantidad)
            };
            return DataHelper.GetInstance().ExecuteSpDml("SP_GUARDAR_DETALLE", DFlst);

        }
        public DetalleFactura GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
    public class ArticuloRepository : IArticuloRepository 
    {
        public List<Articulo> GetAll()
        {
            List<Articulo> lst = new List<Articulo>();

            var dt = DataHelper.GetInstance().ExecuteSPQuery("SP_RECUPERAR_ARTICULOS");

            foreach (DataRow row in dt.Rows)
            {
                Articulo a = new Articulo();
                a.id_articulo = (int)row["id_articulo"];
                a.Nombre = (string)row["nombre"];
                a.PrecioUnitario = (decimal)row["precioUnitario"];
                lst.Add(a);
            }
            return lst;
        }

        public bool Delete(Articulo articulo)
        {
            throw new NotImplementedException();
        }
        public bool Save(Articulo articulo)
        {
            List<SPparametros> parametro = new List<SPparametros>()
            {
                new SPparametros("@id", articulo.id_articulo),
                new SPparametros("@nombre", articulo.Nombre),
                new SPparametros("@precio", articulo.PrecioUnitario)
            };
            return DataHelper.GetInstance().ExecuteSpDml("SP_GUARDAR_ARTICULO",parametro);

        }
        public Articulo GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
