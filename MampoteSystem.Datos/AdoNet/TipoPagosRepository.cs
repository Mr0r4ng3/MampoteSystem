using MampoteSystem.Datos.Interfaces;
using MampoteSystem.Entidad.Pagos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.AdoNet
{
    public class TipoPagosRepository : Repository<tipoPago>, ITipoPagoRepository
    {
        public TipoPagosRepository(MampoteSystemContext mampoteSystemContext) : base(mampoteSystemContext)
        {
        }

        public IEnumerable<tipoPago> GetList()
        {
            return GetList("dbo.SpTipoPagoList");
        }
    }
}
