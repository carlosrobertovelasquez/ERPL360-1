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
    public partial class FmantenimientoConjunto : FormsPlantillas.FormPlantillaMantenimientoSmall
    {
        ConjuntoModel _conjuntomodelo = new ConjuntoModel();
        public FmantenimientoConjunto()
        {
            InitializeComponent();
        }

        public override void Guardar()
        {
            
            var numeroConjunto =_conjuntomodelo.BuscarConjunto(txtCompania.Text);

            var valor = numeroConjunto.Count();


            if (valor == 0)
            {
               

                //Procedemos a guardar
                _conjuntomodelo.State = EntityState.Added;
                _conjuntomodelo.CONJUNTO1 = txtCompania.Text;
                _conjuntomodelo.NOMBRE1 = txtNombreCompania.Text;
                _conjuntomodelo.DIREC11 = txtCalle.Text;
                _conjuntomodelo.DIREC21 = txtMunicipio.Text;
                _conjuntomodelo.TELEFONO1 = txtTelefono.Text;
                _conjuntomodelo.DOBLE_MONEDA1 = chbDobleMoneda.Checked ? "S" : "N";
                _conjuntomodelo.DOBLE_CONTABILIDAD1 = chbDobleCierreContable.Checked ? "S" : "N";
                _conjuntomodelo.USA_LOTES1 = chbControlLotes.Checked ? "S" : "N";
                _conjuntomodelo.USAR_CENTROS_COSTO1 = chbCentroCosto.Checked ? "S" : "N";
                _conjuntomodelo.CONSOLIDA1 = chbConsolida.Checked ? "S" : "N";
                _conjuntomodelo.CONSOLIDADORA1 =txtCompaniaConsolidadora.Text;
                _conjuntomodelo.BD_CIA_CONSOLIDAD1 = chbMismaBase.Checked ?"S": "N";
                _conjuntomodelo.CONTA_A_CONSOLID1 = txtCompaniaConsolidadora.Text;
                _conjuntomodelo.MISMO_CUADRO_CTB1 = chbMismoCuadreContable.Checked ? "S" : "N";
                _conjuntomodelo.USUARIO_MODIF_BD1 = UserLoginCache.USUARIO;
                _conjuntomodelo.FCH_HORA_MODIF_BD1 = DateTime.Now;
                _conjuntomodelo.NOTAS1 = txtNota.Text;
                _conjuntomodelo.USA_UNIDADES1 = chbContabilizarUnidades.Checked ? "S" : "N";
                _conjuntomodelo.UNIDAD_OMISION1 = txtUnidadOmision.Text;
                _conjuntomodelo.MONEDA_CONSOLIDA1 = rbNormal.Checked?"S":"N";
                _conjuntomodelo.VERSION_BD1 = "1.0";
                _conjuntomodelo.USUARIO_ULT_MOD1 = UserLoginCache.USUARIO;
                _conjuntomodelo.FCH_HORA_ULT_MOD1 = DateTime.Now;
                _conjuntomodelo.VERSION_INSTALAC1 = "1.0";
                _conjuntomodelo.NIT1 = txtNit.Text;
                _conjuntomodelo.PAIS1 = txtPais.Text;
                _conjuntomodelo.GLN1 = txtgln.Text;
                _conjuntomodelo.UBICACION1 = txtUbicacionGeografica.Text;
                _conjuntomodelo.IDIOMA1 = txtIdioma.Text;
                _conjuntomodelo.USA_SUCURSAL1 = chbUsaSucursal.Checked ? "S" : "N";
                _conjuntomodelo.MASCARA_SUCURSAL1 = txtMascaraSucursal.Text;
                _conjuntomodelo.DIRECCION_WEB11 = "w";
                _conjuntomodelo.DIRECCION_WEB21 = "w";
                _conjuntomodelo.NOMBRE_WEB11 = "VV";
                _conjuntomodelo.NOMBRE_WEB21 = "XX";
                _conjuntomodelo.DIRECCION_PAG_WEB1 = "xx";
                _conjuntomodelo.EMAIL_DOC_ELECTRONICO1 = "xx";
                _conjuntomodelo.PAIS_DIVISION1 = txtUbicacionGeografica.Text;
                _conjuntomodelo.DIVISION_GEOGRAFICA11 = "";
                _conjuntomodelo.DIVISION_GEOGRAFICA21 = " ";
                _conjuntomodelo.NUMERO_REGISTRO1 = txtNueroRegistro.Text;
                _conjuntomodelo.DIREC31 = txtEstado.Text;
                _conjuntomodelo.COD_POSTAL1 = txtCodigoPostal.Text;
                _conjuntomodelo.DIVISION_GEOGRAFICA31 = "";
                _conjuntomodelo.DIVISION_GEOGRAFICA41 = "";
                _conjuntomodelo.REGIMEN_FISCAL1 = txtRegimen.Text;
                _conjuntomodelo.INVENTARIO_DOLAR1 = chbInventarioDolares.Checked ? "S" : "N";
                _conjuntomodelo.CreatedBy1 = UserLoginCache.USUARIO;
                _conjuntomodelo.CreateDate1 = DateTime.Now;
                _conjuntomodelo.UpdatedBy1 = UserLoginCache.USUARIO;
                _conjuntomodelo.RecordDate1 = DateTime.Now;

                               

                bool valid = new Helps.DataValidation(_conjuntomodelo).Validate();
                if (valid == true)
                {
                    string result = _conjuntomodelo.SaveChanges();

                    MessageBox.Show(result);
                    _conjuntomodelo.SaveChanges();
                }




            }
            else
            {
                //Procedemos a editar                

                _conjuntomodelo.State = EntityState.Modified;
                _conjuntomodelo.CONJUNTO1 = txtCompania.Text;
                _conjuntomodelo.NOMBRE1 = txtNombreCompania.Text;
                _conjuntomodelo.DIREC11 = txtCalle.Text;
                _conjuntomodelo.DIREC21 = txtMunicipio.Text;
                _conjuntomodelo.TELEFONO1 = txtTelefono.Text;
                _conjuntomodelo.DOBLE_MONEDA1 = chbDobleMoneda.Checked ? "S" : "N";
                _conjuntomodelo.DOBLE_CONTABILIDAD1 = chbDobleCierreContable.Checked ? "S" : "N";
                _conjuntomodelo.USA_LOTES1 = chbControlLotes.Checked ? "S" : "N";
                _conjuntomodelo.USAR_CENTROS_COSTO1 = chbCentroCosto.Checked ? "S" : "N";
                _conjuntomodelo.CONSOLIDA1 = chbConsolida.Checked ? "S" : "N";
                _conjuntomodelo.CONSOLIDADORA1 = txtCompaniaConsolidadora.Text;
                _conjuntomodelo.BD_CIA_CONSOLIDAD1 = chbMismaBase.Checked ? "S" : "N";
                _conjuntomodelo.CONTA_A_CONSOLID1 = txtCompaniaConsolidadora.Text;
                _conjuntomodelo.MISMO_CUADRO_CTB1 = chbMismoCuadreContable.Checked ? "S" : "N";
                _conjuntomodelo.USUARIO_MODIF_BD1 = UserLoginCache.USUARIO;
                _conjuntomodelo.FCH_HORA_MODIF_BD1 = DateTime.Now;
                _conjuntomodelo.NOTAS1 = txtNota.Text;
                _conjuntomodelo.USA_UNIDADES1 = chbContabilizarUnidades.Checked ? "S" : "N";
                _conjuntomodelo.UNIDAD_OMISION1 = txtUnidadOmision.Text;
                _conjuntomodelo.MONEDA_CONSOLIDA1 = rbNormal.Checked ? "S" : "N"; 
                _conjuntomodelo.VERSION_BD1 = "1.0";
                _conjuntomodelo.USUARIO_ULT_MOD1 = UserLoginCache.USUARIO;
                _conjuntomodelo.FCH_HORA_ULT_MOD1 = DateTime.Now;
                _conjuntomodelo.VERSION_INSTALAC1 = "1.0";
                _conjuntomodelo.NIT1 = txtNit.Text;
                _conjuntomodelo.PAIS1 = txtPais.Text;
                _conjuntomodelo.GLN1 = txtgln.Text;
                _conjuntomodelo.UBICACION1 = txtUbicacionGeografica.Text;
                _conjuntomodelo.IDIOMA1 = txtIdioma.Text;
                _conjuntomodelo.USA_SUCURSAL1 = chbUsaSucursal.Checked ? "S" : "N";
                _conjuntomodelo.MASCARA_SUCURSAL1 = txtMascaraSucursal.Text;
                _conjuntomodelo.DIRECCION_WEB11 = "w";
                _conjuntomodelo.DIRECCION_WEB21 = "w";
                _conjuntomodelo.NOMBRE_WEB11 = "VV";
                _conjuntomodelo.NOMBRE_WEB21 = "XX";
                _conjuntomodelo.DIRECCION_PAG_WEB1 = "xx";
                _conjuntomodelo.EMAIL_DOC_ELECTRONICO1 = "xx";
                _conjuntomodelo.PAIS_DIVISION1 = txtUbicacionGeografica.Text;
                _conjuntomodelo.DIVISION_GEOGRAFICA11 = "";
                _conjuntomodelo.DIVISION_GEOGRAFICA21 = " ";
                _conjuntomodelo.NUMERO_REGISTRO1 = txtNueroRegistro.Text;
                _conjuntomodelo.DIREC31 = txtEstado.Text;
                _conjuntomodelo.COD_POSTAL1 = txtCodigoPostal.Text;
                _conjuntomodelo.DIVISION_GEOGRAFICA31 = "";
                _conjuntomodelo.DIVISION_GEOGRAFICA41 = "";
                _conjuntomodelo.REGIMEN_FISCAL1 = txtRegimen.Text;
                _conjuntomodelo.INVENTARIO_DOLAR1 = chbInventarioDolares.Checked ? "S" : "N";
                _conjuntomodelo.UpdatedBy1 = UserLoginCache.USUARIO;
                _conjuntomodelo.RecordDate1 = DateTime.Now;


                bool valid = new Helps.DataValidation(_conjuntomodelo).Validate();
                if (valid == true)
                {
                    _conjuntomodelo.SaveChanges();
                    string result = _conjuntomodelo.SaveChanges();
                    MessageBox.Show(result);


                }

               // Vendedores fvendedores = new Vendedores();
                //Pentiente regresar datagrid
                //fvendedores.Cargargrid();


            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtRegimen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCompania_TextChanged(object sender, EventArgs e)
        {
            txtCompania.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtCompania_Validated(object sender, EventArgs e)
        {
             ConjuntoModel _conjunto = new ConjuntoModel();
            var existeConjunto = _conjuntomodelo.BuscarConjunto(txtCompania.Text);
            var valor = existeConjunto.Count();

            if (valor == 1)
            {
                const string message = "Compañia ya Existe";
                const string caption = "Validar Compañia";
                var resultM = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompania.Focus();

            }
        }

        private void txtNombreCompania_TextChanged(object sender, EventArgs e)
        {
            txtNombreCompania.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
