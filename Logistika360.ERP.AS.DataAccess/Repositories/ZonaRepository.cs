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
    public class ZonaRepository : MasterRepository, IZonaRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public ZonaRepository()
        {
            selectAll = "SELECT * FROM "+UserLoginCache.CONJUNTO+".ZONA";
            insert = "insert into "+UserLoginCache.CONJUNTO+".ZONA(ZONA,NOMBRE,RecordDate,CreatedBy,UpdatedBy,CreateDate) values(@ZONA,@NOMBRE,@RecordDate,@CreatedBy,@UpdatedBy,@CreateDate)";
            update = "UPDATE "+UserLoginCache.CONJUNTO+".ZONA SET  NOMBRE=@NOMBRE,  RecordDate=@RecordDate,  UpdatedBy=@UpdatedBy   WHERE  ZONA=@ZONA ";
            delete = "DELETE "+UserLoginCache.CONJUNTO+".ZONA WHERE  ZONA=@ZONA";
        }
        public int Add(Zona entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ZONA", entity.ZONA));
         
            parameters.Add(new SqlParameter("@NOMBRE", entity.NOMBRE));
            parameters.Add(new SqlParameter("@RecordDate", entity.RecordDate));
            parameters.Add(new SqlParameter("@CreatedBy", entity.CreatedBy));
            parameters.Add(new SqlParameter("@UpdatedBy", entity.UpdatedBy));
            parameters.Add(new SqlParameter("@CreateDate", entity.CreateDate));
            return ExecuteNonQuery(insert);

        }

        public int Edit(Zona entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ZONA", entity.ZONA));
            parameters.Add(new SqlParameter("@NOMBRE", entity.NOMBRE));
            parameters.Add(new SqlParameter("@RecordDate", entity.RecordDate));
            parameters.Add(new SqlParameter("@UpdatedBy", entity.UpdatedBy));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Zona> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listZona = new List<Zona>();
            foreach (DataRow item in tableResult.Rows)
            {
                listZona.Add(new Zona
                {
                    ZONA = item[0].ToString(),
                    NOMBRE = item[1].ToString(),
                    RecordDate = Convert.ToDateTime(item[2]),
                    CreatedBy = item[3].ToString(),
                    UpdatedBy = item[4].ToString(),
                    CreateDate = Convert.ToDateTime(item[5]),

                });
            }
            return listZona;
        }

        public int Remove(string ZONA)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ZONA", ZONA));
            return ExecuteNonQuery(delete);
            
        }

        public int Remove2(string ZONA, string CONJUNTO)
        {
            throw new NotImplementedException();
        }
    }
}
