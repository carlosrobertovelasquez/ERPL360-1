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

namespace Logistika360.ERP.AS.Presentacion.Tablas.Funcionarios.Vendedor
{
    public partial class Vendedores :FormsPlantillas.FormPlantillaGridSmall
    {

        private VendedorModel vendedor = new VendedorModel();
        public Vendedores()
        {
            InitializeComponent();
        }

        private void Vendedores_Load(object sender, EventArgs e)
        {
            this.Text = UserLoginCache.CONJUNTO+" "+"Vendedor";
            Cargargrid();
        }

        public override void Cargargrid()
        {

            try
            {
                
                dgvDatos.Rows.Clear();
                List<VendedorModel> LVendedor = new List<VendedorModel>();

                DataGridViewRow dgvVendedor = new DataGridViewRow();
                dgvVendedor.CreateCells(dgvDatos);

                LVendedor = vendedor.GetAll();
                var activo = false;
                foreach (var item in LVendedor)
                {
                    if (item.Activo1 == "S")
                    {
                        activo = true;
                    }
                    else
                    {
                        activo = false;
                    }



                    dgvDatos.Columns.Add("Columna1", "Vendedor");
                    dgvDatos.Columns.Add("Columna2", "Nombre");
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                    dgvDatos.Columns.Add(chk);
                    chk.HeaderText = "Activo";
                    chk.Name = "chk";
                    //dgvDatos.Columns.Add("Columna1", "Activo");
                    dgvDatos.Rows.Add(item.Vendedor1, item.Nombre1, activo);
                }

                //dwgUsuarios.DataSource = usuario.GetAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

    }
}
