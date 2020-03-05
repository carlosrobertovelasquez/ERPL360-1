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
    public partial class Pais : FormsPlantillas.FormPlantillaGridSmall
    {
        private PaisModel oPais = new PaisModel();
        private string refrescar = "N";
        public Pais()
        {
            InitializeComponent();
        }

        public override void Refrescar()
        {
            refrescar = "S";
            Cargargrid();
        }
        public override void Cargargrid()
        {

            if (refrescar == "N")
            {
                //Agregamos Columnas
                dgvDatos.Columns.Add("Columna1", "Codigo");
                dgvDatos.Columns.Add("Columna2", "Nombre");
            }
            try
            {

                dgvDatos.Rows.Clear();
                DataGridViewRow dgvPais = new DataGridViewRow();
                dgvPais.CreateCells(dgvDatos);
                var LPais = oPais.GetAll();
                                
                foreach (var item in LPais)
                {

                    dgvDatos.Rows.Add(item.PAIS1, item.NOMBRE1);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Pais_Load(object sender, EventArgs e)
        {
            this.Text = UserLoginCache.CONJUNTO + " " + "Compañias";
            Cargargrid();
        }

        public override void Nuevo()
        {
            //Logramos que no se abra mas de una vez el formulario          
            if (Application.OpenForms["FmantenimientoPais"] != null)
            {
                Application.OpenForms["FmantenimientoPais"].Activate();
            }
            else
            {
                FmantenimientoPais fr = new FmantenimientoPais();
              //  fr.txtCompania.Text = "";
               // fr.txtNombreCompania.Text = "";

                fr.Show();
            }
        }
    }
}
