using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Logistika360.ERP.ERPADMIN.DataAccess.Repositories
{
  public abstract  class Repository
    {
        private readonly string connectionString;

        public Repository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["conERPL360"].ToString();
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
