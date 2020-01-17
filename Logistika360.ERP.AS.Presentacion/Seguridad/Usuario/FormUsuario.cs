using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logistika360.ERP.ERPADMIN.Common.Cache;
using Logistika360.ERP.ERPADMIN.Domain.Models;
using Logistika360.ERP.ERPADMIN.Domain.ValueObjects;

namespace Logistika360.ERP.AS.Presentacion.Seguridad.Usuario
{
    public partial class FormUsuario : Form
    {
        //Función importada de la librería user32.dll para mostrar una ventana en diferentes estados
        [DllImport("user32.dll")]
        public static extern long ShowWindow(IntPtr hwnd, uint nCmdShow);

        //Función para pasar a primer plano una ventana y activarla
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hwnd);

        //Variable que indica que hay mas de una instancia de la app ejecutandoce
        private bool prev_instances = false;

        private UsuarioModel usuario = new UsuarioModel();
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

            //Si hay mas de una instancia de mi aplicación
          

            LoadUserData();
            ListarUsuario();
        }

        public void ListarUsuario()
        {
            try
            {

                dwgUsuarios.Rows.Clear();
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
                    else
                    {
                        activo = false;
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
            
            ListarUsuario();
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


            if (Application.OpenForms["FormPrivilegiosdeUsuario"] != null)
            {
                Application.OpenForms["FormPrivilegiosdeUsuario"].Activate();
            }
            else
            {

                

                FormPrivilegiosdeUsuario fr = new FormPrivilegiosdeUsuario();
                fr.txtcelular.Text = "";
                fr.txtcorreo.Text = "";
                fr.txtusuariowindows.Text = "";
                fr.txtfrecuenciaclave.Text = "0";
                fr.txtLimiteIntentos.Text = "0";
                fr.chbesrequerido.Checked = false;
                fr.txtfrecuenciaclave.Enabled = true;
                fr.txtLimiteIntentos.Enabled = true;
                fr.Show();
            }
        }

        private void dwgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FormUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void MenuSuperiorEliminar_Click(object sender, EventArgs e)
        {


            const string message = "Esta seguro de Borrar el Usuario";
            const string caption = "Eliminar Usuario";
            var resultM = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            




            if (dwgUsuarios.SelectedRows.Count>0)
            {


                if (resultM == DialogResult.Yes)
                {
                    UsuarioModel usuario = new UsuarioModel();
                    usuario.State = EntityState.Deleted;
                    usuario.USUARIO1 = dwgUsuarios.CurrentRow.Cells[0].Value.ToString();
                    usuario.SaveChanges();
                    string result = usuario.SaveChanges();
                    MessageBox.Show(result);
                    ListarUsuario();
                }
            }
            else
            {
                MessageBox.Show("Selecione un Usuario");
            }

            
        }

        private void MenuSuperiorEditar_Click(object sender, EventArgs e)
        {
            if (dwgUsuarios.SelectedRows.Count > 0)
            {
                //Logramos que no se abra mas de una vez el formulario          
                if (Application.OpenForms["FormPrivilegiosdeUsuario"] != null)
                {
                    Application.OpenForms["FormPrivilegiosdeUsuario"].Activate();
                }
                else
                {
                    FormPrivilegiosdeUsuario fr = new FormPrivilegiosdeUsuario();
                    fr.txtusuario.Text = dwgUsuarios.CurrentRow.Cells[0].Value.ToString();
                    fr.txtusuario.Enabled = false;
                    if (dwgUsuarios.CurrentRow.Cells[2].Value==null )
                    {
                        fr.chbActivo.Checked = true;
                    }
                    else
                    {
                        fr.chbActivo.Checked = false;
                    }
                    fr.txtnombre.Text = dwgUsuarios.CurrentRow.Cells[1].Value.ToString();


                    fr.txtcorreo.Text = dwgUsuarios.CurrentRow.Cells[3].Value.ToString();
                    fr.txtcelular.Text = dwgUsuarios.CurrentRow.Cells[4].Value.ToString();
                    fr.Show();
                }
            }
            else
            {
                MessageBox.Show("Requiere Selecionar un Usuario");
            }
        }
    }
}
