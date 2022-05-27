using MampoteSystem.Entidad;
using MampoteSystem.Entidad.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.Interfaces
{
    public interface ICompraRepository : IRepository<compra>
    {
        IEnumerable<compraReport> GetList(DateTime desde, DateTime hasta);
        int Crud(compra compra, detalleCompra detalle);

        string GetNewID();
    }
}
