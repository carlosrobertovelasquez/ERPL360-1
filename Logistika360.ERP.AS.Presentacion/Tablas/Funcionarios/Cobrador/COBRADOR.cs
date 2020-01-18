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
namespace Logistika360.ERP.AS.Presentacion.Tablas.Funcionarios.Cobrador
{
    public partial class COBRADOR : FormPlantillaGridSmall
    {
        public COBRADOR()
        {
            InitializeComponent();
        }

        private void COBRADOR_Load(object sender, EventArgs e)
        {
            this.Text = UserLoginCache.CONJUNTO + " " + "Cobrador";
        }
    }
}
