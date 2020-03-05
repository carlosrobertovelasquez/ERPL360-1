using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logistika360.ERP.AS.DataAccess.Contracts;
using Logistika360.ERP.AS.DataAccess.Entities;
using Logistika360.ERP.AS.DataAccess.Repositories;
using Logistika360.ERP.AS.Domain.ValueObjects;
using Logistika360.ERP.ERPADMIN.Common.Cache;
using Logistika360.ERP.ERPADMIN.DataAccess.Repositories;
using System.ComponentModel.DataAnnotations;

namespace Logistika360.ERP.AS.Domain.Models
{
    public class PaisModel : IDisposable
    {

        private string PAIS;
        private string CONJUNTO;
        private string DIRECCION;
        private string NOMBRE;
        private string CTR_VENTAS;
        private string CTA_VENTAS;
        private string CTR_DESC_GRAL;
        private string CTA_DESC_GRAL;
        private string CTR_COST_VENT;
        private string CTA_COST_VENT;
        private string CTR_DESC_LIN;
        private string CTA_DESC_LIN;
        private string CTR_COST_LIN;
        private string CTA_COST_LIN;
        private string CTR_GAST_COM;
        private string CTA_GAST_COM;
        private string CTR_CONTADO;
        private string CTA_CONTADO;
        private string CTR_CXC;
        private string CTA_CXC;
        private string CTR_LXC;
        private string CTA_LXC;
        private string CTR_PRONTO_PAG_CXC;
        private string CTA_PRONTO_PAG_CXC;
        private string CTR_INT_MORA_CXC;
        private string CTA_INT_MORA_CXC;
        private string CTR_RECIBOS_CXC;
        private string CTA_RECIBOS_CXC;
        private string CTR_DEBITO_CXC;
        private string CTA_DEBITO_CXC;
        private string CTR_CREDITO_CXC;
        private string CTA_CREDITO_CXC;
        private string CTR_IMPUESTO1_CXC;
        private string CTA_IMPUESTO1_CXC;
        private string CTR_IMPUESTO2_CXC;
        private string CTA_IMPUESTO2_CXC;
        private string CTR_RUBRO1_CXC;
        private string CTA_RUBRO1_CXC;
        private string CTR_RUBRO2_CXC;
        private string CTA_RUBRO2_CXC;
        private string CTR_ANTICIPO_CXC;
        private string CTA_ANTICIPO_CXC;
        private string CTR_LXP;
        private string CTA_LXP;
        private string CTR_CREDITO_CXP;
        private string CTA_CREDITO_CXP;
        private string CTR_DEBITO_CXP;
        private string CTA_DEBITO_CXP;
        private string CTR_CXP;
        private string CTA_CXP;
        private string CTR_PRONTO_PAG_CXP;
        private string CTA_PRONTO_PAG_CXP;
        private string CTR_COMISION_CXP;
        private string CTA_COMISION_CXP;
        private string CTR_IMPUESTO1_CXP;
        private string CTA_IMPUESTO1_CXP;
        private string CTR_IMPUESTO2_CXP;
        private string CTA_IMPUESTO2_CXP;
        private string CTR_RUBRO1_CXP;
        private string CTA_RUBRO1_CXP;
        private string CTR_RUBRO2_CXP;
        private string CTA_RUBRO2_CXP;
        private string CTR_ANTICIPO_CXP;
        private string CTA_ANTICIPO_CXP;
        private string CTR_DESC_BONIF;
        private string CTA_DESC_BONIF;
        private string CTR_DEV_VENTAS;
        private string CTA_DEV_VENTAS;
        private string CTR_INT_CORRIENTE;
        private string CTA_INT_CORRIENTE;
        private string CODIGO_ISO;
        private string ETIQUETA_DIV_GEO1;
        private string ETIQUETA_DIV_GEO2;
        private string MONEDA;
        private string CTR_VENTAS_EXEN;
        private string CTA_VENTAS_EXEN;
        private string CTR_AJUSTE_REDONDEO;
        private string CTA_AJUSTE_REDONDEO;
        private string ETIQUETA_DIV_GEO3;
        private string ETIQUETA_DIV_GEO4;
        private string U_PAIS;
        private DateTime RecordDate;
        private string CreatedBy;
        private string UpdatedBy;
        private DateTime CreateDate;

        private IPaisRepository paisRepository;
        public EntityState State { private get; set; }
        [Required]
        public string PAIS1 { get => PAIS; set => PAIS = value; }
        public string CONJUNTO1 { get => CONJUNTO; set => CONJUNTO = value; }
        [Required]
        public string DIRECCION1 { get => DIRECCION; set => DIRECCION = value; }
        [Required]
        public string NOMBRE1 { get => NOMBRE; set => NOMBRE = value; }
        public string CTR_VENTAS1 { get => CTR_VENTAS; set => CTR_VENTAS = value; }
        public string CTA_VENTAS1 { get => CTA_VENTAS; set => CTA_VENTAS = value; }
        public string CTR_DESC_GRAL1 { get => CTR_DESC_GRAL; set => CTR_DESC_GRAL = value; }
        public string CTA_DESC_GRAL1 { get => CTA_DESC_GRAL; set => CTA_DESC_GRAL = value; }
        public string CTR_COST_VENT1 { get => CTR_COST_VENT; set => CTR_COST_VENT = value; }
        public string CTA_COST_VENT1 { get => CTA_COST_VENT; set => CTA_COST_VENT = value; }
        public string CTR_DESC_LIN1 { get => CTR_DESC_LIN; set => CTR_DESC_LIN = value; }
        public string CTA_DESC_LIN1 { get => CTA_DESC_LIN; set => CTA_DESC_LIN = value; }
        public string CTR_COST_LIN1 { get => CTR_COST_LIN; set => CTR_COST_LIN = value; }
        public string CTA_COST_LIN1 { get => CTA_COST_LIN; set => CTA_COST_LIN = value; }
        public string CTR_GAST_COM1 { get => CTR_GAST_COM; set => CTR_GAST_COM = value; }
        public string CTA_GAST_COM1 { get => CTA_GAST_COM; set => CTA_GAST_COM = value; }
        public string CTR_CONTADO1 { get => CTR_CONTADO; set => CTR_CONTADO = value; }
        public string CTA_CONTADO1 { get => CTA_CONTADO; set => CTA_CONTADO = value; }
        public string CTR_CXC1 { get => CTR_CXC; set => CTR_CXC = value; }
        public string CTA_CXC1 { get => CTA_CXC; set => CTA_CXC = value; }
        public string CTR_LXC1 { get => CTR_LXC; set => CTR_LXC = value; }
        public string CTA_LXC1 { get => CTA_LXC; set => CTA_LXC = value; }
        public string CTR_PRONTO_PAG_CXC1 { get => CTR_PRONTO_PAG_CXC; set => CTR_PRONTO_PAG_CXC = value; }
        public string CTA_PRONTO_PAG_CXC1 { get => CTA_PRONTO_PAG_CXC; set => CTA_PRONTO_PAG_CXC = value; }
        public string CTR_INT_MORA_CXC1 { get => CTR_INT_MORA_CXC; set => CTR_INT_MORA_CXC = value; }
        public string CTA_INT_MORA_CXC1 { get => CTA_INT_MORA_CXC; set => CTA_INT_MORA_CXC = value; }
        public string CTR_RECIBOS_CXC1 { get => CTR_RECIBOS_CXC; set => CTR_RECIBOS_CXC = value; }
        public string CTA_RECIBOS_CXC1 { get => CTA_RECIBOS_CXC; set => CTA_RECIBOS_CXC = value; }
        public string CTR_DEBITO_CXC1 { get => CTR_DEBITO_CXC; set => CTR_DEBITO_CXC = value; }
        public string CTA_DEBITO_CXC1 { get => CTA_DEBITO_CXC; set => CTA_DEBITO_CXC = value; }
        public string CTR_CREDITO_CXC1 { get => CTR_CREDITO_CXC; set => CTR_CREDITO_CXC = value; }
        public string CTA_CREDITO_CXC1 { get => CTA_CREDITO_CXC; set => CTA_CREDITO_CXC = value; }
        public string CTR_IMPUESTO1_CXC1 { get => CTR_IMPUESTO1_CXC; set => CTR_IMPUESTO1_CXC = value; }
        public string CTA_IMPUESTO1_CXC1 { get => CTA_IMPUESTO1_CXC; set => CTA_IMPUESTO1_CXC = value; }
        public string CTR_IMPUESTO2_CXC1 { get => CTR_IMPUESTO2_CXC; set => CTR_IMPUESTO2_CXC = value; }
        public string CTA_IMPUESTO2_CXC1 { get => CTA_IMPUESTO2_CXC; set => CTA_IMPUESTO2_CXC = value; }
        public string CTR_RUBRO1_CXC1 { get => CTR_RUBRO1_CXC; set => CTR_RUBRO1_CXC = value; }
        public string CTA_RUBRO1_CXC1 { get => CTA_RUBRO1_CXC; set => CTA_RUBRO1_CXC = value; }
        public string CTR_RUBRO2_CXC1 { get => CTR_RUBRO2_CXC; set => CTR_RUBRO2_CXC = value; }
        public string CTA_RUBRO2_CXC1 { get => CTA_RUBRO2_CXC; set => CTA_RUBRO2_CXC = value; }
        public string CTR_ANTICIPO_CXC1 { get => CTR_ANTICIPO_CXC; set => CTR_ANTICIPO_CXC = value; }
        public string CTA_ANTICIPO_CXC1 { get => CTA_ANTICIPO_CXC; set => CTA_ANTICIPO_CXC = value; }
        public string CTR_LXP1 { get => CTR_LXP; set => CTR_LXP = value; }
        public string CTA_LXP1 { get => CTA_LXP; set => CTA_LXP = value; }
        public string CTR_CREDITO_CXP1 { get => CTR_CREDITO_CXP; set => CTR_CREDITO_CXP = value; }
        public string CTA_CREDITO_CXP1 { get => CTA_CREDITO_CXP; set => CTA_CREDITO_CXP = value; }
        public string CTR_DEBITO_CXP1 { get => CTR_DEBITO_CXP; set => CTR_DEBITO_CXP = value; }
        public string CTA_DEBITO_CXP1 { get => CTA_DEBITO_CXP; set => CTA_DEBITO_CXP = value; }
        public string CTR_CXP1 { get => CTR_CXP; set => CTR_CXP = value; }
        public string CTA_CXP1 { get => CTA_CXP; set => CTA_CXP = value; }
        public string CTR_PRONTO_PAG_CXP1 { get => CTR_PRONTO_PAG_CXP; set => CTR_PRONTO_PAG_CXP = value; }
        public string CTA_PRONTO_PAG_CXP1 { get => CTA_PRONTO_PAG_CXP; set => CTA_PRONTO_PAG_CXP = value; }
        public string CTR_COMISION_CXP1 { get => CTR_COMISION_CXP; set => CTR_COMISION_CXP = value; }
        public string CTA_COMISION_CXP1 { get => CTA_COMISION_CXP; set => CTA_COMISION_CXP = value; }
        public string CTR_IMPUESTO1_CXP1 { get => CTR_IMPUESTO1_CXP; set => CTR_IMPUESTO1_CXP = value; }
        public string CTA_IMPUESTO1_CXP1 { get => CTA_IMPUESTO1_CXP; set => CTA_IMPUESTO1_CXP = value; }
        public string CTR_IMPUESTO2_CXP1 { get => CTR_IMPUESTO2_CXP; set => CTR_IMPUESTO2_CXP = value; }
        public string CTA_IMPUESTO2_CXP1 { get => CTA_IMPUESTO2_CXP; set => CTA_IMPUESTO2_CXP = value; }
        public string CTR_RUBRO1_CXP1 { get => CTR_RUBRO1_CXP; set => CTR_RUBRO1_CXP = value; }
        public string CTA_RUBRO1_CXP1 { get => CTA_RUBRO1_CXP; set => CTA_RUBRO1_CXP = value; }
        public string CTR_RUBRO2_CXP1 { get => CTR_RUBRO2_CXP; set => CTR_RUBRO2_CXP = value; }
        public string CTA_RUBRO2_CXP1 { get => CTA_RUBRO2_CXP; set => CTA_RUBRO2_CXP = value; }
        public string CTR_ANTICIPO_CXP1 { get => CTR_ANTICIPO_CXP; set => CTR_ANTICIPO_CXP = value; }
        public string CTA_ANTICIPO_CXP1 { get => CTA_ANTICIPO_CXP; set => CTA_ANTICIPO_CXP = value; }
        public string CTR_DESC_BONIF1 { get => CTR_DESC_BONIF; set => CTR_DESC_BONIF = value; }
        public string CTA_DESC_BONIF1 { get => CTA_DESC_BONIF; set => CTA_DESC_BONIF = value; }
        public string CTR_DEV_VENTAS1 { get => CTR_DEV_VENTAS; set => CTR_DEV_VENTAS = value; }
        public string CTA_DEV_VENTAS1 { get => CTA_DEV_VENTAS; set => CTA_DEV_VENTAS = value; }
        public string CTR_INT_CORRIENTE1 { get => CTR_INT_CORRIENTE; set => CTR_INT_CORRIENTE = value; }
        public string CTA_INT_CORRIENTE1 { get => CTA_INT_CORRIENTE; set => CTA_INT_CORRIENTE = value; }
        [Required]
        public string CODIGO_ISO1 { get => CODIGO_ISO; set => CODIGO_ISO = value; }
        public string ETIQUETA_DIV_GEO11 { get => ETIQUETA_DIV_GEO1; set => ETIQUETA_DIV_GEO1 = value; }
        public string ETIQUETA_DIV_GEO21 { get => ETIQUETA_DIV_GEO2; set => ETIQUETA_DIV_GEO2 = value; }
        public string MONEDA1 { get => MONEDA; set => MONEDA = value; }
        public string CTR_VENTAS_EXEN1 { get => CTR_VENTAS_EXEN; set => CTR_VENTAS_EXEN = value; }
        public string CTA_VENTAS_EXEN1 { get => CTA_VENTAS_EXEN; set => CTA_VENTAS_EXEN = value; }
        public string CTR_AJUSTE_REDONDEO1 { get => CTR_AJUSTE_REDONDEO; set => CTR_AJUSTE_REDONDEO = value; }
        public string CTA_AJUSTE_REDONDEO1 { get => CTA_AJUSTE_REDONDEO; set => CTA_AJUSTE_REDONDEO = value; }
        public string ETIQUETA_DIV_GEO31 { get => ETIQUETA_DIV_GEO3; set => ETIQUETA_DIV_GEO3 = value; }
        public string ETIQUETA_DIV_GEO41 { get => ETIQUETA_DIV_GEO4; set => ETIQUETA_DIV_GEO4 = value; }
        public string U_PAIS1 { get => U_PAIS; set => U_PAIS = value; }
        public DateTime RecordDate1 { get => RecordDate; set => RecordDate = value; }
        public string CreatedBy1 { get => CreatedBy; set => CreatedBy = value; }
        public string UpdatedBy1 { get => UpdatedBy; set => UpdatedBy = value; }
        public DateTime CreateDate1 { get => CreateDate; set => CreateDate = value; }


        public PaisModel()
        {
            paisRepository = new PaisRepository();
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var paisModel = new Pais();
                paisModel.PAIS = PAIS1;
                paisModel.CONJUNTO = CONJUNTO1;
                paisModel.DIRECCION = DIRECCION1;
                paisModel.NOMBRE = NOMBRE1;
                paisModel.CTR_VENTAS = CTR_VENTAS1;
                paisModel.CTA_VENTAS = CTA_VENTAS1;
                paisModel.CTR_DESC_GRAL = CTR_DESC_GRAL1;
                paisModel.CTA_DESC_GRAL = CTA_DESC_GRAL1;
                paisModel.CTR_COST_VENT = CTR_COST_VENT1;
                paisModel.CTA_COST_VENT = CTA_COST_VENT1;
                paisModel.CTR_DESC_LIN = CTR_DESC_LIN1;
                paisModel.CTA_DESC_LIN = CTA_DESC_LIN1;
                paisModel.CTR_COST_LIN = CTR_COST_LIN1;
                paisModel.CTA_COST_LIN = CTA_COST_LIN1;
                paisModel.CTR_GAST_COM = CTR_GAST_COM1;
                paisModel.CTA_GAST_COM = CTA_GAST_COM1;
                paisModel.CTR_CONTADO = CTR_CONTADO1;
                paisModel.CTA_CONTADO = CTA_CONTADO1;
                paisModel.CTR_CXC = CTR_CXC1;
                paisModel.CTA_CXC = CTA_CXC1;
                paisModel.CTR_LXC = CTR_LXC1;
                paisModel.CTA_LXC = CTA_LXC1;
                paisModel.CTR_PRONTO_PAG_CXC = CTR_PRONTO_PAG_CXC1;
                paisModel.CTA_PRONTO_PAG_CXC = CTA_PRONTO_PAG_CXC1;
                paisModel.CTR_INT_MORA_CXC = CTR_INT_MORA_CXC1;
                paisModel.CTA_INT_MORA_CXC = CTA_INT_MORA_CXC1;
                paisModel.CTR_RECIBOS_CXC = CTR_RECIBOS_CXC1;
                paisModel.CTA_RECIBOS_CXC = CTA_RECIBOS_CXC1;
                paisModel.CTR_DEBITO_CXC = CTR_DEBITO_CXC1;
                paisModel.CTA_DEBITO_CXC = CTA_DEBITO_CXC1;
                paisModel.CTR_CREDITO_CXC = CTR_CREDITO_CXC1;
                paisModel.CTA_CREDITO_CXC = CTA_CREDITO_CXC1;
                paisModel.CTR_IMPUESTO1_CXC = CTR_IMPUESTO1_CXC1;
                paisModel.CTA_IMPUESTO1_CXC = CTA_IMPUESTO1_CXC1;
                paisModel.CTR_IMPUESTO2_CXC = CTR_IMPUESTO2_CXC1;
                paisModel.CTA_IMPUESTO2_CXC = CTA_IMPUESTO2_CXC1;
                paisModel.CTR_RUBRO1_CXC = CTR_RUBRO1_CXC1;
                paisModel.CTA_RUBRO1_CXC = CTA_RUBRO1_CXC1;
                paisModel.CTR_RUBRO2_CXC = CTR_RUBRO2_CXC1;
                paisModel.CTA_RUBRO2_CXC = CTA_RUBRO2_CXC1;
                paisModel.CTR_ANTICIPO_CXC = CTR_ANTICIPO_CXC1;
                paisModel.CTA_ANTICIPO_CXC = CTA_ANTICIPO_CXC1;
                paisModel.CTR_LXP = CTR_LXP1;
                paisModel.CTA_LXP = CTA_LXP1;
                paisModel.CTR_CREDITO_CXP = CTR_CREDITO_CXP1;
                paisModel.CTA_CREDITO_CXP = CTA_CREDITO_CXP1;
                paisModel.CTR_DEBITO_CXP = CTR_DEBITO_CXP1;
                paisModel.CTA_DEBITO_CXP = CTA_DEBITO_CXP1;
                paisModel.CTR_CXP = CTR_CXP1;
                paisModel.CTA_CXP = CTA_CXP1;
                paisModel.CTR_PRONTO_PAG_CXP = CTR_PRONTO_PAG_CXP1;
                paisModel.CTA_PRONTO_PAG_CXP = CTA_PRONTO_PAG_CXP1;
                paisModel.CTR_COMISION_CXP = CTR_COMISION_CXP1;
                paisModel.CTA_COMISION_CXP = CTA_COMISION_CXP1;
                paisModel.CTR_IMPUESTO1_CXP = CTR_IMPUESTO1_CXP1;
                paisModel.CTA_IMPUESTO1_CXP = CTA_IMPUESTO1_CXP1;
                paisModel.CTR_IMPUESTO2_CXP = CTR_IMPUESTO2_CXP1;
                paisModel.CTA_IMPUESTO2_CXP = CTA_IMPUESTO2_CXP1;
                paisModel.CTR_RUBRO1_CXP = CTR_RUBRO1_CXP1;
                paisModel.CTA_RUBRO1_CXP = CTA_RUBRO1_CXP1;
                paisModel.CTR_RUBRO2_CXP = CTR_RUBRO2_CXP1;
                paisModel.CTA_RUBRO2_CXP = CTA_RUBRO2_CXP1;
                paisModel.CTR_ANTICIPO_CXP = CTR_ANTICIPO_CXP1;
                paisModel.CTA_ANTICIPO_CXP = CTA_ANTICIPO_CXP1;
                paisModel.CTR_DESC_BONIF = CTR_DESC_BONIF1;
                paisModel.CTA_DESC_BONIF = CTA_DESC_BONIF1;
                paisModel.CTR_DEV_VENTAS = CTR_DEV_VENTAS1;
                paisModel.CTA_DEV_VENTAS = CTA_DEV_VENTAS1;
                paisModel.CTR_INT_CORRIENTE = CTR_INT_CORRIENTE1;
                paisModel.CTA_INT_CORRIENTE = CTA_INT_CORRIENTE1;
                paisModel.CODIGO_ISO = CODIGO_ISO1;
                paisModel.ETIQUETA_DIV_GEO1 = ETIQUETA_DIV_GEO11;
                paisModel.ETIQUETA_DIV_GEO2 = ETIQUETA_DIV_GEO21;
                paisModel.MONEDA = MONEDA1;
                paisModel.CTR_VENTAS_EXEN = CTR_VENTAS_EXEN1;
                paisModel.CTA_VENTAS_EXEN = CTA_VENTAS_EXEN1;
                paisModel.CTR_AJUSTE_REDONDEO = CTR_AJUSTE_REDONDEO1;
                paisModel.CTA_AJUSTE_REDONDEO = CTA_AJUSTE_REDONDEO1;
                paisModel.ETIQUETA_DIV_GEO3 = ETIQUETA_DIV_GEO31;
                paisModel.ETIQUETA_DIV_GEO4 = ETIQUETA_DIV_GEO41;
                paisModel.U_PAIS = U_PAIS1;
                paisModel.RecordDate = RecordDate1;
                paisModel.CreatedBy = CreatedBy1;
                paisModel.UpdatedBy = UpdatedBy1;
                paisModel.CreateDate = CreateDate1;

                switch (State)
                {
                    case EntityState.Added:
                        // Ejecutar reglas comerciales /Calculos
                        paisRepository.Add(paisModel);
                        message = "Pais Agregado";
                        break;
                    case EntityState.Deleted:
                        paisRepository.Remove2(PAIS1, CONJUNTO1);
                        message = "Pais Eliminado";
                        break;
                    case EntityState.Modified:
                        paisRepository.Edit(paisModel);
                        message = "Pais Editado";
                        break;

                    default:
                        break;
                }

            }
            catch (Exception ex)
            {

                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
                {
                    message = "Registro Ya Existe";
                }
                else
                {
                    message = ex.ToString();
                }
            }
            return message;
        }


        public List<PaisModel> GetAll()
        {
            var paisDataModel = paisRepository.GetAll();
            var listPais = new List<PaisModel>();
            foreach (Pais item in paisDataModel)
            {
                listPais.Add(new PaisModel
                {
                    PAIS1 = item.PAIS,
                    CONJUNTO1 = item.CONJUNTO,
                    DIRECCION1 = item.DIRECCION,
                    NOMBRE1 = item.NOMBRE,
                    CTR_VENTAS1 = item.CTR_VENTAS,
                    CTA_VENTAS1 = item.CTA_VENTAS,
                    CTR_DESC_GRAL1 = item.CTR_DESC_GRAL,
                    CTA_DESC_GRAL1 = item.CTA_DESC_GRAL,
                    CTR_COST_VENT1 = item.CTR_COST_VENT,
                    CTA_COST_VENT1 = item.CTA_COST_VENT,
                    CTR_DESC_LIN1 = item.CTR_DESC_LIN,
                    CTA_DESC_LIN1 = item.CTA_DESC_LIN,
                    CTR_COST_LIN1 = item.CTR_COST_LIN,
                    CTA_COST_LIN1 = item.CTA_COST_LIN,
                    CTR_GAST_COM1 = item.CTR_GAST_COM,
                    CTA_GAST_COM1 = item.CTA_GAST_COM,
                    CTR_CONTADO1 = item.CTR_CONTADO,
                    CTA_CONTADO1 = item.CTA_CONTADO,
                    CTR_CXC1 = item.CTR_CXC,
                    CTA_CXC1 = item.CTA_CXC,
                    CTR_LXC1 = item.CTR_LXC,
                    CTA_LXC1 = item.CTA_LXC,
                    CTR_PRONTO_PAG_CXC1 = item.CTR_PRONTO_PAG_CXC,
                    CTA_PRONTO_PAG_CXC1 = item.CTA_PRONTO_PAG_CXC,
                    CTR_INT_MORA_CXC1 = item.CTR_INT_MORA_CXC,
                    CTA_INT_MORA_CXC1 = item.CTA_INT_MORA_CXC,
                    CTR_RECIBOS_CXC1 = item.CTR_RECIBOS_CXC,
                    CTA_RECIBOS_CXC1 = item.CTA_RECIBOS_CXC,
                    CTR_DEBITO_CXC1 = item.CTR_DEBITO_CXC,
                    CTA_DEBITO_CXC1 = item.CTA_DEBITO_CXC,
                    CTR_CREDITO_CXC1 = item.CTR_CREDITO_CXC,
                    CTA_CREDITO_CXC1 = item.CTA_CREDITO_CXC,
                    CTR_IMPUESTO1_CXC1 = item.CTR_IMPUESTO1_CXC,
                    CTA_IMPUESTO1_CXC1 = item.CTA_IMPUESTO1_CXC,
                    CTR_IMPUESTO2_CXC1 = item.CTR_IMPUESTO2_CXC,
                    CTA_IMPUESTO2_CXC1 = item.CTA_IMPUESTO2_CXC,
                    CTR_RUBRO1_CXC1 = item.CTR_RUBRO1_CXC,
                    CTA_RUBRO1_CXC1 = item.CTA_RUBRO1_CXC,
                    CTR_RUBRO2_CXC1 = item.CTR_RUBRO2_CXC,
                    CTA_RUBRO2_CXC1 = item.CTA_RUBRO2_CXC,
                    CTR_ANTICIPO_CXC1 = item.CTR_ANTICIPO_CXC,
                    CTA_ANTICIPO_CXC1 = item.CTA_ANTICIPO_CXC,
                    CTR_LXP1 = item.CTR_LXP,
                    CTA_LXP1 = item.CTA_LXP,
                    CTR_CREDITO_CXP1 = item.CTR_CREDITO_CXP,
                    CTA_CREDITO_CXP1 = item.CTA_CREDITO_CXP,
                    CTR_DEBITO_CXP1 = item.CTR_DEBITO_CXP,
                    CTA_DEBITO_CXP1 = item.CTA_DEBITO_CXP,
                    CTR_CXP1 = item.CTR_CXP,
                    CTA_CXP1 = item.CTA_CXP,
                    CTR_PRONTO_PAG_CXP1 = item.CTR_PRONTO_PAG_CXP,
                    CTA_PRONTO_PAG_CXP1 = item.CTA_PRONTO_PAG_CXP,
                    CTR_COMISION_CXP1 = item.CTR_COMISION_CXP,
                    CTA_COMISION_CXP1 = item.CTA_COMISION_CXP,
                    CTR_IMPUESTO1_CXP1 = item.CTR_IMPUESTO1_CXP,
                    CTA_IMPUESTO1_CXP1 = item.CTA_IMPUESTO1_CXP,
                    CTR_IMPUESTO2_CXP1 = item.CTR_IMPUESTO2_CXP,
                    CTA_IMPUESTO2_CXP1 = item.CTA_IMPUESTO2_CXP,
                    CTR_RUBRO1_CXP1 = item.CTR_RUBRO1_CXP,
                    CTA_RUBRO1_CXP1 = item.CTA_RUBRO1_CXP,
                    CTR_RUBRO2_CXP1 = item.CTR_RUBRO2_CXP,
                    CTA_RUBRO2_CXP1 = item.CTA_RUBRO2_CXP,
                    CTR_ANTICIPO_CXP1 = item.CTR_ANTICIPO_CXP,
                    CTA_ANTICIPO_CXP1 = item.CTA_ANTICIPO_CXP,
                    CTR_DESC_BONIF1 = item.CTR_DESC_BONIF,
                    CTA_DESC_BONIF1 = item.CTA_DESC_BONIF,
                    CTR_DEV_VENTAS1 = item.CTR_DEV_VENTAS,
                    CTA_DEV_VENTAS1 = item.CTA_DEV_VENTAS,
                    CTR_INT_CORRIENTE1 = item.CTR_INT_CORRIENTE,
                    CTA_INT_CORRIENTE1 = item.CTA_INT_CORRIENTE,
                    CODIGO_ISO1 = item.CODIGO_ISO,
                    ETIQUETA_DIV_GEO11 = item.ETIQUETA_DIV_GEO1,
                    ETIQUETA_DIV_GEO21 = item.ETIQUETA_DIV_GEO2,
                    MONEDA1 = item.MONEDA,
                    CTR_VENTAS_EXEN1 = item.CTR_VENTAS_EXEN,
                    CTA_VENTAS_EXEN1 = item.CTA_VENTAS_EXEN,
                    CTR_AJUSTE_REDONDEO1 = item.CTR_AJUSTE_REDONDEO,
                    CTA_AJUSTE_REDONDEO1 = item.CTA_AJUSTE_REDONDEO,
                    ETIQUETA_DIV_GEO31 = item.ETIQUETA_DIV_GEO3,
                    ETIQUETA_DIV_GEO41 = item.ETIQUETA_DIV_GEO4,
                    U_PAIS1 = item.U_PAIS,
                    RecordDate1 = item.RecordDate,
                    CreatedBy1 = item.CreatedBy,
                    UpdatedBy1 = item.UpdatedBy,
                    CreateDate1 = item.CreateDate,

                });
            }
            return listPais;
        }

        public IEnumerable<PaisModel> PaisConjunto(string filter1)
        {
            return GetAll().FindAll(e => e.CONJUNTO.Equals(filter1));
        }
        public IEnumerable<PaisModel> BuscarPais(string PAIS, string CONJUNTO)
        {
            return GetAll().FindAll(e => e.PAIS.Equals(PAIS) && e.CONJUNTO.Equals(CONJUNTO));
        }

       




        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
