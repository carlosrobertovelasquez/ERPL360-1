using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logistika360.ERP.ERPADMIN.Common.Cache;
using Logistika360.ERP.AS.Domain.Models;
using Logistika360.ERP.AS.Domain.ValueObjects;

namespace Logistika360.ERP.AS.Presentacion.Forms
{
    public partial class SISGLOBALES  :FormsPlantillas.FormPlantillaGridSmall
    {
        private ConjuntoModel conjunto = new ConjuntoModel();
        private string refrescar = "N";

        public SISGLOBALES()
        {
            InitializeComponent();
        }

        public override void Refrescar()
        {
            refrescar = "S";
            Cargargrid();
        }

        public override void Borrar()
        {
            const string message = "Compañias No se pueden Borrar";
            const string caption = "Eliminar Compañias";
            var resultM = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public override void Cargargrid()
        {

            if (refrescar == "N")
            {
                //Agregamos Columnas
                dgvDatos.Columns.Add("Columna1", "Compañia");
                dgvDatos.Columns.Add("Columna2", "Nombre");
                dgvDatos.Columns.Add("Columna3", "Dirección");
                dgvDatos.Columns.Add("Columna4", "Dirección Postal");
                dgvDatos.Columns.Add("Columna5", "Pais");
                
            }


            try
            {

                dgvDatos.Rows.Clear();
                DataGridViewRow dgvConjunto = new DataGridViewRow();
                dgvConjunto.CreateCells(dgvDatos);
                var LConjunto = conjunto.GetAll();
                


                foreach (var item in LConjunto)
                {
                    
                    dgvDatos.Rows.Add(item.CONJUNTO1, item.NOMBRE1, item.DIREC11,item.DIREC21,item.PAIS1);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void SISGLOBALES_Load(object sender, EventArgs e)
        {
            this.Text = UserLoginCache.CONJUNTO + " " + "Compañias";
            Cargargrid();
        }

        public override void Nuevo()
        {
            //Logramos que no se abra mas de una vez el formulario          
            if (Application.OpenForms["FmantemiminetoConjunto"] != null)
            {
                Application.OpenForms["FmantemiminetoConjunto"].Activate();
            }
            else
            {
                FmantenimientoConjunto fr = new FmantenimientoConjunto();
                fr.txtCompania.Text = "";
                fr.txtNombreCompania.Text = "";
                
                fr.Show();
            }
        }
        public override void Editar()
        {

            if (dgvDatos.SelectedRows.Count > 0)
            {
                //Logramos que no se abra mas de una vez el formulario          
                if (Application.OpenForms["FmantemiminetoVendedor"] != null)
                {
                    Application.OpenForms["FmantemiminetoVendedor"].Activate();
                }
                else
                {
                    FmantenimientoConjunto fr = new FmantenimientoConjunto();

                    fr.txtCompania.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    fr.txtCompania.Enabled = false;

                    ConjuntoModel conjunto = new ConjuntoModel();

                    var codigoconjunto = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    var buscar = conjunto.BuscarConjunto(codigoconjunto);
                    

                    foreach (var item in buscar)
                    {
                        fr.txtNombreCompania.Text = item.NOMBRE1.ToString();
                        fr.txtCalle.Text = item.DIREC11.ToString();
                        fr.txtMunicipio.Text = item.DIREC21.ToString();
                        fr.txtTelefono.Text = item.TELEFONO1.ToString();
                        //fr.pbLogo.
                        fr.txtEstado.Text = item.DIREC31.ToString();
                        fr.txtCodigoPostal.Text = item.COD_POSTAL1.ToString();
                        fr.txtPais.Text = item.PAIS1.ToString();
                        fr.txtRegimen.Text = item.REGIMEN_FISCAL1.ToString();
                        fr.txtTelefono.Text = item.TELEFONO1.ToString();
                        fr.txtNit.Text = item.NIT1.ToString();
                        fr.txtIdioma.Text = item.IDIOMA1.ToString();
                        fr.txtNueroRegistro.Text = item.NUMERO_REGISTRO1.ToString();
                        fr.txtUbicacionGeografica.Text = item.UBICACION1.ToString();
                        if (item.DOBLE_MONEDA1=="S")
                        {
                            fr.chbDobleMoneda.Checked = true;
                        }
                        else
                        {
                            fr.chbDobleMoneda.Checked = false;
                        }

                        if (item.DOBLE_CONTABILIDAD1=="S")
                        {
                            fr.chbDobleCierreContable.Checked = true;
                        }
                        else
                        {
                            fr.chbDobleCierreContable.Checked = false;
                        }
                        if (item.USAR_CENTROS_COSTO1=="S")
                        {
                            fr.chbCentroCosto.Checked = true;
                        }
                        else
                        {
                            fr.chbCentroCosto.Checked = false;
                        }
                        if (item.USA_UNIDADES1=="S")
                        {
                            fr.chbContabilizarUnidades.Checked = true;
                        }
                        else
                        {
                            fr.chbContabilizarUnidades.Checked = false;
                        }

                        if (item.INVENTARIO_DOLAR1=="S")
                        {
                            fr.chbInventarioDolares.Checked = true;
                        }
                        else
                        {
                            fr.chbInventarioDolares.Checked =false;
                        }

                        if (item.USA_LOTES1=="S")
                        {
                            fr.chbControlLotes.Checked = true;
                        }
                        else
                        {
                            fr.chbControlLotes.Checked = false;
                        }
                        if (item.USA_SUCURSAL1=="S")
                        {
                            fr.chbUsaSucursal.Checked = true;
                        }
                        else
                        {
                            fr.chbUsaSucursal.Checked = false;
                        }

                        fr.txtMascaraSucursal.Text = item.MASCARA_SUCURSAL1;
                        fr.txtUnidadOmision.Text = item.UNIDAD_OMISION1;
                        if (item.CONSOLIDADORA1=="S")
                        {
                            fr.chbConsolida.Checked = true;
                        }
                        else
                        {
                            fr.chbConsolida.Checked = false;
                        }
                        fr.txtUsuarioCreacion.Text = item.CreatedBy1;
                        fr.txtFechaCreacion.Text =  item.CreateDate1.ToString();
                        fr.txtUsuarioUpdate.Text = item.UpdatedBy1;
                        fr.txtFechaUpdate.Text =  item.RecordDate1.ToString();
                        fr.txtNota.Text = item.NOTAS1;

              

                    }

                    fr.Show();
                }
            }
            else
            {
                MessageBox.Show("Requiere Selecionar un Usuario");
            }

        }
    }
}
