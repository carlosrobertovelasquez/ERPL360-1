using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logistika360.ERP.AS.Presentacion.FormsPlantillas
{
    public partial class FormPlantillaMantenimientoSmall : Form
    {
        public FormPlantillaMantenimientoSmall()
        {
            InitializeComponent();
        }
        public virtual void Nuevo()
        {

        }
        public virtual void Guardar()
        {

        }
        public virtual void GuardarSalir()
        {

        }
        public virtual void Deshacer()
        {

        }
        public virtual void Eliminar()
        {

        }
        public virtual void Ultimo()
        {

        }
        public virtual void Anterior()
        {

        }
        public virtual void Siguiente()
        {

        }
        public virtual void Primero()
        {

        }
        public virtual void Adjunto()
        {

        }
        public virtual void Ayuda()
        {

        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void menuGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            GuardarSalir();
        }

        private void menuDeshacer_Click(object sender, EventArgs e)
        {
            Deshacer();
        }

        private void menuPrimero_Click(object sender, EventArgs e)
        {
            Primero();
        }

        private void menuAnterior_Click(object sender, EventArgs e)
        {
            Anterior();
        }

        private void menuSiguiente_Click(object sender, EventArgs e)
        {
            Siguiente();
        }

        private void menuUltimo_Click(object sender, EventArgs e)
        {
            Ultimo();
        }

        private void menuAdjunto_Click(object sender, EventArgs e)
        {
            Adjunto();
        }

        private void menuAyuda_Click(object sender, EventArgs e)
        {
            Ayuda();
        }
    }
}
