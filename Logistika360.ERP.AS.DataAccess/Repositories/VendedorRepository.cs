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
    public class VendedorRepository:MasterRepository,IVendedorRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public VendedorRepository()
        {
            selectAll = "SELECT * FROM "+UserLoginCache.CONJUNTO+".VENDEDOR";
            insert = "insert into "+UserLoginCache.CONJUNTO+".VENDEDOR(VENDEDOR,NOMBRE,EMPLEADO,COMISION,CTR_COMISION,CTA_COMISION,CORREO,ACTIVO,TELEFONO,CREATEDBY,CREATEDATE,RECORDDATE,UPDATEDBY) values(@VENDEDOR,@NOMBRE,@EMPLEADO,@COMISION,@CTR_COMISION,@CTA_COMISION,@CORREO,@ACTIVO,@TELEFONO,@CREATEDBY,@CREATEDATE,@RECORDDATE,@UPDATEDBY)";
            update = "UPDATE "+UserLoginCache.CONJUNTO+".VENDEDOR SET NOMBRE=@NOMBRE,EMPLEADO=@EMPLEADO,CTR_COMISION=@CTR_COMISION,CTA_COMISION=@CTA_COMISION,CORREO=@CORREO,ACTIVO=@ACTIVO,TELEFONO=@TELEFONO,UPDATEDBY=@UPDATEDBY,RECORDDATE=@RECORDDATE WHERE  VENDEDOR=@VENDEDOR ";
            delete = "DELETE "+UserLoginCache.CONJUNTO+".VENDEDOR WHERE  VENDEDOR=@VENDEDOR";
        }

        public int Add(Vendedor entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@VENDEDOR", entity.VENDEDOR));
            parameters.Add(new SqlParameter("@NOMBRE", entity.NOMBRE));
            parameters.Add(new SqlParameter("@EMPLEADO", entity.EMPLEADO));
            parameters.Add(new SqlParameter("@COMISION", entity.COMISION));
            parameters.Add(new SqlParameter("@CTR_COMISION", entity.CTR_COMISION));
            parameters.Add(new SqlParameter("@CTA_COMISION", entity.CTA_COMISION));
            parameters.Add(new SqlParameter("@CORREO", entity.CORREO));
            parameters.Add(new SqlParameter("@ACTIVO", entity.ACTIVO));
            parameters.Add(new SqlParameter("@TELEFONO", entity.TELEFONO));
            parameters.Add(new SqlParameter("@CREATEDBY", entity.CreatedBy));
            parameters.Add(new SqlParameter("@CREATEDATE", entity.CreateDate));
            parameters.Add(new SqlParameter("@RECORDDATE", entity.RecordDate));
            parameters.Add(new SqlParameter("@UPDATEDBY", entity.UpdatedBy));
            return ExecuteNonQuery(insert);

        }

        public int Edit(Vendedor entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@VENDEDOR", entity.VENDEDOR));
            parameters.Add(new SqlParameter("@NOMBRE", entity.NOMBRE));
            parameters.Add(new SqlParameter("@EMPLEADO", entity.EMPLEADO));
            parameters.Add(new SqlParameter("@COMISION", entity.COMISION));
            parameters.Add(new SqlParameter("@CTR_COMISION", entity.CTR_COMISION));
            parameters.Add(new SqlParameter("@CTA_COMISION", entity.CTA_COMISION));
            parameters.Add(new SqlParameter("@CORREO", entity.CORREO));
            parameters.Add(new SqlParameter("@ACTIVO", entity.ACTIVO));
            parameters.Add(new SqlParameter("@TELEFONO", entity.TELEFONO));
            parameters.Add(new SqlParameter("@RECORDDATE", entity.RecordDate));
            parameters.Add(new SqlParameter("@UPDATEDBY", entity.UpdatedBy));
            return ExecuteNonQuery(update);

        }

        public IEnumerable<Vendedor> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listVendedor = new List<Vendedor>();
            foreach (DataRow item in tableResult.Rows)
            {
                listVendedor.Add(new Vendedor
                {
                    VENDEDOR = item[0].ToString(),
                    NOMBRE=item[1].ToString(),
                    EMPLEADO = item[2].ToString(),
                    COMISION = Convert.ToDecimal( item[3].ToString()),
                    CTR_COMISION =  item[4].ToString(),
                    CTA_COMISION = item[5].ToString(),
                    CORREO = item[6].ToString(),
                    ACTIVO = item[7].ToString(),
                    TELEFONO = item[8].ToString(),
                    UpdatedBy = item[9].ToString(),
                    RecordDate = Convert.ToDateTime(item[10]),
                    CreatedBy = item[11].ToString(),
                    CreateDate = Convert.ToDateTime(item[12]),
                    
                });
            }
            return listVendedor;
        }

        
        public int Remove(string VENDEDOR)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@VENDEDOR", VENDEDOR));
            return ExecuteNonQuery(delete);
            
        }

        public int Remove2(string VENDEDOR,string CONJUNTO)
        {

            throw new NotImplementedException();


        }
    }
}
