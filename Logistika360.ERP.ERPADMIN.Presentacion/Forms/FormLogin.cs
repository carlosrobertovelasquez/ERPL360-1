using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Configuration;
using Logistika360.ERP.ERPADMIN.Domain.Models;
using Logistika360.ERP.ERPADMIN.Common.Cache;
using System.Globalization;

namespace Logistika360.ERP.ERPADMIN.Presentacion.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void FormLogin_Load(object sender, EventArgs e)
        {
            string Vals = System.Configuration.ConfigurationManager.AppSettings["conjunto"];
            string[]  tmparray =Vals.Split(',');


            foreach ( string c  in tmparray)
            {
                this.CmbConjunto.Items.Add(c);

            }
            CmbConjunto.Items.Insert(0, "Seleccionar Empresa");
            CmbConjunto.SelectedIndex = 0;

            
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lineShape1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.LightGray;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.DimGray;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO")
            {
                if (txtContrasena.Text != "CONTRASEÑA")
                {

                }
                else
                {
                    msgError("Ingrese el Password");
                    txtContrasena.Clear();
                    txtUsuario.Focus();
                }
                
                if (CmbConjunto.GetItemText(CmbConjunto.SelectedItem) != "Seleccionar Empresa")
                {
                    UsuarioModel user = new UsuarioModel();
                    
                    var ACTIVO = "S";
                    var validarLogin = user.login( txtUsuario.Text, txtContrasena.Text,ACTIVO);
                   

                   if (validarLogin.Count()>0  )
                      
                    {
                                               
                        foreach (var item in validarLogin)
                        {
                            UserLoginCache.USUARIO = item.USUARIO1;
                            UserLoginCache.NOMBRE = item.NOMBRE1;
                            UserLoginCache.CORREO_ELECTRONICO = item.CORREO_ELECTRONICO1;
                            UserLoginCache.CONJUNTO = CmbConjunto.GetItemText(CmbConjunto.SelectedItem);
                        }

                       


                        FormMenu mainMenu = new FormMenu();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Revise sus credeciales");
                    }

                }
                else msgError("Debe selecionar una Empresa");

            }
            else msgError("Ingrese Usuario");   
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "   " + msg;
            lblErrorMessage.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtContrasena.Text = "CONTRASEÑA";
            txtContrasena.UseSystemPasswordChar = false;
            txtUsuario.Text="USUARIO";
            lblErrorMessage.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }
    }
}
