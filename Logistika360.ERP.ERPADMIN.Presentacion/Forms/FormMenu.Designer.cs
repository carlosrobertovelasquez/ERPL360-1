namespace Logistika360.ERP.ERPADMIN.Presentacion.Forms
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnnombreModulo = new System.Windows.Forms.Button();
            this.treeMenu = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnFAAA = new System.Windows.Forms.Button();
            this.btnCerrarSeccion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lblConjunto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.iconorestaurar = new System.Windows.Forms.PictureBox();
            this.iconomaximizar = new System.Windows.Forms.PictureBox();
            this.iconominimizar = new System.Windows.Forms.PictureBox();
            this.iconocerrar = new System.Windows.Forms.PictureBox();
            this.btnslide = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lbfecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconorestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconomaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconominimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconocerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.btnFAAA);
            this.MenuVertical.Controls.Add(this.btnnombreModulo);
            this.MenuVertical.Controls.Add(this.treeMenu);
            this.MenuVertical.Controls.Add(this.panelBotones);
            this.MenuVertical.Controls.Add(this.btnCerrarSeccion);
            this.MenuVertical.Controls.Add(this.pictureBox2);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(312, 650);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // btnnombreModulo
            // 
            this.btnnombreModulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnnombreModulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnombreModulo.Location = new System.Drawing.Point(-3, 65);
            this.btnnombreModulo.Name = "btnnombreModulo";
            this.btnnombreModulo.Size = new System.Drawing.Size(317, 30);
            this.btnnombreModulo.TabIndex = 3;
            this.btnnombreModulo.Text = "nombremodulo";
            this.btnnombreModulo.UseVisualStyleBackColor = true;
            this.btnnombreModulo.Visible = false;
            // 
            // treeMenu
            // 
            this.treeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.treeMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeMenu.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeMenu.FullRowSelect = true;
            this.treeMenu.ImageIndex = 0;
            this.treeMenu.ImageList = this.imageList1;
            this.treeMenu.Location = new System.Drawing.Point(4, 97);
            this.treeMenu.Name = "treeMenu";
            this.treeMenu.SelectedImageIndex = 0;
            this.treeMenu.Size = new System.Drawing.Size(306, 248);
            this.treeMenu.TabIndex = 3;
            this.treeMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeMenu_AfterSelect);
            this.treeMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeMenu_NodeMouseClick);
            this.treeMenu.Click += new System.EventHandler(this.treeMenu_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_Closed_16xLG.png");
            this.imageList1.Images.SetKeyName(1, "folder_Open_16xLG.png");
            this.imageList1.Images.SetKeyName(2, "callout_16xLG.png");
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBotones.AutoScroll = true;
            this.panelBotones.Location = new System.Drawing.Point(0, 341);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(312, 255);
            this.panelBotones.TabIndex = 3;
            this.panelBotones.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBotones_Paint);
            // 
            // btnFAAA
            // 
            this.btnFAAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFAAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFAAA.Enabled = false;
            this.btnFAAA.FlatAppearance.BorderSize = 0;
            this.btnFAAA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnFAAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFAAA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFAAA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFAAA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFAAA.Location = new System.Drawing.Point(3, 321);
            this.btnFAAA.Name = "btnFAAA";
            this.btnFAAA.Size = new System.Drawing.Size(304, 34);
            this.btnFAAA.TabIndex = 7;
            this.btnFAAA.Text = "Modulos Instalados";
            this.btnFAAA.UseVisualStyleBackColor = false;
            this.btnFAAA.Click += new System.EventHandler(this.btnFA_Click_1);
            // 
            // btnCerrarSeccion
            // 
            this.btnCerrarSeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrarSeccion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSeccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCerrarSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSeccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSeccion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSeccion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSeccion.Image")));
            this.btnCerrarSeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSeccion.Location = new System.Drawing.Point(0, 610);
            this.btnCerrarSeccion.Name = "btnCerrarSeccion";
            this.btnCerrarSeccion.Size = new System.Drawing.Size(309, 40);
            this.btnCerrarSeccion.TabIndex = 3;
            this.btnCerrarSeccion.Text = "Cerrar Sección";
            this.btnCerrarSeccion.UseVisualStyleBackColor = true;
            this.btnCerrarSeccion.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(310, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(152)))), ((int)(((byte)(29)))));
            this.BarraTitulo.Controls.Add(this.lblConjunto);
            this.BarraTitulo.Controls.Add(this.label2);
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Controls.Add(this.lblUsuario);
            this.BarraTitulo.Controls.Add(this.iconorestaurar);
            this.BarraTitulo.Controls.Add(this.iconomaximizar);
            this.BarraTitulo.Controls.Add(this.iconominimizar);
            this.BarraTitulo.Controls.Add(this.iconocerrar);
            this.BarraTitulo.Controls.Add(this.btnslide);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(312, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(988, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // lblConjunto
            // 
            this.lblConjunto.AutoSize = true;
            this.lblConjunto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConjunto.Location = new System.Drawing.Point(446, 21);
            this.lblConjunto.Name = "lblConjunto";
            this.lblConjunto.Size = new System.Drawing.Size(98, 19);
            this.lblConjunto.TabIndex = 7;
            this.lblConjunto.Text = "lblConjunto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "EMPRESA :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIO :";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(232, 21);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(84, 19);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "lblUsuario";
            this.lblUsuario.Click += new System.EventHandler(this.label3_Click);
            // 
            // iconorestaurar
            // 
            this.iconorestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconorestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconorestaurar.Image = ((System.Drawing.Image)(resources.GetObject("iconorestaurar.Image")));
            this.iconorestaurar.Location = new System.Drawing.Point(907, 15);
            this.iconorestaurar.Name = "iconorestaurar";
            this.iconorestaurar.Size = new System.Drawing.Size(25, 25);
            this.iconorestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconorestaurar.TabIndex = 3;
            this.iconorestaurar.TabStop = false;
            this.iconorestaurar.Visible = false;
            this.iconorestaurar.Click += new System.EventHandler(this.iconorestaurar_Click);
            // 
            // iconomaximizar
            // 
            this.iconomaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconomaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconomaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconomaximizar.Image")));
            this.iconomaximizar.Location = new System.Drawing.Point(906, 11);
            this.iconomaximizar.Name = "iconomaximizar";
            this.iconomaximizar.Size = new System.Drawing.Size(25, 25);
            this.iconomaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconomaximizar.TabIndex = 2;
            this.iconomaximizar.TabStop = false;
            this.iconomaximizar.Click += new System.EventHandler(this.iconomaximizar_Click);
            // 
            // iconominimizar
            // 
            this.iconominimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconominimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconominimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconominimizar.Image")));
            this.iconominimizar.Location = new System.Drawing.Point(877, 11);
            this.iconominimizar.Name = "iconominimizar";
            this.iconominimizar.Size = new System.Drawing.Size(25, 25);
            this.iconominimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconominimizar.TabIndex = 1;
            this.iconominimizar.TabStop = false;
            this.iconominimizar.Click += new System.EventHandler(this.iconominimizar_Click);
            // 
            // iconocerrar
            // 
            this.iconocerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconocerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconocerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconocerrar.Image")));
            this.iconocerrar.Location = new System.Drawing.Point(937, 11);
            this.iconocerrar.Name = "iconocerrar";
            this.iconocerrar.Size = new System.Drawing.Size(25, 25);
            this.iconocerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconocerrar.TabIndex = 0;
            this.iconocerrar.TabStop = false;
            this.iconocerrar.Click += new System.EventHandler(this.iconocerrar_Click);
            // 
            // btnslide
            // 
            this.btnslide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnslide.Image = ((System.Drawing.Image)(resources.GetObject("btnslide.Image")));
            this.btnslide.Location = new System.Drawing.Point(6, 9);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(35, 35);
            this.btnslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnslide.TabIndex = 0;
            this.btnslide.TabStop = false;
            this.btnslide.Click += new System.EventHandler(this.btnslide_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelContenedor.Controls.Add(this.lbfecha);
            this.panelContenedor.Controls.Add(this.lblHora);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContenedor.ForeColor = System.Drawing.Color.Black;
            this.panelContenedor.Location = new System.Drawing.Point(312, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(988, 600);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.Black;
            this.lbfecha.Location = new System.Drawing.Point(4, 553);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(112, 47);
            this.lbfecha.TabIndex = 2;
            this.lbfecha.Tag = "";
            this.lbfecha.Text = "Hora";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(4, 466);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(188, 80);
            this.lblHora.TabIndex = 1;
            this.lblHora.Tag = "";
            this.lblHora.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconorestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconomaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconominimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconocerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnslide;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox iconocerrar;
        private System.Windows.Forms.PictureBox iconorestaurar;
        private System.Windows.Forms.PictureBox iconomaximizar;
        private System.Windows.Forms.PictureBox iconominimizar;
        private System.Windows.Forms.Button btnCerrarSeccion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConjunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnFAAA;
        private System.Windows.Forms.TreeView treeMenu;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnnombreModulo;
    }
}