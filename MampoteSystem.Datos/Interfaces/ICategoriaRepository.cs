using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampoteSystem.Entidad;

namespace MampoteSystem.Datos.Interfaces
{
    public interface ICategoriaRepository : IRepository<categoria>
    {
        IEnumerable<categoria> GetListComida();
        IEnumerable<categoria> GetListProds();
    }
}
