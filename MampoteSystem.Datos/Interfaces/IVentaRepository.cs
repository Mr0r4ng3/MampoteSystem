using MampoteSystem.Entidad;
using MampoteSystem.Entidad.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.Interfaces
{
    public interface IVentaRepository : IRepository<venta>
    {
        IEnumerable<ventaReport> GetList(DateTime desde, DateTime hasta, bool Vendido);
        int Crud(venta venta, detalleVenta detalle, bool isComision);
        string GetNewID();
        string GetNewFactura();
        int pagarComision(string idVenta, bool cancel);
        int actualizarNota(string idVenta, string Nota);
        int DeleteVenta(string idVenta);
        int DeleteDetalle(string idDetalle);
    }
}
