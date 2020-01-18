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
namespace Logistika360.ERP.AS.Presentacion.FormsPlantillas
{
    public partial class FormPlantillaGridSmall : Form
    {
        public FormPlantillaGridSmall()
        {
            InitializeComponent();
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void Borrar()
        {

        }
        public virtual void Nuevo()
        {

        }
        public virtual void Consultar()
        {

        }

        public virtual Boolean Guardar()
        {
            return false;
        }

        public virtual void Cargargrid()
        {

        }

        public virtual void Excel()
        {

        }
        public virtual void Refrescar()
        {

        }
        public virtual void Imprimir()
        {

        }
        public virtual void Barras()
        {

        }
        public virtual void Filtro()
        {

        }
        public virtual void Ayuda()
        {

        }

        private void menuNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void menuEliminar_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        private void menuFiltro_Click(object sender, EventArgs e)
        {
            Filtro();
        }

        private void menuColumnas_Click(object sender, EventArgs e)
        {
            Barras();
        }

        private void menuImpresion_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void menuExcel_Click(object sender, EventArgs e)
        {
            Excel();
        }

        private void menuAyuda_Click(object sender, EventArgs e)
        {
            Ayuda();
        }

        private void menuRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }
    }
}
