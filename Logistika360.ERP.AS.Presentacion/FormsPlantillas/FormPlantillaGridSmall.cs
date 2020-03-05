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
        public virtual void Editar()
        {

        }

        public virtual Boolean Guardar()
        {
            return false;
        }

        public virtual void Cargargrid()
        {

        }

        public virtual void Excel( DataGridView dgvDatos)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog()==DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application application;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                application = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = application.Workbooks.Add();
                hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el datagridView rellenado la hoka de trabajo
                for (int i = 0; i < dgvDatos.Rows.Count-1; i++)
                {
                    for (int j = 0; j < dgvDatos.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = dgvDatos.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                application.Quit();

            }
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
            Excel(dgvDatos);
        }

        private void menuAyuda_Click(object sender, EventArgs e)
        {
            Ayuda();
        }

        private void menuRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
    }
}
