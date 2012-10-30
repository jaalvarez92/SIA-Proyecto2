namespace PruebaPDF
{
    partial class Form1
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
            this.btnEstadoResultados = new System.Windows.Forms.Button();
            this.btnBalanceGeneral = new System.Windows.Forms.Button();
            this.btnBalanceComprobacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstadoResultados
            // 
            this.btnEstadoResultados.Location = new System.Drawing.Point(12, 12);
            this.btnEstadoResultados.Name = "btnEstadoResultados";
            this.btnEstadoResultados.Size = new System.Drawing.Size(196, 22);
            this.btnEstadoResultados.TabIndex = 0;
            this.btnEstadoResultados.Text = "Generar Estado de Resultados";
            this.btnEstadoResultados.UseVisualStyleBackColor = true;
            this.btnEstadoResultados.Click += new System.EventHandler(this.btnEstadoResultados_Click);
            // 
            // btnBalanceGeneral
            // 
            this.btnBalanceGeneral.Location = new System.Drawing.Point(12, 40);
            this.btnBalanceGeneral.Name = "btnBalanceGeneral";
            this.btnBalanceGeneral.Size = new System.Drawing.Size(196, 22);
            this.btnBalanceGeneral.TabIndex = 1;
            this.btnBalanceGeneral.Text = "Generar Balance General";
            this.btnBalanceGeneral.UseVisualStyleBackColor = true;
            this.btnBalanceGeneral.Click += new System.EventHandler(this.btnBalanceGeneral_Click);
            // 
            // btnBalanceComprobacion
            // 
            this.btnBalanceComprobacion.Location = new System.Drawing.Point(12, 68);
            this.btnBalanceComprobacion.Name = "btnBalanceComprobacion";
            this.btnBalanceComprobacion.Size = new System.Drawing.Size(196, 22);
            this.btnBalanceComprobacion.TabIndex = 2;
            this.btnBalanceComprobacion.Text = "Generar Balance de Comprobación";
            this.btnBalanceComprobacion.UseVisualStyleBackColor = true;
            this.btnBalanceComprobacion.Click += new System.EventHandler(this.btnBalanceComprobacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 112);
            this.Controls.Add(this.btnBalanceComprobacion);
            this.Controls.Add(this.btnBalanceGeneral);
            this.Controls.Add(this.btnEstadoResultados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstadoResultados;
        private System.Windows.Forms.Button btnBalanceGeneral;
        private System.Windows.Forms.Button btnBalanceComprobacion;
    }
}

