namespace Logistika360.ERP.ERPADMIN.Presentacion.Forms
{
    partial class FomPlatillagrid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuNuevo = new System.Windows.Forms.ToolStripButton();
            this.menuEliminar = new System.Windows.Forms.ToolStripButton();
            this.menuFiltro = new System.Windows.Forms.ToolStripButton();
            this.menuBarra = new System.Windows.Forms.ToolStripButton();
            this.menuImpresion = new System.Windows.Forms.ToolStripButton();
            this.menuExcel = new System.Windows.Forms.ToolStripButton();
            this.menuAyuda = new System.Windows.Forms.ToolStripButton();
            this.menuRefrescar = new System.Windows.Forms.ToolStripButton();
            this.menuSalir = new System.Windows.Forms.ToolStripButton();
            this.dwgDatos = new System.Windows.Forms.DataGridView();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dwgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNuevo,
            this.menuEliminar,
            this.menuFiltro,
            this.menuBarra,
            this.menuImpresion,
            this.menuExcel,
            this.menuAyuda,
            this.menuRefrescar,
            this.menuSalir});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(438, 39);
            this.Menu.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.statusStrip1.Location = new System.Drawing.Point(0, 281);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(438, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuNuevo
            // 
            this.menuNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuNuevo.Image = global::Logistika360.ERP.ERPADMIN.Presentacion.Properties.Resources.Newfile_page_document_empty_6315__1_;
            this.menuNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuNuevo.Name = "menuNuevo";
            this.menuNuevo.Size = new System.Drawing.Size(36, 36);
            this.menuNuevo.Text = "Nuevo";
            // 
            // menuEliminar
            // 
            this.menuEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuEliminar.Image = global::Logistika360.ERP.ERPADMIN.Presentacion.Properties.Resources.document_delete_256_icon_icons_com_75995;
            this.menuEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEliminar.Name = "menuEliminar";
            this.menuEliminar.Size = new System.Drawing.Size(36, 36);
            this.menuEliminar.Text = "Eliminar";
            // 
            // menuFiltro
            // 
            this.menuFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuFiltro.Image = global::Logistika360.ERP.ERPADMIN.Presentacion.Properties.Resources._094filter_99905;
            this.menuFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFiltro.Name = "menuFiltro";
            this.menuFiltro.Size = new System.Drawing.Size(36, 36);
            this.menuFiltro.Text = "Filtar";
            // 
            // menuBarra
            // 
            this.menuBarra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuBarra.Image = global::Logistika360.ERP.ERPADMIN.Presentacion.Properties.Resources._4_icon_icons_com_68889;
            this.menuBarra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuBarra.Name = "menuBarra";
            this.menuBarra.Size = new System.Drawing.Size(36, 36);
            this.menuBarra.Text = "Barra";
            // 
            // menuImpresion
            // 
            this.menuImpresion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuImpresion.Image = global::Logistika360.ERP.ERPADMIN.Presentacion.Properties.Resources.actions_document_print_15785;
            this.menuImpresion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuImpresion.Name = "menuImpresion";
            this.menuImpresion.Size = new System.Drawing.Size(36, 36);
            this.menuImpresion.Text = "Impresion";
            // 
            // menuExcel
            // 
            this.menuExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuExcel.Image = global::Logistika360.ERP.ERPADMIN.Presentacion.Properties.Resources._1486565571_microsoft_office_excel_81549;
            this.menuExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuExcel.Name = "menuExcel";
            this.menuExcel.Size = new System.Drawing.Size(36, 36);
            this.menuExcel.Text = "Excel";
            // 
            // menuAyuda
            // 
            this.menuAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuAyuda.Image = global::Logistika360.ERP.ERPADMIN.Presentacion.Properties.Resources.Help_icon_icons_com_73700__1_;
            this.menuAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(36, 36);
            this.menuAyuda.Text = "Ayuda";
            // 
            // menuRefrescar
            // 
            this.menuRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuRefrescar.Image = global::Logistika360.ERP.ERPADMIN.Presentacion.Properties.Resources.refresh_17814;
            this.menuRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuRefrescar.Name = "menuRefrescar";
            this.menuRefrescar.Size = new System.Drawing.Size(36, 36);
            this.menuRefrescar.Text = "Refrescar";
            // 
            // menuSalir
            // 
            this.menuSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuSalir.Image = global::Logistika360.ERP.ERPADMIN.Presentacion.Properties.Resources.sign_emergency_code_sos_63_icon_icons_com_57219;
            this.menuSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(36, 36);
            this.menuSalir.Text = "Salir";
            // 
            // dwgDatos
            // 
            this.dwgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwgDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dwgDatos.Location = new System.Drawing.Point(0, 39);
            this.dwgDatos.Name = "dwgDatos";
            this.dwgDatos.Size = new System.Drawing.Size(438, 242);
            this.dwgDatos.TabIndex = 2;
            // 
            // FomPlatillagrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(438, 303);
            this.Controls.Add(this.dwgDatos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FomPlatillagrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FomPlatillagrid";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dwgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripButton menuNuevo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton menuEliminar;
        private System.Windows.Forms.ToolStripButton menuFiltro;
        private System.Windows.Forms.ToolStripButton menuBarra;
        private System.Windows.Forms.ToolStripButton menuImpresion;
        private System.Windows.Forms.ToolStripButton menuExcel;
        private System.Windows.Forms.ToolStripButton menuAyuda;
        private System.Windows.Forms.ToolStripButton menuRefrescar;
        private System.Windows.Forms.ToolStripButton menuSalir;
        private System.Windows.Forms.DataGridView dwgDatos;
    }
}