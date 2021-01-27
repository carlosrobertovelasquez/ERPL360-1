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


namespace Logistika360.ERP.AS.Presentacion.Tablas.Tipos.Moneda
{
    public partial class FmantemiminetoMoneda : FormsPlantillas.FormPlantillaMantenimientoSmall
    {
        MonedaModel monedamodelo = new MonedaModel();
        public FmantemiminetoMoneda()
        {
            InitializeComponent();
        }
        public override void Guardar()
        {
            // MessageBox.Show("AQUI VAMOS INGRESANDO");



            var numerousuario = monedamodelo.BuscarMoneda(txtMoneda.Text);

            var valor = numerousuario.Count();


            if (valor == 0)
            {

                //Procedemos a guardar
                monedamodelo.State = EntityState.Added;
                monedamodelo.Moneda1 = txtMoneda.Text;
                monedamodelo.Nombre1 = txtNombre.Text;
                monedamodelo.Codigo_iso1 = txtCodigoIso.Text;
                monedamodelo.CreatedBy1 = UserLoginCache.USUARIO;
                monedamodelo.CreateDate1 = DateTime.Today;
                monedamodelo.UpdatedBy1 = UserLoginCache.USUARIO;
                monedamodelo.RecordDate1 = DateTime.Today;


                bool valid = new Helps.DataValidation(monedamodelo).Validate();
                if (valid == true)
                {
                    string result = monedamodelo.SaveChanges();

                    MessageBox.Show(result);
                    monedamodelo.SaveChanges();
                }




            }
            else
            {
                //Procedemos a editar                

                monedamodelo.State = EntityState.Modified;
                monedamodelo.Moneda1 = txtMoneda.Text;
                monedamodelo.Nombre1 = txtNombre.Text;
                monedamodelo.Codigo_iso1 = txtCodigoIso.Text;
                monedamodelo.UpdatedBy1 = UserLoginCache.USUARIO;
                monedamodelo.RecordDate1 = DateTime.Today;


                bool valid = new Helps.DataValidation(monedamodelo).Validate();
                if (valid == true)
                {
                    monedamodelo.SaveChanges();
                    string result = monedamodelo.SaveChanges();
                    MessageBox.Show(result);


                }

                Moneda fmoneda = new Moneda();
                //Pentiente regresar datagrid
                fmoneda.Cargargrid();


            }
        }
        public override void GuardarSalir()
        {
            Guardar();
            this.Close();
        }
        public override void Nuevo()
        {

            txtMoneda.Text = "";
            txtNombre.Text = "";
            txtCodigoIso.Text = "";
            txtMoneda.Focus();
        }

        private void FmantemiminetoMoneda_Load(object sender, EventArgs e)
        {
            this.Text = UserLoginCache.CONJUNTO + " " + "Mantenimiento de Moneda";
        }
    }
}
