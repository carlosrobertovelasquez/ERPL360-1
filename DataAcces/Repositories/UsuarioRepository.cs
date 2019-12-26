using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces.Contracts;
using DataAcces.Entities;
using System.Data;
using System.Data.SqlClient;

namespace DataAcces.Repositories
{
    public class UsuarioRepository : MasterRepository, IUsuarioRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        private string rangofecha;
        public UsuarioRepository()
        {
            selectAll = "select * from ERPL360.Usuario";
            insert = "insert into ERPL360.Usuario values(@USUARIO,@NOMBRE,@TIPO,@ACTIVO,@REQ_CAMBIO_CLAVE,@FRECUENCIA_CLAVE,@FECHA_ULT_CLAVE,@MAX_INTENTOS_CONEX,@CLAVE,@CORREO_ELECTRONICO,@TIPO_ACCESO,@CELULAR,@TIPO_PERSONALIZADO)";
            update = "update ERPL360.Usuario set NOMBRE=@NOMBRE,TIPO=@TIPO,ACTIVO=@ACTIVO,REQ_CAMBIO_CLAVE=@REQ_CAMBIO_CLAVE,FRECUENCIA_CLAVE=@FRECUENCIA_CLAVE,FECHA_ULT_CLAVE=@FECHA_ULT_CLAVE,MAX_INTENTOS_CONEX=@MAX_INTENTOS_CONEX,CLAVE=@CLAVE,CORREO_ELECTRONICO=@CORREO_ELECTRONICO,TIPO_ACCESO=@TIPO_ACCESO,CELULAR=@CELULAR,TIPO_PERSONALIZADO=@TIPO_PERSONALIZADO WHERE USUARIO=@USUARIO ";
            delete = "delete from ERPL360.Usuario where Usuario=@Usuario or CORREO_ELECTRONICO=@CORREO_ELECTRONICO";
            rangofecha = "select * from ERPL360.Usuario";
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
            parameters.Add(new SqlParameter("@CLAVE", entity.CLAVE));
            parameters.Add(new SqlParameter("@CORREO_ELECTRONICO", entity.CORREO_ELECTRONICO));
            parameters.Add(new SqlParameter("@TIPO_ACCESO", entity.TIPO_ACCESO));
            parameters.Add(new SqlParameter("@CELULAR", entity.CELULAR));
            parameters.Add(new SqlParameter("@TIPO_PERSONALIZADO", entity.TIPO_PERSONALIZADO));
             return ExecuteNonQuery(update);
        }

        public IEnumerable<Usuario> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listUsuarios = new List<Usuario>();
            foreach ( DataRow item in tableResult.Rows)
            {
                listUsuarios.Add(new Usuario {
                    USUARIO = item[0].ToString(),
                    NOMBRE = item[1].ToString(),
                    TIPO = item[2].ToString(),
                    ACTIVO = item[3].ToString(),
                    REQ_CAMBIO_CLAVE = item[4].ToString(),
                    FRECUENCIA_CLAVE = item[5].ToString(),
                    FECHA_ULT_CLAVE = Convert.ToDateTime(item[6]),
                    MAX_INTENTOS_CONEX = item[7].ToString(),
                    CLAVE=item[8].ToString(),
                    CORREO_ELECTRONICO=item[9].ToString(),
                    TIPO_ACCESO=item[10].ToString(),
                    CELULAR=item[11].ToString(),
                    TIPO_PERSONALIZADO=item[12].ToString()
                });
            }
            return listUsuarios;
        }

        public int RangoFecha(DateTime FechaInicial, DateTime FechaFinal)
        {
            throw new NotImplementedException();
        }

        public int Remove(string Usuario)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@USUARIO", Usuario));
            return ExecuteNonQuery(delete);
        }
    }
}
