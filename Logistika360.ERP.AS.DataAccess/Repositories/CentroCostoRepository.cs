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
    public class CentroCostoRepository : MasterRepository, ICentroCostoRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public CentroCostoRepository()
        {

            selectAll = "SELECT * FROM ERPL360.CENTRO_COSTO";
            insert = "insert into ERPL360.CENTRO_COSTO(CENTRO_COSTO,CONJUNTO,DESCRIPCION,ACEPTA_DATOS,TIPO,RecordDate,CreatedBy,UpdatedBy,CreateDate) values(@RUTA,@CONJUNTO,@NOMBRE,@RecordDate,@CreatedBy,@UpdatedBy,@CreateDate)";
            update = "UPDATE ERPL360.CENTRO_COSTO SET  DESCRIPCION=@DESCRIPCION , ACEPTA_DATOS=@ACEPTA_DATOS,TIPO=@TIPO, RecordDate=@RecordDate,  UpdatedBy=@UpdatedBy   WHERE CONJUNTO=@CONJUNTO AND CENTRO_COSTO=@CENTRO_COSTO ";
            delete = "DELETE ERPL360.CENTRO_COSTO WHERE CONJUNTO=@CONJUNTO AND CENTRO_COSTO=@CENTRO_COSTO";

        }


        public int Add(CentroCosto entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@CENTRO_COSTO", entity.CENTROCOSTO));
            parameters.Add(new SqlParameter("@CONJUNTO", entity.CONJUNTO));
            parameters.Add(new SqlParameter("@DESCRIPCION", entity.DESCRIPCION));
            parameters.Add(new SqlParameter("@ACEPTA_DATOS", entity.ACEPTADATOS));
            parameters.Add(new SqlParameter("@TIPO", entity.TIPO));
            parameters.Add(new SqlParameter("@RecordDate", entity.RecordDate));
            parameters.Add(new SqlParameter("@CreatedBy", entity.CreatedBy));
            parameters.Add(new SqlParameter("@UpdatedBy", entity.UpdatedBy));
            parameters.Add(new SqlParameter("@CreateDate", entity.CreateDate));
            return ExecuteNonQuery(insert);

        }

        public int Edit(CentroCosto entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@CENTRO_COSTO", entity.CENTROCOSTO));
            parameters.Add(new SqlParameter("@CONJUNTO", entity.CONJUNTO));
            parameters.Add(new SqlParameter("@DESCRIPCION", entity.DESCRIPCION));
            parameters.Add(new SqlParameter("@ACEPTA_DATOS", entity.ACEPTADATOS));
            parameters.Add(new SqlParameter("@TIPO", entity.TIPO));
            parameters.Add(new SqlParameter("@RecordDate", entity.RecordDate));
            parameters.Add(new SqlParameter("@UpdatedBy", entity.UpdatedBy));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<CentroCosto> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listCentroCosto = new List<CentroCosto>();
            foreach (DataRow item in tableResult.Rows)
            {
                listCentroCosto.Add(new CentroCosto
                {
                    CENTROCOSTO = item[0].ToString(),
                    CONJUNTO = item[1].ToString(),
                    DESCRIPCION = item[2].ToString(),
                    ACEPTADATOS = item[3].ToString(),
                    TIPO = item[4].ToString(),
                    RecordDate = Convert.ToDateTime(item[5]),
                    CreatedBy = item[6].ToString(),
                    UpdatedBy = item[7].ToString(),
                    CreateDate = Convert.ToDateTime(item[8]),

                });
            }
            return listCentroCosto;
        }

        public int Remove(string valor)
        {
            throw new NotImplementedException();
        }

        public int Remove2(string CentroCosto, string Conjunto)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@CENTROCOSTO", CentroCosto));
            parameters.Add(new SqlParameter("@CONJUNTO", Conjunto));
            return ExecuteNonQuery(delete);
        }
    }
}
