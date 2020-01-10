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

namespace Logistika360.ERP.ERPADMIN.Presentacion.Forms
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            circularProgressBar1.Value += 1;

            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();

                FormMenu mainMenu = new FormMenu();
                mainMenu.Show();
                mainMenu.FormClosed += Logout;
                this.Hide();

            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            FormLogin login = new FormLogin();

            
            login.txtContrasena.Text = "CONTRASEÑA";
          //  login.UseSystemPasswordChar = false;
            login.Text = "USUARIO";
            login.lblErrorMessage.Visible = false;
            login.Show();
            login.txtUsuario.Focus();
        }


        private void FormWelcome_Load(object sender, EventArgs e)
        {
            lblUsername.Text = UserLoginCache.NOMBRE;

            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();
        } 

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
