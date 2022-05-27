using MampoteSystem.Datos.AdoNet;
using MampoteSystem.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MampoteSystem.Datos
{
    public class UnitOfWork : IUnitOfWork
    {
        private string stringConnection = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        protected MampoteSystemContext ObjContext;

        public ICategoriaRepository categoria { get; private set; }
        public IProductosRepository productos { get; private set; }
        public IProveedoresRepository proveedores { get; private set; }
        public IClientesRepository clientes{ get; private set; }
        public ICompraRepository compra { get; private set; }

        public IDetalleCompraRepository detalleCompra { get; private set; }

        public IUsuariosRepository usuarios { get; private set; }

        public IVentaRepository venta { get; private set; }

        public IDetalleVentaRepository detalleVenta { get; private set; }

        public ITipoPagoRepository tipoPagos { get; private set; }

        public IPagoRepository pago { get; private set; }

        public UnitOfWork() 
        {
            this.ObjContext = new MampoteSystemContext(stringConnection);

            categoria = new CategoriaRepository(ObjContext);
            productos = new ProductosRepository(ObjContext);
            proveedores = new ProveedoresRepository(ObjContext);
            clientes = new ClientesRepository(ObjContext);
            compra = new CompraRepository(ObjContext);
            detalleCompra = new DetalleCompraRepository(ObjContext);
            usuarios = new UsuariosRepository(ObjContext);
            venta = new VentaRepository(ObjContext);
            detalleVenta = new DetalleVentaRepository(ObjContext);
            tipoPagos = new TipoPagosRepository(ObjContext);
            pago = new PagoRepository(ObjContext);

        }
        public void Dispose()
        {
            ObjContext.Dispose();
        }
    }
}
