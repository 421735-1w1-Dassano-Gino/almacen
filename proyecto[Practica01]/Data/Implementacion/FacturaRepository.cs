using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using proyecto_Practica01_.Dominio;
using proyecto_Practica01_.Data.Helpers;
using proyecto_Practica01_.Data.Implementacion;


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
}
