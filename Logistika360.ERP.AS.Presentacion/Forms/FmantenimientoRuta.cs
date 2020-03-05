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


namespace Logistika360.ERP.AS.Presentacion.Forms
{
    public partial class FmantenimientoRuta :  FormsPlantillas.FormPlantillaMantenimientoSmall
    {

        RutaModel rutamodelo = new RutaModel();

        public FmantenimientoRuta()
        {
            InitializeComponent();
        }

        public override void Guardar()
        {
            // MessageBox.Show("AQUI VAMOS INGRESANDO");



            var numerousuario = rutamodelo.BuscarRuta(txtCodigo.Text, UserLoginCache.CONJUNTO);

            var valor = numerousuario.Count();


            if (valor == 0)
            {

                //Procedemos a guardar
                rutamodelo.State = EntityState.Added;
                rutamodelo.Ruta1 = txtCodigo.Text;
                rutamodelo.Nombre1 = txtNombre.Text;
                rutamodelo.CreatedBy1 = UserLoginCache.USUARIO;
                rutamodelo.CreateDate1 = DateTime.Today;
                rutamodelo.UpdatedBy1 = UserLoginCache.USUARIO;
                rutamodelo.RecordDate1 = DateTime.Today;
                rutamodelo.Conjunto1 = UserLoginCache.CONJUNTO;

                bool valid = new Helps.DataValidation(rutamodelo).Validate();
                if (valid == true)
                {
                    string result = rutamodelo.SaveChanges();

                    MessageBox.Show(result);
                    rutamodelo.SaveChanges();
                }




            }
            else
            {
                //Procedemos a editar                

                rutamodelo.State = EntityState.Modified;
                rutamodelo.Ruta1 = txtCodigo.Text;
                rutamodelo.Nombre1 = txtNombre.Text;
                rutamodelo.UpdatedBy1 = UserLoginCache.USUARIO;
                rutamodelo.RecordDate1 = DateTime.Today;
                rutamodelo.Conjunto1 = UserLoginCache.CONJUNTO;

                bool valid = new Helps.DataValidation(rutamodelo).Validate();
                if (valid == true)
                {
                    rutamodelo.SaveChanges();
                    string result = rutamodelo.SaveChanges();
                    MessageBox.Show(result);


                }

                Ruta frutas = new Ruta();
                //Pentiente regresar datagrid
                frutas.Cargargrid();


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
            txtCodigo.Focus();
        }

        private void FmantenimientoRuta_Load(object sender, EventArgs e)
        {
            
            this.Text = UserLoginCache.CONJUNTO + " " + "Mantenimiento de Rutas";
            
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            RutaModel oRuta = new RutaModel();
            var existeRuta = oRuta.BuscarRuta(txtCodigo.Text, UserLoginCache.CONJUNTO);
            var valor = existeRuta.Count();

            if (valor == 1)
            {
                const string message = "Ruta ya Existe";
                const string caption = "Validar Ruta";
                var resultM = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();

            }
        }
    }
}
