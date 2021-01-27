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


namespace Logistika360.ERP.AS.Presentacion.Tablas.Otros.Bodega
{
    
    public partial class Bodega : FormsPlantillas.FormPlantillaGridSmall
    {
        private BodegaModel bodega = new BodegaModel();
        private string refrescar = "N";
        public Bodega()
        {
            InitializeComponent();
        }

        private void Bodega_Load(object sender, EventArgs e)
        {
            this.Text = UserLoginCache.CONJUNTO + " " + "Bodega";
            Cargargrid();
        }

        public override void Cargargrid()
        {

            if (refrescar == "N")
            {
                //Agregamos Columnas
                dgvDatos.Columns.Add("Columna1", "Bodega");
                dgvDatos.Columns.Add("Columna2", "Nombre");
                
            }


            try
            {

                dgvDatos.Rows.Clear();
                DataGridViewRow dgvBodega = new DataGridViewRow();
                dgvBodega.CreateCells(dgvDatos);
                var LBodega = bodega.BodegaConjunto();
                
                foreach (var item in LBodega)
                {
                    

                    dgvDatos.Rows.Add(item.Bodega1, item.Nombre1);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public override void Nuevo()
        {
            //Logramos que no se abra mas de una vez el formulario          
            if (Application.OpenForms["FmantemiminetoBodega"] != null)
            {
                Application.OpenForms["FmantemiminetoBodega"].Activate();
            }
            else
            {
                FmanteniminetoBodega fr = new FmanteniminetoBodega();
                fr.txtCodigo.Text = "";
                fr.txtNombre.Text = "";
                fr.txtTelefono.Text = "";
                fr.txtConsecTraslados.Text = "";
                fr.txtDireccion.Text = "";
                fr.rdbConsumo.Checked = false;
                fr.rdbVentas.Checked = false;
                fr.rdbNodisponible.Checked = false;
                fr.Show();
            }
        }
        public override void Editar()
        {

            if (dgvDatos.SelectedRows.Count > 0)
            {
                //Logramos que no se abra mas de una vez el formulario          
                if (Application.OpenForms["FmantemiminetoBodega"] != null)
                {
                    Application.OpenForms["FmantemiminetoBodega"].Activate();
                }
                else
                {
                    FmanteniminetoBodega fr = new FmanteniminetoBodega();

                    fr.txtCodigo.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    fr.txtCodigo.Enabled = false;

                    BodegaModel bodega = new BodegaModel();

                    var codigobodega = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    var buscar = bodega.BuscarBodega(codigobodega);

                    foreach (var item in buscar)
                    {
                        fr.txtCodigo.Text = item.Bodega1.ToString();
                        fr.txtNombre.Text = item.Nombre1.ToString();
                        fr.txtTelefono.Text = item.Telefono1.ToString();
                        fr.txtConsecTraslados.Text = item.Consec_traslados1.ToString();
                        fr.txtDireccion.Text = item.Direccion1.ToString();
                        if (item.Tipo1 == "C")
                        {
                            fr.rdbConsumo.Checked = true;
                            fr.rdbNodisponible.Checked = false;
                            fr.rdbVentas.Checked = false;
                        }
                        if (item.Tipo1 == "V")
                        {
                            fr.rdbConsumo.Checked = false;
                            fr.rdbNodisponible.Checked = false;
                            fr.rdbVentas.Checked = true;
                        }
                        if (item.Tipo1 == "N")
                        {
                            fr.rdbConsumo.Checked = false;
                            fr.rdbNodisponible.Checked = true;
                            fr.rdbVentas.Checked = false;
                        }

                    }

                    fr.Show();
                }
            }
            else
            {
                MessageBox.Show("Requiere Selecionar un Usuario");
            }

        }
        public override void Refrescar()
        {
            refrescar = "S";
            Cargargrid();
        }
        public override void Borrar()
        {

            const string message = "Esta seguro de Borrar La Bodega";
            const string caption = "Eliminar Bodega";
            var resultM = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dgvDatos.SelectedRows.Count > 0)
            {


                if (resultM == DialogResult.Yes)
                {
                    BodegaModel bodega = new BodegaModel();
                    bodega.State = EntityState.Deleted;
                    bodega.Bodega1 = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    bodega.SaveChanges();
                    string result = bodega.SaveChanges();
                    MessageBox.Show(result);

                }
            }
            else
            {
                MessageBox.Show("Selecione una Bodega");

            }
            Refrescar();

        }
    }
}
