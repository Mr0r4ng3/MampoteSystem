using MampoteSystem.Entidad;
using MampoteSystem.Entidad.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.Interfaces
{
    public interface IProductosRepository : IRepository<productos>
    {
        IEnumerable<productosReport> GetListProds();
        IEnumerable<comidaReport> GetListComida();
        IEnumerable<prodComi> GetListTwo();
        int Crud(productos entity, string option);
        int setStock(string codigo, int cantidad);
    }
}
