namespace UI
{
    partial class CrearAsiento
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
            this.dataGridViewAsientos = new System.Windows.Forms.DataGridView();
            this.Cuenta = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DebitoLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditoLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebitoSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditoSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebitoOtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditoOtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAgregarLinea = new System.Windows.Forms.Button();
            this.buttonEliminarLinea = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.dateTimePickerFechaDocumento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalDebito = new System.Windows.Forms.Label();
            this.labelTotalCredito = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsientos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAsientos
            // 
            this.dataGridViewAsientos.AllowUserToAddRows = false;
            this.dataGridViewAsientos.AllowUserToDeleteRows = false;
            this.dataGridViewAsientos.AllowUserToResizeColumns = false;
            this.dataGridViewAsientos.AllowUserToResizeRows = false;
            this.dataGridViewAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta,
            this.Moneda,
            this.DebitoLocal,
            this.CreditoLocal,
            this.DebitoSistema,
            this.CreditoSistema,
            this.DebitoOtra,
            this.CreditoOtra});
            this.dataGridViewAsientos.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewAsientos.Name = "dataGridViewAsientos";
            this.dataGridViewAsientos.Size = new System.Drawing.Size(848, 249);
            this.dataGridViewAsientos.TabIndex = 0;
            this.dataGridViewAsientos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAsientos_CellEndEdit);
            // 
            // Cuenta
            // 
            this.Cuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            // 
            // Moneda
            // 
            this.Moneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            // 
            // DebitoLocal
            // 
            this.DebitoLocal.HeaderText = "Débito(local)";
            this.DebitoLocal.Name = "DebitoLocal";
            // 
            // CreditoLocal
            // 
            this.CreditoLocal.HeaderText = "Crédito(local)";
            this.CreditoLocal.Name = "CreditoLocal";
            // 
            // DebitoSistema
            // 
            this.DebitoSistema.HeaderText = "Débito(sistema)";
            this.DebitoSistema.Name = "DebitoSistema";
            this.DebitoSistema.ReadOnly = true;
            // 
            // CreditoSistema
            // 
            this.CreditoSistema.HeaderText = "Crédito(sistema)";
            this.CreditoSistema.Name = "CreditoSistema";
            this.CreditoSistema.ReadOnly = true;
            // 
            // DebitoOtra
            // 
            this.DebitoOtra.HeaderText = "Débito(Otras)";
            this.DebitoOtra.Name = "DebitoOtra";
            // 
            // CreditoOtra
            // 
            this.CreditoOtra.HeaderText = "Crédito(Otras)";
            this.CreditoOtra.Name = "CreditoOtra";
            // 
            // buttonAgregarLinea
            // 
            this.buttonAgregarLinea.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAgregarLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarLinea.ForeColor = System.Drawing.Color.White;
            this.buttonAgregarLinea.Image = global::UI.Properties.Resources.add;
            this.buttonAgregarLinea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregarLinea.Location = new System.Drawing.Point(554, 12);
            this.buttonAgregarLinea.Name = "buttonAgregarLinea";
            this.buttonAgregarLinea.Size = new System.Drawing.Size(153, 33);
            this.buttonAgregarLinea.TabIndex = 1;
            this.buttonAgregarLinea.Text = "Agregar Línea";
            this.buttonAgregarLinea.UseVisualStyleBackColor = false;
            this.buttonAgregarLinea.Click += new System.EventHandler(this.buttonAgregarLinea_Click);
            // 
            // buttonEliminarLinea
            // 
            this.buttonEliminarLinea.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEliminarLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarLinea.ForeColor = System.Drawing.Color.White;
            this.buttonEliminarLinea.Image = global::UI.Properties.Resources.delete;
            this.buttonEliminarLinea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminarLinea.Location = new System.Drawing.Point(713, 12);
            this.buttonEliminarLinea.Name = "buttonEliminarLinea";
            this.buttonEliminarLinea.Size = new System.Drawing.Size(143, 33);
            this.buttonEliminarLinea.TabIndex = 2;
            this.buttonEliminarLinea.Text = "Eliminar Línea";
            this.buttonEliminarLinea.UseVisualStyleBackColor = false;
            this.buttonEliminarLinea.Click += new System.EventHandler(this.buttonEliminarLinea_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Image = global::UI.Properties.Resources.accept;
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(618, 326);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(118, 29);
            this.buttonGuardar.TabIndex = 3;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonAtras
            // 
            this.buttonAtras.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtras.ForeColor = System.Drawing.Color.White;
            this.buttonAtras.Image = global::UI.Properties.Resources.arrow_left;
            this.buttonAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAtras.Location = new System.Drawing.Point(742, 326);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(118, 29);
            this.buttonAtras.TabIndex = 33;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = false;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // dateTimePickerFechaDocumento
            // 
            this.dateTimePickerFechaDocumento.Location = new System.Drawing.Point(138, 31);
            this.dateTimePickerFechaDocumento.Name = "dateTimePickerFechaDocumento";
            this.dateTimePickerFechaDocumento.Size = new System.Drawing.Size(332, 20);
            this.dateTimePickerFechaDocumento.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Fecha del documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Total Débito:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Total Crédito:";
            // 
            // labelTotalDebito
            // 
            this.labelTotalDebito.AutoSize = true;
            this.labelTotalDebito.Location = new System.Drawing.Point(83, 326);
            this.labelTotalDebito.Name = "labelTotalDebito";
            this.labelTotalDebito.Size = new System.Drawing.Size(13, 13);
            this.labelTotalDebito.TabIndex = 38;
            this.labelTotalDebito.Text = "0";
            // 
            // labelTotalCredito
            // 
            this.labelTotalCredito.AutoSize = true;
            this.labelTotalCredito.Location = new System.Drawing.Point(83, 345);
            this.labelTotalCredito.Name = "labelTotalCredito";
            this.labelTotalCredito.Size = new System.Drawing.Size(13, 13);
            this.labelTotalCredito.TabIndex = 39;
            this.labelTotalCredito.Text = "0";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(138, 5);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(332, 20);
            this.textBoxDescripcion.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Descripción:";
            // 
            // CrearAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 367);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelTotalCredito);
            this.Controls.Add(this.labelTotalDebito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFechaDocumento);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonEliminarLinea);
            this.Controls.Add(this.buttonAgregarLinea);
            this.Controls.Add(this.dataGridViewAsientos);
            this.Name = "CrearAsiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearAsiento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAsientos;
        private System.Windows.Forms.Button buttonAgregarLinea;
        private System.Windows.Forms.Button buttonEliminarLinea;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalDebito;
        private System.Windows.Forms.Label labelTotalCredito;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewComboBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebitoLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditoLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebitoSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditoSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebitoOtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditoOtra;
    }
}