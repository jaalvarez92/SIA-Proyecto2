namespace ModuloComprasVentas
{
    partial class Formulario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.botonAgregarLinea = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxNumDoc = new System.Windows.Forms.TextBox();
            this.panelServicios = new System.Windows.Forms.Panel();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.comboBoxCuentas = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Artículo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlmacenDestino = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Crear = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MontoImpuestos = new System.Windows.Forms.Label();
            this.TotalSinImpuesto = new System.Windows.Forms.Label();
            this.comboBoxTipoDoc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSocios = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelServicios.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.botonAgregarLinea);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBoxNumDoc);
            this.panel1.Controls.Add(this.panelServicios);
            this.panel1.Controls.Add(this.panel);
            this.panel1.Controls.Add(this.Crear);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.MontoImpuestos);
            this.panel1.Controls.Add(this.TotalSinImpuesto);
            this.panel1.Controls.Add(this.comboBoxTipoDoc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxSocios);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 653);
            this.panel1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(605, 163);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(195, 21);
            this.comboBox2.TabIndex = 33;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::UI.Properties.Resources.cancel;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(489, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 31);
            this.button1.TabIndex = 32;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // botonAgregarLinea
            // 
            this.botonAgregarLinea.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botonAgregarLinea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonAgregarLinea.Image = global::UI.Properties.Resources.add;
            this.botonAgregarLinea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAgregarLinea.Location = new System.Drawing.Point(47, 425);
            this.botonAgregarLinea.Name = "botonAgregarLinea";
            this.botonAgregarLinea.Size = new System.Drawing.Size(130, 31);
            this.botonAgregarLinea.TabIndex = 31;
            this.botonAgregarLinea.Text = "Agregar Linea";
            this.botonAgregarLinea.UseVisualStyleBackColor = false;
            this.botonAgregarLinea.Click += new System.EventHandler(this.botonAgregarLinea_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(196, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Tipo Documento Previo:";
            // 
            // textBoxNumDoc
            // 
            this.textBoxNumDoc.Location = new System.Drawing.Point(196, 120);
            this.textBoxNumDoc.Name = "textBoxNumDoc";
            this.textBoxNumDoc.Size = new System.Drawing.Size(197, 20);
            this.textBoxNumDoc.TabIndex = 28;
            // 
            // panelServicios
            // 
            this.panelServicios.Controls.Add(this.textBoxMonto);
            this.panelServicios.Controls.Add(this.label11);
            this.panelServicios.Controls.Add(this.label8);
            this.panelServicios.Controls.Add(this.label9);
            this.panelServicios.Controls.Add(this.textBoxDescripcion);
            this.panelServicios.Controls.Add(this.comboBoxCuentas);
            this.panelServicios.Location = new System.Drawing.Point(47, 212);
            this.panelServicios.Name = "panelServicios";
            this.panelServicios.Size = new System.Drawing.Size(800, 187);
            this.panelServicios.TabIndex = 26;
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(557, 139);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(195, 20);
            this.textBoxMonto.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(451, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Monto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Descripción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Cuentas:";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(136, 22);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(618, 74);
            this.textBoxDescripcion.TabIndex = 22;
            this.textBoxDescripcion.Text = "\r\n\r\n\r\n";
            // 
            // comboBoxCuentas
            // 
            this.comboBoxCuentas.FormattingEnabled = true;
            this.comboBoxCuentas.Location = new System.Drawing.Point(145, 139);
            this.comboBoxCuentas.Name = "comboBoxCuentas";
            this.comboBoxCuentas.Size = new System.Drawing.Size(195, 21);
            this.comboBoxCuentas.TabIndex = 24;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dataGridView1);
            this.panel.Location = new System.Drawing.Point(14, 219);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(855, 180);
            this.panel.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artículo,
            this.Descripción,
            this.Cantidad,
            this.Moneda,
            this.Precio,
            this.Impuesto,
            this.Total,
            this.AlmacenDestino});
            this.dataGridView1.Location = new System.Drawing.Point(3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(849, 177);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Artículo
            // 
            this.Artículo.HeaderText = "Artículo";
            this.Artículo.Name = "Artículo";
            this.Artículo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Artículo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Moneda
            // 
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Impuesto
            // 
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.Items.AddRange(new object[] {
            "IV",
            "EXE"});
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Impuesto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // AlmacenDestino
            // 
            this.AlmacenDestino.HeaderText = "Almacen Destino";
            this.AlmacenDestino.Name = "AlmacenDestino";
            this.AlmacenDestino.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AlmacenDestino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Crear
            // 
            this.Crear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Crear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Crear.Image = global::UI.Properties.Resources.accept;
            this.Crear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Crear.Location = new System.Drawing.Point(298, 563);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(98, 31);
            this.Crear.TabIndex = 21;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = false;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(700, 494);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(700, 462);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(700, 431);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(554, 494);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Total:";
            // 
            // MontoImpuestos
            // 
            this.MontoImpuestos.AutoSize = true;
            this.MontoImpuestos.Location = new System.Drawing.Point(554, 462);
            this.MontoImpuestos.Name = "MontoImpuestos";
            this.MontoImpuestos.Size = new System.Drawing.Size(106, 13);
            this.MontoImpuestos.TabIndex = 16;
            this.MontoImpuestos.Text = "Monto de Impuestos:";
            // 
            // TotalSinImpuesto
            // 
            this.TotalSinImpuesto.AutoSize = true;
            this.TotalSinImpuesto.Location = new System.Drawing.Point(554, 431);
            this.TotalSinImpuesto.Name = "TotalSinImpuesto";
            this.TotalSinImpuesto.Size = new System.Drawing.Size(129, 13);
            this.TotalSinImpuesto.TabIndex = 15;
            this.TotalSinImpuesto.Text = "Total antes de Impuestos:";
            // 
            // comboBoxTipoDoc
            // 
            this.comboBoxTipoDoc.FormattingEnabled = true;
            this.comboBoxTipoDoc.Items.AddRange(new object[] {
            "Orden de Compra",
            "Entrada de Mercancías",
            "Factura de Proveedores",
            "Orden de Venta",
            "Entrega de Mercancías",
            "Factura de Clientes",
            "Factura de Servicios",
            "Notas de Crédito"});
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(196, 54);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(200, 21);
            this.comboBoxTipoDoc.TabIndex = 13;
            this.comboBoxTipoDoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoDoc_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo de Documento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "# Documento Previo:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(605, 86);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha Contabilización:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Entrega:";
            // 
            // comboBoxSocios
            // 
            this.comboBoxSocios.FormattingEnabled = true;
            this.comboBoxSocios.Location = new System.Drawing.Point(603, 120);
            this.comboBoxSocios.Name = "comboBoxSocios";
            this.comboBoxSocios.Size = new System.Drawing.Size(199, 21);
            this.comboBoxSocios.TabIndex = 5;
            this.comboBoxSocios.SelectedIndexChanged += new System.EventHandler(this.comboBoxSocios_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Socio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de Documento:";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 651);
            this.Controls.Add(this.panel1);
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelServicios.ResumeLayout(false);
            this.panelServicios.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSocios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label MontoImpuestos;
        private System.Windows.Forms.Label TotalSinImpuesto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxCuentas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Panel panelServicios;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNumDoc;
        private System.Windows.Forms.ComboBox comboBoxTipoDoc;
        private System.Windows.Forms.DataGridViewComboBoxColumn Artículo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewComboBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewComboBoxColumn AlmacenDestino;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button botonAgregarLinea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}