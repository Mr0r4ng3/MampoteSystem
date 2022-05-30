using MampoteSystem.Datos.Interfaces;
using MampoteSystem.Entidad;
using MampoteSystem.Entidad.Report;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.AdoNet
{
    public class DetalleCompraRepository : Repository<detalleCompra>, IDetalleCompraRepository
    {
        public DetalleCompraRepository(MampoteSystemContext mampoteSystemContext) : base(mampoteSystemContext)
        {
        }

        public int Crud(detalleCompra entity, string option)
        {
            try
            {
                return (int)ObjContext.ExecuteNonQuery("dbo.SpDetalleCompraMantenimiento", System.Data.CommandType.StoredProcedure,
                    new SqlParameter[]
                    {
                        new SqlParameter("@id",entity.id),
                        new SqlParameter("@idCompra",entity.idCompra),
                        new SqlParameter("@codigoProducot",entity.codigoProducto),
                        new SqlParameter("@Cantidad",entity.Cantidad),
                        new SqlParameter("@Precio_Compra",entity.PrecioCompra),
                        new SqlParameter("@Precio_Venta",entity.PrecioVenta),
                        new SqlParameter("@SubTotal",entity.SubTotal),
                        new SqlParameter("@Option",option)

                    });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<detalleCompraReport> GetList(string idCompra, decimal Tasa)
        {
            return ObjContext.ToList<detalleCompraReport>(
                    ObjContext.GetData("dbo.SpDetalleCompraList", new SqlParameter[]{
                        new SqlParameter("@idCompra",idCompra)
                    }).Tables[0]
                    );
        }
    }
}
