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
    public partial class Ruta : FormsPlantillas.FormPlantillaGridSmall
    {

        private RutaModel ruta = new RutaModel();
        private string refrescar = "N";


        public Ruta()
        {
            InitializeComponent();
        }

        private void Ruta_Load(object sender, EventArgs e)
        {
            this.Text = UserLoginCache.CONJUNTO + " " + "Rutas";
            Cargargrid();
        }
        public override void Cargargrid()
        {

            if (refrescar == "N")
            {
                //Agregamos Columnas
                dgvDatos.Columns.Add("Columna1", "Ruta");
                dgvDatos.Columns.Add("Columna2", "Nombre");
            }


            try
            {

                dgvDatos.Rows.Clear();
                DataGridViewRow dgvVendedor = new DataGridViewRow();
                dgvVendedor.CreateCells(dgvDatos);
                var LVendedor = ruta.RutaConjunto(UserLoginCache.CONJUNTO);
               


                foreach (var item in LVendedor)
                {
                   

                    dgvDatos.Rows.Add(item.Ruta1, item.Nombre1);
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
            if (Application.OpenForms["FmantemiminetoRuta"] != null)
            {
                Application.OpenForms["FmantemiminetoRuta"].Activate();
            }
            else
            {
                FmantenimientoRuta fr = new FmantenimientoRuta();
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
                if (Application.OpenForms["FmantemiminetoRuta"] != null)
                {
                    Application.OpenForms["FmantemiminetoRuta"].Activate();
                }
                else
                {
                    FmantenimientoRuta fr = new FmantenimientoRuta();

                    fr.txtCodigo.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    fr.txtCodigo.Enabled = false;

                    RutaModel vendedor = new RutaModel();

                    var codigoruta = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    var buscar = ruta.BuscarRuta(codigoruta, UserLoginCache.CONJUNTO);

                    foreach (var item in buscar)
                    {
                        fr.txtCodigo.Text = item.Ruta1.ToString();
                        fr.txtNombre.Text = item.Nombre1.ToString();
                        

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

            const string message = "Esta seguro de Borrar La Ruta";
            const string caption = "Eliminar Ruta";
            var resultM = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dgvDatos.SelectedRows.Count > 0)
            {


                if (resultM == DialogResult.Yes)
                {
                    RutaModel ruta = new RutaModel();
                    ruta.State = EntityState.Deleted;
                    ruta.Ruta1 = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    ruta.Conjunto1 = UserLoginCache.CONJUNTO;
                    ruta.SaveChanges();
                    string result = ruta.SaveChanges();
                    MessageBox.Show(result);

                }
            }
            else
            {
                MessageBox.Show("Selecione una Ruta");

            }
            Refrescar();

        }


    }
}
