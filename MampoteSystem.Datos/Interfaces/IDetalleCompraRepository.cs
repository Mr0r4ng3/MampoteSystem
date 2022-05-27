using MampoteSystem.Entidad;
using MampoteSystem.Entidad.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.Interfaces
{
    public interface IDetalleCompraRepository : IRepository<detalleCompra>
    {
        IEnumerable<detalleCompraReport> GetList(string idCompra, decimal Tasa);
        int Crud(detalleCompra entity, string option);
    }
}
