using MampoteSystem.Entidad;
using MampoteSystem.Entidad.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.Interfaces
{
    public interface IDetalleVentaRepository : IRepository<detalleVenta>
    {
        IEnumerable<detalleVentaReport> GetDetalles(string idVenta);
        IEnumerable<detalleVentaReport> GetDetallesReport(string idVenta);

    }
}
