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
    public partial class CentroCosto : FormsPlantillas.FormPlantillaGridSmall
    {
        private CentroCostoModel centrocosto = new CentroCostoModel();
        private string refrescar = "N";

        public CentroCosto()
        {
            InitializeComponent();
        }

        private void CentroCosto_Load(object sender, EventArgs e)
        {
            this.Text = UserLoginCache.CONJUNTO + " " + "Centro Costos";
            Cargargrid();
        }
        public override void Cargargrid()
        {

            if (refrescar == "N")
            {
                //Agregamos Columnas
                dgvDatos.Columns.Add("Columna1", "Centro Costo");
                dgvDatos.Columns.Add("Columna2", "Descripcion");
                
            }


            try
            {

                dgvDatos.Rows.Clear();
                DataGridViewRow dgvCentroCosto = new DataGridViewRow();
                dgvCentroCosto.CreateCells(dgvDatos);
                var LCentroCosto = centrocosto.CentroCostoConjunto (UserLoginCache.CONJUNTO);



                foreach (var item in LCentroCosto)
                {


                    dgvDatos.Rows.Add(item.CentroCosto1, item.Descripcion1);
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
            if (Application.OpenForms["FmantenimientoCentroCosto"] != null)
            {
                Application.OpenForms["FmantenimientoCentroCosto"].Activate();
            }
            else
            {
                FmantenimientoCentroCosto fr = new FmantenimientoCentroCosto();
                //fr.txtCodigo.Text = "";
                //fr.txtNombre.Text = "";

                fr.Show();
            }
        }

        public override void Editar()
        {

            if (dgvDatos.SelectedRows.Count > 0)
            {
                //Logramos que no se abra mas de una vez el formulario          
                if (Application.OpenForms["FmantemiminetoCentroCosto"] != null)
                {
                    Application.OpenForms["FmantemiminetoCentroCosto"].Activate();
                }
                else
                {
                    FmantenimientoCentroCosto fr = new FmantenimientoCentroCosto();

                   // fr.txtCodigo.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                   // fr.txtCodigo.Enabled = false;

                    CentroCostoModel vendedor = new CentroCostoModel();

                    var codigocentrocosto = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    var buscar = centrocosto.BuscarCentroCosto(codigocentrocosto, UserLoginCache.CONJUNTO);

                    foreach (var item in buscar)
                    {
                     //   fr.txtCodigo.Text = item.CentroCosto1.ToString();
                      //  fr.txtNombre.Text = item.Descripcion1.ToString();


                    }

                    fr.Show();
                }
            }
            else
            {
                MessageBox.Show("Requiere Selecionar un Centro Costo" +
                    "");
            }

        }

        public override void Refrescar()
        {
            refrescar = "S";
            Cargargrid();
        }


        public override void Borrar()
        {

            const string message = "Esta seguro de Borrar El Centro Costo";
            const string caption = "Eliminar Centro Costo";
            var resultM = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dgvDatos.SelectedRows.Count > 0)
            {


                if (resultM == DialogResult.Yes)
                {
                    CentroCostoModel centrocosto = new CentroCostoModel();
                    centrocosto.State = EntityState.Deleted;
                    centrocosto.CentroCosto1 = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    centrocosto.Conjunto1 = UserLoginCache.CONJUNTO;
                    centrocosto.SaveChanges();
                    string result = centrocosto.SaveChanges();
                    MessageBox.Show(result);

                }
            }
            else
            {
                MessageBox.Show("Selecione un Centro Costo");

            }
            Refrescar();

        }
    }
}
