using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace UI
{
    public partial class ActualizarTipoCambio : Form
    {
        #region Atributos
        private Entities _Monedas;
        #endregion

        #region Propiedades
        public int MonedaBase
        {
            get
            {
                int codigo;
                if (comboBoxMonedaBase.Text.Equals("")) codigo = 0;
                else
                {
                    Entity moneda = _Monedas.Get("nombre", comboBoxMonedaBase.Text);
                    codigo = (int)moneda.Get("idmoneda");
                }
                return codigo;
            }
            set 
            {
                Entity moneda = _Monedas.Get("idmoneda", value);
                comboBoxMonedaBase.Text = (String)moneda.Get("nombre");
            }
        }


        public int MonedaCambio
        {
            get
            {
                int codigo;
                if (comboBoxMonedaCambio.Text.Equals("")) codigo = 0;
                else
                {
                    Entity moneda = _Monedas.Get("nombre", comboBoxMonedaCambio.Text);
                    codigo = (int)moneda.Get("idmoneda");
                }
                return codigo;
            }
            set
            {
                Entity moneda = _Monedas.Get("idmoneda", value);
                comboBoxMonedaCambio.Text = (String)moneda.Get("nombre");
            }
        }

        public decimal Valor
        {
            get
            {
                decimal valor;
                if (textBoxValor.Text.Equals("")) valor = 0;
                else
                {
                    valor = decimal.Parse(textBoxValor.Text);
                }
                return valor;
            }
        }
        #endregion




        #region Constructor
        public ActualizarTipoCambio()
        {
            InitializeComponent();
            LlenarComboBoxMonedas();
            ConectarConBCCR();
        }

        
        #endregion 

        #region Métodos
        public void LlenarComboBoxMonedas()
        {
            comboBoxMonedaBase.Items.Clear();
            comboBoxMonedaCambio.Items.Clear();
            _Monedas = MonedaLogica.ObtenerMonedas();
            foreach (Entity moneda in _Monedas)
            {
                comboBoxMonedaBase.Items.Add(moneda.Get("nombre"));
                comboBoxMonedaCambio.Items.Add(moneda.Get("nombre"));
            }
        }

        private void IngresarTipoCambio()
        {
            TipoCambioLogica.IngresarTipoCambio(MonedaBase, MonedaCambio, Valor);
        }

        public Boolean ValidarCampos()
        {
            return (!MonedaBase.Equals(0) && !MonedaCambio.Equals(0) && !Valor.Equals(0));
        }
        #endregion


        #region Eventos
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Owner.Enabled = true;
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            IngresarTipoCambio();
            this.Owner.Enabled = true;
            CrearAsiento ca =  ((CrearAsiento)this.Owner);
            ((CrearAsiento)this.Owner).ProcesarTipoCambio(ca._FilaTC, ca._ColumnaTC);
            this.Close();
        }

        private void ConectarConBCCR()
        {
            txtCompraCRC.Text = ConexionBCCR.TipoCambio.Instancia.obtenerTipoCambioCompra(DateTime.Now).ToString();
            txtVentaCRC.Text = ConexionBCCR.TipoCambio.Instancia.obtenerTipoCambioVenta(DateTime.Now).ToString();
        }
        #endregion 
    }
}
