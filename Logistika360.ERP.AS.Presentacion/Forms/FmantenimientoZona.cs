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
    public partial class FmantenimientoZona : FormsPlantillas.FormPlantillaMantenimientoSmall
    {
        ZonaModel zonamodelo = new ZonaModel();
        public FmantenimientoZona()
        {
            InitializeComponent();
        }

        public override void Guardar()
        {
            // MessageBox.Show("AQUI VAMOS INGRESANDO");



            var numerousuario = zonamodelo.BuscarZona(txtCodigo.Text, UserLoginCache.CONJUNTO);

            var valor = numerousuario.Count();


            if (valor == 0)
            {

                //Procedemos a guardar
                zonamodelo.State = EntityState.Added;
                zonamodelo.Zona1 = txtCodigo.Text;
                zonamodelo.Nombre1 = txtNombre.Text;
                zonamodelo.CreatedBy1 = UserLoginCache.USUARIO;
                zonamodelo.CreateDate1 = DateTime.Today;
                zonamodelo.UpdatedBy1 = UserLoginCache.USUARIO;
                zonamodelo.RecordDate1 = DateTime.Today;
                zonamodelo.Conjunto1 = UserLoginCache.CONJUNTO;

                bool valid = new Helps.DataValidation(zonamodelo).Validate();
                if (valid == true)
                {
                    string result = zonamodelo.SaveChanges();

                    MessageBox.Show(result);
                    zonamodelo.SaveChanges();
                }




            }
            else
            {
                //Procedemos a editar                

                zonamodelo.State = EntityState.Modified;
                zonamodelo.Zona1 = txtCodigo.Text;
                zonamodelo.Nombre1 = txtNombre.Text;
                zonamodelo.UpdatedBy1 = UserLoginCache.USUARIO;
                zonamodelo.RecordDate1 = DateTime.Today;
                zonamodelo.Conjunto1 = UserLoginCache.CONJUNTO;

                bool valid = new Helps.DataValidation(zonamodelo).Validate();
                if (valid == true)
                {
                    zonamodelo.SaveChanges();
                    string result = zonamodelo.SaveChanges();
                    MessageBox.Show(result);


                }

                Zona fzona = new Zona();
                //Pentiente regresar datagrid
                fzona.Cargargrid();


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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            ZonaModel oZona = new ZonaModel();
            var existeZona = oZona.BuscarZona(txtCodigo.Text, UserLoginCache.CONJUNTO);
            var valor = existeZona.Count();

            if (valor == 1)
            {
                const string message = "Zona ya Existe";
                const string caption = "Validar Zona";
                var resultM = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();

            }
        }

        private void FmantenimientoZona_Load(object sender, EventArgs e)
        {
            this.Text = UserLoginCache.CONJUNTO + " " + "Mantenimiento de Zonas";
        }
    }
}
