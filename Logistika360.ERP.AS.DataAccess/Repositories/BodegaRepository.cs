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
    public class BodegaRepository : MasterRepository, IBodegaRepository
    {


        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public BodegaRepository()
        {

            selectAll = "SELECT * FROM " + UserLoginCache.CONJUNTO + ".BODEGA";
            insert = "insert into " + UserLoginCache.CONJUNTO + ".BODEGA(BODEGA,NOMBRE,TIPO,TELEFONO,DIRECCION,CONSEC_TRASLADOS,RecordDate,CreatedBy,UpdatedBy,CreateDate) values(@BODEGA,@NOMBRE,@TIPO,@TELEFONO,@DIRECCION,@CONSEC_TRASLADOS,@RecordDate,@CreatedBy,@UpdatedBy,@CreateDate)";
            update = "UPDATE " + UserLoginCache.CONJUNTO + ".BODEGA SET  NOMBRE=@NOMBRE , TIPO=@TIPO,TELEFONO=@TELEFONO,DIRECCION=@DIRECCION,CONSEC_TRASLADOS=@CONSEC_TRASLADOS, RecordDate=@RecordDate,  UpdatedBy=@UpdatedBy   WHERE BODEGA=@BODEGA ";
            delete = "DELETE " + UserLoginCache.CONJUNTO + ".BODEGA WHERE  BODEGA=@BODEGA";

        }
        public int Add(Bodega entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@BODEGA", entity.BODEGA));
            parameters.Add(new SqlParameter("@NOMBRE", entity.NOMBRE));
            parameters.Add(new SqlParameter("@TIPO", entity.TIPO));
            parameters.Add(new SqlParameter("@TELEFONO", entity.TELEFONO));
            parameters.Add(new SqlParameter("@DIRECCION", entity.DIRECCION));
            if (entity.CONSEC_TRASLADOS == "")
            {
                parameters.Add(new SqlParameter("@CONSEC_TRASLADOS", DBNull.Value));
            }
            else
            {
                parameters.Add(new SqlParameter("@CONSEC_TRASLADOS", entity.CONSEC_TRASLADOS));
            }
            
            parameters.Add(new SqlParameter("@RecordDate", entity.RecordDate));
            parameters.Add(new SqlParameter("@CreatedBy", entity.CreatedBy));
            parameters.Add(new SqlParameter("@UpdatedBy", entity.UpdatedBy));
            parameters.Add(new SqlParameter("@CreateDate", entity.CreateDate));
            return ExecuteNonQuery(insert);
        }

       

        public int Edit(Bodega entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@BODEGA", entity.BODEGA));
            parameters.Add(new SqlParameter("@NOMBRE", entity.NOMBRE));
            parameters.Add(new SqlParameter("@TIPO", entity.TIPO));
            parameters.Add(new SqlParameter("@TELEFONO", entity.TELEFONO));
            parameters.Add(new SqlParameter("@DIRECCION", entity.DIRECCION));
            if (entity.CONSEC_TRASLADOS=="")
            {
                parameters.Add(new SqlParameter("@CONSEC_TRASLADOS", DBNull.Value));
            }
            else
            {
                parameters.Add(new SqlParameter("@CONSEC_TRASLADOS", entity.CONSEC_TRASLADOS));
            }
            parameters.Add(new SqlParameter("@RecordDate", entity.RecordDate));
            parameters.Add(new SqlParameter("@UpdatedBy", entity.UpdatedBy));
            return ExecuteNonQuery(update);
        }
        

        public IEnumerable<Bodega> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listBodega = new List<Bodega>();
            foreach (DataRow item in tableResult.Rows)
            {
                listBodega.Add(new Bodega
                {
                    BODEGA = item[0].ToString(),
                    NOMBRE = item[1].ToString(),
                    TIPO = item[2].ToString(),
                    TELEFONO = item[3].ToString(),
                    DIRECCION = item[4].ToString(),
                    CONSEC_TRASLADOS = item[5].ToString(),
                    RecordDate = Convert.ToDateTime(item[6]),
                    CreatedBy = item[7].ToString(),
                    UpdatedBy = item[8].ToString(),
                    CreateDate = Convert.ToDateTime(item[9]),

                });
            }
            return listBodega;
        }

        public int Remove(string BODEGA)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@BODEGA", BODEGA));

            return ExecuteNonQuery(delete);
        }

        public int Remove2(string valor1, string valor2)
        {
            throw new NotImplementedException();
        }
    }
}
