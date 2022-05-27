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
    }
}
