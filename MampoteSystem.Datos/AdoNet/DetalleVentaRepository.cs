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
    public class DetalleVentaRepository : Repository<detalleVenta>, IDetalleVentaRepository
    {
        public DetalleVentaRepository(MampoteSystemContext mampoteSystemContext) : base(mampoteSystemContext)
        {
        }

        public IEnumerable<detalleVentaReport> GetDetalles(string idVenta)
        {
            return ObjContext.ToList<detalleVentaReport>(
                    ObjContext.GetData("dbo.SpDetalleVentaList", new SqlParameter[]{
                        new SqlParameter("@idVenta",idVenta),
                    }).Tables[0]
                    );
        }

        public IEnumerable<detalleVentaReport> GetDetallesReport(string idVenta)
        {
            string command = "select d.Tipo," +
                                "d.Codigo," +
                                "p.Nombre," +
                                "SUM(d.Cantidad) as Cantidad," +
                                "d.Precio_Venta," +
                                "d.IVA," +
                                "SUM(d.SubTotal) as SubTotal " +
                            "from detalleVenta d " +
                            "join productos p on d.Codigo = p.Codigo " +
                            $"where d.idVenta = '{idVenta}' " +
                            "group by d.Tipo, d.Codigo, p.Nombre, d.Precio_Venta, d.IVA";

            return ObjContext.ToList<detalleVentaReport>(
                            ObjContext.GetData(command).Tables[0]
                        );
        }
    }
}
