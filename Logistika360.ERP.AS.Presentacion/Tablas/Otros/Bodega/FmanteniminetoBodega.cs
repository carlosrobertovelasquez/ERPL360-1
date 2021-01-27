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

namespace Logistika360.ERP.AS.Presentacion.Tablas.Otros.Bodega
{
    public partial class FmanteniminetoBodega :  FormsPlantillas.FormPlantillaMantenimientoSmall
    {
        BodegaModel bodegamodelo = new BodegaModel();
        public FmanteniminetoBodega()
        {
            InitializeComponent();
        }
        public override void Guardar()
        {
            // MessageBox.Show("AQUI VAMOS INGRESANDO");



            var numerousuario = bodegamodelo.BuscarBodega(txtCodigo.Text);

            var valor = numerousuario.Count();


            if (valor == 0)
            {

                //Procedemos a guardar
                bodegamodelo.State = EntityState.Added;
                bodegamodelo.Bodega1 = txtCodigo.Text;
                bodegamodelo.Nombre1 = txtNombre.Text;
                bodegamodelo.Telefono1 = txtTelefono.Text;
                bodegamodelo.Consec_traslados1 = txtConsecTraslados.Text;
                bodegamodelo.Direccion1 = txtDireccion.Text;
                if (rdbConsumo.Checked == true)
                {
                    bodegamodelo.Tipo1 = "C";
                }
                if (rdbVentas.Checked == true)
                {
                    bodegamodelo.Tipo1 = "V";
                }
                if (rdbNodisponible.Checked == true)
                {
                    bodegamodelo.Tipo1 = "N";
                }

                bodegamodelo.CreatedBy1 = UserLoginCache.USUARIO;
                bodegamodelo.CreateDate1 = DateTime.Today;
                bodegamodelo.UpdatedBy1 = UserLoginCache.USUARIO;
                bodegamodelo.RecordDate1 = DateTime.Today;


                bool valid = new Helps.DataValidation(bodegamodelo).Validate();
                if (valid == true)
                {
                    string result = bodegamodelo.SaveChanges();

                    MessageBox.Show(result);
                    bodegamodelo.SaveChanges();
                }

            }
            else
            {
                //Procedemos a editar                

                bodegamodelo.State = EntityState.Modified;
                bodegamodelo.Bodega1 = txtCodigo.Text;
                bodegamodelo.Nombre1 = txtNombre.Text;
                bodegamodelo.Telefono1 = txtTelefono.Text;
                bodegamodelo.Consec_traslados1 = txtConsecTraslados.Text;
                bodegamodelo.Direccion1 = txtDireccion.Text;

                if (rdbConsumo.Checked == true)
                {
                    bodegamodelo.Tipo1 = "C";
                }
                if (rdbVentas.Checked == true)
                {
                    bodegamodelo.Tipo1 = "V";
                }
                if (rdbNodisponible.Checked == true)
                {
                    bodegamodelo.Tipo1 = "N";
                }

                bodegamodelo.UpdatedBy1 = UserLoginCache.USUARIO;
                bodegamodelo.RecordDate1 = DateTime.Today;


                bool valid = new Helps.DataValidation(bodegamodelo).Validate();
                if (valid == true)
                {
                    bodegamodelo.SaveChanges();
                    string result = bodegamodelo.SaveChanges();
                    MessageBox.Show(result);


                }

                Bodega fbodega = new Bodega();
                //Pentiente regresar datagrid
                fbodega.Cargargrid();


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
            txtTelefono.Text = "";
            txtConsecTraslados.Text ="";
            txtDireccion.Text = "";
            txtCodigo.Focus();
        }

        private void FmanteniminetoBodega_Load(object sender, EventArgs e)
        {
            this.Text = UserLoginCache.CONJUNTO + " " + "Mantenimiento de Bodega";
           // this.rdbVentas.Checked = true;
           
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            BodegaModel bodega = new BodegaModel();
            var existebodega = bodega.BuscarBodega(txtCodigo.Text);
            var valor = existebodega.Count();

            if (valor == 1)
            {
                const string message = "Bodega ya Existe";
                const string caption = "Validar Bodega";
                var resultM = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();

            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
