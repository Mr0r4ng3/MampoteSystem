using MampoteSystem.Datos.AdoNet.Helper;
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
    public class CompraRepository : Repository<compra>, ICompraRepository
    {
        IGetNewID _helper;
        public CompraRepository(MampoteSystemContext mampoteSystemContext) : base(mampoteSystemContext)
        {
            _helper = new GetNewID(mampoteSystemContext);
        }

        public int Crud(compra compra, detalleCompra detalle)
        {
            try
            {
                string querySql = "dbo.SpCompraInsert";
                return ObjContext.ExecuteNonQuery(querySql, System.Data.CommandType.StoredProcedure,
                    new SqlParameter[]{
                      
                        new SqlParameter("@idCompra",compra.id),
                        new SqlParameter("@Usuario",compra.Usuario),
                        new SqlParameter("@idProveedor",compra.idProveedor),
                        new SqlParameter("@NumeroFactura ",compra.NumeroFactura),
                        new SqlParameter("@MontoTotal ",compra.MontoTotal),
                        new SqlParameter("@Tasa",compra.Tasa),
                      //Sección para Detale
                        new SqlParameter("@idDetalle",""),
                        new SqlParameter("@codigoProducto",detalle.codigoProducto),
                        new SqlParameter("@Cantidad",detalle.Cantidad),
                        new SqlParameter("@Precio_Compra",detalle.PrecioCompra),
                        new SqlParameter("@Precio_Venta",detalle.PrecioVenta),
                        new SqlParameter("@SubTotal",detalle.SubTotal)
                    });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<compraReport> GetList(DateTime desde, DateTime hasta)
        {
            return ObjContext.ToList<compraReport>(
                    ObjContext.GetData("dbo.SpCompraList", new SqlParameter[]{
                        new SqlParameter("@Desde",desde),
                        new SqlParameter("@Hasta",hasta),
                    }).Tables[0]
                );
        }

        public string GetNewID()
        {
            return _helper.GetID("Compra");
        }

        public int DeleteDetalle(string idDetalle)
        {
            try
            {
                return ObjContext.ExecuteNonQuery($"delete detalleCompra where id = '{idDetalle}'", System.Data.CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteCompra(string idCompra)
        {
            try
            {
                return ObjContext.ExecuteNonQuery($"delete compra where id = '{idCompra}'", System.Data.CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
