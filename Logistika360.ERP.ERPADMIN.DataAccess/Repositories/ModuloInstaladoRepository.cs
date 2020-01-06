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
    public class ModuloInstaladoRepository : MasterRepository, IModuloInstaladoRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        private string modulos;

        public ModuloInstaladoRepository()
        {
            selectAll = "select * from ERPL360.MODULO_INSTALADO";
            insert = "insert into ERPL360.Usuario(USUARIO,NOMBRE,TIPO,ACTIVO,REQ_CAMBIO_CLAVE,FRECUENCIA_CLAVE,FECHA_ULT_CLAVE,MAX_INTENTOS_CONEX,CLAVE,CORREO_ELECTRONICO,TIPO_ACCESO,CELULAR,TIPO_PERSONALIZADO) values(@USUARIO,@NOMBRE,@TIPO,@ACTIVO,@REQ_CAMBIO_CLAVE,@FRECUENCIA_CLAVE,@FECHA_ULT_CLAVE,@MAX_INTENTOS_CONEX,@CLAVE,@CORREO_ELECTRONICO,@TIPO_ACCESO,@CELULAR,@TIPO_PERSONALIZADO)";
            update = "update ERPL360.Usuario set NOMBRE=@NOMBRE,TIPO=@TIPO,ACTIVO=@ACTIVO,REQ_CAMBIO_CLAVE=@REQ_CAMBIO_CLAVE,FRECUENCIA_CLAVE=@FRECUENCIA_CLAVE,FECHA_ULT_CLAVE=@FECHA_ULT_CLAVE,MAX_INTENTOS_CONEX=@MAX_INTENTOS_CONEX,CLAVE=@CLAVE,CORREO_ELECTRONICO=@CORREO_ELECTRONICO,TIPO_ACCESO=@TIPO_ACCESO,CELULAR=@CELULAR,TIPO_PERSONALIZADO=@TIPO_PERSONALIZADO where USUARIO=@USUARIO ";
            delete = "delete ERPL360.Usuario where USUARIO=@USUARIO";
            modulos = "select MI.CONJUNTO,AC.ACCION,AC.NOMBREACCION from ERPL360.MODULO_INSTALADO MI,ERPL360.ACCION AC where MI.ACCION=AC.ACCION AND CONJUNTO=@CONJUNTO ";
        }

        public int Add(Modulo_Instalado entity)
        {
            throw new NotImplementedException();
        }

        public int Edit(Modulo_Instalado entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Modulo_Instalado> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Modulo_Instalado> Imodulos(string CONJUNTO)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@CONJUNTO", CONJUNTO));

            //var tableResult = ExecuteReader(usuario);
            var tableResult = ExecuteReaderParametros(modulos);
            var listModulo = new List<Modulo_Instalado>();
            foreach (DataRow item in tableResult.Rows)
            {
                listModulo.Add(new Modulo_Instalado
                {

                    CONJUNTO = item[0].ToString(),
                    ACCION = item[1].ToString(),
                    NOMBREACCION = item[2].ToString()

                });
            }
            return listModulo;

        }

        public int Remove(string valor)
        {
            throw new NotImplementedException();
        }

        public List<Modulo_Instalado> imodulo(string CONJUNTO)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@CONJUNTO", CONJUNTO));
            
            //var tableResult = ExecuteReader(usuario);
            var tableResult = ExecuteReaderParametros(modulos);
            var listModulo = new List<Modulo_Instalado>();
            foreach (DataRow item in tableResult.Rows)
            {
                listModulo.Add(new Modulo_Instalado
                {

                    CONJUNTO = item[0].ToString(),
                    ACCION = item[1].ToString(),
                    NOMBREACCION=item[2].ToString()
                    
                });
            }
            return listModulo;

        }
    }
}
