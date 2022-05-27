using MampoteSystem.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.Interfaces
{
    public interface IProveedoresRepository : IRepository<proveedores>
    {
        IEnumerable<proveedores> GetList();
        int Crud(proveedores entity, string option);
        proveedores GetProveedor(string RIF);
    }
}
