namespace UI.ModuloClientes
{
    partial class ConsultarSocio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.CLodigo = new System.Windows.Forms.Label();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.dataGridViewDcoumentos = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDcoumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(12, 145);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(136, 20);
            this.textBoxCodigo.TabIndex = 0;
            // 
            // CLodigo
            // 
            this.CLodigo.AutoSize = true;
            this.CLodigo.BackColor = System.Drawing.Color.Transparent;
            this.CLodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CLodigo.Location = new System.Drawing.Point(9, 129);
            this.CLodigo.Name = "CLodigo";
            this.CLodigo.Size = new System.Drawing.Size(40, 13);
            this.CLodigo.TabIndex = 1;
            this.CLodigo.Text = "Código";
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.ForeColor = System.Drawing.Color.White;
            this.buttonConsultar.Image = global::UI.Properties.Resources.magnifier;
            this.buttonConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConsultar.Location = new System.Drawing.Point(12, 187);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(136, 34);
            this.buttonConsultar.TabIndex = 5;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDatos.Controls.Add(this.dataGridViewDcoumentos);
            this.groupBoxDatos.Controls.Add(this.label5);
            this.groupBoxDatos.Controls.Add(this.labelSaldo);
            this.groupBoxDatos.Controls.Add(this.label3);
            this.groupBoxDatos.Controls.Add(this.labelNombre);
            this.groupBoxDatos.Controls.Add(this.label1);
            this.groupBoxDatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxDatos.Location = new System.Drawing.Point(168, 12);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(466, 411);
            this.groupBoxDatos.TabIndex = 6;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos del Socio";
            // 
            // dataGridViewDcoumentos
            // 
            this.dataGridViewDcoumentos.AllowUserToAddRows = false;
            this.dataGridViewDcoumentos.AllowUserToDeleteRows = false;
            this.dataGridViewDcoumentos.AllowUserToResizeColumns = false;
            this.dataGridViewDcoumentos.AllowUserToResizeRows = false;
            this.dataGridViewDcoumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDcoumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Tipo,
            this.Monto,
            this.Consultar});
            this.dataGridViewDcoumentos.Location = new System.Drawing.Point(37, 175);
            this.dataGridViewDcoumentos.Name = "dataGridViewDcoumentos";
            this.dataGridViewDcoumentos.RowHeadersVisible = false;
            this.dataGridViewDcoumentos.Size = new System.Drawing.Size(406, 219);
            this.dataGridViewDcoumentos.TabIndex = 6;
            // 
            // Fecha
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Tipo
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Tipo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Monto
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Monto.DefaultCellStyle = dataGridViewCellStyle3;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Consultar
            // 
            this.Consultar.HeaderText = "Consultar";
            this.Consultar.Name = "Consultar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Documentos Pendientes: ";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.Location = new System.Drawing.Point(116, 90);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(0, 25);
            this.labelSaldo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(116, 32);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(0, 25);
            this.labelNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.ForeColor = System.Drawing.Color.White;
            this.buttonVolver.Image = global::UI.Properties.Resources.arrow_left;
            this.buttonVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVolver.Location = new System.Drawing.Point(498, 435);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(136, 34);
            this.buttonVolver.TabIndex = 7;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // ConsultarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(642, 481);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.CLodigo);
            this.Controls.Add(this.textBoxCodigo);
            this.Name = "ConsultarSocio";
            this.Text = "ConsultarSocio";
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDcoumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label CLodigo;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.DataGridView dataGridViewDcoumentos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewButtonColumn Consultar;
    }
}