using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FontAwesome;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Logistika360.ERP.ERPADMIN.Common.Cache;
using Logistika360.ERP.ERPADMIN.Domain.Models;
using Logistika360.ERP.AS.Presentacion.Forms;
using Logistika360.ERP.AS.Presentacion.Seguridad.Usuario;
using Logistika360.ERP.AS.Presentacion.Tablas.Funcionarios.Vendedor;
using Logistika360.ERP.AS.Presentacion.Tablas;
using Logistika360.ERP.AS.Presentacion.Tablas.Funcionarios.Cobrador;
using Logistika360.ERP.AS.Presentacion.Tablas.Otros.Bodega;
using Logistika360.ERP.AS.Presentacion.Tablas.Tipos.Moneda;
using Logistika360.ERP.AS.Presentacion.Administracion;

namespace Logistika360.ERP.ERPADMIN.Presentacion.Forms
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 67;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconocerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconomaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconorestaurar.Visible = true;
            iconomaximizar.Visible = false;
        }

        private void iconorestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconorestaurar.Visible = false;
            iconomaximizar.Visible = true;
        }

        private void iconominimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelDetalleMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormInPanel(object Fromhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
                Form fh = Fromhijo as Form;
                fh.TopLevel = false;
               this.panelContenedor.Controls.Add(fh);
               this.panelContenedor.Tag = fh;
               fh.Location = new Point((panelContenedor.Width - fh.Width) / 2, (panelContenedor.Height - fh.Height) / 2);
               fh.Show();
          }

        private void btnAS_Click(object sender, EventArgs e)
        {
          //  AbrirFormInPanel(new AS.Usuario.FormUsuario());
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de cerrar seccion?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoadUserData()
        {
            lblUsuario.Text = UserLoginCache.USUARIO;   
            lblConjunto.Text = UserLoginCache.CONJUNTO;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            LoadUserData();
            agregarMenu();
        }

        private void agregarMenu()
        {
             int valorInicial = 0;
            int valorAncho = 22;
            ModuloInstaladoModel modulos = new ModuloInstaladoModel();
            var ModulosInstalados = modulos.modulos(UserLoginCache.CONJUNTO,UserLoginCache.USUARIO);

            foreach (var item in ModulosInstalados)
            {
                valorInicial = valorInicial + valorAncho;
                var NombreBoton = "btn" + item.NOMBRECONSTANTE;
          
                Button btnCG = new Button();
                btnCG.FlatAppearance.BorderSize = 0;
                btnCG.Cursor = System.Windows.Forms.Cursors.Hand;
                btnCG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
                btnCG.FlatStyle = System.Windows.Forms.FlatStyle.System;
                btnCG.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnCG.ForeColor = System.Drawing.Color.White;
                btnCG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btnCG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btnCG.Size = new System.Drawing.Size(312, 30);
                btnCG.Location = new System.Drawing.Point(-1, valorInicial);
                btnCG.Name = NombreBoton;
                btnCG.TabIndex = 7;
                btnCG.Text = item.NOMBREACCION;
                btnCG.UseVisualStyleBackColor = true;
                Label accion = new Label();
                Label nombreModulo = new Label();
                panelBotones.Controls.Add(accion);
                panelBotones.Controls.Add(nombreModulo);
                accion.Text = item.ACCION;
                nombreModulo.Text = item.NOMBREACCION;
                btnCG.Click += new System.EventHandler((sender1,e1) => btnFA_Click(sender1,e1,accion.Text,nombreModulo.Text));      
                panelBotones.Controls.Add(btnCG);
            }
        }

        private void PanelCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lbfecha.Text = DateTime.Now.ToString("dddd:MMMM:yyyy");
        }

        private void btnFA_Click(object sender1, EventArgs e1, string accion,string nombreModulo)
        {
            treeMenu.Nodes.Clear();
            btnnombreModulo.Text = "";
            
            btnnombreModulo.Visible = true;
            btnnombreModulo.Text = nombreModulo;
            var _accion = accion;
            CrearNodoDelPadre(Int32.Parse(_accion),null);
            treeMenu.Nodes.Add("", "Acerca de ...",imageIndex:2,selectedImageIndex:2);
        }

        private void CrearNodoDelPadre(int indicePadre,TreeNode nodoPadre)
        {

            ParentescoModel padres = new ParentescoModel();
            DataTable dtsN = padres.Nodos();
            DataView  dataViewHijos =new DataView  (dtsN);
            dataViewHijos.RowFilter = dtsN.Columns["PADRE"].ColumnName + "=" + indicePadre;

            foreach (DataRowView dataRowCurrent in dataViewHijos)
            {
                TreeNode nuevoNodo = new TreeNode();
                nuevoNodo.Text = dataRowCurrent["NOMBREACCION"].ToString().Trim();
                nuevoNodo.Name = dataRowCurrent["ACCION"].ToString().Trim();
                nuevoNodo.Tag= dataRowCurrent["NOMBRECONSTANTE"].ToString().Trim();
                nuevoNodo.ImageIndex = 0;
                nuevoNodo.SelectedImageIndex = 1;
                if (nodoPadre == null)
                {
                    treeMenu.Nodes.Add(nuevoNodo);
                }
                else
                {
                    nodoPadre.Nodes.Add(nuevoNodo);
                }
                CrearNodoDelPadre(Int32.Parse(dataRowCurrent["ACCION"].ToString()), nuevoNodo);   
            }
            

        }

        private void panelBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFA_Click_1(object sender, EventArgs e)
        {

        }

        private void treeMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void treeMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            string constante;
            string accion;

          //  accion = treeMenu.SelectedNode.Name;
            constante = e.Node.Tag.ToString();
            PrivilegioEXModel privilegioEX = new PrivilegioEXModel();
            var privilegiosex = privilegioEX.FindByUsuario(UserLoginCache.USUARIO, UserLoginCache.CONJUNTO, constante);

            var llamarformulario = privilegiosex.Count();

          if (llamarformulario == 1)
            {
                switch (constante)
                {
                    case "AS_VENDEDORES":
                        AbrirFormInPanel(new Vendedores());

                        break;
                    case "AS_COBRADOR":
                        AbrirFormInPanel(new COBRADOR());
                        break;
                    case "AS_GLOBALES":

                        AbrirFormInPanel(new GLOBALES());
                        break;
                    case "AS_SISGLOBALES":
                        AbrirFormInPanel(new SISGLOBALES());
                        break;
                    case "AS_PAISES":
                        AbrirFormInPanel(new Pais());
                       break;
                    case "AS_ZONAS":
                        AbrirFormInPanel(new Zona());
                        break;
                    case "AS_RUTAS":
                        AbrirFormInPanel(new Ruta());
                        break;
                    case "AS_CENTRO_COSTO":
                        AbrirFormInPanel(new CentroCosto());
                        break;
                    case "AS_BODEGAS":
                        AbrirFormInPanel(new Bodega());
                        break;
                    case "AS_MONEDAS":
                        AbrirFormInPanel(new Moneda());
                        break;
                }

                
                //AbrirFormInPanel(new AS_VENDEDORES());

                //AbrirFormInPanel(new FormUsuario());
            }
            else
            {
                MessageBox.Show("No tiene privilegios en este Opcion");
            }







        }

        private void treeMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {


             ////if (this.panelContenedor.Controls.Count > 0)
            ////    this.panelContenedor.Controls.RemoveAt(0);
            ////FormUsuario form = Application.OpenForms.OfType<FormUsuario>().FirstOrDefault();
            ////FormUsuario fr = new FormUsuario();
            ////fr.TopLevel = false;
            ////this.panelContenedor.Controls.Add(fr);
            ////this.panelContenedor.Tag = fr;
            ////fr.BringToFront();
            ////fr.Location = new Point((panelContenedor.Width - fr.Width) / 2, (panelContenedor.Height - fr.Height) / 2);
            ////fr.Show();





            //string constante;
            //string accion;

            //accion = treeMenu.SelectedNode.Name;
            //constante = e.Node.Tag.ToString();
            //PrivilegioEXModel privilegioEX = new PrivilegioEXModel();
            //var privilegiosex = privilegioEX.FindByUsuario(UserLoginCache.USUARIO, UserLoginCache.CONJUNTO,constante);

            //var llamarformulario = privilegiosex.Count();

            //MessageBox.Show(constante);

            //const string AS_VENDEDORES = "Vendedores";

            //Form fr = new Form();



            //AbrirFormInPanel(new AS_VENDEDORES());



            //if (llamarformulario==1)
            //{
            //    switch (constante)
            //    {
            //        case "AS_VENDEDORES":
            //            AbrirFormInPanel(new Vendedores());

            //            break;
            //        case "AS_COBRADOR":
            //            AbrirFormInPanel(new COBRADOR());
            //            break;
            //        case "AS_GLOBALES":

            //            AbrirFormInPanel(new GLOBALES());
            //            break;
            //        case "AS_SISGLOBALES":
            //            AbrirFormInPanel(new SISGLOBALES());

            //            break;

            //    }
            //     //AbrirFormInPanel(new AS_VENDEDORES());

            //    //AbrirFormInPanel(new FormUsuario());
            //}


            //AbrirFormInPanel(new Vendedores());










        }

       

    }
}
