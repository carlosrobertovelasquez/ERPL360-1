using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logistika360.ERP.AS.Presentacion.Administracion
{
    public partial class GLOBALES : Form
    {
        public GLOBALES()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtpais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F1)
            {
                MessageBox.Show("Aqui vamos");
            }
        }
    }
}
