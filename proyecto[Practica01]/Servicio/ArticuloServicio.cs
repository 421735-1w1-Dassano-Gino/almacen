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
