using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logistika360.ERP.ERPADMIN.DataAccess.Contracts;
using Logistika360.ERP.ERPADMIN.DataAccess.Entities;
using System.Data;
using System.Data.SqlClient;


namespace Logistika360.ERP.ERPADMIN.DataAccess.Repositories
{
    public class PrivilegioEXRepository : MasterRepository, IPrivilegioExRepository
    {

        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public PrivilegioEXRepository()
        {
            selectAll = "select pr.ACCION,pr.ACTIVO,pr.CONJUNTO,pr.USUARIO,ac.NOMBRECONSTANTE from ERPL360.PRIVILEGIO_EX pr,ERPL360.ACCION ac where pr.ACCION=ac.ACCION";
            insert = "";
            update = "";
            delete = "";
        }

        public int Add(Privilegio_Ex entity)
        {
            throw new NotImplementedException();
        }

        public int Edit(Privilegio_Ex entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Privilegio_Ex> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listPrivilegioEX = new List<Privilegio_Ex>();
            foreach (DataRow item in tableResult.Rows)
            {
                listPrivilegioEX.Add(new Privilegio_Ex
                {
                    USUARIO = item[3].ToString(),
                    CONJUNTO = item[2].ToString(),
                    ACCION = Convert.ToInt32( item[0]),
                    ACTIVO = item[1].ToString(),
                    NOMBRECONSTANTE= item[4].ToString(),

                });
            }
            return listPrivilegioEX;
        }

        public int Remove(string valor)
        {
            throw new NotImplementedException();
        }

        public int Remove2(string valor1, string valor2)
        {
            throw new NotImplementedException();
        }
    }
}
