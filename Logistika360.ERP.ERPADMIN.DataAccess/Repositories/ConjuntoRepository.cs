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
    public class ConjuntoRepository : MasterRepository, IUsuarioRepository
    {

        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        private string conjunto;

        public ConjuntoRepository()
        {
            selectAll = "select * from ERPL360.conjunto";
            insert = "insert into ERPL360.Usuario(USUARIO,NOMBRE,TIPO,ACTIVO,REQ_CAMBIO_CLAVE,FRECUENCIA_CLAVE,FECHA_ULT_CLAVE,MAX_INTENTOS_CONEX,CLAVE,CORREO_ELECTRONICO,TIPO_ACCESO,CELULAR,TIPO_PERSONALIZADO) values(@USUARIO,@NOMBRE,@TIPO,@ACTIVO,@REQ_CAMBIO_CLAVE,@FRECUENCIA_CLAVE,@FECHA_ULT_CLAVE,@MAX_INTENTOS_CONEX,@CLAVE,@CORREO_ELECTRONICO,@TIPO_ACCESO,@CELULAR,@TIPO_PERSONALIZADO)";
            update = "update ERPL360.Usuario set NOMBRE=@NOMBRE,TIPO=@TIPO,ACTIVO=@ACTIVO,REQ_CAMBIO_CLAVE=@REQ_CAMBIO_CLAVE,FRECUENCIA_CLAVE=@FRECUENCIA_CLAVE,FECHA_ULT_CLAVE=@FECHA_ULT_CLAVE,MAX_INTENTOS_CONEX=@MAX_INTENTOS_CONEX,CLAVE=@CLAVE,CORREO_ELECTRONICO=@CORREO_ELECTRONICO,TIPO_ACCESO=@TIPO_ACCESO,CELULAR=@CELULAR,TIPO_PERSONALIZADO=@TIPO_PERSONALIZADO where USUARIO=@USUARIO ";
            delete = "delete ERPL360.Usuario where USUARIO=@USUARIO";
            conjunto = "select * from ERPL360.conjunto where CONJUNTO=@CONJUNTO";
        }



        public int Add(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public int Edit(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Login(string USUARIO, string CONTRASENA, string ACTIVO)
        {
            throw new NotImplementedException();
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
