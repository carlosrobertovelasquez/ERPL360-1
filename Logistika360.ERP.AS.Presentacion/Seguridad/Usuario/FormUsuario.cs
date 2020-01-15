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
using Logistika360.ERP.ERPADMIN.Domain.Models;

namespace Logistika360.ERP.AS.Presentacion.Seguridad.Usuario
{
    public partial class FormUsuario : Form
    {

        private UsuarioModel usuario = new UsuarioModel();
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            LoadUserData();
            ListarUsuario();
        }

        private void ListarUsuario()
        {
            try
            {

                List<UsuarioModel> LUsuario = new List<UsuarioModel>();

                DataGridViewRow dwgusuario2 = new DataGridViewRow();
                dwgusuario2.CreateCells(dwgUsuarios);

                LUsuario = usuario.GetAll();
                var activo=false;
                foreach (var item in LUsuario)
                {
                    if (item.ACTIVO1=="S")
                    {
                         activo = true;
                    }
                   


                    dwgUsuarios.Rows.Add(item.USUARIO1,item.NOMBRE1,activo,item.CORREO_ELECTRONICO1,item.CELULAR1); 
                }

                //dwgUsuarios.DataSource = usuario.GetAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadUserData()
        {
            //lblUsuario.Text = UserLoginCache.USUARIO;

            this.Text = UserLoginCache.CONJUNTO+"-"+"Usuario";
        }

               

        private void toolStripButton8_Click(object sender, EventArgs e)
        {

        }

        private void MenuSuperiorSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void MenuSuperior_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuSuperiorNuevo_Click(object sender, EventArgs e)
        {



            FormPrivilegiosdeUsuario fr = new FormPrivilegiosdeUsuario();
            
            fr.Show();
        }

        private void dwgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormPrivilegiosdeUsuario fr = new FormPrivilegiosdeUsuario();
            fr.txtusuario.Text= dwgUsuarios.CurrentRow.Cells[0].Value.ToString();
            fr.txtusuario.Enabled = false;
            fr.txtnombre.Text= dwgUsuarios.CurrentRow.Cells[1].Value.ToString();
 
            //fr.chbActivo.Checked= dwgUsuarios.CurrentRow.Cells[2].Value.;
            fr.txtcorreo.Text= dwgUsuarios.CurrentRow.Cells[3].Value.ToString();
            fr.txtcelular.Text= dwgUsuarios.CurrentRow.Cells[4].Value.ToString();
            fr.Show();
        }
    }
}
