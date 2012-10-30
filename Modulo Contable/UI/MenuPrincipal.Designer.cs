namespace UI
{
    partial class MenuPrincipal
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
            this.buttonCuentas = new System.Windows.Forms.Button();
            this.buttonAsientos = new System.Windows.Forms.Button();
            this.buttonEmpresa = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.buttonCierre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAgregarPeriodoContable = new System.Windows.Forms.Button();
            this.labNombreEmpresa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labCedJuridica = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCuentas
            // 
            this.buttonCuentas.AccessibleName = "";
            this.buttonCuentas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCuentas.ForeColor = System.Drawing.Color.White;
            this.buttonCuentas.Image = global::UI.Properties.Resources.book_add;
            this.buttonCuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCuentas.Location = new System.Drawing.Point(14, 39);
            this.buttonCuentas.Name = "buttonCuentas";
            this.buttonCuentas.Size = new System.Drawing.Size(190, 34);
            this.buttonCuentas.TabIndex = 0;
            this.buttonCuentas.Text = "Crear Cuentas";
            this.buttonCuentas.UseVisualStyleBackColor = false;
            this.buttonCuentas.Click += new System.EventHandler(this.buttonCuentas_Click);
            // 
            // buttonAsientos
            // 
            this.buttonAsientos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAsientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsientos.ForeColor = System.Drawing.Color.White;
            this.buttonAsientos.Image = global::UI.Properties.Resources.application;
            this.buttonAsientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAsientos.Location = new System.Drawing.Point(210, 39);
            this.buttonAsientos.Name = "buttonAsientos";
            this.buttonAsientos.Size = new System.Drawing.Size(191, 34);
            this.buttonAsientos.TabIndex = 1;
            this.buttonAsientos.Text = "Crear Asientos";
            this.buttonAsientos.UseVisualStyleBackColor = false;
            this.buttonAsientos.Click += new System.EventHandler(this.buttonAsientos_Click);
            // 
            // buttonEmpresa
            // 
            this.buttonEmpresa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpresa.ForeColor = System.Drawing.Color.White;
            this.buttonEmpresa.Image = global::UI.Properties.Resources.computer_add;
            this.buttonEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmpresa.Location = new System.Drawing.Point(14, 79);
            this.buttonEmpresa.Name = "buttonEmpresa";
            this.buttonEmpresa.Size = new System.Drawing.Size(190, 34);
            this.buttonEmpresa.TabIndex = 2;
            this.buttonEmpresa.Text = "Crear Empresa";
            this.buttonEmpresa.UseVisualStyleBackColor = false;
            this.buttonEmpresa.Click += new System.EventHandler(this.buttonEmpresa_Click);
            // 
            // buttonReportes
            // 
            this.buttonReportes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportes.ForeColor = System.Drawing.Color.White;
            this.buttonReportes.Image = global::UI.Properties.Resources.application_cascade;
            this.buttonReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportes.Location = new System.Drawing.Point(210, 79);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(191, 34);
            this.buttonReportes.TabIndex = 3;
            this.buttonReportes.Text = "Reportes y Consultas";
            this.buttonReportes.UseVisualStyleBackColor = false;
            this.buttonReportes.Click += new System.EventHandler(this.buttonReportes_Click);
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.buttonCerrarSesion.Image = global::UI.Properties.Resources.bullet_go;
            this.buttonCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCerrarSesion.Location = new System.Drawing.Point(495, 343);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(146, 27);
            this.buttonCerrarSesion.TabIndex = 4;
            this.buttonCerrarSesion.Text = "Cerrar Sesión";
            this.buttonCerrarSesion.UseVisualStyleBackColor = false;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // buttonCierre
            // 
            this.buttonCierre.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCierre.ForeColor = System.Drawing.Color.White;
            this.buttonCierre.Image = global::UI.Properties.Resources.calculator_edit;
            this.buttonCierre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCierre.Location = new System.Drawing.Point(14, 119);
            this.buttonCierre.Name = "buttonCierre";
            this.buttonCierre.Size = new System.Drawing.Size(190, 34);
            this.buttonCierre.TabIndex = 5;
            this.buttonCierre.Text = "Realizar Cierre";
            this.buttonCierre.UseVisualStyleBackColor = false;
            this.buttonCierre.Click += new System.EventHandler(this.buttonCierre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menú Principal";
            // 
            // buttonAgregarPeriodoContable
            // 
            this.buttonAgregarPeriodoContable.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAgregarPeriodoContable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarPeriodoContable.ForeColor = System.Drawing.Color.White;
            this.buttonAgregarPeriodoContable.Image = global::UI.Properties.Resources.clock_add;
            this.buttonAgregarPeriodoContable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregarPeriodoContable.Location = new System.Drawing.Point(210, 119);
            this.buttonAgregarPeriodoContable.Name = "buttonAgregarPeriodoContable";
            this.buttonAgregarPeriodoContable.Size = new System.Drawing.Size(191, 34);
            this.buttonAgregarPeriodoContable.TabIndex = 7;
            this.buttonAgregarPeriodoContable.Text = "Agregar Periodo Contable";
            this.buttonAgregarPeriodoContable.UseVisualStyleBackColor = false;
            this.buttonAgregarPeriodoContable.Click += new System.EventHandler(this.buttonAgregarPeriodoContable_Click);
            // 
            // labNombreEmpresa
            // 
            this.labNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombreEmpresa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labNombreEmpresa.Location = new System.Drawing.Point(42, 87);
            this.labNombreEmpresa.Name = "labNombreEmpresa";
            this.labNombreEmpresa.Size = new System.Drawing.Size(142, 42);
            this.labNombreEmpresa.TabIndex = 8;
            this.labNombreEmpresa.Text = "Nombre Empresa";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labCedJuridica);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labNombreEmpresa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 201);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Empresa";
            // 
            // label4
            // 
            this.label4.Image = global::UI.Properties.Resources.key_go;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 28);
            this.label4.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(42, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 42);
            this.label5.TabIndex = 12;
            this.label5.Text = "Id de la Empresa";
            // 
            // label3
            // 
            this.label3.Image = global::UI.Properties.Resources.book;
            this.label3.Location = new System.Drawing.Point(6, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 28);
            this.label3.TabIndex = 11;
            // 
            // labCedJuridica
            // 
            this.labCedJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCedJuridica.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labCedJuridica.Location = new System.Drawing.Point(42, 146);
            this.labCedJuridica.Name = "labCedJuridica";
            this.labCedJuridica.Size = new System.Drawing.Size(142, 42);
            this.labCedJuridica.TabIndex = 10;
            this.labCedJuridica.Text = "Cedula Juridica";
            // 
            // label2
            // 
            this.label2.Image = global::UI.Properties.Resources.computer;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 28);
            this.label2.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonCuentas);
            this.groupBox2.Controls.Add(this.buttonEmpresa);
            this.groupBox2.Controls.Add(this.buttonAgregarPeriodoContable);
            this.groupBox2.Controls.Add(this.buttonCierre);
            this.groupBox2.Controls.Add(this.buttonAsientos);
            this.groupBox2.Controls.Add(this.buttonReportes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(223, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 201);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // MenuPrincipal
            // 
            this.AccessibleName = "buttonCuentas";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::UI.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(653, 395);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCerrarSesion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(669, 433);
            this.MinimumSize = new System.Drawing.Size(669, 433);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCuentas;
        private System.Windows.Forms.Button buttonAsientos;
        private System.Windows.Forms.Button buttonEmpresa;
        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.Button buttonCierre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgregarPeriodoContable;
        public System.Windows.Forms.Label labNombreEmpresa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labCedJuridica;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}