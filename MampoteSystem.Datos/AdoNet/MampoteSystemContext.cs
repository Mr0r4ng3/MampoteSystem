using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.AdoNet
{
    public class MampoteSystemContext : SqlManager
    {
        private string StringSqlConnection;

        public MampoteSystemContext(string connectionString) : base(connectionString)
        {
            this.StringSqlConnection = connectionString;
        }
    }
}
