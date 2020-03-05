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
    public class RutaRepository : MasterRepository,IRutaRepository
    {

        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public RutaRepository()
        {
            
                selectAll = "SELECT * FROM ERPL360.RUTA";
                insert = "insert into ERPL360.RUTA(RUTA,CONJUNTO,NOMBRE,RecordDate,CreatedBy,UpdatedBy,CreateDate) values(@RUTA,@CONJUNTO,@NOMBRE,@RecordDate,@CreatedBy,@UpdatedBy,@CreateDate)";
                update = "UPDATE ERPL360.RUTA SET  NOMBRE=@NOMBRE , RecordDate=@RecordDate,  UpdatedBy=@UpdatedBy   WHERE CONJUNTO=@CONJUNTO AND RUTA=@RUTA ";
                delete = "DELETE ERPL360.RUTA WHERE CONJUNTO=@CONJUNTO AND RUTA=@RUTA";
            
        }

        public int Add(Ruta entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@RUTA", entity.RUTA));
            parameters.Add(new SqlParameter("@CONJUNTO", entity.CONJUNTO));
            parameters.Add(new SqlParameter("@NOMBRE", entity.NOMBRE));
            parameters.Add(new SqlParameter("@RecordDate", entity.RecordDate));
            parameters.Add(new SqlParameter("@CreatedBy", entity.CreatedBy));
            parameters.Add(new SqlParameter("@UpdatedBy", entity.UpdatedBy));
            parameters.Add(new SqlParameter("@CreateDate", entity.CreateDate));
            return ExecuteNonQuery(insert);

        }

        public int Edit(Ruta entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@RUTA", entity.RUTA));
            parameters.Add(new SqlParameter("@CONJUNTO", entity.CONJUNTO));
            parameters.Add(new SqlParameter("@NOMBRE", entity.NOMBRE));
            parameters.Add(new SqlParameter("@RecordDate", entity.RecordDate));
            parameters.Add(new SqlParameter("@UpdatedBy", entity.UpdatedBy));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Ruta> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listRuta = new List<Ruta>();
            foreach (DataRow item in tableResult.Rows)
            {
                listRuta.Add(new Ruta
                {
                    RUTA = item[0].ToString(),
                    CONJUNTO = item[1].ToString(),
                    NOMBRE = item[2].ToString(),
                    RecordDate = Convert.ToDateTime(item[3]),
                    CreatedBy = item[4].ToString(),
                    UpdatedBy = item[5].ToString(),
                    CreateDate = Convert.ToDateTime(item[6]),

                });
            }
            return listRuta;
        }

        public int Remove(string valor)
        {
            throw new NotImplementedException();
        }

        public int Remove2(string RUTA, string CONJUNTO)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@RUTA", RUTA));
            parameters.Add(new SqlParameter("@CONJUNTO", CONJUNTO));
            return ExecuteNonQuery(delete);
        }
    }
}
