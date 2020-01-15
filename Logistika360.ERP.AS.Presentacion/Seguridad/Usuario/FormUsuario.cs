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
    }
}
