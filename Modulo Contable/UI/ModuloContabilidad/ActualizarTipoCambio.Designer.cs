namespace UI
{
    partial class ActualizarTipoCambio
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
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMonedaBase = new System.Windows.Forms.ComboBox();
            this.comboBoxMonedaCambio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.groupBoxWS = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompraCRC = new System.Windows.Forms.TextBox();
            this.txtVentaCRC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxWS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Image = global::UI.Properties.Resources.accept;
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(403, 342);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(108, 27);
            this.buttonGuardar.TabIndex = 0;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Image = global::UI.Properties.Resources.arrow_left;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(519, 342);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(108, 27);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Atrás";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::UI.Properties.Resources.coins;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Moneda Cambio: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMonedaBase
            // 
            this.comboBoxMonedaBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonedaBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMonedaBase.FormattingEnabled = true;
            this.comboBoxMonedaBase.Location = new System.Drawing.Point(162, 29);
            this.comboBoxMonedaBase.Name = "comboBoxMonedaBase";
            this.comboBoxMonedaBase.Size = new System.Drawing.Size(164, 24);
            this.comboBoxMonedaBase.TabIndex = 4;
            // 
            // comboBoxMonedaCambio
            // 
            this.comboBoxMonedaCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonedaCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMonedaCambio.FormattingEnabled = true;
            this.comboBoxMonedaCambio.Location = new System.Drawing.Point(162, 77);
            this.comboBoxMonedaCambio.Name = "comboBoxMonedaCambio";
            this.comboBoxMonedaCambio.Size = new System.Drawing.Size(164, 24);
            this.comboBoxMonedaCambio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::UI.Properties.Resources.coins_add;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(85, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValor.Location = new System.Drawing.Point(162, 131);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(164, 22);
            this.textBoxValor.TabIndex = 7;
            // 
            // groupBoxWS
            // 
            this.groupBoxWS.Controls.Add(this.tabControl1);
            this.groupBoxWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxWS.Location = new System.Drawing.Point(403, 81);
            this.groupBoxWS.Name = "groupBoxWS";
            this.groupBoxWS.Size = new System.Drawing.Size(224, 200);
            this.groupBoxWS.TabIndex = 8;
            this.groupBoxWS.TabStop = false;
            this.groupBoxWS.Text = "Web Service BCCR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(208, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Actualizar Tipo de Cambio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxMonedaBase);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxValor);
            this.groupBox1.Controls.Add(this.comboBoxMonedaCambio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 200);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::UI.Properties.Resources.coins;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Moneda Base: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(201, 149);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtVentaCRC);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtCompraCRC);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(193, 120);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "USD a CRC";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Compra";
            // 
            // txtCompraCRC
            // 
            this.txtCompraCRC.Enabled = false;
            this.txtCompraCRC.Location = new System.Drawing.Point(75, 26);
            this.txtCompraCRC.Name = "txtCompraCRC";
            this.txtCompraCRC.Size = new System.Drawing.Size(100, 22);
            this.txtCompraCRC.TabIndex = 1;
            // 
            // txtVentaCRC
            // 
            this.txtVentaCRC.Enabled = false;
            this.txtVentaCRC.Location = new System.Drawing.Point(74, 54);
            this.txtVentaCRC.Name = "txtVentaCRC";
            this.txtVentaCRC.Size = new System.Drawing.Size(100, 22);
            this.txtVentaCRC.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Venta";
            // 
            // ActualizarTipoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 395);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxWS);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(669, 433);
            this.MinimumSize = new System.Drawing.Size(669, 433);
            this.Name = "ActualizarTipoCambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Tipo de Cambio";
            this.groupBoxWS.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.GroupBox groupBoxWS;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox comboBoxMonedaBase;
        public System.Windows.Forms.ComboBox comboBoxMonedaCambio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtVentaCRC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCompraCRC;
        private System.Windows.Forms.Label label5;
    }
}