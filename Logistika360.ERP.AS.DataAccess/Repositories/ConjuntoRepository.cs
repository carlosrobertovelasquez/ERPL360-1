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
    public class ConjuntoRepository : MasterRepository, IConjuntoRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public ConjuntoRepository()
        {
            selectAll = "SELECT * FROM ERPL360.CONJUNTO";
            insert = "INSERT INTO ERPL360.CONJUNTO(CONJUNTO ,NOMBRE ,DIREC1 ,DIREC2 ,TELEFONO  ,DOBLE_MONEDA ,DOBLE_CONTABILIDAD ,USA_LOTES ,USAR_CENTROS_COSTO ,CONSOLIDA ,CONSOLIDADORA ,BD_CIA_CONSOLIDAD ,CONTA_A_CONSOLID ,MISMO_CUADRO_CTB ,USUARIO_ULT_MOD ,FCH_HORA_ULT_MOD ,NOTAS ,USA_UNIDADES ,UNIDAD_OMISION ,MONEDA_CONSOLIDA ,VERSION_BD ,USUARIO_MODIF_BD ,FCH_HORA_MODIF_BD ,VERSION_INSTALAC ,NIT ,PAIS ,GLN ,UBICACION ,IDIOMA ,USA_SUCURSAL ,MASCARA_SUCURSAL ,DIRECCION_WEB1 ,DIRECCION_WEB2 ,NOMBRE_WEB1 ,NOMBRE_WEB2 ,DIRECCION_PAG_WEB ,EMAIL_DOC_ELECTRONICO ,PAIS_DIVISION ,DIVISION_GEOGRAFICA1 ,DIVISION_GEOGRAFICA2  ,NUMERO_REGISTRO ,DIREC3 ,COD_POSTAL ,DIVISION_GEOGRAFICA3 ,DIVISION_GEOGRAFICA4 ,REGIMEN_FISCAL ,INVENTARIO_DOLAR ,RecordDate ,CreatedBy ,UpdatedBy ,CreateDate) VALUES (@CONJUNTO ,@NOMBRE ,@DIREC1 ,@DIREC2 ,@TELEFONO  ,@DOBLE_MONEDA ,@DOBLE_CONTABILIDAD ,@USA_LOTES ,@USAR_CENTROS_COSTO ,@CONSOLIDA ,@CONSOLIDADORA ,@BD_CIA_CONSOLIDAD ,@CONTA_A_CONSOLID ,@MISMO_CUADRO_CTB ,@USUARIO_ULT_MOD ,@FCH_HORA_ULT_MOD ,@NOTAS ,@USA_UNIDADES ,@UNIDAD_OMISION ,@MONEDA_CONSOLIDA ,@VERSION_BD ,@USUARIO_MODIF_BD ,@FCH_HORA_MODIF_BD ,@VERSION_INSTALAC ,@NIT ,@PAIS ,@GLN ,@UBICACION ,@IDIOMA ,@USA_SUCURSAL ,@MASCARA_SUCURSAL ,@DIRECCION_WEB1 ,@DIRECCION_WEB2 ,@NOMBRE_WEB1 ,@NOMBRE_WEB2 ,@DIRECCION_PAG_WEB ,@EMAIL_DOC_ELECTRONICO ,@PAIS_DIVISION ,@DIVISION_GEOGRAFICA1 ,@DIVISION_GEOGRAFICA2  ,@NUMERO_REGISTRO ,@DIREC3 ,@COD_POSTAL ,@DIVISION_GEOGRAFICA3 ,@DIVISION_GEOGRAFICA4 ,@REGIMEN_FISCAL ,@INVENTARIO_DOLAR ,@RecordDate ,@CreatedBy ,@UpdatedBy ,@CreateDate)";
            update = "UPDATE ERPL360.CONJUNTO SET NOMBRE=@NOMBRE ,DIREC1=@DIREC1 ,DIREC2=@DIREC2 ,TELEFONO=@TELEFONO  ,DOBLE_MONEDA=@DOBLE_MONEDA ,DOBLE_CONTABILIDAD=@DOBLE_CONTABILIDAD ,USA_LOTES=@USA_LOTES ,USAR_CENTROS_COSTO=@USAR_CENTROS_COSTO ,CONSOLIDA=@CONSOLIDA ,CONSOLIDADORA=@CONSOLIDADORA ,BD_CIA_CONSOLIDAD=@BD_CIA_CONSOLIDAD ,CONTA_A_CONSOLID=@CONTA_A_CONSOLID ,MISMO_CUADRO_CTB=@MISMO_CUADRO_CTB ,USUARIO_ULT_MOD=@USUARIO_ULT_MOD ,FCH_HORA_ULT_MOD=@FCH_HORA_ULT_MOD ,NOTAS=@NOTAS ,USA_UNIDADES=@USA_UNIDADES ,UNIDAD_OMISION=@UNIDAD_OMISION ,MONEDA_CONSOLIDA=@MONEDA_CONSOLIDA ,VERSION_BD=@VERSION_BD ,USUARIO_MODIF_BD=@USUARIO_MODIF_BD ,FCH_HORA_MODIF_BD=@FCH_HORA_MODIF_BD ,VERSION_INSTALAC=@VERSION_INSTALAC ,NIT=@NIT ,PAIS=@PAIS ,GLN=@GLN ,UBICACION=@UBICACION ,IDIOMA=@IDIOMA ,USA_SUCURSAL=@USA_SUCURSAL ,MASCARA_SUCURSAL=@MASCARA_SUCURSAL ,DIRECCION_WEB1=@DIRECCION_WEB1 ,DIRECCION_WEB2=@DIRECCION_WEB2 ,NOMBRE_WEB1=@NOMBRE_WEB1 ,NOMBRE_WEB2=@NOMBRE_WEB2 ,DIRECCION_PAG_WEB=@DIRECCION_PAG_WEB ,EMAIL_DOC_ELECTRONICO=@EMAIL_DOC_ELECTRONICO ,PAIS_DIVISION=@PAIS_DIVISION ,DIVISION_GEOGRAFICA1=@DIVISION_GEOGRAFICA1 ,DIVISION_GEOGRAFICA2=@DIVISION_GEOGRAFICA2  ,NUMERO_REGISTRO=@NUMERO_REGISTRO ,DIREC3=@DIREC3 ,COD_POSTAL=@COD_POSTAL ,DIVISION_GEOGRAFICA3=@DIVISION_GEOGRAFICA3 ,DIVISION_GEOGRAFICA4=@DIVISION_GEOGRAFICA4 ,REGIMEN_FISCAL=@REGIMEN_FISCAL ,INVENTARIO_DOLAR=@INVENTARIO_DOLAR, RecordDate=@RecordDate,UpdatedBy=@UpdatedBy WHERE CONJUNTO=@CONJUNTO";
            delete = "";
        }

        public int Add(Conjunto entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@CONJUNTO", entity.CONJUNTO));
            parameters.Add(new SqlParameter("@NOMBRE", entity.NOMBRE));
            parameters.Add(new SqlParameter("@DIREC1", entity.DIREC1));
            parameters.Add(new SqlParameter("@DIREC2", entity.DIREC2));
            parameters.Add(new SqlParameter("@TELEFONO", entity.TELEFONO));
           // parameters.Add(new SqlParameter("@LOGO", entity.LOGO));
            parameters.Add(new SqlParameter("@DOBLE_MONEDA", entity.DOBLE_MONEDA));
            parameters.Add(new SqlParameter("@DOBLE_CONTABILIDAD", entity.DOBLE_CONTABILIDAD));
            parameters.Add(new SqlParameter("@USA_LOTES", entity.USA_LOTES));
            parameters.Add(new SqlParameter("@USAR_CENTROS_COSTO", entity.USAR_CENTROS_COSTO));
            parameters.Add(new SqlParameter("@CONSOLIDA", entity.CONSOLIDA));
            parameters.Add(new SqlParameter("@CONSOLIDADORA", entity.CONSOLIDADORA));
            parameters.Add(new SqlParameter("@BD_CIA_CONSOLIDAD", entity.BD_CIA_CONSOLIDAD));
            parameters.Add(new SqlParameter("@CONTA_A_CONSOLID", entity.CONTA_A_CONSOLID));
            parameters.Add(new SqlParameter("@MISMO_CUADRO_CTB", entity.MISMO_CUADRO_CTB));
            parameters.Add(new SqlParameter("@USUARIO_ULT_MOD", entity.USUARIO_ULT_MOD));
            parameters.Add(new SqlParameter("@FCH_HORA_ULT_MOD", entity.FCH_HORA_ULT_MOD));
            parameters.Add(new SqlParameter("@NOTAS", entity.NOTAS));
            parameters.Add(new SqlParameter("@USA_UNIDADES", entity.USA_UNIDADES));
            parameters.Add(new SqlParameter("@UNIDAD_OMISION", entity.UNIDAD_OMISION));
            parameters.Add(new SqlParameter("@MONEDA_CONSOLIDA", entity.MONEDA_CONSOLIDA));
            parameters.Add(new SqlParameter("@VERSION_BD", entity.VERSION_BD));
            parameters.Add(new SqlParameter("@USUARIO_MODIF_BD", entity.USUARIO_MODIF_BD));
            parameters.Add(new SqlParameter("@FCH_HORA_MODIF_BD", entity.FCH_HORA_MODIF_BD));
            parameters.Add(new SqlParameter("@VERSION_INSTALAC", entity.VERSION_INSTALAC));
            parameters.Add(new SqlParameter("@NIT", entity.NIT));
            parameters.Add(new SqlParameter("@PAIS", entity.PAIS));
            parameters.Add(new SqlParameter("@GLN", entity.GLN));
            parameters.Add(new SqlParameter("@UBICACION", entity.UBICACION));
            parameters.Add(new SqlParameter("@IDIOMA", entity.IDIOMA));
            parameters.Add(new SqlParameter("@USA_SUCURSAL", entity.USA_SUCURSAL));
            parameters.Add(new SqlParameter("@MASCARA_SUCURSAL", entity.MASCARA_SUCURSAL));
            parameters.Add(new SqlParameter("@DIRECCION_WEB1", entity.DIRECCION_WEB1));
            parameters.Add(new SqlParameter("@DIRECCION_WEB2", entity.DIRECCION_WEB2));
            parameters.Add(new SqlParameter("@NOMBRE_WEB1", entity.NOMBRE_WEB1));
            parameters.Add(new SqlParameter("@NOMBRE_WEB2", entity.NOMBRE_WEB2));
            parameters.Add(new SqlParameter("@DIRECCION_PAG_WEB", entity.DIRECCION_PAG_WEB));
            parameters.Add(new SqlParameter("@EMAIL_DOC_ELECTRONICO", entity.EMAIL_DOC_ELECTRONICO));
            parameters.Add(new SqlParameter("@PAIS_DIVISION", entity.PAIS_DIVISION));
            parameters.Add(new SqlParameter("@DIVISION_GEOGRAFICA1", entity.DIVISION_GEOGRAFICA1));
            parameters.Add(new SqlParameter("@DIVISION_GEOGRAFICA2", entity.DIVISION_GEOGRAFICA2));
            //parameters.Add(new SqlParameter("@LOGO_CIA", entity.LOGO_CIA));
            parameters.Add(new SqlParameter("@NUMERO_REGISTRO", entity.NUMERO_REGISTRO));
            parameters.Add(new SqlParameter("@DIREC3", entity.DIREC3));
            parameters.Add(new SqlParameter("@COD_POSTAL", entity.COD_POSTAL));
            parameters.Add(new SqlParameter("@DIVISION_GEOGRAFICA3", entity.DIVISION_GEOGRAFICA3));
            parameters.Add(new SqlParameter("@DIVISION_GEOGRAFICA4", entity.DIVISION_GEOGRAFICA4));
            parameters.Add(new SqlParameter("@REGIMEN_FISCAL", entity.REGIMEN_FISCAL));
            parameters.Add(new SqlParameter("@INVENTARIO_DOLAR", entity.INVENTARIO_DOLAR));
            parameters.Add(new SqlParameter("@RecordDate", entity.RecordDate));
            parameters.Add(new SqlParameter("@CreatedBy", entity.CreatedBy));
            parameters.Add(new SqlParameter("@UpdatedBy", entity.UpdatedBy));
            parameters.Add(new SqlParameter("@CreateDate", entity.CreateDate));
            return ExecuteNonQuery(insert);
        }

        public int Edit(Conjunto entity)
        {
            parameters = new List<SqlParameter>();
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@CONJUNTO", entity.CONJUNTO));
            parameters.Add(new SqlParameter("@NOMBRE", entity.NOMBRE));
            parameters.Add(new SqlParameter("@DIREC1", entity.DIREC1));
            parameters.Add(new SqlParameter("@DIREC2", entity.DIREC2));
            parameters.Add(new SqlParameter("@TELEFONO", entity.TELEFONO));
            // parameters.Add(new SqlParameter("@LOGO", entity.LOGO));
            parameters.Add(new SqlParameter("@DOBLE_MONEDA", entity.DOBLE_MONEDA));
            parameters.Add(new SqlParameter("@DOBLE_CONTABILIDAD", entity.DOBLE_CONTABILIDAD));
            parameters.Add(new SqlParameter("@USA_LOTES", entity.USA_LOTES));
            parameters.Add(new SqlParameter("@USAR_CENTROS_COSTO", entity.USAR_CENTROS_COSTO));
            parameters.Add(new SqlParameter("@CONSOLIDA", entity.CONSOLIDA));
            parameters.Add(new SqlParameter("@CONSOLIDADORA", entity.CONSOLIDADORA));
            parameters.Add(new SqlParameter("@BD_CIA_CONSOLIDAD", entity.BD_CIA_CONSOLIDAD));
            parameters.Add(new SqlParameter("@CONTA_A_CONSOLID", entity.CONTA_A_CONSOLID));
            parameters.Add(new SqlParameter("@MISMO_CUADRO_CTB", entity.MISMO_CUADRO_CTB));
            parameters.Add(new SqlParameter("@USUARIO_ULT_MOD", entity.USUARIO_ULT_MOD));
            parameters.Add(new SqlParameter("@FCH_HORA_ULT_MOD", entity.FCH_HORA_ULT_MOD));
            parameters.Add(new SqlParameter("@NOTAS", entity.NOTAS));
            parameters.Add(new SqlParameter("@USA_UNIDADES", entity.USA_UNIDADES));
            parameters.Add(new SqlParameter("@UNIDAD_OMISION", entity.UNIDAD_OMISION));
            parameters.Add(new SqlParameter("@MONEDA_CONSOLIDA", entity.MONEDA_CONSOLIDA));
            parameters.Add(new SqlParameter("@VERSION_BD", entity.VERSION_BD));
            parameters.Add(new SqlParameter("@USUARIO_MODIF_BD", entity.USUARIO_MODIF_BD));
            parameters.Add(new SqlParameter("@FCH_HORA_MODIF_BD", entity.FCH_HORA_MODIF_BD));
            parameters.Add(new SqlParameter("@VERSION_INSTALAC", entity.VERSION_INSTALAC));
            parameters.Add(new SqlParameter("@NIT", entity.NIT));
            parameters.Add(new SqlParameter("@PAIS", entity.PAIS));
            parameters.Add(new SqlParameter("@GLN", entity.GLN));
            parameters.Add(new SqlParameter("@UBICACION", entity.UBICACION));
            parameters.Add(new SqlParameter("@IDIOMA", entity.IDIOMA));
            parameters.Add(new SqlParameter("@USA_SUCURSAL", entity.USA_SUCURSAL));
            parameters.Add(new SqlParameter("@MASCARA_SUCURSAL", entity.MASCARA_SUCURSAL));
            parameters.Add(new SqlParameter("@DIRECCION_WEB1", entity.DIRECCION_WEB1));
            parameters.Add(new SqlParameter("@DIRECCION_WEB2", entity.DIRECCION_WEB2));
            parameters.Add(new SqlParameter("@NOMBRE_WEB1", entity.NOMBRE_WEB1));
            parameters.Add(new SqlParameter("@NOMBRE_WEB2", entity.NOMBRE_WEB2));
            parameters.Add(new SqlParameter("@DIRECCION_PAG_WEB", entity.DIRECCION_PAG_WEB));
            parameters.Add(new SqlParameter("@EMAIL_DOC_ELECTRONICO", entity.EMAIL_DOC_ELECTRONICO));
            parameters.Add(new SqlParameter("@PAIS_DIVISION", entity.PAIS_DIVISION));
            parameters.Add(new SqlParameter("@DIVISION_GEOGRAFICA1", entity.DIVISION_GEOGRAFICA1));
            parameters.Add(new SqlParameter("@DIVISION_GEOGRAFICA2", entity.DIVISION_GEOGRAFICA2));
            //parameters.Add(new SqlParameter("@LOGO_CIA", entity.LOGO_CIA));
            parameters.Add(new SqlParameter("@NUMERO_REGISTRO", entity.NUMERO_REGISTRO));
            parameters.Add(new SqlParameter("@DIREC3", entity.DIREC3));
            parameters.Add(new SqlParameter("@COD_POSTAL", entity.COD_POSTAL));
            parameters.Add(new SqlParameter("@DIVISION_GEOGRAFICA3", entity.DIVISION_GEOGRAFICA3));
            parameters.Add(new SqlParameter("@DIVISION_GEOGRAFICA4", entity.DIVISION_GEOGRAFICA4));
            parameters.Add(new SqlParameter("@REGIMEN_FISCAL", entity.REGIMEN_FISCAL));
            parameters.Add(new SqlParameter("@INVENTARIO_DOLAR", entity.INVENTARIO_DOLAR));
            parameters.Add(new SqlParameter("@RecordDate", entity.RecordDate));
            parameters.Add(new SqlParameter("@UpdatedBy", entity.UpdatedBy));
          


            return ExecuteNonQuery(update);
        }


        public IEnumerable<Conjunto> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listConjunto = new List<Conjunto>();
            foreach (DataRow item in tableResult.Rows)
            {
                listConjunto.Add(new Conjunto
                {
                    CONJUNTO = item[0].ToString(),
                    NOMBRE = item[1].ToString(),
                    DIREC1 = item[2].ToString(),
                    DIREC2 = item[3].ToString(),
                    TELEFONO = item[4].ToString(),
                    LOGO = item[5].ToString(),
                    DOBLE_MONEDA = item[6].ToString(),
                    DOBLE_CONTABILIDAD = item[7].ToString(),
                    USA_LOTES = item[8].ToString(),
                    USAR_CENTROS_COSTO = item[9].ToString(),
                    CONSOLIDA = item[10].ToString(),
                    CONSOLIDADORA = item[11].ToString(),
                    BD_CIA_CONSOLIDAD = item[12].ToString(),
                    CONTA_A_CONSOLID = item[13].ToString(),
                    MISMO_CUADRO_CTB = item[14].ToString(),
                    USUARIO_ULT_MOD = item[15].ToString(),
                    FCH_HORA_ULT_MOD = Convert.ToDateTime( item[16]),
                    NOTAS = item[17].ToString(),
                    USA_UNIDADES = item[18].ToString(),
                    UNIDAD_OMISION = item[19].ToString(),
                    MONEDA_CONSOLIDA = item[20].ToString(),
                    VERSION_BD = item[21].ToString(),
                    USUARIO_MODIF_BD = item[22].ToString(),
                    FCH_HORA_MODIF_BD =Convert.ToDateTime( item[23]),
                    VERSION_INSTALAC = item[24].ToString(),
                    NIT = item[25].ToString(),
                    PAIS = item[26].ToString(),
                    GLN = item[27].ToString(),
                    UBICACION = item[28].ToString(),
                    IDIOMA = item[29].ToString(),
                    USA_SUCURSAL = item[30].ToString(),
                    MASCARA_SUCURSAL = item[31].ToString(),
                    DIRECCION_WEB1 = item[32].ToString(),
                    DIRECCION_WEB2 = item[33].ToString(),
                    NOMBRE_WEB1 = item[34].ToString(),
                    NOMBRE_WEB2 = item[35].ToString(),
                    DIRECCION_PAG_WEB = item[36].ToString(),
                    EMAIL_DOC_ELECTRONICO = item[37].ToString(),
                    PAIS_DIVISION = item[38].ToString(),
                    DIVISION_GEOGRAFICA1 = item[39].ToString(),
                    DIVISION_GEOGRAFICA2 = item[40].ToString(),
                    LOGO_CIA = item[41].ToString(),
                    NUMERO_REGISTRO = item[42].ToString(),
                    DIREC3 = item[43].ToString(),
                    COD_POSTAL = item[44].ToString(),
                    DIVISION_GEOGRAFICA3 = item[45].ToString(),
                    DIVISION_GEOGRAFICA4 = item[46].ToString(),
                    REGIMEN_FISCAL = item[47].ToString(),
                   RecordDate=Convert.ToDateTime(item[49]),
                    CreatedBy=item[50].ToString(),
                   UpdatedBy=item[51].ToString(),
                  CreateDate=Convert.ToDateTime(item[52]),
 
                });
            }
            return listConjunto;
        }

        public int Remove(string CONJUNTO)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@CONJUNTO", CONJUNTO));
            return ExecuteNonQuery(delete);

            
        }

        public int Remove2(string valor1, string valor2)
        {
            throw new NotImplementedException();

        }
    }
}



