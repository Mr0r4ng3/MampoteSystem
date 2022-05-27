using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.Interfaces
{
    public interface IRepository<T> where T : class, new()
    {
        int Insert(string querySql, params SqlParameter[] sqlParameters);
        int Update(string querySql, params SqlParameter[] sqlParameters);
        int Delete(string querySql, params SqlParameter[] sqlParameters);
        int Crud(string querySql, params SqlParameter[] sqlParameters); //Insert, Update, Delete
        IEnumerable<T> GetList(string querySql);
    }
}
