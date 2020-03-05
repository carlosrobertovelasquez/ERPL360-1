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
    public class PaisRepository : MasterRepository, IPaisRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public PaisRepository()
        {
            selectAll = "SELECT * FROM ERPL360.PAIS";
            insert = "insert into ERPL360.PAIS(PAIS,CONJUNTO,DIRECCION,NOMBRE,CTR_VENTAS,CTA_VENTAS,CTR_DESC_GRAL,CTA_DESC_GRAL,CTR_COST_VENT,CTA_COST_VENT,CTR_DESC_LIN,CTA_DESC_LIN,CTR_COST_LIN,CTA_COST_LIN,CTR_GAST_COM,CTA_GAST_COM,CTR_CONTADO,CTA_CONTADO,CTR_CXC,CTA_CXC,CTR_LXC,CTA_LXC,CTR_PRONTO_PAG_CXC,CTA_PRONTO_PAG_CXC,CTR_INT_MORA_CXC,CTA_INT_MORA_CXC,CTR_RECIBOS_CXC,CTA_RECIBOS_CXC,CTR_DEBITO_CXC,CTA_DEBITO_CXC,CTR_CREDITO_CXC,CTA_CREDITO_CXC,CTR_IMPUESTO1_CXC,CTA_IMPUESTO1_CXC,CTR_IMPUESTO2_CXC,CTA_IMPUESTO2_CXC,CTR_RUBRO1_CXC,CTA_RUBRO1_CXC,CTR_RUBRO2_CXC,CTA_RUBRO2_CXC,CTR_ANTICIPO_CXC,CTA_ANTICIPO_CXC,CTR_LXP,CTA_LXP,CTR_CREDITO_CXP,CTA_CREDITO_CXP,CTR_DEBITO_CXP,CTA_DEBITO_CXP,CTR_CXP,CTA_CXP,CTR_PRONTO_PAG_CXP,CTA_PRONTO_PAG_CXP,CTR_COMISION_CXP,CTA_COMISION_CXP,CTR_IMPUESTO1_CXP,CTA_IMPUESTO1_CXP,CTR_IMPUESTO2_CXP,CTA_IMPUESTO2_CXP,CTR_RUBRO1_CXP,CTA_RUBRO1_CXP,CTR_RUBRO2_CXP,CTA_RUBRO2_CXP,CTR_ANTICIPO_CXP,CTA_ANTICIPO_CXP,CTR_DESC_BONIF,CTA_DESC_BONIF,CTR_DEV_VENTAS,CTA_DEV_VENTAS,CTR_INT_CORRIENTE,CTA_INT_CORRIENTE,CODIGO_ISO,ETIQUETA_DIV_GEO1,ETIQUETA_DIV_GEO2,MONEDA,CTR_VENTAS_EXEN,CTA_VENTAS_EXEN,CTR_AJUSTE_REDONDEO,CTA_AJUSTE_REDONDEO,ETIQUETA_DIV_GEO3,ETIQUETA_DIV_GEO4,U_PAIS,RecordDate,CreatedBy,UpdatedBy,CreateDate) values(@PAIS,@CONJUNTO,@DIRECCION,@NOMBRE,@CTR_VENTAS,@CTA_VENTAS,@CTR_DESC_GRAL,@CTA_DESC_GRAL,@CTR_COST_VENT,@CTA_COST_VENT,@CTR_DESC_LIN,@CTA_DESC_LIN,@CTR_COST_LIN,@CTA_COST_LIN,@CTR_GAST_COM,@CTA_GAST_COM,@CTR_CONTADO,@CTA_CONTADO,@CTR_CXC,@CTA_CXC,@CTR_LXC,@CTA_LXC,@CTR_PRONTO_PAG_CXC,@CTA_PRONTO_PAG_CXC,@CTR_INT_MORA_CXC,@CTA_INT_MORA_CXC,@CTR_RECIBOS_CXC,@CTA_RECIBOS_CXC,@CTR_DEBITO_CXC,@CTA_DEBITO_CXC,@CTR_CREDITO_CXC,@CTA_CREDITO_CXC,@CTR_IMPUESTO1_CXC,@CTA_IMPUESTO1_CXC,@CTR_IMPUESTO2_CXC,@CTA_IMPUESTO2_CXC,@CTR_RUBRO1_CXC,@CTA_RUBRO1_CXC,@CTR_RUBRO2_CXC,@CTA_RUBRO2_CXC,@CTR_ANTICIPO_CXC,@CTA_ANTICIPO_CXC,@CTR_LXP,@CTA_LXP,@CTR_CREDITO_CXP,@CTA_CREDITO_CXP,@CTR_DEBITO_CXP,@CTA_DEBITO_CXP,@CTR_CXP,@CTA_CXP,@CTR_PRONTO_PAG_CXP,@CTA_PRONTO_PAG_CXP,@CTR_COMISION_CXP,@CTA_COMISION_CXP,@CTR_IMPUESTO1_CXP,@CTA_IMPUESTO1_CXP,@CTR_IMPUESTO2_CXP,@CTA_IMPUESTO2_CXP,@CTR_RUBRO1_CXP,@CTA_RUBRO1_CXP,@CTR_RUBRO2_CXP,@CTA_RUBRO2_CXP,@CTR_ANTICIPO_CXP,@CTA_ANTICIPO_CXP,@CTR_DESC_BONIF,@CTA_DESC_BONIF,@CTR_DEV_VENTAS,@CTA_DEV_VENTAS,@CTR_INT_CORRIENTE,@CTA_INT_CORRIENTE,@CODIGO_ISO,@ETIQUETA_DIV_GEO1,@ETIQUETA_DIV_GEO2,@MONEDA,@CTR_VENTAS_EXEN,@CTA_VENTAS_EXEN,@CTR_AJUSTE_REDONDEO,@CTA_AJUSTE_REDONDEO,@ETIQUETA_DIV_GEO3,@ETIQUETA_DIV_GEO4,@U_PAIS,@RecordDate,@CreatedBy,@UpdatedBy,@CreateDate)";
            update = "UPDATE ERPL360.PAIS SET DIRECCION=@DIRECCION, NOMBRE=@NOMBRE, CTR_VENTAS=@CTR_VENTAS, CTA_VENTAS=@CTA_VENTAS, CTR_DESC_GRAL=@CTR_DESC_GRAL, CTA_DESC_GRAL=@CTA_DESC_GRAL, CTR_COST_VENT=@CTR_COST_VENT, CTA_COST_VENT=@CTA_COST_VENT, CTR_DESC_LIN=@CTR_DESC_LIN, CTA_DESC_LIN=@CTA_DESC_LIN, CTR_COST_LIN=@CTR_COST_LIN, CTA_COST_LIN=@CTA_COST_LIN, CTR_GAST_COM=@CTR_GAST_COM, CTA_GAST_COM=@CTA_GAST_COM, CTR_CONTADO=@CTR_CONTADO, CTA_CONTADO=@CTA_CONTADO, CTR_CXC=@CTR_CXC, CTA_CXC=@CTA_CXC, CTR_LXC=@CTR_LXC, CTA_LXC=@CTA_LXC, CTR_PRONTO_PAG_CXC=@CTR_PRONTO_PAG_CXC, CTA_PRONTO_PAG_CXC=@CTA_PRONTO_PAG_CXC, CTR_INT_MORA_CXC=@CTR_INT_MORA_CXC, CTA_INT_MORA_CXC=@CTA_INT_MORA_CXC, CTR_RECIBOS_CXC=@CTR_RECIBOS_CXC, CTA_RECIBOS_CXC=@CTA_RECIBOS_CXC, CTR_DEBITO_CXC=@CTR_DEBITO_CXC, CTA_DEBITO_CXC=@CTA_DEBITO_CXC, CTR_CREDITO_CXC=@CTR_CREDITO_CXC, CTA_CREDITO_CXC=@CTA_CREDITO_CXC, CTR_IMPUESTO1_CXC=@CTR_IMPUESTO1_CXC, CTA_IMPUESTO1_CXC=@CTA_IMPUESTO1_CXC, CTR_IMPUESTO2_CXC=@CTR_IMPUESTO2_CXC, CTA_IMPUESTO2_CXC=@CTA_IMPUESTO2_CXC, CTR_RUBRO1_CXC=@CTR_RUBRO1_CXC, CTA_RUBRO1_CXC=@CTA_RUBRO1_CXC, CTR_RUBRO2_CXC=@CTR_RUBRO2_CXC, CTA_RUBRO2_CXC=@CTA_RUBRO2_CXC, CTR_ANTICIPO_CXC=@CTR_ANTICIPO_CXC, CTA_ANTICIPO_CXC=@CTA_ANTICIPO_CXC, CTR_LXP=@CTR_LXP, CTA_LXP=@CTA_LXP, CTR_CREDITO_CXP=@CTR_CREDITO_CXP, CTA_CREDITO_CXP=@CTA_CREDITO_CXP, CTR_DEBITO_CXP=@CTR_DEBITO_CXP, CTA_DEBITO_CXP=@CTA_DEBITO_CXP, CTR_CXP=@CTR_CXP, CTA_CXP=@CTA_CXP, CTR_PRONTO_PAG_CXP=@CTR_PRONTO_PAG_CXP, CTA_PRONTO_PAG_CXP=@CTA_PRONTO_PAG_CXP, CTR_COMISION_CXP=@CTR_COMISION_CXP, CTA_COMISION_CXP=@CTA_COMISION_CXP, CTR_IMPUESTO1_CXP=@CTR_IMPUESTO1_CXP, CTA_IMPUESTO1_CXP=@CTA_IMPUESTO1_CXP, CTR_IMPUESTO2_CXP=@CTR_IMPUESTO2_CXP, CTA_IMPUESTO2_CXP=@CTA_IMPUESTO2_CXP, CTR_RUBRO1_CXP=@CTR_RUBRO1_CXP, CTA_RUBRO1_CXP=@CTA_RUBRO1_CXP, CTR_RUBRO2_CXP=@CTR_RUBRO2_CXP, CTA_RUBRO2_CXP=@CTA_RUBRO2_CXP, CTR_ANTICIPO_CXP=@CTR_ANTICIPO_CXP, CTA_ANTICIPO_CXP=@CTA_ANTICIPO_CXP, CTR_DESC_BONIF=@CTR_DESC_BONIF, CTA_DESC_BONIF=@CTA_DESC_BONIF, CTR_DEV_VENTAS=@CTR_DEV_VENTAS, CTA_DEV_VENTAS=@CTA_DEV_VENTAS, CTR_INT_CORRIENTE=@CTR_INT_CORRIENTE, CTA_INT_CORRIENTE=@CTA_INT_CORRIENTE, CODIGO_ISO=@CODIGO_ISO, ETIQUETA_DIV_GEO1=@ETIQUETA_DIV_GEO1, ETIQUETA_DIV_GEO2=@ETIQUETA_DIV_GEO2, MONEDA=@MONEDA, CTR_VENTAS_EXEN=@CTR_VENTAS_EXEN, CTA_VENTAS_EXEN=@CTA_VENTAS_EXEN, CTR_AJUSTE_REDONDEO=@CTR_AJUSTE_REDONDEO, CTA_AJUSTE_REDONDEO=@CTA_AJUSTE_REDONDEO, ETIQUETA_DIV_GEO3=@ETIQUETA_DIV_GEO3, ETIQUETA_DIV_GEO4=@ETIQUETA_DIV_GEO4, U_PAIS=@U_PAIS, RecordDate=@RecordDate,  UpdatedBy=@UpdatedBy   WHERE CONJUNTO=@CONJUNTO AND ZONA=@ZONA ";
            delete = "DELETE ERPL360.PAIS WHERE CONJUNTO=@CONJUNTO AND PAIS=@PAIS";
        }

        public int Add(Pais entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@PAIS",entity.PAIS )) ;
            parameters.Add(new SqlParameter("@CONJUNTO", entity.CONJUNTO)) ;
            parameters.Add(new SqlParameter("@DIRECCION", entity.DIRECCION)) ;
            parameters.Add(new SqlParameter("@NOMBRE", entity.NOMBRE)) ;
            parameters.Add(new SqlParameter("@CTR_VENTAS", entity.CTR_VENTAS)) ;
            parameters.Add(new SqlParameter("@CTA_VENTAS", entity.CTA_VENTAS)) ;
            parameters.Add(new SqlParameter("@CTR_DESC_GRAL", entity.CTR_DESC_GRAL)) ;
            parameters.Add(new SqlParameter("@CTA_DESC_GRAL", entity.CTA_DESC_GRAL)) ;
            parameters.Add(new SqlParameter("@CTR_COST_VENT", entity.CTR_COST_VENT)) ;
            parameters.Add(new SqlParameter("@CTA_COST_VENT", entity.CTA_COST_VENT)) ;
            parameters.Add(new SqlParameter("@CTR_DESC_LIN", entity.CTR_DESC_LIN)) ;
            parameters.Add(new SqlParameter("@CTA_DESC_LIN", entity.CTA_DESC_LIN)) ;
            parameters.Add(new SqlParameter("@CTR_COST_LIN", entity.CTR_COST_LIN)) ;
            parameters.Add(new SqlParameter("@CTA_COST_LIN", entity.CTA_COST_LIN)) ;
            parameters.Add(new SqlParameter("@CTR_GAST_COM", entity.CTR_GAST_COM)) ;
            parameters.Add(new SqlParameter("@CTA_GAST_COM", entity.CTA_GAST_COM)) ;
            parameters.Add(new SqlParameter("@CTR_CONTADO", entity.CTR_CONTADO)) ;
            parameters.Add(new SqlParameter("@CTA_CONTADO", entity.CTA_CONTADO)) ;
            parameters.Add(new SqlParameter("@CTR_CXC", entity.CTR_CXC)) ;
            parameters.Add(new SqlParameter("@CTA_CXC", entity.CTA_CXC)) ;
            parameters.Add(new SqlParameter("@CTR_LXC", entity.CTR_LXC)) ;
            parameters.Add(new SqlParameter("@CTA_LXC", entity.CTA_LXC)) ;
            parameters.Add(new SqlParameter("@CTR_PRONTO_PAG_CXC", entity.CTR_PRONTO_PAG_CXC)) ;
            parameters.Add(new SqlParameter("@CTA_PRONTO_PAG_CXC", entity.CTA_PRONTO_PAG_CXC)) ;
            parameters.Add(new SqlParameter("@CTR_INT_MORA_CXC", entity.CTR_INT_MORA_CXC)) ;
            parameters.Add(new SqlParameter("@CTA_INT_MORA_CXC", entity.CTA_INT_MORA_CXC)) ;
            parameters.Add(new SqlParameter("@CTR_RECIBOS_CXC", entity.CTR_RECIBOS_CXC)) ;
            parameters.Add(new SqlParameter("@CTA_RECIBOS_CXC", entity.CTA_RECIBOS_CXC)) ;
            parameters.Add(new SqlParameter("@CTR_DEBITO_CXC", entity.CTR_DEBITO_CXC)) ;
            parameters.Add(new SqlParameter("@CTA_DEBITO_CXC", entity.CTA_DEBITO_CXC)) ;
            parameters.Add(new SqlParameter("@CTR_CREDITO_CXC", entity.CTR_CREDITO_CXC)) ;
            parameters.Add(new SqlParameter("@CTA_CREDITO_CXC", entity.CTA_CREDITO_CXC)) ;
            parameters.Add(new SqlParameter("@CTR_IMPUESTO1_CXC", entity.CTR_IMPUESTO1_CXC)) ;
            parameters.Add(new SqlParameter("@CTA_IMPUESTO1_CXC", entity.CTA_IMPUESTO1_CXC)) ;
            parameters.Add(new SqlParameter("@CTR_IMPUESTO2_CXC", entity.CTR_IMPUESTO2_CXC)) ;
            parameters.Add(new SqlParameter("@CTA_IMPUESTO2_CXC", entity.CTA_IMPUESTO2_CXC)) ;
            parameters.Add(new SqlParameter("@CTR_RUBRO1_CXC", entity.CTR_RUBRO1_CXC)) ;
            parameters.Add(new SqlParameter("@CTA_RUBRO1_CXC", entity.CTA_RUBRO1_CXC)) ;
            parameters.Add(new SqlParameter("@CTR_RUBRO2_CXC", entity.CTR_RUBRO2_CXC)) ;
            parameters.Add(new SqlParameter("@CTA_RUBRO2_CXC", entity.CTA_RUBRO2_CXC)) ;
            parameters.Add(new SqlParameter("@CTR_ANTICIPO_CXC", entity.CTR_ANTICIPO_CXC)) ;
            parameters.Add(new SqlParameter("@CTA_ANTICIPO_CXC", entity.CTA_ANTICIPO_CXC)) ;
            parameters.Add(new SqlParameter("@CTR_LXP", entity.CTR_LXP)) ;
            parameters.Add(new SqlParameter("@CTA_LXP", entity.CTA_LXP)) ;
            parameters.Add(new SqlParameter("@CTR_CREDITO_CXP", entity.CTR_CREDITO_CXP)) ;
            parameters.Add(new SqlParameter("@CTA_CREDITO_CXP", entity.CTA_CREDITO_CXP)) ;
            parameters.Add(new SqlParameter("@CTR_DEBITO_CXP", entity.CTR_DEBITO_CXP)) ;
            parameters.Add(new SqlParameter("@CTA_DEBITO_CXP", entity.CTA_DEBITO_CXP)) ;
            parameters.Add(new SqlParameter("@CTR_CXP", entity.CTR_CXP)) ;
            parameters.Add(new SqlParameter("@CTA_CXP", entity.CTA_CXP)) ;
            parameters.Add(new SqlParameter("@CTR_PRONTO_PAG_CXP", entity.CTR_PRONTO_PAG_CXP)) ;
            parameters.Add(new SqlParameter("@CTA_PRONTO_PAG_CXP", entity.CTA_PRONTO_PAG_CXP)) ;
            parameters.Add(new SqlParameter("@CTR_COMISION_CXP", entity.CTR_COMISION_CXP)) ;
            parameters.Add(new SqlParameter("@CTA_COMISION_CXP", entity.CTA_COMISION_CXP)) ;
            parameters.Add(new SqlParameter("@CTR_IMPUESTO1_CXP", entity.CTR_IMPUESTO1_CXP)) ;
            parameters.Add(new SqlParameter("@CTA_IMPUESTO1_CXP", entity.CTA_IMPUESTO1_CXP)) ;
            parameters.Add(new SqlParameter("@CTR_IMPUESTO2_CXP", entity.CTR_IMPUESTO2_CXP)) ;
            parameters.Add(new SqlParameter("@CTA_IMPUESTO2_CXP", entity.CTA_IMPUESTO2_CXP)) ;
            parameters.Add(new SqlParameter("@CTR_RUBRO1_CXP", entity.CTR_RUBRO1_CXP)) ;
            parameters.Add(new SqlParameter("@CTA_RUBRO1_CXP", entity.CTA_RUBRO1_CXP)) ;
            parameters.Add(new SqlParameter("@CTR_RUBRO2_CXP", entity.CTR_RUBRO2_CXP)) ;
            parameters.Add(new SqlParameter("@CTA_RUBRO2_CXP", entity.CTA_RUBRO2_CXP)) ;
            parameters.Add(new SqlParameter("@CTR_ANTICIPO_CXP", entity.CTR_ANTICIPO_CXP)) ;
            parameters.Add(new SqlParameter("@CTA_ANTICIPO_CXP", entity.CTA_ANTICIPO_CXP)) ;
            parameters.Add(new SqlParameter("@CTR_DESC_BONIF", entity.CTR_DESC_BONIF)) ;
            parameters.Add(new SqlParameter("@CTA_DESC_BONIF", entity.CTA_DESC_BONIF)) ;
            parameters.Add(new SqlParameter("@CTR_DEV_VENTAS", entity.CTR_DEV_VENTAS)) ;
            parameters.Add(new SqlParameter("@CTA_DEV_VENTAS", entity.CTA_DEV_VENTAS)) ;
            parameters.Add(new SqlParameter("@CTR_INT_CORRIENTE", entity.CTR_INT_CORRIENTE)) ;
            parameters.Add(new SqlParameter("@CTA_INT_CORRIENTE", entity.CTA_INT_CORRIENTE)) ;
            parameters.Add(new SqlParameter("@CODIGO_ISO", entity.CODIGO_ISO)) ;
            parameters.Add(new SqlParameter("@ETIQUETA_DIV_GEO1", entity.ETIQUETA_DIV_GEO1)) ;
            parameters.Add(new SqlParameter("@ETIQUETA_DIV_GEO2", entity.ETIQUETA_DIV_GEO2)) ;
            parameters.Add(new SqlParameter("@MONEDA", entity.MONEDA)) ;
            parameters.Add(new SqlParameter("@CTR_VENTAS_EXEN", entity.CTR_VENTAS_EXEN)) ;
            parameters.Add(new SqlParameter("@CTA_VENTAS_EXEN", entity.CTA_VENTAS_EXEN)) ;
            parameters.Add(new SqlParameter("@CTR_AJUSTE_REDONDEO", entity.CTR_AJUSTE_REDONDEO)) ;
            parameters.Add(new SqlParameter("@CTA_AJUSTE_REDONDEO", entity.CTA_AJUSTE_REDONDEO)) ;
            parameters.Add(new SqlParameter("@ETIQUETA_DIV_GEO3", entity.ETIQUETA_DIV_GEO3)) ;
            parameters.Add(new SqlParameter("@ETIQUETA_DIV_GEO4", entity.ETIQUETA_DIV_GEO4)) ;
            parameters.Add(new SqlParameter("@U_PAIS", entity.U_PAIS)) ;
            parameters.Add(new SqlParameter("@RecordDate", entity.RecordDate)) ;
            parameters.Add(new SqlParameter("@CreatedBy", entity.CreatedBy)) ;
            parameters.Add(new SqlParameter("@UpdatedBy", entity.UpdatedBy)) ;
            parameters.Add(new SqlParameter("@CreateDate", entity.CreateDate)) ;
            return ExecuteNonQuery(insert);
        }

        public int Edit(Pais entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@PAIS", entity.PAIS));
            parameters.Add(new SqlParameter("@CONJUNTO", entity.CONJUNTO));
            parameters.Add(new SqlParameter("@DIRECCION", entity.DIRECCION));
            parameters.Add(new SqlParameter("@NOMBRE", entity.NOMBRE));
            parameters.Add(new SqlParameter("@CTR_VENTAS", entity.CTR_VENTAS));
            parameters.Add(new SqlParameter("@CTA_VENTAS", entity.CTA_VENTAS));
            parameters.Add(new SqlParameter("@CTR_DESC_GRAL", entity.CTR_DESC_GRAL));
            parameters.Add(new SqlParameter("@CTA_DESC_GRAL", entity.CTA_DESC_GRAL));
            parameters.Add(new SqlParameter("@CTR_COST_VENT", entity.CTR_COST_VENT));
            parameters.Add(new SqlParameter("@CTA_COST_VENT", entity.CTA_COST_VENT));
            parameters.Add(new SqlParameter("@CTR_DESC_LIN", entity.CTR_DESC_LIN));
            parameters.Add(new SqlParameter("@CTA_DESC_LIN", entity.CTA_DESC_LIN));
            parameters.Add(new SqlParameter("@CTR_COST_LIN", entity.CTR_COST_LIN));
            parameters.Add(new SqlParameter("@CTA_COST_LIN", entity.CTA_COST_LIN));
            parameters.Add(new SqlParameter("@CTR_GAST_COM", entity.CTR_GAST_COM));
            parameters.Add(new SqlParameter("@CTA_GAST_COM", entity.CTA_GAST_COM));
            parameters.Add(new SqlParameter("@CTR_CONTADO", entity.CTR_CONTADO));
            parameters.Add(new SqlParameter("@CTA_CONTADO", entity.CTA_CONTADO));
            parameters.Add(new SqlParameter("@CTR_CXC", entity.CTR_CXC));
            parameters.Add(new SqlParameter("@CTA_CXC", entity.CTA_CXC));
            parameters.Add(new SqlParameter("@CTR_LXC", entity.CTR_LXC));
            parameters.Add(new SqlParameter("@CTA_LXC", entity.CTA_LXC));
            parameters.Add(new SqlParameter("@CTR_PRONTO_PAG_CXC", entity.CTR_PRONTO_PAG_CXC));
            parameters.Add(new SqlParameter("@CTA_PRONTO_PAG_CXC", entity.CTA_PRONTO_PAG_CXC));
            parameters.Add(new SqlParameter("@CTR_INT_MORA_CXC", entity.CTR_INT_MORA_CXC));
            parameters.Add(new SqlParameter("@CTA_INT_MORA_CXC", entity.CTA_INT_MORA_CXC));
            parameters.Add(new SqlParameter("@CTR_RECIBOS_CXC", entity.CTR_RECIBOS_CXC));
            parameters.Add(new SqlParameter("@CTA_RECIBOS_CXC", entity.CTA_RECIBOS_CXC));
            parameters.Add(new SqlParameter("@CTR_DEBITO_CXC", entity.CTR_DEBITO_CXC));
            parameters.Add(new SqlParameter("@CTA_DEBITO_CXC", entity.CTA_DEBITO_CXC));
            parameters.Add(new SqlParameter("@CTR_CREDITO_CXC", entity.CTR_CREDITO_CXC));
            parameters.Add(new SqlParameter("@CTA_CREDITO_CXC", entity.CTA_CREDITO_CXC));
            parameters.Add(new SqlParameter("@CTR_IMPUESTO1_CXC", entity.CTR_IMPUESTO1_CXC));
            parameters.Add(new SqlParameter("@CTA_IMPUESTO1_CXC", entity.CTA_IMPUESTO1_CXC));
            parameters.Add(new SqlParameter("@CTR_IMPUESTO2_CXC", entity.CTR_IMPUESTO2_CXC));
            parameters.Add(new SqlParameter("@CTA_IMPUESTO2_CXC", entity.CTA_IMPUESTO2_CXC));
            parameters.Add(new SqlParameter("@CTR_RUBRO1_CXC", entity.CTR_RUBRO1_CXC));
            parameters.Add(new SqlParameter("@CTA_RUBRO1_CXC", entity.CTA_RUBRO1_CXC));
            parameters.Add(new SqlParameter("@CTR_RUBRO2_CXC", entity.CTR_RUBRO2_CXC));
            parameters.Add(new SqlParameter("@CTA_RUBRO2_CXC", entity.CTA_RUBRO2_CXC));
            parameters.Add(new SqlParameter("@CTR_ANTICIPO_CXC", entity.CTR_ANTICIPO_CXC));
            parameters.Add(new SqlParameter("@CTA_ANTICIPO_CXC", entity.CTA_ANTICIPO_CXC));
            parameters.Add(new SqlParameter("@CTR_LXP", entity.CTR_LXP));
            parameters.Add(new SqlParameter("@CTA_LXP", entity.CTA_LXP));
            parameters.Add(new SqlParameter("@CTR_CREDITO_CXP", entity.CTR_CREDITO_CXP));
            parameters.Add(new SqlParameter("@CTA_CREDITO_CXP", entity.CTA_CREDITO_CXP));
            parameters.Add(new SqlParameter("@CTR_DEBITO_CXP", entity.CTR_DEBITO_CXP));
            parameters.Add(new SqlParameter("@CTA_DEBITO_CXP", entity.CTA_DEBITO_CXP));
            parameters.Add(new SqlParameter("@CTR_CXP", entity.CTR_CXP));
            parameters.Add(new SqlParameter("@CTA_CXP", entity.CTA_CXP));
            parameters.Add(new SqlParameter("@CTR_PRONTO_PAG_CXP", entity.CTR_PRONTO_PAG_CXP));
            parameters.Add(new SqlParameter("@CTA_PRONTO_PAG_CXP", entity.CTA_PRONTO_PAG_CXP));
            parameters.Add(new SqlParameter("@CTR_COMISION_CXP", entity.CTR_COMISION_CXP));
            parameters.Add(new SqlParameter("@CTA_COMISION_CXP", entity.CTA_COMISION_CXP));
            parameters.Add(new SqlParameter("@CTR_IMPUESTO1_CXP", entity.CTR_IMPUESTO1_CXP));
            parameters.Add(new SqlParameter("@CTA_IMPUESTO1_CXP", entity.CTA_IMPUESTO1_CXP));
            parameters.Add(new SqlParameter("@CTR_IMPUESTO2_CXP", entity.CTR_IMPUESTO2_CXP));
            parameters.Add(new SqlParameter("@CTA_IMPUESTO2_CXP", entity.CTA_IMPUESTO2_CXP));
            parameters.Add(new SqlParameter("@CTR_RUBRO1_CXP", entity.CTR_RUBRO1_CXP));
            parameters.Add(new SqlParameter("@CTA_RUBRO1_CXP", entity.CTA_RUBRO1_CXP));
            parameters.Add(new SqlParameter("@CTR_RUBRO2_CXP", entity.CTR_RUBRO2_CXP));
            parameters.Add(new SqlParameter("@CTA_RUBRO2_CXP", entity.CTA_RUBRO2_CXP));
            parameters.Add(new SqlParameter("@CTR_ANTICIPO_CXP", entity.CTR_ANTICIPO_CXP));
            parameters.Add(new SqlParameter("@CTA_ANTICIPO_CXP", entity.CTA_ANTICIPO_CXP));
            parameters.Add(new SqlParameter("@CTR_DESC_BONIF", entity.CTR_DESC_BONIF));
            parameters.Add(new SqlParameter("@CTA_DESC_BONIF", entity.CTA_DESC_BONIF));
            parameters.Add(new SqlParameter("@CTR_DEV_VENTAS", entity.CTR_DEV_VENTAS));
            parameters.Add(new SqlParameter("@CTA_DEV_VENTAS", entity.CTA_DEV_VENTAS));
            parameters.Add(new SqlParameter("@CTR_INT_CORRIENTE", entity.CTR_INT_CORRIENTE));
            parameters.Add(new SqlParameter("@CTA_INT_CORRIENTE", entity.CTA_INT_CORRIENTE));
            parameters.Add(new SqlParameter("@CODIGO_ISO", entity.CODIGO_ISO));
            parameters.Add(new SqlParameter("@ETIQUETA_DIV_GEO1", entity.ETIQUETA_DIV_GEO1));
            parameters.Add(new SqlParameter("@ETIQUETA_DIV_GEO2", entity.ETIQUETA_DIV_GEO2));
            parameters.Add(new SqlParameter("@MONEDA", entity.MONEDA));
            parameters.Add(new SqlParameter("@CTR_VENTAS_EXEN", entity.CTR_VENTAS_EXEN));
            parameters.Add(new SqlParameter("@CTA_VENTAS_EXEN", entity.CTA_VENTAS_EXEN));
            parameters.Add(new SqlParameter("@CTR_AJUSTE_REDONDEO", entity.CTR_AJUSTE_REDONDEO));
            parameters.Add(new SqlParameter("@CTA_AJUSTE_REDONDEO", entity.CTA_AJUSTE_REDONDEO));
            parameters.Add(new SqlParameter("@ETIQUETA_DIV_GEO3", entity.ETIQUETA_DIV_GEO3));
            parameters.Add(new SqlParameter("@ETIQUETA_DIV_GEO4", entity.ETIQUETA_DIV_GEO4));
            parameters.Add(new SqlParameter("@U_PAIS", entity.U_PAIS));
            parameters.Add(new SqlParameter("@RecordDate", entity.RecordDate));
            parameters.Add(new SqlParameter("@UpdatedBy", entity.UpdatedBy));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Pais> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listPais = new List<Pais>();
            foreach (DataRow item in tableResult.Rows)
            {
                listPais.Add(new Pais
                {
                    PAIS = item[0].ToString(),
                    CONJUNTO = item[1].ToString(),
                    DIRECCION = item[2].ToString(),
                    NOMBRE = item[3].ToString(),
                    CTR_VENTAS = item[4].ToString(),
                    CTA_VENTAS = item[5].ToString(),
                    CTR_DESC_GRAL = item[6].ToString(),
                    CTA_DESC_GRAL = item[7].ToString(),
                    CTR_COST_VENT = item[8].ToString(),
                    CTA_COST_VENT = item[9].ToString(),
                    CTR_DESC_LIN = item[10].ToString(),
                    CTA_DESC_LIN = item[11].ToString(),
                    CTR_COST_LIN = item[12].ToString(),
                    CTA_COST_LIN = item[13].ToString(),
                    CTR_GAST_COM = item[14].ToString(),
                    CTA_GAST_COM = item[15].ToString(),
                    CTR_CONTADO = item[16].ToString(),
                    CTA_CONTADO = item[17].ToString(),
                    CTR_CXC = item[18].ToString(),
                    CTA_CXC = item[19].ToString(),
                    CTR_LXC = item[20].ToString(),
                    CTA_LXC = item[21].ToString(),
                    CTR_PRONTO_PAG_CXC = item[22].ToString(),
                    CTA_PRONTO_PAG_CXC = item[23].ToString(),
                    CTR_INT_MORA_CXC = item[24].ToString(),
                    CTA_INT_MORA_CXC = item[25].ToString(),
                    CTR_RECIBOS_CXC = item[26].ToString(),
                    CTA_RECIBOS_CXC = item[27].ToString(),
                    CTR_DEBITO_CXC = item[28].ToString(),
                    CTA_DEBITO_CXC = item[29].ToString(),
                    CTR_CREDITO_CXC = item[30].ToString(),
                    CTA_CREDITO_CXC = item[31].ToString(),
                    CTR_IMPUESTO1_CXC = item[32].ToString(),
                    CTA_IMPUESTO1_CXC = item[33].ToString(),
                    CTR_IMPUESTO2_CXC = item[34].ToString(),
                    CTA_IMPUESTO2_CXC = item[35].ToString(),
                    CTR_RUBRO1_CXC = item[36].ToString(),
                    CTA_RUBRO1_CXC = item[37].ToString(),
                    CTR_RUBRO2_CXC = item[38].ToString(),
                    CTA_RUBRO2_CXC = item[39].ToString(),
                    CTR_ANTICIPO_CXC = item[40].ToString(),
                    CTA_ANTICIPO_CXC = item[41].ToString(),
                    CTR_LXP = item[42].ToString(),
                    CTA_LXP = item[43].ToString(),
                    CTR_CREDITO_CXP = item[44].ToString(),
                    CTA_CREDITO_CXP = item[45].ToString(),
                    CTR_DEBITO_CXP = item[46].ToString(),
                    CTA_DEBITO_CXP = item[47].ToString(),
                    CTR_CXP = item[48].ToString(),
                    CTA_CXP = item[49].ToString(),
                    CTR_PRONTO_PAG_CXP = item[50].ToString(),
                    CTA_PRONTO_PAG_CXP = item[51].ToString(),
                    CTR_COMISION_CXP = item[52].ToString(),
                    CTA_COMISION_CXP = item[53].ToString(),
                    CTR_IMPUESTO1_CXP = item[54].ToString(),
                    CTA_IMPUESTO1_CXP = item[55].ToString(),
                    CTR_IMPUESTO2_CXP = item[56].ToString(),
                    CTA_IMPUESTO2_CXP = item[57].ToString(),
                    CTR_RUBRO1_CXP = item[58].ToString(),
                    CTA_RUBRO1_CXP = item[59].ToString(),
                    CTR_RUBRO2_CXP = item[60].ToString(),
                    CTA_RUBRO2_CXP = item[61].ToString(),
                    CTR_ANTICIPO_CXP = item[62].ToString(),
                    CTA_ANTICIPO_CXP = item[63].ToString(),
                    CTR_DESC_BONIF = item[64].ToString(),
                    CTA_DESC_BONIF = item[65].ToString(),
                    CTR_DEV_VENTAS = item[66].ToString(),
                    CTA_DEV_VENTAS = item[67].ToString(),
                    CTR_INT_CORRIENTE = item[68].ToString(),
                    CTA_INT_CORRIENTE = item[69].ToString(),
                    CODIGO_ISO = item[70].ToString(),
                    ETIQUETA_DIV_GEO1 = item[71].ToString(),
                    ETIQUETA_DIV_GEO2 = item[72].ToString(),
                    MONEDA = item[73].ToString(),
                    CTR_VENTAS_EXEN = item[74].ToString(),
                    CTA_VENTAS_EXEN = item[75].ToString(),
                    CTR_AJUSTE_REDONDEO = item[76].ToString(),
                    CTA_AJUSTE_REDONDEO = item[77].ToString(),
                    ETIQUETA_DIV_GEO3 = item[78].ToString(),
                    ETIQUETA_DIV_GEO4 = item[79].ToString(),
                    U_PAIS = item[80].ToString(),
                    RecordDate = Convert.ToDateTime(item[81]),
                    CreatedBy = item[82].ToString(),
                    UpdatedBy = item[83].ToString(),
                    CreateDate = Convert.ToDateTime(item[84]),

                });
            }
            return listPais;
        }

        public int Remove(string valor)
        {
            throw new NotImplementedException();
        }

        public int Remove2(string PAIS, string CONJUNTO)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@PAIS", PAIS));
            parameters.Add(new SqlParameter("@CONJUNTO", CONJUNTO));
            return ExecuteNonQuery(delete);

        }
    }
}
