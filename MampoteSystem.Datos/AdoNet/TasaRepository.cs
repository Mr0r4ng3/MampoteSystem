using MampoteSystem.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.AdoNet
{
    public class TasaRepository : Repository<object>
    {
        public TasaRepository(MampoteSystemContext mampoteSystemContext) : base(mampoteSystemContext)
        {
        }

        public string readTasa()
        {
            return ObjContext.ExecuteScalar("select Valor from Tasa", System.Data.CommandType.Text).ToString();
        }

        public int setTasa(string newTasa)
        {
            return ObjContext.ExecuteNonQuery($"update Tasa set Valor = '{newTasa}'", System.Data.CommandType.Text);
        }
    }
}
