using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logistika360.ERP.AS.Presentacion.FormsPlantillas;
using Logistika360.ERP.ERPADMIN.Common.Cache;
using Logistika360.ERP.AS.Domain.Models;
using Logistika360.ERP.AS.Domain.ValueObjects;
namespace Logistika360.ERP.AS.Presentacion.Tablas.Tipos.Moneda
{
    public partial class Moneda :  FormsPlantillas.FormPlantillaGridSmall
    {
        private MonedaModel moneda = new MonedaModel();
        private string refrescar = "N";
        public Moneda()
        {
            InitializeComponent();
        }

        private void Moneda_Load(object sender, EventArgs e)
        {
            this.Text = UserLoginCache.CONJUNTO + " " + "Moneda";
            Cargargrid();
        }
        public override void Cargargrid()
        {

            if (refrescar == "N")
            {
                //Agregamos Columnas
                dgvDatos.Columns.Add("Columna1", "Moneda");
                dgvDatos.Columns.Add("Columna2", "Nombre");
                
            }


            try
            {

                dgvDatos.Rows.Clear();
                DataGridViewRow dgvMoneda = new DataGridViewRow();
                dgvMoneda.CreateCells(dgvDatos);

                var LMoneda = moneda.MonedaConjunto();
                string activo;


                foreach (var item in LMoneda)
                {
                    

                    dgvDatos.Rows.Add(item.Moneda1, item.Nombre1);
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
            if (Application.OpenForms["FmantemiminetoMoneda"] != null)
            {
                Application.OpenForms["FmantemiminetoMoneda"].Activate();
            }
            else
            {
                FmantemiminetoMoneda fr = new FmantemiminetoMoneda();
                fr.txtMoneda.Text = "";
                fr.txtNombre.Text = "";
                fr.txtCodigoIso.Text = "";
                fr.Show();
            }
        }
        public override void Editar()
        {

            if (dgvDatos.SelectedRows.Count > 0)
            {
                //Logramos que no se abra mas de una vez el formulario          
                if (Application.OpenForms["FmantemiminetoMoneda"] != null)
                {
                    Application.OpenForms["FmantemiminetoMoneda"].Activate();
                }
                else
                {
                    FmantemiminetoMoneda fr = new FmantemiminetoMoneda();

                    fr.txtMoneda.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    fr.txtMoneda.Enabled = false;

                    MonedaModel moneda = new MonedaModel();

                    var codigomoneda = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    var buscar = moneda.BuscarMoneda(codigomoneda);

                    foreach (var item in buscar)
                    {
                        fr.txtMoneda.Text = item.Moneda1.ToString();
                        fr.txtNombre.Text = item.Nombre1.ToString();
                        fr.txtCodigoIso.Text = item.Codigo_iso1.ToString();
                        
                    }

                    fr.Show();
                }
            }
            else
            {
                MessageBox.Show("Requiere Selecionar un Cobrador");
            }


        }
        public override void Refrescar()
        {
            refrescar = "S";
            Cargargrid();
        }
        public override void Borrar()
        {

            const string message = "Esta seguro de Borrar la Moneda";
            const string caption = "Eliminar Moneda";
            var resultM = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dgvDatos.SelectedRows.Count > 0)
            {


                if (resultM == DialogResult.Yes)
                {
                    MonedaModel moneda = new MonedaModel();
                    moneda.State = EntityState.Deleted;
                    moneda.Moneda1 = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    moneda.SaveChanges();
                    string result = moneda.SaveChanges();
                    MessageBox.Show(result);

                }
            }
            else
            {
                MessageBox.Show("Selecione un Cobrador");

            }
            Refrescar();

        }

    }
}
