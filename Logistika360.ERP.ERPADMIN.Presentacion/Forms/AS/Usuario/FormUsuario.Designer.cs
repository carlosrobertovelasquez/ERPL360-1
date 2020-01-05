namespace Logistika360.ERP.ERPADMIN.Presentacion.Forms.AS.Usuario
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.chbPrivilegio = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePropiedades = new System.Windows.Forms.TabPage();
            this.tabPagePrivilegios = new System.Windows.Forms.TabPage();
            this.tabPagePrivilegiosEspeciales = new System.Windows.Forms.TabPage();
            this.tabPageGrupo = new System.Windows.Forms.TabPage();
            this.txtUsuarioWindows = new System.Windows.Forms.TextBox();
            this.txtCorreoEletronico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbEsRequerido = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFrecuenciaClave = new System.Windows.Forms.TextBox();
            this.txtLimitedeintentos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonTransacional = new System.Windows.Forms.RadioButton();
            this.radioButtonConsulta = new System.Windows.Forms.RadioButton();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePropiedades.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(729, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(222, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 20);
            this.textBox2.TabIndex = 4;
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.Location = new System.Drawing.Point(464, 36);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(56, 17);
            this.chbActivo.TabIndex = 5;
            this.chbActivo.Text = "Activo";
            this.chbActivo.UseVisualStyleBackColor = true;
            // 
            // chbPrivilegio
            // 
            this.chbPrivilegio.AutoSize = true;
            this.chbPrivilegio.Location = new System.Drawing.Point(533, 38);
            this.chbPrivilegio.Name = "chbPrivilegio";
            this.chbPrivilegio.Size = new System.Drawing.Size(188, 17);
            this.chbPrivilegio.TabIndex = 6;
            this.chbPrivilegio.Text = "Privilegio de Usuario Administrador";
            this.chbPrivilegio.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePropiedades);
            this.tabControl1.Controls.Add(this.tabPagePrivilegios);
            this.tabControl1.Controls.Add(this.tabPagePrivilegiosEspeciales);
            this.tabControl1.Controls.Add(this.tabPageGrupo);
            this.tabControl1.Location = new System.Drawing.Point(21, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 337);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPagePropiedades
            // 
            this.tabPagePropiedades.Controls.Add(this.groupBox2);
            this.tabPagePropiedades.Controls.Add(this.groupBox1);
            this.tabPagePropiedades.Controls.Add(this.textBox3);
            this.tabPagePropiedades.Controls.Add(this.label5);
            this.tabPagePropiedades.Controls.Add(this.label3);
            this.tabPagePropiedades.Controls.Add(this.txtCorreoEletronico);
            this.tabPagePropiedades.Controls.Add(this.txtUsuarioWindows);
            this.tabPagePropiedades.Controls.Add(this.label4);
            this.tabPagePropiedades.Location = new System.Drawing.Point(4, 22);
            this.tabPagePropiedades.Name = "tabPagePropiedades";
            this.tabPagePropiedades.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePropiedades.Size = new System.Drawing.Size(666, 311);
            this.tabPagePropiedades.TabIndex = 0;
            this.tabPagePropiedades.Text = "Propiedades";
            this.tabPagePropiedades.UseVisualStyleBackColor = true;
            this.tabPagePropiedades.Click += new System.EventHandler(this.tabPagePropiedades_Click);
            // 
            // tabPagePrivilegios
            // 
            this.tabPagePrivilegios.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrivilegios.Name = "tabPagePrivilegios";
            this.tabPagePrivilegios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrivilegios.Size = new System.Drawing.Size(666, 311);
            this.tabPagePrivilegios.TabIndex = 1;
            this.tabPagePrivilegios.Text = "Privilegios";
            this.tabPagePrivilegios.UseVisualStyleBackColor = true;
            // 
            // tabPagePrivilegiosEspeciales
            // 
            this.tabPagePrivilegiosEspeciales.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrivilegiosEspeciales.Name = "tabPagePrivilegiosEspeciales";
            this.tabPagePrivilegiosEspeciales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrivilegiosEspeciales.Size = new System.Drawing.Size(745, 311);
            this.tabPagePrivilegiosEspeciales.TabIndex = 2;
            this.tabPagePrivilegiosEspeciales.Text = "Privilegios Especiales";
            this.tabPagePrivilegiosEspeciales.UseVisualStyleBackColor = true;
            // 
            // tabPageGrupo
            // 
            this.tabPageGrupo.Location = new System.Drawing.Point(4, 22);
            this.tabPageGrupo.Name = "tabPageGrupo";
            this.tabPageGrupo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGrupo.Size = new System.Drawing.Size(745, 311);
            this.tabPageGrupo.TabIndex = 3;
            this.tabPageGrupo.Text = "Grupo";
            this.tabPageGrupo.UseVisualStyleBackColor = true;
            // 
            // txtUsuarioWindows
            // 
            this.txtUsuarioWindows.Location = new System.Drawing.Point(131, 32);
            this.txtUsuarioWindows.Name = "txtUsuarioWindows";
            this.txtUsuarioWindows.Size = new System.Drawing.Size(240, 20);
            this.txtUsuarioWindows.TabIndex = 0;
            // 
            // txtCorreoEletronico
            // 
            this.txtCorreoEletronico.Location = new System.Drawing.Point(132, 65);
            this.txtCorreoEletronico.Name = "txtCorreoEletronico";
            this.txtCorreoEletronico.Size = new System.Drawing.Size(240, 20);
            this.txtCorreoEletronico.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Correo Eletronico :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Usuario Windows  :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(134, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 20);
            this.textBox3.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Celular :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtLimitedeintentos);
            this.groupBox1.Controls.Add(this.txtFrecuenciaClave);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chbEsRequerido);
            this.groupBox1.Location = new System.Drawing.Point(34, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 137);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambio periodo de Clave";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonConsulta);
            this.groupBox2.Controls.Add(this.radioButtonTransacional);
            this.groupBox2.Location = new System.Drawing.Point(334, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 137);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Acceso";
            // 
            // chbEsRequerido
            // 
            this.chbEsRequerido.AutoSize = true;
            this.chbEsRequerido.Location = new System.Drawing.Point(58, 20);
            this.chbEsRequerido.Name = "chbEsRequerido";
            this.chbEsRequerido.Size = new System.Drawing.Size(85, 17);
            this.chbEsRequerido.TabIndex = 0;
            this.chbEsRequerido.Text = "Es requerido";
            this.chbEsRequerido.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Frecuencia Clave :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtFrecuenciaClave
            // 
            this.txtFrecuenciaClave.Location = new System.Drawing.Point(104, 44);
            this.txtFrecuenciaClave.Name = "txtFrecuenciaClave";
            this.txtFrecuenciaClave.Size = new System.Drawing.Size(70, 20);
            this.txtFrecuenciaClave.TabIndex = 2;
            // 
            // txtLimitedeintentos
            // 
            this.txtLimitedeintentos.Location = new System.Drawing.Point(104, 70);
            this.txtLimitedeintentos.Name = "txtLimitedeintentos";
            this.txtLimitedeintentos.Size = new System.Drawing.Size(70, 20);
            this.txtLimitedeintentos.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Limite de intentos :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ultimo Cambio :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "dias";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // radioButtonTransacional
            // 
            this.radioButtonTransacional.AutoSize = true;
            this.radioButtonTransacional.Location = new System.Drawing.Point(30, 43);
            this.radioButtonTransacional.Name = "radioButtonTransacional";
            this.radioButtonTransacional.Size = new System.Drawing.Size(92, 17);
            this.radioButtonTransacional.TabIndex = 0;
            this.radioButtonTransacional.TabStop = true;
            this.radioButtonTransacional.Text = "Transaccional";
            this.radioButtonTransacional.UseVisualStyleBackColor = true;
            // 
            // radioButtonConsulta
            // 
            this.radioButtonConsulta.AutoSize = true;
            this.radioButtonConsulta.Location = new System.Drawing.Point(30, 71);
            this.radioButtonConsulta.Name = "radioButtonConsulta";
            this.radioButtonConsulta.Size = new System.Drawing.Size(66, 17);
            this.radioButtonConsulta.TabIndex = 1;
            this.radioButtonConsulta.TabStop = true;
            this.radioButtonConsulta.Text = "Consulta";
            this.radioButtonConsulta.UseVisualStyleBackColor = true;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.chbPrivilegio);
            this.Controls.Add(this.chbActivo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsuario";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePropiedades.ResumeLayout(false);
            this.tabPagePropiedades.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox chbActivo;
        private System.Windows.Forms.CheckBox chbPrivilegio;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePropiedades;
        private System.Windows.Forms.TextBox txtUsuarioWindows;
        private System.Windows.Forms.TabPage tabPagePrivilegios;
        private System.Windows.Forms.TabPage tabPagePrivilegiosEspeciales;
        private System.Windows.Forms.TabPage tabPageGrupo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreoEletronico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLimitedeintentos;
        private System.Windows.Forms.TextBox txtFrecuenciaClave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbEsRequerido;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButtonConsulta;
        private System.Windows.Forms.RadioButton radioButtonTransacional;
    }
}