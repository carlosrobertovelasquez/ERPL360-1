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
    public partial class Zona : FormsPlantillas.FormPlantillaGridSmall
    {

        private ZonaModel zona = new ZonaModel();
        private string refrescar = "N";

        public Zona()
        {
            InitializeComponent();
        }

        public override void Cargargrid()
        {

            if (refrescar == "N")
            {
                //Agregamos Columnas
                dgvDatos.Columns.Add("Columna1", "Zona");
                dgvDatos.Columns.Add("Columna2", "Nombre");
            }


            try
            {

                dgvDatos.Rows.Clear();
                DataGridViewRow dgvVendedor = new DataGridViewRow();
                dgvVendedor.CreateCells(dgvDatos);
                var LZona = zona.ZonaConjunto(UserLoginCache.CONJUNTO);



                foreach (var item in LZona)
                {


                    dgvDatos.Rows.Add(item.Zona1, item.Nombre1);
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
            if (Application.OpenForms["FmantenimientoZona"] != null)
            {
                Application.OpenForms["FmantenimientoZona"].Activate();
            }
            else
            {
                FmantenimientoZona fr = new FmantenimientoZona();
                fr.txtCodigo.Text = "";
                fr.txtNombre.Text = "";

                fr.Show();
            }
        }
        public override void Editar()
        {

            if (dgvDatos.SelectedRows.Count > 0)
            {
                //Logramos que no se abra mas de una vez el formulario          
                if (Application.OpenForms["FmantenimientoZona"] != null)
                {
                    Application.OpenForms["FmantenimientoZona"].Activate();
                }
                else
                {
                    FmantenimientoZona fr = new FmantenimientoZona();

                    fr.txtCodigo.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    fr.txtCodigo.Enabled = false;

                    RutaModel vendedor = new RutaModel();

                    var codigozona = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    var buscar = zona.BuscarZona(codigozona, UserLoginCache.CONJUNTO);

                    foreach (var item in buscar)
                    {
                        fr.txtCodigo.Text = item.Zona1.ToString();
                        fr.txtNombre.Text = item.Nombre1.ToString();


                    }

                    fr.Show();
                }
            }
            else
            {
                MessageBox.Show("Requiere Selecionar una Zona");
            }

        }
        public override void Refrescar()
        {
            refrescar = "S";
            Cargargrid();
        }
        public override void Borrar()
        {

            const string message = "Esta seguro de Borrar La Zona";
            const string caption = "Eliminar Zona";
            var resultM = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dgvDatos.SelectedRows.Count > 0)
            {


                if (resultM == DialogResult.Yes)
                {
                    ZonaModel zona = new ZonaModel();
                    zona.State = EntityState.Deleted;
                    zona.Zona1 = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    zona.Conjunto1 = UserLoginCache.CONJUNTO;
                    zona.SaveChanges();
                    string result = zona.SaveChanges();
                    MessageBox.Show(result);

                }
            }
            else
            {
                MessageBox.Show("Selecione una Zona");

            }
            Refrescar();

        }

        private void Zona_Load(object sender, EventArgs e)
        {
            this.Text = UserLoginCache.CONJUNTO + " " + "Zona";
            Cargargrid();
        }
    }
}
