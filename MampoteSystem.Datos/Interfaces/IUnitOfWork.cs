using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoriaRepository categoria { get; }
        IProductosRepository productos { get; }
        IProveedoresRepository proveedores { get; }
        IClientesRepository clientes { get; }
        ICompraRepository compra { get; }
        IDetalleCompraRepository detalleCompra { get; }
        IUsuariosRepository usuarios { get; }
        IVentaRepository venta { get; }
        IDetalleVentaRepository detalleVenta { get; }
        ITipoPagoRepository tipoPagos { get; }
        IPagoRepository pago { get; }
    }
}
