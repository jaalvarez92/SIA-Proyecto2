namespace UI
{
    partial class CrearCuenta
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
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelNombreCuentaExtranjera = new System.Windows.Forms.Label();
            this.textBoxNombreCuentaExtranjera = new System.Windows.Forms.TextBox();
            this.botonCrearCuenta = new System.Windows.Forms.Button();
            this.labelCuentaPadre = new System.Windows.Forms.Label();
            this.labelTipoCuenta = new System.Windows.Forms.Label();
            this.labelNombreCuenta = new System.Windows.Forms.Label();
            this.labelMonedaCuenta = new System.Windows.Forms.Label();
            this.comboBoxTipoCuenta = new System.Windows.Forms.ComboBox();
            this.comboBoxMoneda = new System.Windows.Forms.ComboBox();
            this.textBoxNombreCuenta = new System.Windows.Forms.TextBox();
            this.comboBoxCuentaPadre = new System.Windows.Forms.ComboBox();
            this.checkBoxCuentaTitulo = new System.Windows.Forms.CheckBox();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxEliminarCuentas = new System.Windows.Forms.CheckBox();
            this.treeViewCuentas = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCodigo.Location = new System.Drawing.Point(24, 66);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 29;
            this.labelCodigo.Text = "Código";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(24, 82);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 22);
            this.textBoxCodigo.TabIndex = 28;
            // 
            // labelNombreCuentaExtranjera
            // 
            this.labelNombreCuentaExtranjera.AutoSize = true;
            this.labelNombreCuentaExtranjera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCuentaExtranjera.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNombreCuentaExtranjera.Location = new System.Drawing.Point(198, 141);
            this.labelNombreCuentaExtranjera.Name = "labelNombreCuentaExtranjera";
            this.labelNombreCuentaExtranjera.Size = new System.Drawing.Size(131, 13);
            this.labelNombreCuentaExtranjera.TabIndex = 27;
            this.labelNombreCuentaExtranjera.Text = "Nombre Cuenta Extranjera";
            // 
            // textBoxNombreCuentaExtranjera
            // 
            this.textBoxNombreCuentaExtranjera.Location = new System.Drawing.Point(199, 157);
            this.textBoxNombreCuentaExtranjera.Name = "textBoxNombreCuentaExtranjera";
            this.textBoxNombreCuentaExtranjera.Size = new System.Drawing.Size(235, 22);
            this.textBoxNombreCuentaExtranjera.TabIndex = 26;
            // 
            // botonCrearCuenta
            // 
            this.botonCrearCuenta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botonCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrearCuenta.ForeColor = System.Drawing.Color.White;
            this.botonCrearCuenta.Image = global::UI.Properties.Resources.accept;
            this.botonCrearCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCrearCuenta.Location = new System.Drawing.Point(514, 371);
            this.botonCrearCuenta.Name = "botonCrearCuenta";
            this.botonCrearCuenta.Size = new System.Drawing.Size(112, 31);
            this.botonCrearCuenta.TabIndex = 25;
            this.botonCrearCuenta.Text = "Guardar";
            this.botonCrearCuenta.UseVisualStyleBackColor = false;
            this.botonCrearCuenta.Click += new System.EventHandler(this.botonCrearCuenta_Click);
            // 
            // labelCuentaPadre
            // 
            this.labelCuentaPadre.AutoSize = true;
            this.labelCuentaPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuentaPadre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCuentaPadre.Location = new System.Drawing.Point(24, 219);
            this.labelCuentaPadre.Name = "labelCuentaPadre";
            this.labelCuentaPadre.Size = new System.Drawing.Size(72, 13);
            this.labelCuentaPadre.TabIndex = 24;
            this.labelCuentaPadre.Text = "Cuenta Padre";
            // 
            // labelTipoCuenta
            // 
            this.labelTipoCuenta.AutoSize = true;
            this.labelTipoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoCuenta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTipoCuenta.Location = new System.Drawing.Point(24, 139);
            this.labelTipoCuenta.Name = "labelTipoCuenta";
            this.labelTipoCuenta.Size = new System.Drawing.Size(65, 13);
            this.labelTipoCuenta.TabIndex = 23;
            this.labelTipoCuenta.Text = "Tipo Cuenta";
            // 
            // labelNombreCuenta
            // 
            this.labelNombreCuenta.AutoSize = true;
            this.labelNombreCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCuenta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNombreCuenta.Location = new System.Drawing.Point(195, 66);
            this.labelNombreCuenta.Name = "labelNombreCuenta";
            this.labelNombreCuenta.Size = new System.Drawing.Size(81, 13);
            this.labelNombreCuenta.TabIndex = 22;
            this.labelNombreCuenta.Text = "Nombre Cuenta";
            // 
            // labelMonedaCuenta
            // 
            this.labelMonedaCuenta.AutoSize = true;
            this.labelMonedaCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonedaCuenta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelMonedaCuenta.Location = new System.Drawing.Point(130, 66);
            this.labelMonedaCuenta.Name = "labelMonedaCuenta";
            this.labelMonedaCuenta.Size = new System.Drawing.Size(46, 13);
            this.labelMonedaCuenta.TabIndex = 21;
            this.labelMonedaCuenta.Text = "Moneda";
            // 
            // comboBoxTipoCuenta
            // 
            this.comboBoxTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoCuenta.FormattingEnabled = true;
            this.comboBoxTipoCuenta.Location = new System.Drawing.Point(27, 155);
            this.comboBoxTipoCuenta.Name = "comboBoxTipoCuenta";
            this.comboBoxTipoCuenta.Size = new System.Drawing.Size(165, 24);
            this.comboBoxTipoCuenta.TabIndex = 20;
            // 
            // comboBoxMoneda
            // 
            this.comboBoxMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMoneda.FormattingEnabled = true;
            this.comboBoxMoneda.Location = new System.Drawing.Point(132, 82);
            this.comboBoxMoneda.Name = "comboBoxMoneda";
            this.comboBoxMoneda.Size = new System.Drawing.Size(57, 24);
            this.comboBoxMoneda.TabIndex = 19;
            // 
            // textBoxNombreCuenta
            // 
            this.textBoxNombreCuenta.Location = new System.Drawing.Point(195, 82);
            this.textBoxNombreCuenta.Name = "textBoxNombreCuenta";
            this.textBoxNombreCuenta.Size = new System.Drawing.Size(236, 22);
            this.textBoxNombreCuenta.TabIndex = 18;
            // 
            // comboBoxCuentaPadre
            // 
            this.comboBoxCuentaPadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCuentaPadre.FormattingEnabled = true;
            this.comboBoxCuentaPadre.Location = new System.Drawing.Point(24, 235);
            this.comboBoxCuentaPadre.Name = "comboBoxCuentaPadre";
            this.comboBoxCuentaPadre.Size = new System.Drawing.Size(304, 24);
            this.comboBoxCuentaPadre.TabIndex = 17;
            // 
            // checkBoxCuentaTitulo
            // 
            this.checkBoxCuentaTitulo.AutoSize = true;
            this.checkBoxCuentaTitulo.Location = new System.Drawing.Point(343, 237);
            this.checkBoxCuentaTitulo.Name = "checkBoxCuentaTitulo";
            this.checkBoxCuentaTitulo.Size = new System.Drawing.Size(105, 20);
            this.checkBoxCuentaTitulo.TabIndex = 16;
            this.checkBoxCuentaTitulo.Text = "Cuenta Titulo";
            this.checkBoxCuentaTitulo.UseVisualStyleBackColor = true;
            this.checkBoxCuentaTitulo.CheckedChanged += new System.EventHandler(this.checkBoxCuentaTitulo_CheckedChanged);
            // 
            // buttonAtras
            // 
            this.buttonAtras.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtras.ForeColor = System.Drawing.Color.White;
            this.buttonAtras.Image = global::UI.Properties.Resources.arrow_left;
            this.buttonAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAtras.Location = new System.Drawing.Point(634, 371);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(112, 31);
            this.buttonAtras.TabIndex = 32;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = false;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxEliminarCuentas);
            this.panel1.Controls.Add(this.treeViewCuentas);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 366);
            this.panel1.TabIndex = 33;
            // 
            // checkBoxEliminarCuentas
            // 
            this.checkBoxEliminarCuentas.AutoSize = true;
            this.checkBoxEliminarCuentas.Location = new System.Drawing.Point(3, 5);
            this.checkBoxEliminarCuentas.Name = "checkBoxEliminarCuentas";
            this.checkBoxEliminarCuentas.Size = new System.Drawing.Size(104, 17);
            this.checkBoxEliminarCuentas.TabIndex = 1;
            this.checkBoxEliminarCuentas.Text = "Eliminar Cuentas";
            this.checkBoxEliminarCuentas.UseVisualStyleBackColor = true;
            this.checkBoxEliminarCuentas.CheckedChanged += new System.EventHandler(this.checkBoxEliminarCuentas_CheckedChanged);
            // 
            // treeViewCuentas
            // 
            this.treeViewCuentas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.treeViewCuentas.Enabled = false;
            this.treeViewCuentas.Location = new System.Drawing.Point(3, 28);
            this.treeViewCuentas.Name = "treeViewCuentas";
            this.treeViewCuentas.Size = new System.Drawing.Size(250, 335);
            this.treeViewCuentas.TabIndex = 0;
            this.treeViewCuentas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCuentas_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCodigo);
            this.groupBox1.Controls.Add(this.comboBoxMoneda);
            this.groupBox1.Controls.Add(this.labelMonedaCuenta);
            this.groupBox1.Controls.Add(this.labelNombreCuentaExtranjera);
            this.groupBox1.Controls.Add(this.labelCuentaPadre);
            this.groupBox1.Controls.Add(this.checkBoxCuentaTitulo);
            this.groupBox1.Controls.Add(this.textBoxCodigo);
            this.groupBox1.Controls.Add(this.comboBoxCuentaPadre);
            this.groupBox1.Controls.Add(this.textBoxNombreCuentaExtranjera);
            this.groupBox1.Controls.Add(this.labelNombreCuenta);
            this.groupBox1.Controls.Add(this.textBoxNombreCuenta);
            this.groupBox1.Controls.Add(this.labelTipoCuenta);
            this.groupBox1.Controls.Add(this.comboBoxTipoCuenta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(298, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 304);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Cuenta";
            // 
            // CrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.botonCrearCuenta);
            this.MaximizeBox = false;
            this.Name = "CrearCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Crear Cuenta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelNombreCuentaExtranjera;
        private System.Windows.Forms.TextBox textBoxNombreCuentaExtranjera;
        private System.Windows.Forms.Button botonCrearCuenta;
        private System.Windows.Forms.Label labelCuentaPadre;
        private System.Windows.Forms.Label labelTipoCuenta;
        private System.Windows.Forms.Label labelNombreCuenta;
        private System.Windows.Forms.Label labelMonedaCuenta;
        private System.Windows.Forms.ComboBox comboBoxTipoCuenta;
        private System.Windows.Forms.ComboBox comboBoxMoneda;
        private System.Windows.Forms.TextBox textBoxNombreCuenta;
        private System.Windows.Forms.ComboBox comboBoxCuentaPadre;
        private System.Windows.Forms.CheckBox checkBoxCuentaTitulo;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeViewCuentas;
        private System.Windows.Forms.CheckBox checkBoxEliminarCuentas;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}