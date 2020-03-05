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
                oPaismodelo.DIRECCION1 = txtDireccion.Text;
                oPaismodelo.NOMBRE1 = txtDescripcion.Text;
                oPaismodelo.CTR_VENTAS1 = txtFaVentasCentroCosto.Text;
                oPaismodelo.CTR_VENTAS1 = txtFaVentasCuenta.Text;
                oPaismodelo.CTA_DESC_GRAL1 = txtFaDescuentoGeCuenta.Text;
                oPaismodelo.CTR_DESC_GRAL1 = txtFaDescuentoGralCentroCosto.Text;
                oPaismodelo.CTA_COST_VENT1 = txtFaCostoVentaCuenta.Text;
                oPaismodelo.CTR_COST_VENT1 = txtFaCostoVentaCentroCosto.Text;
                oPaismodelo.CTA_DESC_LIN1 = txtFaDescuentoLineaCuenta.Text;
                oPaismodelo.CTR_DESC_LIN1 = txtFaDescuentoLineaCentroCosto.Text;
                oPaismodelo.CTR_COST_LIN1=txtFaCostoLineaCentroCosto.Text;
                oPaismodelo.CTA_COST_LIN1 = txtFaCostoLineaCuenta.Text;
                oPaismodelo.CTR_GAST_COM1 = txtFaGatosComiCentroCosto.Text;
                oPaismodelo.CTA_GAST_COM1 = txtFaGastoComisionCuenta.Text;
                oPaismodelo.CTR_CONTADO1 = txtFaPagoContadoCentroCosto.Text;
                oPaismodelo.CTA_CONTADO1 = txtFaPagoContadoCuenta.Text;
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
                oPaismodelo.CTR_DEBITO_CXC1 = txtCCCierreDebitoCentroCosto.Text;
                oPaismodelo.CTA_DEBITO_CXC1 = txtCCCierreDebitoConta.Text;
                oPaismodelo.CTR_CREDITO_CXC1 = txtCCCierreCreditoCentroCosto.Text;
                oPaismodelo.CTA_CREDITO_CXC1 = txtCCCierreCreditoConta.Text;

                


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
