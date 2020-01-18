namespace Logistika360.ERP.AS.Presentacion.FormsPlantillas
{
    partial class FormPlantillaGridSmall
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
            this.menu = new System.Windows.Forms.ToolStrip();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.menuNuevo = new System.Windows.Forms.ToolStripButton();
            this.menuEliminar = new System.Windows.Forms.ToolStripButton();
            this.menuFiltro = new System.Windows.Forms.ToolStripButton();
            this.menuColumnas = new System.Windows.Forms.ToolStripButton();
            this.menuImpresion = new System.Windows.Forms.ToolStripButton();
            this.menuExcel = new System.Windows.Forms.ToolStripButton();
            this.menuAyuda = new System.Windows.Forms.ToolStripButton();
            this.menuRefrescar = new System.Windows.Forms.ToolStripButton();
            this.menuSalir = new System.Windows.Forms.ToolStripButton();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNuevo,
            this.menuEliminar,
            this.menuFiltro,
            this.menuColumnas,
            this.menuImpresion,
            this.menuExcel,
            this.menuAyuda,
            this.menuRefrescar,
            this.menuSalir});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(362, 39);
            this.menu.TabIndex = 0;
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 275);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(362, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 39);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(362, 236);
            this.dgvDatos.TabIndex = 2;
            // 
            // menuNuevo
            // 
            this.menuNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuNuevo.Image = global::Logistika360.ERP.AS.Presentacion.Properties.Resources.Newfile_page_document_empty_6315__1_;
            this.menuNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuNuevo.Name = "menuNuevo";
            this.menuNuevo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuNuevo.Size = new System.Drawing.Size(36, 36);
            this.menuNuevo.Text = "Nuevo";
            this.menuNuevo.Click += new System.EventHandler(this.menuNuevo_Click);
            // 
            // menuEliminar
            // 
            this.menuEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuEliminar.Image = global::Logistika360.ERP.AS.Presentacion.Properties.Resources.document_delete_256_icon_icons_com_75995;
            this.menuEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEliminar.Name = "menuEliminar";
            this.menuEliminar.Size = new System.Drawing.Size(36, 36);
            this.menuEliminar.Text = "Eliminar";
            this.menuEliminar.Click += new System.EventHandler(this.menuEliminar_Click);
            // 
            // menuFiltro
            // 
            this.menuFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuFiltro.Image = global::Logistika360.ERP.AS.Presentacion.Properties.Resources._094filter_99905;
            this.menuFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFiltro.Name = "menuFiltro";
            this.menuFiltro.Size = new System.Drawing.Size(36, 36);
            this.menuFiltro.Text = "Filtrar";
            this.menuFiltro.Click += new System.EventHandler(this.menuFiltro_Click);
            // 
            // menuColumnas
            // 
            this.menuColumnas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuColumnas.Image = global::Logistika360.ERP.AS.Presentacion.Properties.Resources._4_icon_icons_com_68889;
            this.menuColumnas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuColumnas.Name = "menuColumnas";
            this.menuColumnas.Size = new System.Drawing.Size(36, 36);
            this.menuColumnas.Text = "Columnas";
            this.menuColumnas.Click += new System.EventHandler(this.menuColumnas_Click);
            // 
            // menuImpresion
            // 
            this.menuImpresion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuImpresion.Image = global::Logistika360.ERP.AS.Presentacion.Properties.Resources.actions_document_print_15785;
            this.menuImpresion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuImpresion.Name = "menuImpresion";
            this.menuImpresion.Size = new System.Drawing.Size(36, 36);
            this.menuImpresion.Text = "Impresion";
            this.menuImpresion.Click += new System.EventHandler(this.menuImpresion_Click);
            // 
            // menuExcel
            // 
            this.menuExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuExcel.Image = global::Logistika360.ERP.AS.Presentacion.Properties.Resources._1486565571_microsoft_office_excel_81549;
            this.menuExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuExcel.Name = "menuExcel";
            this.menuExcel.Size = new System.Drawing.Size(36, 36);
            this.menuExcel.Text = "Excel";
            this.menuExcel.Click += new System.EventHandler(this.menuExcel_Click);
            // 
            // menuAyuda
            // 
            this.menuAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuAyuda.Image = global::Logistika360.ERP.AS.Presentacion.Properties.Resources.Help_icon_icons_com_73700__1_;
            this.menuAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(36, 36);
            this.menuAyuda.Text = "Ayuda";
            this.menuAyuda.Click += new System.EventHandler(this.menuAyuda_Click);
            // 
            // menuRefrescar
            // 
            this.menuRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuRefrescar.Image = global::Logistika360.ERP.AS.Presentacion.Properties.Resources.refresh_17814;
            this.menuRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuRefrescar.Name = "menuRefrescar";
            this.menuRefrescar.Size = new System.Drawing.Size(36, 36);
            this.menuRefrescar.Text = "Refrescar";
            this.menuRefrescar.Click += new System.EventHandler(this.menuRefrescar_Click);
            // 
            // menuSalir
            // 
            this.menuSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuSalir.Image = global::Logistika360.ERP.AS.Presentacion.Properties.Resources.sign_emergency_code_sos_63_icon_icons_com_57219;
            this.menuSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(36, 36);
            this.menuSalir.Text = "Salir";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // FormPlantillaGridSmall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 297);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menu);
            this.Name = "FormPlantillaGridSmall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPlantillaGridSmall";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton menuSalir;
        public System.Windows.Forms.ToolStrip menu;
        public System.Windows.Forms.ToolStripButton menuNuevo;
        public System.Windows.Forms.ToolStripButton menuEliminar;
        public System.Windows.Forms.ToolStripButton menuFiltro;
        public System.Windows.Forms.ToolStripButton menuColumnas;
        public System.Windows.Forms.ToolStripButton menuImpresion;
        public System.Windows.Forms.ToolStripButton menuExcel;
        public System.Windows.Forms.ToolStripButton menuAyuda;
        public System.Windows.Forms.ToolStripButton menuRefrescar;
        public System.Windows.Forms.StatusStrip statusBar;
        public System.Windows.Forms.DataGridView dgvDatos;
    }
}