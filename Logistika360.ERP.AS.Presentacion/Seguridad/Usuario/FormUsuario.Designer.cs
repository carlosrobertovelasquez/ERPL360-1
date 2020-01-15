namespace Logistika360.ERP.AS.Presentacion.Seguridad.Usuario
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuSuperior = new System.Windows.Forms.ToolStrip();
            this.MenuSuperiorNuevo = new System.Windows.Forms.ToolStripButton();
            this.MenuSuperiorEditar = new System.Windows.Forms.ToolStripButton();
            this.MenuSuperiorEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSuperiorFiltar = new System.Windows.Forms.ToolStripButton();
            this.MenuSuperiorBarras = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSuperiorImpresion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSuperiorExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSuperiorAyuda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSuperiorRefrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSuperiorSalir = new System.Windows.Forms.ToolStripButton();
            this.dwgUsuarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dwgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuSuperior
            // 
            this.MenuSuperior.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MenuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSuperiorNuevo,
            this.MenuSuperiorEditar,
            this.MenuSuperiorEliminar,
            this.toolStripSeparator1,
            this.MenuSuperiorFiltar,
            this.MenuSuperiorBarras,
            this.toolStripSeparator2,
            this.MenuSuperiorImpresion,
            this.toolStripSeparator3,
            this.MenuSuperiorExcel,
            this.toolStripSeparator4,
            this.MenuSuperiorAyuda,
            this.toolStripSeparator5,
            this.MenuSuperiorRefrescar,
            this.toolStripSeparator6,
            this.MenuSuperiorSalir});
            this.MenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.MenuSuperior.Name = "MenuSuperior";
            this.MenuSuperior.Size = new System.Drawing.Size(434, 39);
            this.MenuSuperior.TabIndex = 0;
            this.MenuSuperior.Text = "toolStrip1";
            this.MenuSuperior.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuSuperior_ItemClicked);
            // 
            // MenuSuperiorNuevo
            // 
            this.MenuSuperiorNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuSuperiorNuevo.Image = ((System.Drawing.Image)(resources.GetObject("MenuSuperiorNuevo.Image")));
            this.MenuSuperiorNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuSuperiorNuevo.Name = "MenuSuperiorNuevo";
            this.MenuSuperiorNuevo.Size = new System.Drawing.Size(36, 36);
            this.MenuSuperiorNuevo.Text = "Nuevo";
            this.MenuSuperiorNuevo.ToolTipText = "Nuevo";
            this.MenuSuperiorNuevo.Click += new System.EventHandler(this.MenuSuperiorNuevo_Click);
            // 
            // MenuSuperiorEditar
            // 
            this.MenuSuperiorEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuSuperiorEditar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSuperiorEditar.Image")));
            this.MenuSuperiorEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuSuperiorEditar.Name = "MenuSuperiorEditar";
            this.MenuSuperiorEditar.Size = new System.Drawing.Size(36, 36);
            this.MenuSuperiorEditar.Text = "Editar";
            // 
            // MenuSuperiorEliminar
            // 
            this.MenuSuperiorEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuSuperiorEliminar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSuperiorEliminar.Image")));
            this.MenuSuperiorEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuSuperiorEliminar.Name = "MenuSuperiorEliminar";
            this.MenuSuperiorEliminar.Size = new System.Drawing.Size(36, 36);
            this.MenuSuperiorEliminar.Text = "Eliminar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // MenuSuperiorFiltar
            // 
            this.MenuSuperiorFiltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuSuperiorFiltar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSuperiorFiltar.Image")));
            this.MenuSuperiorFiltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuSuperiorFiltar.Name = "MenuSuperiorFiltar";
            this.MenuSuperiorFiltar.Size = new System.Drawing.Size(36, 36);
            this.MenuSuperiorFiltar.Text = "Filtro";
            // 
            // MenuSuperiorBarras
            // 
            this.MenuSuperiorBarras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuSuperiorBarras.Image = ((System.Drawing.Image)(resources.GetObject("MenuSuperiorBarras.Image")));
            this.MenuSuperiorBarras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuSuperiorBarras.Name = "MenuSuperiorBarras";
            this.MenuSuperiorBarras.Size = new System.Drawing.Size(36, 36);
            this.MenuSuperiorBarras.Text = "Mostar Columnas";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // MenuSuperiorImpresion
            // 
            this.MenuSuperiorImpresion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuSuperiorImpresion.Image = ((System.Drawing.Image)(resources.GetObject("MenuSuperiorImpresion.Image")));
            this.MenuSuperiorImpresion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuSuperiorImpresion.Name = "MenuSuperiorImpresion";
            this.MenuSuperiorImpresion.Size = new System.Drawing.Size(36, 36);
            this.MenuSuperiorImpresion.Text = "Imprimir";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // MenuSuperiorExcel
            // 
            this.MenuSuperiorExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuSuperiorExcel.Image = ((System.Drawing.Image)(resources.GetObject("MenuSuperiorExcel.Image")));
            this.MenuSuperiorExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuSuperiorExcel.Name = "MenuSuperiorExcel";
            this.MenuSuperiorExcel.Size = new System.Drawing.Size(36, 36);
            this.MenuSuperiorExcel.Text = "Excel";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // MenuSuperiorAyuda
            // 
            this.MenuSuperiorAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuSuperiorAyuda.Image = ((System.Drawing.Image)(resources.GetObject("MenuSuperiorAyuda.Image")));
            this.MenuSuperiorAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuSuperiorAyuda.Name = "MenuSuperiorAyuda";
            this.MenuSuperiorAyuda.Size = new System.Drawing.Size(36, 36);
            this.MenuSuperiorAyuda.Text = "Ayuda";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // MenuSuperiorRefrescar
            // 
            this.MenuSuperiorRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuSuperiorRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSuperiorRefrescar.Image")));
            this.MenuSuperiorRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuSuperiorRefrescar.Name = "MenuSuperiorRefrescar";
            this.MenuSuperiorRefrescar.Size = new System.Drawing.Size(36, 36);
            this.MenuSuperiorRefrescar.Text = "Refrescar";
            this.MenuSuperiorRefrescar.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // MenuSuperiorSalir
            // 
            this.MenuSuperiorSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuSuperiorSalir.Image = ((System.Drawing.Image)(resources.GetObject("MenuSuperiorSalir.Image")));
            this.MenuSuperiorSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuSuperiorSalir.Name = "MenuSuperiorSalir";
            this.MenuSuperiorSalir.Size = new System.Drawing.Size(36, 36);
            this.MenuSuperiorSalir.Text = "Regresar";
            this.MenuSuperiorSalir.Click += new System.EventHandler(this.MenuSuperiorSalir_Click);
            // 
            // dwgUsuarios
            // 
            this.dwgUsuarios.AllowUserToAddRows = false;
            this.dwgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dwgUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dwgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            this.dwgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dwgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dwgUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dwgUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dwgUsuarios.EnableHeadersVisualStyles = false;
            this.dwgUsuarios.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dwgUsuarios.Location = new System.Drawing.Point(0, 39);
            this.dwgUsuarios.Name = "dwgUsuarios";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dwgUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dwgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dwgUsuarios.Size = new System.Drawing.Size(434, 237);
            this.dwgUsuarios.TabIndex = 1;
            this.dwgUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dwgUsuarios_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Usuario";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Activo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Correo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Celular";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 276);
            this.Controls.Add(this.dwgUsuarios);
            this.Controls.Add(this.MenuSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.MenuSuperior.ResumeLayout(false);
            this.MenuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dwgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MenuSuperior;
        private System.Windows.Forms.ToolStripButton MenuSuperiorNuevo;
        private System.Windows.Forms.ToolStripButton MenuSuperiorEditar;
        private System.Windows.Forms.ToolStripButton MenuSuperiorEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton MenuSuperiorFiltar;
        private System.Windows.Forms.ToolStripButton MenuSuperiorBarras;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton MenuSuperiorImpresion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton MenuSuperiorExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton MenuSuperiorAyuda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton MenuSuperiorRefrescar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton MenuSuperiorSalir;
        private System.Windows.Forms.DataGridView dwgUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}