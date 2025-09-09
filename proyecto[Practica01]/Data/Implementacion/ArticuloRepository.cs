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
            return DataHelper.GetInstance().ExecuteSpDml("SP_GUARDAR_ARTICULO", parametro);

        }
        public Articulo GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
