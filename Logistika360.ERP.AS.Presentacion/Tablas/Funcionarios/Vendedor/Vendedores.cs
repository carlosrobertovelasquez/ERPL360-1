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
        private string refrescar = "N";

        public Vendedores()
        {
            InitializeComponent();
        }

        private void Vendedores_Load(object sender, EventArgs e)
        {
            this.Text = UserLoginCache.CONJUNTO+" "+"Vendedor";
            Cargargrid();
        }

        public override void Cargargrid( )
        {

            if (refrescar=="N")
            {
                //Agregamos Columnas
                dgvDatos.Columns.Add("Columna1", "Vendedor");
                dgvDatos.Columns.Add("Columna2", "Nombre");
                
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                dgvDatos.Columns.Add(chk);
                chk.HeaderText = "Activo";
                chk.Name = "chk";
            }
            

            try
            {
                
                dgvDatos.Rows.Clear();
                DataGridViewRow dgvVendedor = new DataGridViewRow();
                dgvVendedor.CreateCells(dgvDatos);
                var LVendedor = vendedor.VendedorConjunto();
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
                  
                    dgvDatos.Rows.Add(item.Vendedor1, item.Nombre1, activo);
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
            if (Application.OpenForms["FmantemiminetoVendedor"] != null)
            {
                Application.OpenForms["FmantemiminetoVendedor"].Activate();
            }
            else
            {
                FmantenimientoVendedor fr = new FmantenimientoVendedor();
                fr.txtCodigo.Text = "";
                fr.txtNombre.Text = "";
                fr.txtEmpleado.Text = "";
                fr.txtNombreEmpleado.Text = "";
                fr.txtComisiones.Text = "0.00";
                fr.txtCorreo.Text = "";
                fr.txtCentroCosto.Text = "";
                fr.txtNombreCentroCosto.Text = "";
                fr.txtCuentaContable.Text = "";
                fr.txtNombreCuentaContable.Text = "";
                fr.txtTelefono.Text = "";
                fr.ckbEstado.Checked = false;
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
                    FmantenimientoVendedor fr = new FmantenimientoVendedor();

                    fr.txtCodigo.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    fr.txtCodigo.Enabled = false;

                    VendedorModel vendedor = new VendedorModel();

                    var codigovendedor = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    var buscar = vendedor.BuscarVendedor(codigovendedor );

                    foreach (var item in buscar)
                    {
                        fr.txtCodigo.Text = item.Vendedor1.ToString();
                        fr.txtNombre.Text = item.Nombre1.ToString();
                        fr.txtEmpleado.Text = item.Empleado1.ToString();
                        //Aqui buscaremos Nombre de Empleado
                        fr.txtComisiones.Text = item.Comision1.ToString();
                        fr.txtCorreo.Text = item.Correo1.ToString();
                        //Buscar Cuenta Contable
                        fr.txtCuentaContable.Text = item.Cta_comision1.ToString();
                        //Buscar Centro Costo
                        fr.txtCentroCosto.Text = item.Ctr_comision1.ToString();
                        fr.txtTelefono.Text = item.Telefono1.ToString();
                        //Estado de Clientes
                        if (item.Activo1=="S")
                        {
                            fr.ckbEstado.Checked = true;
                        }
                        else
                        {
                            fr.ckbEstado.Checked = false;
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

            const string message = "Esta seguro de Borrar el Vendedor";
            const string caption = "Eliminar Vendedor";
            var resultM = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dgvDatos.SelectedRows.Count > 0)
            {


                if (resultM == DialogResult.Yes)
                {
                    VendedorModel vendedor = new VendedorModel();
                    vendedor.State = EntityState.Deleted;
                    vendedor.Vendedor1 = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    vendedor.SaveChanges();
                    string result = vendedor.SaveChanges();
                    MessageBox.Show(result);
                   
                }
            }
            else
            {
                MessageBox.Show("Selecione un Usuario");
                
            }
            Refrescar();
           
        }

    }
}
