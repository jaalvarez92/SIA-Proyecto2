using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using Entidades;

namespace UI
{
    public partial class VisualizarAsientos : Form
    {
        #region Atributos
        private Entities _Asientos;
        #endregion
        #region Propiedades
        public DateTime FechaInicio
        {
           get { return dateTimePickerInicio.Value.Date; }
        }

        public DateTime FechaFinal
        {
            get { return dateTimePickerFinal.Value.Date; }
        }

        #endregion

        #region Metodos
        public VisualizarAsientos()
        {
            InitializeComponent();
            botonCambiarFecha.Enabled = false;
        }

        private void mostrarAsientos()
        {
            dataGridViewAsientos.Rows.Clear();
            _Asientos = AsientoLogica.ObtenerAsientos(FechaInicio, FechaFinal);
            foreach (Entity asiento in _Asientos)
            {
                String fechaC = ((DateTime)asiento.Get("fechacontabilizado")).ToString();
                String codigo = ((int)asiento.Get("codigoasiento")).ToString();
                String descripcion = (String)asiento.Get("descripcion");
                String cuenta = (String)asiento.Get("nombre");
                String debito_local = ((decimal)asiento.Get("debito_local")).ToString();
                String credito_local = ((decimal)asiento.Get("credito_local")).ToString();
                String debito_sistema = ((decimal)asiento.Get("debito_sistema")).ToString();
                String credito_sistema = ((decimal)asiento.Get("credito_sistema")).ToString();
                dataGridViewAsientos.Rows.Add(fechaC, codigo, descripcion, cuenta, debito_local, credito_local, debito_sistema, credito_sistema);
            }
        }

        #endregion

        #region Eventos
        private void botonConsultarAsientos_Click(object sender, EventArgs e)
        {
            botonConsultarAsientos.Enabled = false;
            botonCambiarFecha.Enabled = true;
            dateTimePickerFinal.Enabled = false;
            dateTimePickerInicio.Enabled = false;
            mostrarAsientos();
        }
        #endregion

        private void botonCambiarFecha_Click(object sender, EventArgs e)
        {
            dateTimePickerFinal.Enabled = true;
            dateTimePickerInicio.Enabled = true;
            botonConsultarAsientos.Enabled = true;
        }

        private void anularAsiento(int pCodigoAsiento) 
        {
            AsientoLogica.NulificarAsiento(pCodigoAsiento);
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {

            this.Owner.Show();	 
            this.Close();
        }

        private void botonAnularAsiento_Click(object sender, EventArgs e)
        {
            try	   
            {	   
                int numerlAsiento = int.Parse(textBoxNumeroAsiento.Text);	   
                if (textBoxNumeroAsiento.Text == "")	   
                {	   
                    MessageBox.Show("Debe Ingresar un número de asiento a insertar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	   
                    return;	   
                }	   
	   
                anularAsiento(numerlAsiento);	   
            }	   
            catch (Exception Ex) { MessageBox.Show("Debe Ingresar un número de asiento a insertar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }	   

        }

    }
}
