using MampoteSystem.Entidad.Pagos;
using MampoteSystem.Entidad.Pagos.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.Interfaces
{
    public interface IPagoRepository : IRepository<pago>
    {
        IEnumerable<pago> GetList(string idVenta);
        int Crud(pago entity, decimal newDeuda, string NumeroFactura, bool Vendido);

        IEnumerable<pagoReport> GetAll(DateTime desde, DateTime hasta);
    }
}
