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
using UI.ERPAsientos;

namespace UI
{
    public partial class CrearAsiento : Form
    {

        #region Atributos
        private Entities _Monedas;
        private Entities _Cuentas;
        private Entity _Empresa;
        public int _ColumnaTC;
        public int _FilaTC;
        #endregion
 
        #region Propiedades
        private DataGridViewRow UltimaFila
        {
            get
            {
                return dataGridViewAsientos.Rows[dataGridViewAsientos.RowCount - 1];
            }
        }

        private int UltimaMoneda
        {
            get
            {
                int codigo;
                if (UltimaFila.Cells[1].Value == null) codigo = 0;
                else
                {
                    Entity moneda = _Monedas.Get("simbolo", UltimaFila.Cells[1].Value);
                    codigo = (int)moneda.Get("idmoneda");
                }
                return codigo;
            }
        }
        
        private int UltimaCuenta
        {
            get
            {
                int codigo;
                if (UltimaFila.Cells[0].Value == null) codigo = 0;
                else
                {
                    Entity cuenta = _Cuentas.Get("nombre", UltimaFila.Cells[0].Value);
                    codigo = (int)cuenta.Get("idcuenta");
                }
                return codigo;
            }
        }

        private Decimal UltimoDebito
        {
            get
            {
                if (UltimaFila.Cells[2].Value!="")
                    return Decimal.Parse(UltimaFila.Cells[2].Value.ToString());
                else
                    return 0;
            }
        }

        private Decimal UltimoCredito
        {
            get
            {
                if (UltimaFila.Cells[3].Value!="")
                    return Decimal.Parse(UltimaFila.Cells[3].Value.ToString());
                else
                    return 0;
            }
        }

        private Decimal UltimoDebitoSistema
        {
            get
            {
                if (UltimaFila.Cells[4].Value != "")
                    return Decimal.Parse(UltimaFila.Cells[4].Value.ToString());
                else
                    return 0;
            }
        }

        private Decimal UltimoCreditoSistema
        {
            get
            {
                if (UltimaFila.Cells[5].Value != "")
                    return Decimal.Parse(UltimaFila.Cells[5].Value.ToString());
                else
                    return 0;
            }
        }

        private Decimal UltimoDebitoOtras
        {
            get
            {
                if (UltimaFila.Cells[6].Value != "")
                    return Decimal.Parse(UltimaFila.Cells[6].Value.ToString());
                else
                    return 0;
            }
        }

        private Decimal UltimoCreditoOtras
        {
            get
            {
                if (UltimaFila.Cells[7].Value != "")
                    return Decimal.Parse(UltimaFila.Cells[7].Value.ToString());
                else
                    return 0;
            }
        }

        private DateTime FechaDocumento
        {
            get
            {
                return dateTimePickerFechaDocumento.Value;
            }
        }

        private String Descripcion
        {
            get
            {
                return textBoxDescripcion.Text;
            }
        }

        private int IdMonedaSistema
        {
            get
            {
                return (int)_Empresa.Get("fk_monedaSistema");
            }
        }

        private int IdMonedaLocal
        {
            get
            {
                return (int)_Empresa.Get("fk_monedaLocal");
            }
        }

        #endregion

        #region Constructor
        public CrearAsiento()
        {
            InitializeComponent();
            LlenarTabla();
            ObtenerInfoEmpresa();
        }
        #endregion

        #region Métodos
        private void ObtenerInfoEmpresa()
        {
            _Empresa = GrupoLogica.ObtenerInformacionEmpresa();
        }

        private void LlenarTabla()
        {
            _Monedas = MonedaLogica.ObtenerMonedas();
            //foreach (Entity moneda in _Monedas){
            //    ((DataGridViewComboBoxColumn)dataGridViewAsientos.Columns[1]).Items.Add(moneda.Get("simbolo"));
            //}
            _Cuentas = CuentaLogica.ObtenerCuentas();
            foreach (Entity cuenta in _Cuentas){
                if (! (Boolean)cuenta.Get("estitulo"))
                ((DataGridViewComboBoxColumn)dataGridViewAsientos.Columns[0]).Items.Add(cuenta.Get("nombre"));
            }
        }

        private Boolean CalcularTotales()
        {
            decimal debito = 0;
            decimal credito = 0;

            labelTotalDebito.Text = "0";
            labelTotalCredito.Text = "0";
            foreach (DataGridViewRow dr in dataGridViewAsientos.Rows)
            {

                if (dr.Cells[2].Value !="")
                {
                    debito += Decimal.Parse(dr.Cells[2].Value.ToString());
                    labelTotalDebito.Text = debito.ToString();
                }
                    
                if (dr.Cells[3].Value !="")
                {
                    credito += Decimal.Parse(dr.Cells[3].Value.ToString());
                    labelTotalCredito.Text = credito.ToString();
                }
            }
            return credito.Equals(debito);
        }

        private Boolean ValidarUltimaFila()
        {
            if (dataGridViewAsientos.RowCount != 0)
            {
                return (UltimaMoneda != 0 && UltimaCuenta != 0 && FechaDocumento != null
               && ((UltimoDebito == 0 && UltimoCredito != 0) || (UltimoDebito != 0 && UltimoCredito == 0))
               && ((UltimoDebitoSistema == 0 && UltimoCreditoSistema != 0) || (UltimoDebitoSistema != 0 && UltimoCreditoSistema == 0)));
            }
            else
            {
                return true;
            }
        }

        private void LlenarComboBoxMonedas(int pIdFila)
        {
            ((DataGridViewComboBoxCell)dataGridViewAsientos.Rows[pIdFila].Cells[1]).Items.Clear();
            if (UltimaCuenta != 0)
            {
                Entity cuenta = _Cuentas.Get("idcuenta", UltimaCuenta);

                Object idmoneda = cuenta.Get("fk_idmoneda");
                if (idmoneda == DBNull.Value)
                {
                    foreach (Entity moneda in _Monedas)
                    {
                        ((DataGridViewComboBoxCell)dataGridViewAsientos.Rows[pIdFila].Cells[1]).Items.Add((String)moneda.Get("simbolo"));
                    }
                }
                else
                {
                    Entity moneda = _Monedas.Get("idmoneda", (int)idmoneda);
                    ((DataGridViewComboBoxCell)dataGridViewAsientos.Rows[pIdFila].Cells[1]).Items.Add((String)moneda.Get("simbolo"));
                }
            }
        }

        private void ProcesarSeleccionMoneda(int pIdFila)
        {
            if (UltimaMoneda != 0)
            {
                dataGridViewAsientos.Rows[pIdFila].Cells[2].ReadOnly = true;
                dataGridViewAsientos.Rows[pIdFila].Cells[3].ReadOnly = true;
                dataGridViewAsientos.Rows[pIdFila].Cells[4].ReadOnly = true;
                dataGridViewAsientos.Rows[pIdFila].Cells[5].ReadOnly = true;
                dataGridViewAsientos.Rows[pIdFila].Cells[6].ReadOnly = true;
                dataGridViewAsientos.Rows[pIdFila].Cells[7].ReadOnly = true;
                dataGridViewAsientos.Rows[pIdFila].Cells[2].Value = "";
                dataGridViewAsientos.Rows[pIdFila].Cells[3].Value = "";
                dataGridViewAsientos.Rows[pIdFila].Cells[4].Value = "";
                dataGridViewAsientos.Rows[pIdFila].Cells[5].Value = "";
                dataGridViewAsientos.Rows[pIdFila].Cells[6].Value = "";
                dataGridViewAsientos.Rows[pIdFila].Cells[7].Value = "";

                if (UltimaMoneda == IdMonedaLocal)
                {
                    dataGridViewAsientos.Rows[pIdFila].Cells[2].ReadOnly = false;
                    dataGridViewAsientos.Rows[pIdFila].Cells[3].ReadOnly = false;
                }
                else
                {
                    if (UltimaMoneda == IdMonedaSistema)
                    {
                        dataGridViewAsientos.Rows[pIdFila].Cells[4].ReadOnly = false;
                        dataGridViewAsientos.Rows[pIdFila].Cells[5].ReadOnly = false;
                    }
                    else
                    {
                        dataGridViewAsientos.Rows[pIdFila].Cells[6].ReadOnly = false;
                        dataGridViewAsientos.Rows[pIdFila].Cells[7].ReadOnly = false;
                    }
                }
            }
        }

        private void AbrirActualizarTipoCambio(int pIdColumna)
        {
            ActualizarTipoCambio actualizar = new ActualizarTipoCambio();
            actualizar.Show(this);
            if (pIdColumna == 2 || pIdColumna == 3)
            {
                actualizar.MonedaBase = IdMonedaLocal;
                actualizar.MonedaCambio = IdMonedaSistema;
            }
            else if (pIdColumna == 4 || pIdColumna == 5)
            {
                actualizar.MonedaBase = IdMonedaSistema;
                actualizar.MonedaCambio = IdMonedaLocal;
            }
            else
            {
                actualizar.MonedaBase = UltimaMoneda;
                actualizar.MonedaCambio = IdMonedaLocal;
            }
            actualizar.comboBoxMonedaBase.Enabled = false;
            actualizar.comboBoxMonedaCambio.Enabled = false;
            this.Enabled = false;
        }

        public void ProcesarTipoCambio(int pIdFila, int pIdColumna)
        {
            _FilaTC = pIdFila;
            _ColumnaTC = pIdColumna;
            if (pIdColumna == 2 || pIdColumna == 3)
            {
                Entity tipo_cambio = TipoCambioLogica.ObtenerTipoCambio(IdMonedaLocal, IdMonedaSistema, DateTime.Now);
                Entities tabla = (Entities)tipo_cambio.Get("table");
                if (tabla.Count > 0)
                {
                    Entity tipo_cambio_ = tabla[0];
                    decimal monto = (decimal)tipo_cambio_.Get("cambio");
                    dataGridViewAsientos.Rows[pIdFila].Cells[pIdColumna + 2].Value = (decimal.Parse(dataGridViewAsientos.Rows[pIdFila].Cells[pIdColumna].Value.ToString()) * monto).ToString();
                }
                else
                {
                    AbrirActualizarTipoCambio(pIdColumna);
                }
            }
            if (pIdColumna == 4 || pIdColumna == 5)
            {
                Entity tipo_cambio = TipoCambioLogica.ObtenerTipoCambio(IdMonedaSistema, IdMonedaLocal, DateTime.Now);
                Entities tabla = (Entities)tipo_cambio.Get("table");
                if (tabla.Count > 0)
                {
                    Entity tipo_cambio_ = tabla[0];
                    decimal monto = (decimal)tipo_cambio_.Get("cambio");
                    dataGridViewAsientos.Rows[pIdFila].Cells[pIdColumna - 2].Value = (decimal.Parse(dataGridViewAsientos.Rows[pIdFila].Cells[pIdColumna].Value.ToString()) * monto).ToString();
                }
                else
                {
                    AbrirActualizarTipoCambio(pIdColumna);
                }
            }
            if (pIdColumna == 6 || pIdColumna == 7)
            {
                Entity tipo_cambio = TipoCambioLogica.ObtenerTipoCambio(UltimaMoneda, IdMonedaLocal, DateTime.Now);
                Entities tabla = (Entities)tipo_cambio.Get("table");
                if (tabla.Count > 0)
                {
                    Entity tipo_cambio_ = tabla[0];
                    decimal monto = (decimal)tipo_cambio_.Get("cambio");
                    dataGridViewAsientos.Rows[pIdFila].Cells[pIdColumna - 4].Value = (decimal.Parse(dataGridViewAsientos.Rows[pIdFila].Cells[pIdColumna].Value.ToString()) * monto).ToString();
                    ProcesarTipoCambio(pIdFila, pIdColumna-4);
                }
                else
                {
                    AbrirActualizarTipoCambio(pIdColumna);
                }
            }
            CalcularTotales();

        }

        private int ObtenerIdCuenta(string pNombre)
        {
            int id=0;
            foreach (Entity cuenta in _Cuentas)
            {
                if (((string)cuenta.Get("Nombre")).Equals(pNombre))
                {
                    id = (int)cuenta.Get("IdCuenta");
                }
            }
            return id;
        }

        
        private void GuardarAsiento()
        {
            //int idAsiento = AsientoLogica.IngresarAsiento(FechaDocumento);
            ERPAsientos.ERPAsientosClient cliente = new ERPAsientosClient();
            int idAsiento = cliente.ingresarNuevoAsiento(FechaDocumento);
            foreach (DataGridViewRow dr in dataGridViewAsientos.Rows)
            {
                int idcuenta = ObtenerIdCuenta(dr.Cells[0].Value.ToString());
                if (!dr.Cells[2].Value.Equals(""))
                    cliente.ingresarCuentasAsiento(idAsiento, idcuenta, Decimal.Parse(dr.Cells[2].Value.ToString()), Decimal.Parse(dr.Cells[4].Value.ToString()), false);
                else
                    cliente.ingresarCuentasAsiento(idAsiento, idcuenta, Decimal.Parse(dr.Cells[3].Value.ToString()), Decimal.Parse(dr.Cells[5].Value.ToString()), true);
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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (CalcularTotales())
            {
                GuardarAsiento();
            }
            else
            {
                MessageBox.Show("Los montos de Débito y crédito de Sistema deben ser iguales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonAgregarLinea_Click(object sender, EventArgs e)
        {
            if (ValidarUltimaFila())
            {
                if (dataGridViewAsientos.RowCount > 0)
                {
                    if (UltimoDebito > 0)
                    {
                        labelTotalDebito.Text = (Decimal.Parse(labelTotalDebito.Text) + UltimoDebito).ToString();
                    }
                    if (UltimoCredito > 0)
                    {
                        labelTotalCredito.Text = (Decimal.Parse(labelTotalCredito.Text) + UltimoCredito).ToString();
                    }
                    dataGridViewAsientos.Rows[dataGridViewAsientos.RowCount - 1].ReadOnly = true;
                }
                dataGridViewAsientos.Rows.Add();
                dataGridViewAsientos.Rows[dataGridViewAsientos.RowCount-1].Cells[2].Value="";
                dataGridViewAsientos.Rows[dataGridViewAsientos.RowCount-1].Cells[3].Value="";
                dataGridViewAsientos.Rows[dataGridViewAsientos.RowCount-1].Cells[4].Value="";
                dataGridViewAsientos.Rows[dataGridViewAsientos.RowCount-1].Cells[5].Value="";
            }
            else
            {
                MessageBox.Show("La línea que intenta agregar es inválida o no tiene la información necesaria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEliminarLinea_Click(object sender, EventArgs e)
        {
            List<int> a_eliminar = new List<int>();
            if  (dataGridViewAsientos.RowCount != 0){
                for (int i = dataGridViewAsientos.RowCount - 1; i >= 0; i--)
                {
                    if (dataGridViewAsientos.Rows[i].Selected)
                    {
                        a_eliminar.Add(i);
                    }
                }

                foreach (int i in a_eliminar)
                {
                    dataGridViewAsientos.Rows.RemoveAt(i);
                }
            }
            CalcularTotales();
        }

        private void dataGridViewAsientos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                LlenarComboBoxMonedas(e.RowIndex);
            if (e.ColumnIndex == 1)
                ProcesarSeleccionMoneda(e.RowIndex);
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
                ProcesarTipoCambio(e.RowIndex, e.ColumnIndex);
            CalcularTotales();
        }

        #endregion

        
        
    }
}
