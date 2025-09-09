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
}
