using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace UI
{
    public partial class Configuracion : Form
    {

        #region Constructor
        public Configuracion()
        {
            InitializeComponent();
        }
        #endregion

        #region Propiedades
        private DateTime FechaInicioC{
            get
            {
                return dateTimePickerInicioContabilidad.Value;
            }
        }

        private DateTime FechaFinalC
        {
            get
            {
                return dateTimePickerFinalContabilidad.Value;
            }
        }

        private DateTime FechaInicioD
        {
            get
            {
                return dateTimePickerInicioDocumento.Value;
            }
        }

        private DateTime FechaFinalD
        {
            get
            {
                return dateTimePickerFinalDocumento.Value;
            }
        }

        private DateTime FechaInicioV
        {
            get
            {
                return dateTimePickerInicioVencimiento.Value;
            }
        }

        private DateTime FechaFinalV
        {
            get
            {
                return dateTimePickerFinalVencimiento.Value;
            }
        }
        #endregion 

        #region Eventos
        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Owner.Refresh();
            this.Close();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (GrupoLogica.AgregarPeriodoContable(FechaInicioC, FechaFinalC, FechaInicioD, FechaFinalD, FechaInicioV, FechaFinalV))
                MessageBox.Show("Se agregó el periodo contable exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else    
                MessageBox.Show("No se pudo agregar el periodo contable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion 
    }
}
