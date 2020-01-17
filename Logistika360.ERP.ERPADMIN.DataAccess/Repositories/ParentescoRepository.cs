using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logistika360.ERP.ERPADMIN.DataAccess.Contracts;
using Logistika360.ERP.ERPADMIN.DataAccess.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Logistika360.ERP.ERPADMIN.DataAccess.Repositories
{
    public class ParentescoRepository : MasterRepository, IParentescoRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        private string nodopadre;
        private SqlConnection conn;

        public ParentescoRepository()
        {
            selectAll = "select * from ERPL360.PARENTESCO";
            insert = "insert into ERPL360.Usuario(USUARIO,NOMBRE,TIPO,ACTIVO,REQ_CAMBIO_CLAVE,FRECUENCIA_CLAVE,FECHA_ULT_CLAVE,MAX_INTENTOS_CONEX,CLAVE,CORREO_ELECTRONICO,TIPO_ACCESO,CELULAR,TIPO_PERSONALIZADO) values(@USUARIO,@NOMBRE,@TIPO,@ACTIVO,@REQ_CAMBIO_CLAVE,@FRECUENCIA_CLAVE,@FECHA_ULT_CLAVE,@MAX_INTENTOS_CONEX,@CLAVE,@CORREO_ELECTRONICO,@TIPO_ACCESO,@CELULAR,@TIPO_PERSONALIZADO)";
            update = "update ERPL360.Usuario set NOMBRE=@NOMBRE,TIPO=@TIPO,ACTIVO=@ACTIVO,REQ_CAMBIO_CLAVE=@REQ_CAMBIO_CLAVE,FRECUENCIA_CLAVE=@FRECUENCIA_CLAVE,FECHA_ULT_CLAVE=@FECHA_ULT_CLAVE,MAX_INTENTOS_CONEX=@MAX_INTENTOS_CONEX,CLAVE=@CLAVE,CORREO_ELECTRONICO=@CORREO_ELECTRONICO,TIPO_ACCESO=@TIPO_ACCESO,CELULAR=@CELULAR,TIPO_PERSONALIZADO=@TIPO_PERSONALIZADO where USUARIO=@USUARIO ";
            delete = "delete ERPL360.Usuario where USUARIO=@USUARIO";
            nodopadre = "select* from ERPL360.PARENTESCO where PADRE=@PADRE ORDER BY NUMEROHERMANO ";


        }

        public int Add(Parentesco entity)
        {
            throw new NotImplementedException();
        }

        public int Edit(Parentesco entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Parentesco> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listParentesco = new List<Parentesco>();
            foreach (DataRow item in tableResult.Rows)
            {
                listParentesco.Add(new Parentesco
                {
                    ACCION=item[0].ToString(),
                    PADRE=item[1].ToString(),
                    NUMEROHERMANO=Convert.ToInt32( item[2])
                    
                });
            }
            return listParentesco;
        }

        public List<Parentesco> ICargaNodos(string PADRE)
        {

            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@PADRE", PADRE));
            
            //var tableResult = ExecuteReader(usuario);
            var tableResult = ExecuteReaderParametros(nodopadre);
            var listParentesco = new List<Parentesco>();
            foreach (DataRow item in tableResult.Rows)
            {
                listParentesco.Add(new Parentesco
                {

                    ACCION=item[0].ToString(),
                    PADRE=item[1].ToString(),
                    NUMEROHERMANO=Convert.ToInt16( item[2])

                    
                });
            }
            return listParentesco;



        }

        

        public int Remove(string valor)
        {
            throw new NotImplementedException();
        }

        public DataTable arbol()
        {
            DataSet dts = new DataSet();
            String connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["conERPL360"].ConnectionString;
            conn = new SqlConnection(connectionString);
            String Sequel = "select PA.ACCION,PA.PADRE,PA.NUMEROHERMANO ,AC.NOMBREACCION,AC.NOMBRECONSTANTE FROM ERPL360.PARENTESCO PA ,ERPL360.ACCION AC WHERE AC.ACCION=PA.ACCION AND AC.ESMODULO='N' and TIPO IN ('F','C','A') AND SUBTIPO IN ('M','E','P','R','C','T','A','G')   ORDER BY NUMEROHERMANO";
            SqlDataAdapter da = new SqlDataAdapter(Sequel, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Open();


            return dt;
        }

        public DataTable arbolMenuPrivilegios()
        {
            

            try
            {
                DataSet dts = new DataSet();
                DataSet union = new DataSet();
                String connectionString;
                connectionString = ConfigurationManager.ConnectionStrings["conERPL360"].ConnectionString;
                conn = new SqlConnection(connectionString);
                String Sequel = "select PA.ACCION,PA.PADRE,PA.NUMEROHERMANO ,AC.NOMBREACCION,AC.NOMBRECONSTANTE FROM ERPL360.PARENTESCO PA ,ERPL360.ACCION AC WHERE AC.ACCION=PA.ACCION ";
                SqlDataAdapter da2 = new SqlDataAdapter(Sequel, conn);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
               // union.Tables.Add(dt2);
                conn.Open();

                //UNION  

                //conn = new SqlConnection(connectionString);
                //String Sequel2 = "select pr.ACCION,pr.padre,ac.NOMBREACCION, 'N' as ACTIVO from erpl360.PARENTESCO pr, erpL360.ACCION ac where pr.ACCION = ac.ACCION and pr.accion NOT in (select accion from erpL360.PRIVILEGIO_EX where CONJUNTO = 'CINCOH' and USUARIO = 'JVALLE')  ";
                //SqlDataAdapter da3 = new SqlDataAdapter(Sequel2, conn);
                //DataTable dt3 = new DataTable();
                //da3.Fill(dt3);
                //union.Tables.Add(dt2);
                //conn.Open();



                return dt2;
            }
            catch (Exception ex)
            {
                DataTable dts2 = new DataTable();
                var error = ex.Message;
                return dts2;
            }


           


            
        }

        public int Remove2(string valor1, string valor2)
        {
            throw new NotImplementedException();
        }
    }
}
