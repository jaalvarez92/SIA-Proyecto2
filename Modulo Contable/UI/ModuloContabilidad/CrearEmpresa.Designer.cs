namespace UI
{
    partial class CrearEmpresa
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMonedaSistema = new System.Windows.Forms.ComboBox();
            this.comboBoxMonedaLocal = new System.Windows.Forms.ComboBox();
            this.textBoxCedulaJuridica = new System.Windows.Forms.TextBox();
            this.botonRutaArchivo = new System.Windows.Forms.Button();
            this.textBoxLogotipo = new System.Windows.Forms.TextBox();
            this.labelLogotipo = new System.Windows.Forms.Label();
            this.textBoxEsquema = new System.Windows.Forms.TextBox();
            this.labelCedulaJuridica = new System.Windows.Forms.Label();
            this.textBoxNombreEmpresa = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNombreEmpresa = new System.Windows.Forms.Label();
            this.labelSchema = new System.Windows.Forms.Label();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.botonCrearEmpresa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Image = global::UI.Properties.Resources.coins;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(37, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Moneda de Sistema:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Image = global::UI.Properties.Resources.coins;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(75, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "MonedaLocal:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMonedaSistema
            // 
            this.comboBoxMonedaSistema.FormattingEnabled = true;
            this.comboBoxMonedaSistema.Location = new System.Drawing.Point(193, 230);
            this.comboBoxMonedaSistema.Name = "comboBoxMonedaSistema";
            this.comboBoxMonedaSistema.Size = new System.Drawing.Size(214, 24);
            this.comboBoxMonedaSistema.TabIndex = 27;
            // 
            // comboBoxMonedaLocal
            // 
            this.comboBoxMonedaLocal.FormattingEnabled = true;
            this.comboBoxMonedaLocal.Location = new System.Drawing.Point(193, 195);
            this.comboBoxMonedaLocal.Name = "comboBoxMonedaLocal";
            this.comboBoxMonedaLocal.Size = new System.Drawing.Size(214, 24);
            this.comboBoxMonedaLocal.TabIndex = 26;
            // 
            // textBoxCedulaJuridica
            // 
            this.textBoxCedulaJuridica.Location = new System.Drawing.Point(193, 160);
            this.textBoxCedulaJuridica.Name = "textBoxCedulaJuridica";
            this.textBoxCedulaJuridica.Size = new System.Drawing.Size(214, 22);
            this.textBoxCedulaJuridica.TabIndex = 24;
            // 
            // botonRutaArchivo
            // 
            this.botonRutaArchivo.BackColor = System.Drawing.Color.Transparent;
            this.botonRutaArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRutaArchivo.ForeColor = System.Drawing.Color.White;
            this.botonRutaArchivo.Image = global::UI.Properties.Resources.magnifier;
            this.botonRutaArchivo.Location = new System.Drawing.Point(413, 126);
            this.botonRutaArchivo.Name = "botonRutaArchivo";
            this.botonRutaArchivo.Size = new System.Drawing.Size(37, 22);
            this.botonRutaArchivo.TabIndex = 23;
            this.botonRutaArchivo.UseVisualStyleBackColor = false;
            this.botonRutaArchivo.Click += new System.EventHandler(this.botonRutaArchivo_Click);
            // 
            // textBoxLogotipo
            // 
            this.textBoxLogotipo.Enabled = false;
            this.textBoxLogotipo.Location = new System.Drawing.Point(193, 126);
            this.textBoxLogotipo.Name = "textBoxLogotipo";
            this.textBoxLogotipo.Size = new System.Drawing.Size(214, 22);
            this.textBoxLogotipo.TabIndex = 22;
            // 
            // labelLogotipo
            // 
            this.labelLogotipo.Image = global::UI.Properties.Resources.asterisk_orange;
            this.labelLogotipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLogotipo.Location = new System.Drawing.Point(103, 126);
            this.labelLogotipo.Name = "labelLogotipo";
            this.labelLogotipo.Size = new System.Drawing.Size(89, 19);
            this.labelLogotipo.TabIndex = 21;
            this.labelLogotipo.Text = "Logotipo:";
            this.labelLogotipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxEsquema
            // 
            this.textBoxEsquema.Location = new System.Drawing.Point(193, 89);
            this.textBoxEsquema.Name = "textBoxEsquema";
            this.textBoxEsquema.Size = new System.Drawing.Size(214, 22);
            this.textBoxEsquema.TabIndex = 20;
            // 
            // labelCedulaJuridica
            // 
            this.labelCedulaJuridica.Image = global::UI.Properties.Resources.book;
            this.labelCedulaJuridica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCedulaJuridica.Location = new System.Drawing.Point(80, 162);
            this.labelCedulaJuridica.Name = "labelCedulaJuridica";
            this.labelCedulaJuridica.Size = new System.Drawing.Size(107, 19);
            this.labelCedulaJuridica.TabIndex = 19;
            this.labelCedulaJuridica.Text = "Ced. Jurídica:";
            this.labelCedulaJuridica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNombreEmpresa
            // 
            this.textBoxNombreEmpresa.Location = new System.Drawing.Point(193, 53);
            this.textBoxNombreEmpresa.Name = "textBoxNombreEmpresa";
            this.textBoxNombreEmpresa.Size = new System.Drawing.Size(214, 22);
            this.textBoxNombreEmpresa.TabIndex = 17;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNombreEmpresa);
            this.groupBox1.Controls.Add(this.labelNombreEmpresa);
            this.groupBox1.Controls.Add(this.labelCedulaJuridica);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxEsquema);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelLogotipo);
            this.groupBox1.Controls.Add(this.comboBoxMonedaSistema);
            this.groupBox1.Controls.Add(this.textBoxLogotipo);
            this.groupBox1.Controls.Add(this.comboBoxMonedaLocal);
            this.groupBox1.Controls.Add(this.botonRutaArchivo);
            this.groupBox1.Controls.Add(this.labelSchema);
            this.groupBox1.Controls.Add(this.textBoxCedulaJuridica);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 288);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(248, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Agregar Empresa";
            // 
            // labelNombreEmpresa
            // 
            this.labelNombreEmpresa.Image = global::UI.Properties.Resources.computer;
            this.labelNombreEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNombreEmpresa.Location = new System.Drawing.Point(105, 56);
            this.labelNombreEmpresa.Name = "labelNombreEmpresa";
            this.labelNombreEmpresa.Size = new System.Drawing.Size(82, 19);
            this.labelNombreEmpresa.TabIndex = 18;
            this.labelNombreEmpresa.Text = "Nombre:";
            this.labelNombreEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSchema
            // 
            this.labelSchema.Image = global::UI.Properties.Resources.medal_bronze_2;
            this.labelSchema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSchema.Location = new System.Drawing.Point(100, 92);
            this.labelSchema.Name = "labelSchema";
            this.labelSchema.Size = new System.Drawing.Size(87, 19);
            this.labelSchema.TabIndex = 25;
            this.labelSchema.Text = "Esquema:";
            this.labelSchema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonAtras
            // 
            this.buttonAtras.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtras.ForeColor = System.Drawing.Color.White;
            this.buttonAtras.Image = global::UI.Properties.Resources.arrow_left;
            this.buttonAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAtras.Location = new System.Drawing.Point(497, 350);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(116, 33);
            this.buttonAtras.TabIndex = 31;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = false;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // botonCrearEmpresa
            // 
            this.botonCrearEmpresa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botonCrearEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrearEmpresa.ForeColor = System.Drawing.Color.White;
            this.botonCrearEmpresa.Image = global::UI.Properties.Resources.accept;
            this.botonCrearEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCrearEmpresa.Location = new System.Drawing.Point(375, 350);
            this.botonCrearEmpresa.Name = "botonCrearEmpresa";
            this.botonCrearEmpresa.Size = new System.Drawing.Size(116, 33);
            this.botonCrearEmpresa.TabIndex = 30;
            this.botonCrearEmpresa.Text = "Guardar";
            this.botonCrearEmpresa.UseVisualStyleBackColor = false;
            this.botonCrearEmpresa.Click += new System.EventHandler(this.botonCrearEmpresa_Click);
            // 
            // CrearEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 395);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.botonCrearEmpresa);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(669, 433);
            this.MinimumSize = new System.Drawing.Size(669, 433);
            this.Name = "CrearEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Empresa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMonedaSistema;
        private System.Windows.Forms.ComboBox comboBoxMonedaLocal;
        private System.Windows.Forms.Label labelSchema;
        private System.Windows.Forms.TextBox textBoxCedulaJuridica;
        private System.Windows.Forms.Button botonRutaArchivo;
        private System.Windows.Forms.TextBox textBoxLogotipo;
        private System.Windows.Forms.Label labelLogotipo;
        private System.Windows.Forms.TextBox textBoxEsquema;
        private System.Windows.Forms.Label labelCedulaJuridica;
        private System.Windows.Forms.Label labelNombreEmpresa;
        private System.Windows.Forms.TextBox textBoxNombreEmpresa;
        private System.Windows.Forms.Button botonCrearEmpresa;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}