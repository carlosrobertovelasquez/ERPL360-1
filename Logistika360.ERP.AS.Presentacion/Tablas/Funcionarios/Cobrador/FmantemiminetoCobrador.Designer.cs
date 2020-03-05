namespace Logistika360.ERP.AS.Presentacion.Tablas.Funcionarios.Cobrador
{
    partial class FmantemiminetoCobrador
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbEstado = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtComisiones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCentroCosto = new System.Windows.Forms.TextBox();
            this.txtCentroCosto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreCuentaContable = new System.Windows.Forms.TextBox();
            this.txtCuentaContable = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(102, 61);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 21);
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.Validated += new System.EventHandler(this.txtCodigo_Validated_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ckbEstado
            // 
            this.ckbEstado.AutoSize = true;
            this.ckbEstado.Location = new System.Drawing.Point(325, 65);
            this.ckbEstado.Name = "ckbEstado";
            this.ckbEstado.Size = new System.Drawing.Size(110, 17);
            this.ckbEstado.TabIndex = 23;
            this.ckbEstado.Text = "Cobrador Inactivo";
            this.ckbEstado.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(102, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(378, 21);
            this.txtNombre.TabIndex = 25;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.Location = new System.Drawing.Point(217, 138);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.ReadOnly = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(266, 21);
            this.txtNombreEmpleado.TabIndex = 28;
            this.txtNombreEmpleado.TextChanged += new System.EventHandler(this.txtNombreEmpleado_TextChanged);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleado.Location = new System.Drawing.Point(102, 138);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(100, 21);
            this.txtEmpleado.TabIndex = 27;
            this.txtEmpleado.TextChanged += new System.EventHandler(this.txtEmpleado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Empleado:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(266, 171);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(221, 21);
            this.txtCorreo.TabIndex = 32;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // txtComisiones
            // 
            this.txtComisiones.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComisiones.Location = new System.Drawing.Point(102, 172);
            this.txtComisiones.Name = "txtComisiones";
            this.txtComisiones.Size = new System.Drawing.Size(100, 21);
            this.txtComisiones.TabIndex = 31;
            this.txtComisiones.TextChanged += new System.EventHandler(this.txtComisiones_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Correo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Comisiones:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNombreCentroCosto
            // 
            this.txtNombreCentroCosto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCentroCosto.Location = new System.Drawing.Point(219, 204);
            this.txtNombreCentroCosto.Name = "txtNombreCentroCosto";
            this.txtNombreCentroCosto.ReadOnly = true;
            this.txtNombreCentroCosto.Size = new System.Drawing.Size(269, 21);
            this.txtNombreCentroCosto.TabIndex = 35;
            // 
            // txtCentroCosto
            // 
            this.txtCentroCosto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCentroCosto.Location = new System.Drawing.Point(102, 204);
            this.txtCentroCosto.Name = "txtCentroCosto";
            this.txtCentroCosto.Size = new System.Drawing.Size(100, 21);
            this.txtCentroCosto.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "C. C. Comision:";
            // 
            // txtNombreCuentaContable
            // 
            this.txtNombreCuentaContable.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCuentaContable.Location = new System.Drawing.Point(227, 241);
            this.txtNombreCuentaContable.Name = "txtNombreCuentaContable";
            this.txtNombreCuentaContable.ReadOnly = true;
            this.txtNombreCuentaContable.Size = new System.Drawing.Size(268, 21);
            this.txtNombreCuentaContable.TabIndex = 38;
            // 
            // txtCuentaContable
            // 
            this.txtCuentaContable.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaContable.Location = new System.Drawing.Point(102, 241);
            this.txtCuentaContable.Name = "txtCuentaContable";
            this.txtCuentaContable.Size = new System.Drawing.Size(100, 21);
            this.txtCuentaContable.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Cuenta Comision:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(102, 274);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 21);
            this.txtTelefono.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Telefono :";
            // 
            // FmantemiminetoCobrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 324);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombreCuentaContable);
            this.Controls.Add(this.txtCuentaContable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNombreCentroCosto);
            this.Controls.Add(this.txtCentroCosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtComisiones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckbEstado);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Name = "FmantemiminetoCobrador";
            this.Text = "FmantemiminetoCobrador";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.ckbEstado, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtEmpleado, 0);
            this.Controls.SetChildIndex(this.txtNombreEmpleado, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtComisiones, 0);
            this.Controls.SetChildIndex(this.txtCorreo, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtCentroCosto, 0);
            this.Controls.SetChildIndex(this.txtNombreCentroCosto, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtCuentaContable, 0);
            this.Controls.SetChildIndex(this.txtNombreCuentaContable, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox ckbEstado;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNombreEmpleado;
        public System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtCorreo;
        public System.Windows.Forms.TextBox txtComisiones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNombreCentroCosto;
        public System.Windows.Forms.TextBox txtCentroCosto;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtNombreCuentaContable;
        public System.Windows.Forms.TextBox txtCuentaContable;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
    }
}