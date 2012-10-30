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
    public partial class CrearEmpresa : Form
    {
        #region Constructor
        public CrearEmpresa()
        {
            InitializeComponent();
            LLenarComboBoxMonedas();
        }
        #endregion

        #region Propiedades
        public String NombreEmpresa
        {
            get { return textBoxNombreEmpresa.Text; }
            set { textBoxNombreEmpresa.Text = value; }
        }

        public String Cedula
        {
            get { return textBoxCedulaJuridica.Text; }
            set { textBoxCedulaJuridica.Text = value; }
        }

        public String Logotipo
        {
            get { return textBoxLogotipo.Text; }
            set { textBoxLogotipo.Text = value; }
        }

        public String Esquema
        {
            get { return textBoxEsquema.Text; }
            set { textBoxEsquema.Text = value; }
        }

        public String MonedaLocal
        {
            get { return comboBoxMonedaLocal.Text; }
            set { comboBoxMonedaLocal.Text = value; }
        }

        public String MonedaSistema
        {
            get { return comboBoxMonedaSistema.Text; }
            set { comboBoxMonedaSistema.Text = value; }
        }
        #endregion

        #region Eventos
        private void botonCrearEmpresa_Click(object sender, EventArgs e)
        {
            if (GrupoLogica.CrearEmpresaGrupo(NombreEmpresa, Esquema, int.Parse(Cedula), Logotipo, MonedaLocal, MonedaSistema))
            {
                MessageBox.Show("Creación exitosa de empresa.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Owner.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Creación de empresa no pudo ser completada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Owner.Refresh();
            this.Close();
        }

        private void botonRutaArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxLogotipo.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
        }
        #endregion

        #region Métodos
        public void LLenarComboBoxMonedas()
        {
            Entities monedas = MonedaLogica.ObtenerMonedas();
            foreach (Entity moneda in monedas)
            {
                comboBoxMonedaLocal.Items.Add(moneda.Get("nombre"));
                comboBoxMonedaSistema.Items.Add(moneda.Get("nombre"));
            }
        }
        #endregion

    }
}
