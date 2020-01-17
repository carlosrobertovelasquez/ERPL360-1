using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logistika360.ERP.ERPADMIN.Domain.Models;
using Logistika360.ERP.ERPADMIN.Domain.ValueObjects;
using Logistika360.ERP.ERPADMIN.Common.Cache;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Logistika360.ERP.AS.Presentacion.Seguridad.Usuario
{
    public partial class FormPrivilegiosdeUsuario : Form
    {

        //Función importada de la librería user32.dll para mostrar una ventana en diferentes estados
        [DllImport("user32.dll")]
        public static extern long ShowWindow(IntPtr hwnd, uint nCmdShow);

        //Función para pasar a primer plano una ventana y activarla
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hwnd);

        //Variable que indica que hay mas de una instancia de la app ejecutandoce
        private bool prev_instances = false;
        private FormUsuario FormUsuario = new FormUsuario();
        public FormPrivilegiosdeUsuario()
        {
            InitializeComponent();
           

        }

        private void FormPrivilegiosdeUsuario_Load(object sender, EventArgs e)
        {

            if (Process.GetProcessesByName("WindowsFormsApplication2").Length > 1)
            {
                //Asigno verdadero a la variable
                prev_instances = true;
                //Cierro el formulario
                Close();
            }

            cargarArbolMenu();
            LoadUserData();
            cargarusuario();
         

        }

        
        private void cargarArbolMenu()
        {
            ArbolMenu.Nodes.Clear();
            
                        
            //CrearNodoDelPadre(Int32.Parse(_accion), null);

            CrearNodoDelPadre(2, null);

        }



        private void CrearNodoDelPadre(int indicePadre, TreeNode nodoPadre)
        {

            ParentescoModel padres = new ParentescoModel();
            DataTable dtsN = padres.arbolMenuPrivilegios();
            DataView dataViewHijos = new DataView(dtsN);
            dataViewHijos.RowFilter = dtsN.Columns["PADRE"].ColumnName + "=" + indicePadre;

            foreach (DataRowView dataRowCurrent in dataViewHijos)
            {
                TreeNode nuevoNodo = new TreeNode();
                nuevoNodo.Text = dataRowCurrent["NOMBREACCION"].ToString().Trim();
                nuevoNodo.Name = dataRowCurrent["ACCION"].ToString().Trim();
                nuevoNodo.Tag = dataRowCurrent["NOMBRECONSTANTE"].ToString().Trim();
                nuevoNodo.ImageIndex = 0;
                nuevoNodo.SelectedImageIndex = 1;
                if (nodoPadre == null)
                {
                    ArbolMenu.Nodes.Add(nuevoNodo);
                }
                else
                {
                    nodoPadre.Nodes.Add(nuevoNodo);
                }
                CrearNodoDelPadre(Int32.Parse(dataRowCurrent["ACCION"].ToString()), nuevoNodo);
            }

        }

        private void cargarusuario()
        {
            UsuarioModel usuario = new UsuarioModel();
            
            var Lusuario= usuario.FindByUsuario(txtusuario.Text);


           

            foreach (var item in Lusuario)
            {
                if (item.REQ_CAMBIO_CLAVE1=="S")
                {
                    chbesrequerido.Checked = true;
                }
                else
                {
                    chbesrequerido.Checked = false;
                }

                if (item.ACTIVO1=="S")
                {
                    chbActivo.Checked = true;
                }
                else
                {
                    chbActivo.Checked = false;
                }



                txtLimiteIntentos.Text =  item.MAX_INTENTOS_CONEX1.ToString();
                txtfrecuenciaclave.Text = item.FRECUENCIA_CLAVE1.ToString();
                 dtpUltimoCambio.Value = item.FECHA_ULT_CLAVE1;



            }



        }


        private void LoadUserData()
        {
            //lblUsuario.Text = UserLoginCache.USUARIO;

            this.Text = UserLoginCache.CONJUNTO + "-" + "Privilegios del Usuario";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guardar()
        {
            // MessageBox.Show("AQUI VAMOS INGRESANDO");

            UsuarioModel usuario = new UsuarioModel();

            var  numerousuario = usuario.FindByUsuario(txtusuario.Text);

            var valor= numerousuario.Count();

       
                if (valor==0)
                {
                    
                    //Procedemos a guardar
                    usuario.State = EntityState.Added;
                    usuario.USUARIO1 =  txtusuario.Text;
                    usuario.NOMBRE1 = txtnombre.Text;
                    usuario.ACTIVO1 = chbActivo.Checked ? "S" : "N";
                    usuario.TIPO1 = chbtipoaccesoConsulta.Checked ? "S" : "N";
                    usuario.REQ_CAMBIO_CLAVE1 = chbesrequerido.Checked ? "S" : "N";
                    usuario.FRECUENCIA_CLAVE1 =Convert.ToDecimal(txtfrecuenciaclave.Text);
                    usuario.MAX_INTENTOS_CONEX1 = Convert.ToDecimal(txtLimiteIntentos.Text);
                    usuario.FECHA_ULT_CLAVE1 = dtpUltimoCambio.Value;
                    usuario.CORREO_ELECTRONICO1 = txtcorreo.Text;
                    usuario.TIPO_ACCESO1 = chbprivilegiousuarioadmin.Checked ? "S" : "N";
                    usuario.CELULAR1 = txtcelular.Text;
                    usuario.TIPO_PERSONALIZADO1 = "T";
                usuario.CLAVE1 = "L" + txtusuario.Text;
                    

                bool valid = new Helps.DataValidation(usuario).Validate();
                if (valid == true)
                {
                    string result = usuario.SaveChanges();
                    result = result +" "+ "Clave="+usuario.CLAVE1;
                    MessageBox.Show(result  );
                    usuario.SaveChanges();
                }
                



            }
                else
                {
                    //Procedemos a editar                
                   
                    usuario.State = EntityState.Modified;
                    usuario.USUARIO1 = txtusuario.Text;
                    usuario.NOMBRE1 = txtnombre.Text;
                    usuario.ACTIVO1 = chbActivo.Checked ? "S" : "N";
                    usuario.TIPO1 = chbtipoaccesoConsulta.Checked ? "S" : "N";
                    usuario.REQ_CAMBIO_CLAVE1 = chbesrequerido.Checked ? "S" : "N";
                    usuario.FRECUENCIA_CLAVE1 = Convert.ToDecimal( txtfrecuenciaclave.Text);
                    usuario.MAX_INTENTOS_CONEX1 =Convert.ToDecimal( txtLimiteIntentos.Text);
                    usuario.FECHA_ULT_CLAVE1 = dtpUltimoCambio.Value;
                    usuario.CORREO_ELECTRONICO1 = txtcorreo.Text;
                    usuario.TIPO_ACCESO1 = chbprivilegiousuarioadmin.Checked ? "S" : "N";
                    usuario.CELULAR1 = txtcelular.Text;
                    usuario.TIPO_PERSONALIZADO1 = "T";
                    
                    bool valid = new Helps.DataValidation(usuario).Validate();
                    if (valid == true)
                    {
                        usuario.SaveChanges();
                        string result = usuario.SaveChanges();
                        MessageBox.Show(result);
                       

                    }

                    FormUsuario fusuario = new FormUsuario();


                }

            




           
        }

        private void menuGuardar_Click(object sender, EventArgs e)
        {

            guardar();
        }

        private void txtfrecuenciaclave_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLimiteIntentos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FormPrivilegiosdeUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Si habían mas de una instancia
            if (prev_instances)
            {
                //Obtengo el proceso principal de la primera instancia de mi app
                Process p = Process.GetProcessesByName("WindowsFormsApplication2").Where(it => it.Id != Process.GetCurrentProcess().Id).First();
                //Muestro la ventana
                ShowWindow(p.MainWindowHandle, 1);
                //La activo y la paso a primer plano
                SetForegroundWindow(p.MainWindowHandle);
            }
        }

        private void menuGuardarSalir_Click(object sender, EventArgs e)
        {
            guardar();
            this.Close();

        }

        private void menuEliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            txtusuario.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtusuario_Validated(object sender, EventArgs e)
        {
            UsuarioModel usuario = new UsuarioModel();
            var existeusuario = usuario.FindByUsuario(txtusuario.Text);
            var valor = existeusuario.Count();

            if (valor==1)
            {
                const string message = "Usuario ya Existe";
                const string caption = "Validar Usuario";
                var resultM = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusuario.Focus();

            }
        }

        private void menuNuevo_Click(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            txtnombre.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
