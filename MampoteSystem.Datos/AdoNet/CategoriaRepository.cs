using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampoteSystem.Datos.Interfaces;
using MampoteSystem.Entidad;

namespace MampoteSystem.Datos.AdoNet
{
    public class CategoriaRepository : Repository<categoria>, ICategoriaRepository
    {

        public CategoriaRepository(MampoteSystemContext mampoteSystemContext) : base(mampoteSystemContext)
        {
        }

        public IEnumerable<categoria> GetListComida()
        {
            return GetList("dbo.SpCategoriaComidaList");

        }

        public IEnumerable<categoria> GetListProds()
        {
            return GetList("dbo.SpCategoriaProductosList");

        }
    }
}
