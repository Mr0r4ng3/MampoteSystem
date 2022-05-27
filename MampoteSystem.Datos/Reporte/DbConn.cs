using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.Reporte
{
    public abstract class DbConn
    {
        private readonly string connectionString;

        public DbConn()
        {
            connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
