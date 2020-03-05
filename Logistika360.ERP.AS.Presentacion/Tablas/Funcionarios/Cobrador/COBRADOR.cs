using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logistika360.ERP.AS.Presentacion.FormsPlantillas;
using Logistika360.ERP.ERPADMIN.Common.Cache;
using Logistika360.ERP.AS.Domain.Models;
using Logistika360.ERP.AS.Domain.ValueObjects;


namespace Logistika360.ERP.AS.Presentacion.Tablas.Funcionarios.Cobrador
{
    public partial class COBRADOR : FormsPlantillas.FormPlantillaGridSmall
    {
        private CobradorModel cobrador = new  CobradorModel();
        private string refrescar = "N";

        public COBRADOR()
        {
            InitializeComponent();
        }

        private void COBRADOR_Load(object sender, EventArgs e)
        {
            this.Text = UserLoginCache.CONJUNTO + " " + "Cobrador";
            Cargargrid();
        }
        public override void Cargargrid()
        {

            if (refrescar == "N")
            {
                //Agregamos Columnas
                dgvDatos.Columns.Add("Columna1", "Cobrador");
                dgvDatos.Columns.Add("Columna2", "Nombre");
                dgvDatos.Columns.Add("Columna3", "Activo");

                //DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                //dgvDatos.Columns.Add(chk);
                //chk.HeaderText = "Activo";
                //chk.Name = "chk";
            }


            try
            {

                dgvDatos.Rows.Clear();
                DataGridViewRow dgvCobrador = new DataGridViewRow();
                dgvCobrador.CreateCells(dgvDatos);
                
                var LCobrador = cobrador.CobradorConjunto(UserLoginCache.CONJUNTO);
                string activo  ;


                foreach (var item in LCobrador)
                {
                    if (item.Activo1 == "S")
                    {
                        activo = "Activo";
                    }
                    else
                    {
                        activo = "Inactivo";
                    }

                    dgvDatos.Rows.Add(item.Cobrador1, item.Nombre1, activo);
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
            if (Application.OpenForms["FmantemiminetoCobrador"] != null)
            {
                Application.OpenForms["FmantemiminetoCobrador"].Activate();
            }
            else
            {
                FmantemiminetoCobrador fr = new FmantemiminetoCobrador();
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
                if (Application.OpenForms["FmantemiminetoCobrador"] != null)
                {
                    Application.OpenForms["FmantemiminetoCobrador"].Activate();
                }
                else
                {
                    FmantemiminetoCobrador fr = new FmantemiminetoCobrador();

                    fr.txtCodigo.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    fr.txtCodigo.Enabled = false;

                    CobradorModel cobrador = new CobradorModel();

                    var codigocobrador = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    var buscar = cobrador.BuscarCobrador(codigocobrador, UserLoginCache.CONJUNTO);

                    foreach (var item in buscar)
                    {
                        fr.txtCodigo.Text = item.Cobrador1.ToString();
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
                        if (item.Activo1 == "S")
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
                MessageBox.Show("Requiere Selecionar un Cobrador");
            }

        }
        public override void Refrescar()
        {
            refrescar = "S";
            Cargargrid();
        }
        public override void Borrar()
        {

            const string message = "Esta seguro de Borrar el Cobrador";
            const string caption = "Eliminar Cobrador";
            var resultM = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dgvDatos.SelectedRows.Count > 0)
            {


                if (resultM == DialogResult.Yes)
                {
                    CobradorModel cobrador = new CobradorModel();
                    cobrador.State = EntityState.Deleted;
                    cobrador.Cobrador1 = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    cobrador.Conjunto1 = UserLoginCache.CONJUNTO;
                    cobrador.SaveChanges();
                    string result = cobrador.SaveChanges();
                    MessageBox.Show(result);

                }
            }
            else
            {
                MessageBox.Show("Selecione un Cobrador");

            }
            Refrescar();

        }

    }
}
