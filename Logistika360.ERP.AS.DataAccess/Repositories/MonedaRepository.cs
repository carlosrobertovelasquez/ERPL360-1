using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logistika360.ERP.ERPADMIN.DataAccess.Repositories;
using Logistika360.ERP.ERPADMIN.Common.Cache;
using Logistika360.ERP.AS.DataAccess.Entities;
using Logistika360.ERP.AS.DataAccess.Contracts;
using System.Data;
using System.Data.SqlClient;

namespace Logistika360.ERP.AS.DataAccess.Repositories
{
    public class MonedaRepository : MasterRepository, IMonedaRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public MonedaRepository()
        {

            selectAll = "SELECT * FROM " + UserLoginCache.CONJUNTO + ".MONEDA";
            insert = "insert into " + UserLoginCache.CONJUNTO + ".MONEDA(MONEDA,NOMBRE,CODIGO_ISO,RecordDate,CreatedBy,UpdatedBy,CreateDate) values(@MONEDA,@NOMBRE,@CODIGO_ISO,@RecordDate,@CreatedBy,@UpdatedBy,@CreateDate)";
            update = "UPDATE " + UserLoginCache.CONJUNTO + ".MONEDA SET  NOMBRE=@NOMBRE , CODIGO_ISO=@CODIGO_ISO, RecordDate=@RecordDate,  UpdatedBy=@UpdatedBy   WHERE MONEDA=@MONEDA ";
            delete = "DELETE " + UserLoginCache.CONJUNTO + ".MONEDA WHERE  MONEDA=@MONEDA";

        }

        public int Add(Moneda entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MONEDA", entity.MONEDA));
            parameters.Add(new SqlParameter("@NOMBRE", entity.NOMBRE));
            parameters.Add(new SqlParameter("@CODIGO_ISO", entity.CODIGO_ISO));
            parameters.Add(new SqlParameter("@RecordDate", entity.RecordDate));
            parameters.Add(new SqlParameter("@CreatedBy", entity.CreatedBy));
            parameters.Add(new SqlParameter("@UpdatedBy", entity.UpdatedBy));
            parameters.Add(new SqlParameter("@CreateDate", entity.CreateDate));
            return ExecuteNonQuery(insert);
        }

        public int Edit(Moneda entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MONEDA", entity.MONEDA));
            parameters.Add(new SqlParameter("@NOMBRE", entity.NOMBRE));
            parameters.Add(new SqlParameter("@CODIGO_ISO", entity.CODIGO_ISO));
            parameters.Add(new SqlParameter("@RecordDate", entity.RecordDate));
            parameters.Add(new SqlParameter("@UpdatedBy", entity.UpdatedBy));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Moneda> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listMoneda= new List<Moneda>();
            foreach (DataRow item in tableResult.Rows)
            {
                listMoneda.Add(new Moneda
                {
                    MONEDA = item[0].ToString(),
                    NOMBRE = item[1].ToString(),
                    CODIGO_ISO = item[2].ToString(),
                    RecordDate = Convert.ToDateTime(item[3]),
                    CreatedBy = item[4].ToString(),
                    UpdatedBy = item[5].ToString(),
                    CreateDate = Convert.ToDateTime(item[6]),

                });
            }
            return listMoneda;
        }

        public int Remove(string MONEDA)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MONEDA", MONEDA));

            return ExecuteNonQuery(delete);
        }

        public int Remove2(string valor1, string valor2)
        {
            throw new NotImplementedException();
        }
    }
}
