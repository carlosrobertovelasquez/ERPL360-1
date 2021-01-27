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

namespace Logistika360.ERP.AS.Presentacion.Tablas.Funcionarios.Cobrador
{
    public partial class FmantemiminetoCobrador : FormsPlantillas.FormPlantillaMantenimientoSmall
    {
        CobradorModel cobradormodelo = new CobradorModel();

        public FmantemiminetoCobrador()
        {
            InitializeComponent();
        }


        public override void Guardar()
        {
            // MessageBox.Show("AQUI VAMOS INGRESANDO");



            var numerousuario = cobradormodelo.BuscarCobrador(txtCodigo.Text);

            var valor = numerousuario.Count();


            if (valor == 0)
            {

                //Procedemos a guardar
                cobradormodelo.State = EntityState.Added;
                cobradormodelo.Cobrador1 = txtCodigo.Text;
                cobradormodelo.Nombre1 = txtNombre.Text;
                cobradormodelo.Empleado1 = txtEmpleado.Text;
                cobradormodelo.Comision1 = Convert.ToDecimal(txtComisiones.Text);
                cobradormodelo.Correo1 = txtCorreo.Text;
                cobradormodelo.Ctr_comision1 = txtCentroCosto.Text;
                cobradormodelo.Cta_comision1 = txtCuentaContable.Text;
                cobradormodelo.Telefono1 = txtTelefono.Text;
                cobradormodelo.Activo1 = ckbEstado.Checked ? "S" : "N";
                cobradormodelo.CreatedBy1 = UserLoginCache.USUARIO;
                cobradormodelo.CreateDate1 = DateTime.Today;
                cobradormodelo.UpdatedBy1 = UserLoginCache.USUARIO;
                cobradormodelo.RecordDate1 = DateTime.Today;
               

                bool valid = new Helps.DataValidation(cobradormodelo).Validate();
                if (valid == true)
                {
                    string result = cobradormodelo.SaveChanges();

                    MessageBox.Show(result);
                    cobradormodelo.SaveChanges();
                }




            }
            else
            {
                //Procedemos a editar                

                cobradormodelo.State = EntityState.Modified;
                cobradormodelo.Cobrador1 = txtCodigo.Text;
                cobradormodelo.Nombre1 = txtNombre.Text;
                cobradormodelo.Empleado1 = txtEmpleado.Text;
                cobradormodelo.Comision1 = Convert.ToDecimal(txtComisiones.Text);
                cobradormodelo.Correo1 = txtCorreo.Text;
                cobradormodelo.Ctr_comision1 = txtCentroCosto.Text;
                cobradormodelo.Cta_comision1 = txtCuentaContable.Text;
                cobradormodelo.Telefono1 = txtTelefono.Text;
                cobradormodelo.Activo1 = ckbEstado.Checked ? "S" : "N";
                cobradormodelo.UpdatedBy1 = UserLoginCache.USUARIO;
                cobradormodelo.RecordDate1 = DateTime.Today;
             

                bool valid = new Helps.DataValidation(cobradormodelo).Validate();
                if (valid == true)
                {
                    cobradormodelo.SaveChanges();
                    string result = cobradormodelo.SaveChanges();
                    MessageBox.Show(result);


                }

                COBRADOR fcobrador = new COBRADOR();
                //Pentiente regresar datagrid
                fcobrador.Cargargrid();


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
            this.Text = UserLoginCache.CONJUNTO + " " + "Mantenimiento de Cobrador";
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
            CobradorModel cobrador = new CobradorModel();
            var existecobrador = cobrador.BuscarCobrador(txtCodigo.Text);
            var valor = existecobrador.Count();

            if (valor == 1)
            {
                const string message = "Cobrador ya Existe";
                const string caption = "Validar Cobrador";
                var resultM = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();

            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void txtNombreEmpleado_TextChanged(object sender, EventArgs e)
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

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_Validated_1(object sender, EventArgs e)
        {
            CobradorModel oCobrador = new CobradorModel();
            var existeCobrador = oCobrador.BuscarCobrador(txtCodigo.Text);
            var valor = existeCobrador.Count();

            if (valor == 1)
            {
                const string message = "Cobrador ya Existe";
                const string caption = "Validar Cobrador";
                var resultM = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();

            }
        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {
            txtNombre.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
