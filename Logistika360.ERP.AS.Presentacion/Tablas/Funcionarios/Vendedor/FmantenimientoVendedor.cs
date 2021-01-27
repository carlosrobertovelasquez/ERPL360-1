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

namespace Logistika360.ERP.AS.Presentacion.Tablas.Funcionarios.Vendedor
{
    public partial class FmantenimientoVendedor : FormsPlantillas.FormPlantillaMantenimientoSmall
    {

        VendedorModel vendedormodelo = new VendedorModel();
        public FmantenimientoVendedor()
        {
            InitializeComponent();
        }

        public override void Guardar()
        {
            // MessageBox.Show("AQUI VAMOS INGRESANDO");

           

            var numerousuario = vendedormodelo.BuscarVendedor(txtCodigo.Text);

            var valor = numerousuario.Count();


            if (valor == 0)
            {

                //Procedemos a guardar
                vendedormodelo.State = EntityState.Added;
                vendedormodelo.Vendedor1 = txtCodigo.Text;
                vendedormodelo.Nombre1 = txtNombre.Text;
                vendedormodelo.Empleado1 = txtEmpleado.Text;
                vendedormodelo.Comision1 = Convert.ToDecimal( txtComisiones.Text);
                vendedormodelo.Correo1 = txtCorreo.Text;
                vendedormodelo.Ctr_comision1 = txtCentroCosto.Text;
                vendedormodelo.Cta_comision1 = txtCuentaContable.Text;
                vendedormodelo.Telefono1 = txtTelefono.Text;
                vendedormodelo.Activo1 = ckbEstado.Checked ? "S":"N" ;
                vendedormodelo.CreatedBy1 = UserLoginCache.USUARIO;
                vendedormodelo.CreateDate1 = DateTime.Today;
                vendedormodelo.UpdatedBy1 = UserLoginCache.USUARIO;
                vendedormodelo.RecordDate1 = DateTime.Today;
              

                bool valid = new Helps.DataValidation(vendedormodelo).Validate();
                if (valid == true)
                {
                    string result = vendedormodelo.SaveChanges();
                    
                    MessageBox.Show(result);
                    vendedormodelo.SaveChanges();
                }




            }
            else
            {
                //Procedemos a editar                

                vendedormodelo.State = EntityState.Modified;
                vendedormodelo.Vendedor1 = txtCodigo.Text;
                vendedormodelo.Nombre1 = txtNombre.Text;
                vendedormodelo.Empleado1 = txtEmpleado.Text;
                vendedormodelo.Comision1 = Convert.ToDecimal(txtComisiones.Text);
                vendedormodelo.Correo1 = txtCorreo.Text;
                vendedormodelo.Ctr_comision1 = txtCentroCosto.Text;
                vendedormodelo.Cta_comision1 = txtCuentaContable.Text;
                vendedormodelo.Telefono1 = txtTelefono.Text;
                vendedormodelo.Activo1 = ckbEstado.Checked ? "S" : "N";
                vendedormodelo.UpdatedBy1 = UserLoginCache.USUARIO;
                vendedormodelo.RecordDate1 = DateTime.Today;
               

                bool valid = new Helps.DataValidation(vendedormodelo).Validate();
                if (valid == true)
                {
                    vendedormodelo.SaveChanges();
                    string result = vendedormodelo.SaveChanges();
                    MessageBox.Show(result);


                }

                Vendedores fvendedores = new  Vendedores();
                //Pentiente regresar datagrid
                fvendedores.Cargargrid();


            }

        }

        public override void GuardarSalir()
        {
            Guardar();
            this.Close();
        }
        public override void Nuevo()
        {
           
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtEmpleado.Text = "";
            txtNombreEmpleado.Text = "";
            txtComisiones.Text = "0.00";
            txtCorreo.Text = "";
            txtCentroCosto.Text = "";
            txtNombreCentroCosto.Text = "";
            txtCuentaContable.Text = "";
            txtNombreCuentaContable.Text = "";
            txtTelefono.Text = "";
            ckbEstado.Checked = false;
            txtCodigo.Focus();
        }
        private void FmantenimientoVendedor_Load(object sender, EventArgs e)
        {
            txtComisiones.Text = "0.00";
            this.Text = UserLoginCache.CONJUNTO + " " + "Mantenimiento de Vendedor";
            this.ckbEstado.Checked = true;
        }

        private void txtComisiones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            VendedorModel vendedor = new VendedorModel();
            var existevendedor = vendedor.BuscarVendedor(txtCodigo.Text);
            var valor = existevendedor.Count();

            if (valor == 1)
            {
                const string message = "Vendedor ya Existe";
                const string caption = "Validar Vendedor";
                var resultM = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();

            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.CharacterCasing = CharacterCasing.Upper;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtComisiones_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtCuentaContable_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreCuentaContable_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
