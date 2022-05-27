using MampoteSystem.Datos.Interfaces;
using System.Data.SqlClient;

namespace MampoteSystem.Datos.AdoNet.Helper
{
    public class GetNewID : IGetNewID
    {
        protected readonly MampoteSystemContext ObjContext;
        public GetNewID(MampoteSystemContext storageContext)
        {
            ObjContext = storageContext;
        }
        public string GetID(string option)
        {
            string command = "dbo.SpGetNewID";
            var salida = ObjContext.ExecuteScalar(command,
                System.Data.CommandType.StoredProcedure,
                new SqlParameter[]
                {
                    new SqlParameter("@option",option)
                });

            return (string)salida;
        }
    }
}
