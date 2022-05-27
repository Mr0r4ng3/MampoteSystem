using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampoteSystem.Datos.Interfaces;
using MampoteSystem.Datos.AdoNet;
using System.Data.SqlClient;
using System.Data;

namespace MampoteSystem.Datos
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        protected readonly MampoteSystemContext ObjContext;
        public Repository(MampoteSystemContext mampoteSystemContext) 
        {
            this.ObjContext = mampoteSystemContext;
        }
        public int Crud(string querySql, params SqlParameter[] sqlParameters)
        {
            try
            {
                return ObjContext.ExecuteNonQuery(querySql, CommandType.StoredProcedure,
                    sqlParameters);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Delete(string querySql, params SqlParameter[] sqlParameters)
        {
            return ObjContext.ExecuteNonQuery(querySql, CommandType.StoredProcedure,
                sqlParameters);
        }

        public IEnumerable<T> GetList(string querySql)
        {
            var dataSet = ObjContext.GetData(querySql);
            return ObjContext.ToList<T>(dataSet.Tables[0]);
        }

        public int Insert(string querySql, params SqlParameter[] sqlParameters)
        {
            return ObjContext.ExecuteNonQuery(querySql, CommandType.StoredProcedure,
                sqlParameters);
        }

        public int Update(string querySql, params SqlParameter[] sqlParameters)
        {
            return ObjContext.ExecuteNonQuery(querySql, CommandType.StoredProcedure,
                sqlParameters);
        }
    }
}
