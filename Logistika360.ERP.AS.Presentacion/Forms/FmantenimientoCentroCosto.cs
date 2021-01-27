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
    public partial class FmantenimientoCentroCosto :   FormsPlantillas.FormPlantillaMantenimientoSmall
    {
        CentroCostoModel centrocostomodelo = new CentroCostoModel();

        public FmantenimientoCentroCosto()
        {
            InitializeComponent();
        }

        public override void Guardar()
        {
            // MessageBox.Show("AQUI VAMOS INGRESANDO");



            var numerousuario = centrocostomodelo.BuscarCentroCosto(txtCodigo.Text);

            var valor = numerousuario.Count();


            if (valor == 0)
            {

                //Procedemos a guardar
                centrocostomodelo.State = EntityState.Added;
                centrocostomodelo.CentroCosto1 = txtCodigo.Text;
                centrocostomodelo.Descripcion1 = txtNombre.Text;
                centrocostomodelo.CreatedBy1 = UserLoginCache.USUARIO;
                centrocostomodelo.CreateDate1 = DateTime.Today;
                centrocostomodelo.UpdatedBy1 = UserLoginCache.USUARIO;
                centrocostomodelo.RecordDate1 = DateTime.Today;
                

                bool valid = new Helps.DataValidation(centrocostomodelo).Validate();
                if (valid == true)
                {
                    string result = centrocostomodelo.SaveChanges();

                    MessageBox.Show(result);
                    centrocostomodelo.SaveChanges();
                }




            }
            else
            {
                //Procedemos a editar                

                centrocostomodelo.State = EntityState.Modified;
                centrocostomodelo.CentroCosto1 = txtCodigo.Text;
                centrocostomodelo.Descripcion1 = txtNombre.Text;
                centrocostomodelo.UpdatedBy1 = UserLoginCache.USUARIO;
                centrocostomodelo.RecordDate1 = DateTime.Today;
                

                bool valid = new Helps.DataValidation(centrocostomodelo).Validate();
                if (valid == true)
                {
                    centrocostomodelo.SaveChanges();
                    string result = centrocostomodelo.SaveChanges();
                    MessageBox.Show(result);


                }

                Ruta frutas = new Ruta();
                //Pentiente regresar datagrid
                frutas.Cargargrid();


            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
