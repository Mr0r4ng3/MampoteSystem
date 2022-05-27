using MampoteSystem.Datos.Interfaces;
using MampoteSystem.Entidad.Pagos;
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

        public int Crud(pago entity, decimal newDeuda, string NumeroFactura, bool Vendido)
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
                                                    new SqlParameter("@Vuelto",entity.Vuelto),
                                                    new SqlParameter("@Nota",entity.Nota),
                                                    new SqlParameter("@Usuario",entity.Usuario),
                                                    new SqlParameter("@NewDeuda",newDeuda),
                                                    new SqlParameter("@NumeroFactura",NumeroFactura),
                                                    new SqlParameter("@Vendido",Vendido)
                                    });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<pago> GetAll(DateTime desde, DateTime hasta)
        {
            return ObjContext.ToList<pago>(ObjContext.GetData("dbo.SpListAllPagos", new SqlParameter[]{
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
