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
    public class UsuarioRepository : MasterRepository, IUsuarioRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        private string usuario;

        public UsuarioRepository()
        {
            selectAll = "select * from ERPL360.Usuario";
            insert = "insert into ERPL360.Usuario(USUARIO,NOMBRE,TIPO,ACTIVO,REQ_CAMBIO_CLAVE,FRECUENCIA_CLAVE,FECHA_ULT_CLAVE,MAX_INTENTOS_CONEX,CLAVE,CORREO_ELECTRONICO,TIPO_ACCESO,CELULAR,TIPO_PERSONALIZADO) values(@USUARIO,@NOMBRE,@TIPO,@ACTIVO,@REQ_CAMBIO_CLAVE,@FRECUENCIA_CLAVE,@FECHA_ULT_CLAVE,@MAX_INTENTOS_CONEX,@CLAVE,@CORREO_ELECTRONICO,@TIPO_ACCESO,@CELULAR,@TIPO_PERSONALIZADO)";
            update = "update ERPL360.Usuario set NOMBRE=@NOMBRE,TIPO=@TIPO,ACTIVO=@ACTIVO,REQ_CAMBIO_CLAVE=@REQ_CAMBIO_CLAVE,FRECUENCIA_CLAVE=@FRECUENCIA_CLAVE,FECHA_ULT_CLAVE=@FECHA_ULT_CLAVE,MAX_INTENTOS_CONEX=@MAX_INTENTOS_CONEX,CORREO_ELECTRONICO=@CORREO_ELECTRONICO,TIPO_ACCESO=@TIPO_ACCESO,CELULAR=@CELULAR,TIPO_PERSONALIZADO=@TIPO_PERSONALIZADO where USUARIO=@USUARIO ";
            delete = "delete ERPL360.Usuario where USUARIO=@USUARIO";
            usuario = "select * from ERPL360.Usuario where USUARIO=@USUARIO and CLAVE=@CLAVE and ACTIVO=@ACTIVO";
        }

        public int Add(Usuario entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@USUARIO", entity.USUARIO));
            parameters.Add(new SqlParameter("@NOMBRE", entity.NOMBRE));
            parameters.Add(new SqlParameter("@TIPO", entity.TIPO));
            parameters.Add(new SqlParameter("@ACTIVO", entity.ACTIVO));
            parameters.Add(new SqlParameter("@REQ_CAMBIO_CLAVE", entity.REQ_CAMBIO_CLAVE));
            parameters.Add(new SqlParameter("@FRECUENCIA_CLAVE", entity.FRECUENCIA_CLAVE));
            parameters.Add(new SqlParameter("@FECHA_ULT_CLAVE", entity.FECHA_ULT_CLAVE));
            parameters.Add(new SqlParameter("@MAX_INTENTOS_CONEX", entity.MAX_INTENTOS_CONEX));
            parameters.Add(new SqlParameter("@CLAVE", entity.CLAVE));
            parameters.Add(new SqlParameter("@CORREO_ELECTRONICO", entity.CORREO_ELECTRONICO));
            parameters.Add(new SqlParameter("@TIPO_ACCESO", entity.TIPO_ACCESO));
            parameters.Add(new SqlParameter("@CELULAR", entity.CELULAR));
            parameters.Add(new SqlParameter("@TIPO_PERSONALIZADO", entity.TIPO_PERSONALIZADO));
            return ExecuteNonQuery(insert);
        }

        public int Edit(Usuario entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@USUARIO", entity.USUARIO));
            parameters.Add(new SqlParameter("@NOMBRE", entity.NOMBRE));
            parameters.Add(new SqlParameter("@TIPO", entity.TIPO));
            parameters.Add(new SqlParameter("@ACTIVO", entity.ACTIVO));
            parameters.Add(new SqlParameter("@REQ_CAMBIO_CLAVE", entity.REQ_CAMBIO_CLAVE));
            parameters.Add(new SqlParameter("@FRECUENCIA_CLAVE", entity.FRECUENCIA_CLAVE));
            parameters.Add(new SqlParameter("@FECHA_ULT_CLAVE", entity.FECHA_ULT_CLAVE));
            parameters.Add(new SqlParameter("@MAX_INTENTOS_CONEX", entity.MAX_INTENTOS_CONEX));
            
            parameters.Add(new SqlParameter("@CORREO_ELECTRONICO", entity.CORREO_ELECTRONICO));
            parameters.Add(new SqlParameter("@TIPO_ACCESO", entity.TIPO_ACCESO));
            parameters.Add(new SqlParameter("@CELULAR", entity.CELULAR));
            parameters.Add(new SqlParameter("@TIPO_PERSONALIZADO", entity.TIPO_PERSONALIZADO));
            return ExecuteNonQuery(update);

        }

        public IEnumerable<Usuario> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listUsuario = new List<Usuario>();
            foreach(DataRow item in tableResult.Rows)
            {
                listUsuario.Add(new Usuario
                {
                    USUARIO=item[0].ToString(),
                    NOMBRE= item[1].ToString(),
                    TIPO= item[2].ToString(),
                    ACTIVO= item[3].ToString(),
                    REQ_CAMBIO_CLAVE=item[4].ToString(),
                    FRECUENCIA_CLAVE= Convert.ToDecimal(item[11]),
                    FECHA_ULT_CLAVE=Convert.ToDateTime(item[5]),
                    MAX_INTENTOS_CONEX=Convert.ToDecimal( item[12]),
                    CLAVE= item[6].ToString(),
                    CORREO_ELECTRONICO= item[7].ToString(),
                    TIPO_ACCESO= item[8].ToString(),
                    CELULAR= item[9].ToString(),
                    TIPO_PERSONALIZADO= item[10].ToString(),
                });
            }
            return listUsuario;
        }

        public List<Usuario> Login(string USUARIO,string CLAVE,string ACTIVO )
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@USUARIO", USUARIO));
            parameters.Add(new SqlParameter("@CLAVE", CLAVE));
            parameters.Add(new SqlParameter("@ACTIVO", ACTIVO));
            
            //var tableResult = ExecuteReader(usuario);
            var tableResult = ExecuteReaderParametros(usuario);
            var listUsuario = new List<Usuario>();
            foreach (DataRow item in tableResult.Rows)
            {
                listUsuario.Add(new Usuario
                {
                    USUARIO = item[1].ToString(),
                    NOMBRE = item[2].ToString(),
                    TIPO = item[3].ToString(),
                    ACTIVO = item[4].ToString(),
                    REQ_CAMBIO_CLAVE = item[5].ToString(),
                    FRECUENCIA_CLAVE = Convert.ToDecimal(item[6]),
                    FECHA_ULT_CLAVE = Convert.ToDateTime(item[7].ToString()),
                    MAX_INTENTOS_CONEX = Convert.ToDecimal(item[8]),
                    CLAVE = item[9].ToString(),
                    CORREO_ELECTRONICO = item[10].ToString(),
                    TIPO_ACCESO = item[11].ToString(),
                    CELULAR = item[12].ToString(),
                    TIPO_PERSONALIZADO = item[13].ToString(),
                });
            }
            return listUsuario;

        }

        public int Remove(string USUARIO)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@USUARIO", USUARIO));
            return ExecuteNonQuery(delete);
        }

        public int Remove2(string valor1, string valor2)
        {
            throw new NotImplementedException();
        }
    }
}
