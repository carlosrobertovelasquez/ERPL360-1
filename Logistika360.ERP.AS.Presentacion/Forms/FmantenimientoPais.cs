using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logistika360.ERP.AS.Domain.Models;
using Logistika360.ERP.AS.Domain.ValueObjects;
using Logistika360.ERP.ERPADMIN.Common.Cache;

namespace Logistika360.ERP.AS.Presentacion.Forms
{
    public partial class FmantenimientoPais : FormsPlantillas.FormPlantillaMantenimientoSmall
    {
        PaisModel oPaismodelo = new PaisModel();
        public FmantenimientoPais()
        {
            InitializeComponent();
        }


        public override void Guardar()
        {
            var numeroPais = oPaismodelo.BuscarPais(txtPais.Text, UserLoginCache.CONJUNTO);

            var valor = numeroPais.Count();


            if (valor == 0)
            {
                oPaismodelo.State = EntityState.Added;
                oPaismodelo.PAIS1 = txtPais.Text;
                oPaismodelo.CONJUNTO1 = UserLoginCache.CONJUNTO;
                oPaismodelo.NOMBRE1 = txtDescripcion.Text;
                //Tab de Ventas
                oPaismodelo.CTR_VENTAS1 = txtFaVentasCentroCosto.Text;
                oPaismodelo.CTA_VENTAS1 = txtFaVentasCuenta.Text;
                oPaismodelo.CTR_VENTAS_EXEN1 = txtFaVentasExenCentroCosto.Text;
                oPaismodelo.CTA_VENTAS_EXEN1 = txtFaVentasExceCuenta.Text;
                oPaismodelo.CTR_DEV_VENTAS1 = txtFaDevSVCentroCosto.Text;
                oPaismodelo.CTA_DEV_VENTAS1 = txtFaDevSobreVentaCuenta.Text;
                oPaismodelo.CTA_DESC_GRAL1 = txtFaDescuentoGeCuenta.Text;
                oPaismodelo.CTR_DESC_GRAL1 = txtFaDescuentoGralCentroCosto.Text;
                oPaismodelo.CTA_COST_VENT1 = txtFaCostoVentaCuenta.Text;
                oPaismodelo.CTR_COST_VENT1 = txtFaCostoVentaCentroCosto.Text;
                oPaismodelo.CTA_DESC_LIN1 = txtFaDescuentoLineaCuenta.Text;
                oPaismodelo.CTR_DESC_LIN1 = txtFaDescuentoLineaCentroCosto.Text;
                oPaismodelo.CTR_COST_LIN1 = txtFaCostoLineaCentroCosto.Text;
                oPaismodelo.CTA_COST_LIN1 = txtFaCostoLineaCuenta.Text;
                oPaismodelo.CTR_CONTADO1 = txtFaPagoContadoCentroCosto.Text;
                oPaismodelo.CTA_CONTADO1 = txtFaPagoContadoCuenta.Text;
                oPaismodelo.CTR_GAST_COM1 = txtFaGatosComiCentroCosto.Text;
                oPaismodelo.CTA_GAST_COM1 = txtFaGastoComisionCuenta.Text;
                oPaismodelo.CTR_DESC_BONIF1 = txtFaDescBoniCentroCosto.Text;
                oPaismodelo.CTA_DESC_BONIF1 = txtFaDescuentoBoniCuenta.Text;
                oPaismodelo.CTR_AJUSTE_REDONDEO1 = txtFaAjusteRedondeoCentroCosto.Text;
                oPaismodelo.CTA_AJUSTE_REDONDEO1 = txtFaAjusteRedondeoCuenta.Text;


                //Tab de Cuentas por Cobrar
                oPaismodelo.CTR_CXC1 = txtCCCuentasporCentroCosto.Text;
                oPaismodelo.CTA_CXC1 = txtCCCuentasporCuentaCont.Text;
                oPaismodelo.CTR_LXC1 = txtCCLetraCambioCentroCosto.Text;
                oPaismodelo.CTR_LXC1 = txtCCLetraCambioCuentaConta.Text;
                oPaismodelo.CTR_PRONTO_PAG_CXC1 = txtCCProntoPagoCentroCosto.Text;
                oPaismodelo.CTA_PRONTO_PAG_CXC1 = txtCCProntoPagoConta.Text;
                oPaismodelo.CTR_INT_MORA_CXC1 = txtCCIntereMoraCentroCosto.Text;
                oPaismodelo.CTA_INT_MORA_CXC1 = txtCCInteresCorrienteConta.Text;
                oPaismodelo.CTR_RECIBOS_CXC1 = txtCCReciboCentroCosto.Text;
                oPaismodelo.CTA_RECIBOS_CXC1 = txtCCReciboConta.Text;
                oPaismodelo.CTR_VENTAS1 = txtCCVentaCentroCosto.Text;
                oPaismodelo.CTA_VENTAS1 = txtCCVentasConta.Text;
                oPaismodelo.CTR_RUBRO1_CXC1 = txtCCRentaCentroCosto.Text;
                oPaismodelo.CTA_RUBRO1_CXC1 = txtCCRentaConta.Text;
                oPaismodelo.CTR_ANTICIPO_CXC1 = txtCCAnticipoCentroCosto.Text;
                oPaismodelo.CTA_ANTICIPO_CXC1 = txtCCAnticipoConta.Text;
                oPaismodelo.CTR_DEBITO_CXC1 = txtCCCierreDebitoCentroCosto.Text;
                oPaismodelo.CTA_DEBITO_CXC1 = txtCCCierreDebitoConta.Text;
                oPaismodelo.CTR_CREDITO_CXC1 = txtCCCierreCreditoCentroCosto.Text;
                oPaismodelo.CTA_CREDITO_CXC1 = txtCCCierreCreditoConta.Text;
                oPaismodelo.CTR_INT_CORRIENTE1 = txtCCInteresCorrienteCentroCosto.Text;
                oPaismodelo.CTA_INT_CORRIENTE1 = txtCCInteresCorrienteConta.Text;
           
                
                //Tab de Cuentas por Pagar
                oPaismodelo.CTR_CXP1 = txtCPCuentaPorpagarCentroCosto.Text;
                oPaismodelo.CTA_CXP1 = txtCPCuentaPorPagarCuentaCont.Text;
                oPaismodelo.CTR_LXP1 = txtCPLetraxPagarCentroCosto.Text;
                oPaismodelo.CTA_LXP1 = txtCPLetraPagarCuentaCont.Text;
                oPaismodelo.CTR_PRONTO_PAG_CXP1 = txtCPProntoPagoCentroCosto.Text;
                oPaismodelo.CTA_PRONTO_PAG_CXP1 = txtCPProntoPagoCuentaCont.Text;
                oPaismodelo.CTR_COMISION_CXP1 = txtCPComisionesCentroCosto.Text;
                oPaismodelo.CTA_COMISION_CXP1 = txtCPComisionesCuentaCont.Text;
                oPaismodelo.CTR_IMPUESTO1_CXP1 = txtCPVentasCentroCosto.Text;
                oPaismodelo.CTA_IMPUESTO1_CXP1 = txtCPVentasCuentaConta.Text;
                oPaismodelo.CTR_IMPUESTO2_CXP1 = txtCPConumosCentroCosto.Text;
                oPaismodelo.CTA_IMPUESTO2_CXP1 = txtCPConsumoCuentaConta.Text;
                oPaismodelo.CTR_ANTICIPO_CXP1 = txtCPAnticiposCentroCosto.Text;
                oPaismodelo.CTA_ANTICIPO_CXP1 = txtCPAntticiposCuentaConta.Text;
                oPaismodelo.CTR_DEBITO_CXP1 = txtCPCierreDebitoCentroCosto.Text;
                oPaismodelo.CTA_DEBITO_CXP1 = txtCPCierreDebitoCuentaConta.Text;
                oPaismodelo.CTR_CREDITO_CXP1 = txtCPCierreCreditoCentroCosto.Text;
                oPaismodelo.CTA_CREDITO_CXP1 = txtCPCierreCreditoCuentaConta.Text;
                //Tab Otros
                oPaismodelo.U_PAIS1 = txtCodigoPais.Text;
                oPaismodelo.DIRECCION1 = txtDireccion.Text;


                oPaismodelo.CreatedBy1 = UserLoginCache.USUARIO;
                oPaismodelo.CreateDate1 = DateTime.Today;
                oPaismodelo.UpdatedBy1 = UserLoginCache.USUARIO;
                oPaismodelo.RecordDate1 = DateTime.Today;
                oPaismodelo.CONJUNTO1 = UserLoginCache.CONJUNTO;

                bool valid = new Helps.DataValidation(oPaismodelo).Validate();
                if (valid == true)
                {
                    string result = oPaismodelo.SaveChanges();

                    MessageBox.Show(result);
                    oPaismodelo.SaveChanges();
                }




            }
        }



            private void txtPais_TextChanged(object sender, EventArgs e)
        {
            txtPais.CharacterCasing = CharacterCasing.Upper;
        }



        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtPais_Validated(object sender, EventArgs e)
        {
            PaisModel oPais = new PaisModel();
            var existePais = oPais.BuscarPais(txtPais.Text,UserLoginCache.CONJUNTO);
            var valor = existePais.Count();

            if (valor == 1)
            {
                const string message = "Pais ya Existe";
                const string caption = "Validar Pais";
                var resultM = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPais.Focus();

            }
        }
    }
}
