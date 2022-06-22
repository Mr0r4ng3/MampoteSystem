using MampoteSystem.Datos.Interfaces;
using MampoteSystem.Entidad.Pagos;
using MampoteSystem.Entidad.Pagos.Report;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.AdoNet
{
    public class PagoRepository : Repository<pago>, IPagoRepository
    {
        public PagoRepository(MampoteSystemContext mampoteSystemContext) : base(mampoteSystemContext)
        {
        }

        public int Crud(pago entity, decimal newDeuda, string NumeroFactura, bool Vendido, bool ApplyDescuento, decimal NuevoMonto, 
            decimal NuevaComision, string AddDescuentoInNota, string Descuento, decimal TotalDescuento)
        {
            try
            {
                return (int)ObjContext.ExecuteNonQuery("dbo.SpPagoInsert", System.Data.CommandType.StoredProcedure,
                                    new SqlParameter[]
                                    {
                                                    new SqlParameter("@idVenta",entity.idVenta),
                                                    new SqlParameter("@idTipo",entity.idTipo),
                                                    new SqlParameter("@Monto",entity.Monto),
                                                    new SqlParameter("@Tasa",entity.Tasa),
                                                    new SqlParameter("@Vuelto_Divisas",entity.Vuelto_Divisas),
                                                    new SqlParameter("@Vuelto_Bolivares",entity.Vuelto_Bolivares),
                                                    new SqlParameter("@Propina",entity.Propina),
                                                    new SqlParameter("@Nota",entity.Nota),
                                                    new SqlParameter("@NewDeuda",newDeuda),
                                                    new SqlParameter("@NumeroFactura",NumeroFactura),
                                                    new SqlParameter("@Vendido",Vendido),

                                                    new SqlParameter("@Discount",ApplyDescuento),
                                                    new SqlParameter("@Comision",NuevaComision),
                                                    new SqlParameter("@NewTotal",NuevoMonto),
                                                    new SqlParameter("@PorcentajeDescuento",Descuento),
                                                    new SqlParameter("@TotalDescuento",TotalDescuento),
                                                    new SqlParameter("@AddDescuentoInNota",AddDescuentoInNota)
                                    });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<pagoReport> GetAll(DateTime desde, DateTime hasta)
        {
            return ObjContext.ToList<pagoReport>(ObjContext.GetData("dbo.SpListAllPagos", new SqlParameter[]{
                                            new SqlParameter("@Desde",desde),
                                            new SqlParameter("@Hasta",hasta)
                        }).Tables[0]);
        }

        public IEnumerable<pago> GetList(string idVenta)
        {
            return ObjContext.ToList<pago>(ObjContext.GetData("dbo.SpListPagoVenta", new SqlParameter[]
            {
                new SqlParameter("@idVenta", idVenta)
            }).Tables[0]);
        }
    }
}
