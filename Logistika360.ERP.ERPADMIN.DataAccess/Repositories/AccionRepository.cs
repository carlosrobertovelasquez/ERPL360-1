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
    public class AccionRepository : MasterRepository, IAccionRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        private string usuario;

        public AccionRepository()
        {
            selectAll = "select * from ERPL360.ACCION";
            insert = "insert into ERPL360.Usuario(USUARIO,NOMBRE,TIPO,ACTIVO,REQ_CAMBIO_CLAVE,FRECUENCIA_CLAVE,FECHA_ULT_CLAVE,MAX_INTENTOS_CONEX,CLAVE,CORREO_ELECTRONICO,TIPO_ACCESO,CELULAR,TIPO_PERSONALIZADO) values(@USUARIO,@NOMBRE,@TIPO,@ACTIVO,@REQ_CAMBIO_CLAVE,@FRECUENCIA_CLAVE,@FECHA_ULT_CLAVE,@MAX_INTENTOS_CONEX,@CLAVE,@CORREO_ELECTRONICO,@TIPO_ACCESO,@CELULAR,@TIPO_PERSONALIZADO)";
            update = "update ERPL360.Usuario set NOMBRE=@NOMBRE,TIPO=@TIPO,ACTIVO=@ACTIVO,REQ_CAMBIO_CLAVE=@REQ_CAMBIO_CLAVE,FRECUENCIA_CLAVE=@FRECUENCIA_CLAVE,FECHA_ULT_CLAVE=@FECHA_ULT_CLAVE,MAX_INTENTOS_CONEX=@MAX_INTENTOS_CONEX,CLAVE=@CLAVE,CORREO_ELECTRONICO=@CORREO_ELECTRONICO,TIPO_ACCESO=@TIPO_ACCESO,CELULAR=@CELULAR,TIPO_PERSONALIZADO=@TIPO_PERSONALIZADO where USUARIO=@USUARIO ";
            delete = "delete ERPL360.Usuario where USUARIO=@USUARIO";
            
        }

        public int Add(Accion entity)
        {
            throw new NotImplementedException();
        }

        public int Edit(Accion entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Accion> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listAccion = new List<Accion>();
            foreach (DataRow item in tableResult.Rows)
            {
                listAccion.Add(new Accion
                {
                    ACCION=item[0].ToString(),
                    NOMBREACCION=item[1].ToString(),
                    DESCRIPCION = item[2].ToString(),
                    NOMBRECONSTANTE=item[3].ToString(),
                    ESMODULO=item[4].ToString(),                   
                    TIPO = item[5].ToString(),
                    SUBTIPO=item[6].ToString(),
                    TABLA=item[7].ToString(),
                    INVOCACION=item[8].ToString()

                    
                });
            }
            return listAccion;
        }

        

        public int Remove(string valor)
        {
            throw new NotImplementedException();
        }
    }
}
