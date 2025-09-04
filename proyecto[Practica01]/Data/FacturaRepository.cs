using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using proyecto_Practica01_.Dominio;


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
            throw new NotImplementedException();
        }
        public Factura GetById(int id) 
        {
            throw new NotImplementedException(); 
        }
    }
    public class DetalleFacturaRepository : IDetalleFacturas
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
                df.articulo = (int)row["articulo"];
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
            throw new NotImplementedException();
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
                a.PrecioUnitario = (int)row["precioUnitario"];
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
            throw new NotImplementedException();
        }
        public Articulo GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
