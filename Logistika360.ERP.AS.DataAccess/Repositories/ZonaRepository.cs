using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logistika360.ERP.ERPADMIN.DataAccess.Repositories;
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
            selectAll = "SELECT * FROM ERPL360.ZONA";
            insert = "insert into ERPL360.ZONA(ZONA,CONJUNTO,NOMBRE,RecordDate,CreatedBy,UpdatedBy,CreateDate) values(@ZONA,@CONJUNTO,@NOMBRE,@RecordDate,@CreatedBy,@UpdatedBy,@CreateDate)";
            update = "UPDATE ERPL360.ZONA SET  NOMBRE=@NOMBRE,  RecordDate=@RecordDate,  UpdatedBy=@UpdatedBy   WHERE CONJUNTO=@CONJUNTO AND ZONA=@ZONA ";
            delete = "DELETE ERPL360.ZONA WHERE CONJUNTO=@CONJUNTO AND ZONA=@ZONA";
        }
        public int Add(Zona entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ZONA", entity.ZONA));
            parameters.Add(new SqlParameter("@CONJUNTO", entity.CONJUNTO));
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
            parameters.Add(new SqlParameter("@CONJUNTO", entity.CONJUNTO));
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
                    CONJUNTO = item[1].ToString(),
                    NOMBRE = item[2].ToString(),
                    RecordDate = Convert.ToDateTime(item[3]),
                    CreatedBy = item[4].ToString(),
                    UpdatedBy = item[5].ToString(),
                    CreateDate = Convert.ToDateTime(item[6]),

                });
            }
            return listZona;
        }

        public int Remove(string valor)
        {
            throw new NotImplementedException();
        }

        public int Remove2(string ZONA, string CONJUNTO)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ZONA", ZONA));
            parameters.Add(new SqlParameter("@CONJUNTO", CONJUNTO));
            return ExecuteNonQuery(delete);
        }
    }
}
