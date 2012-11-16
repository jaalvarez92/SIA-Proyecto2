namespace UI.ModuloClientes
{
    partial class MenuModuloClientes
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
            this.buttonAtras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labNombreEmpresa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labCedJuridica = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAgregarSocio = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAtras
            // 
            this.buttonAtras.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtras.ForeColor = System.Drawing.Color.White;
            this.buttonAtras.Image = global::UI.Properties.Resources.bullet_go;
            this.buttonAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAtras.Location = new System.Drawing.Point(495, 343);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(146, 27);
            this.buttonAtras.TabIndex = 4;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = false;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menú Módulo Financiero";
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
            this.groupBox2.Controls.Add(this.buttonConsultar);
            this.groupBox2.Controls.Add(this.buttonAgregarSocio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(223, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 201);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // buttonAgregarSocio
            // 
            this.buttonAgregarSocio.AccessibleName = "";
            this.buttonAgregarSocio.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAgregarSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarSocio.ForeColor = System.Drawing.Color.White;
            this.buttonAgregarSocio.Image = global::UI.Properties.Resources.book_add;
            this.buttonAgregarSocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregarSocio.Location = new System.Drawing.Point(16, 21);
            this.buttonAgregarSocio.Name = "buttonAgregarSocio";
            this.buttonAgregarSocio.Size = new System.Drawing.Size(155, 34);
            this.buttonAgregarSocio.TabIndex = 1;
            this.buttonAgregarSocio.Text = "Agregar Socio";
            this.buttonAgregarSocio.UseVisualStyleBackColor = false;
            this.buttonAgregarSocio.Click += new System.EventHandler(this.buttonAgregarSocio_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.AccessibleName = "";
            this.buttonConsultar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.ForeColor = System.Drawing.Color.White;
            this.buttonConsultar.Image = global::UI.Properties.Resources.book_add;
            this.buttonConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConsultar.Location = new System.Drawing.Point(16, 78);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(155, 34);
            this.buttonConsultar.TabIndex = 2;
            this.buttonConsultar.Text = " Consultar Socio";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // MenuModuloClientes
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::UI.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(653, 395);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAtras);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(669, 433);
            this.MinimumSize = new System.Drawing.Size(669, 433);
            this.Name = "MenuModuloClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Módulo Clientes";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labNombreEmpresa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labCedJuridica;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAgregarSocio;
        private System.Windows.Forms.Button buttonConsultar;
    }
}