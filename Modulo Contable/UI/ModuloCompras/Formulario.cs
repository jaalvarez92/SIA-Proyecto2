using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica.ModuloCompras;

namespace ModuloComprasVentas
{
    public partial class Formulario : Form
    {
        #region atributos
        decimal TotalAntesImpuestos = 0;
        decimal TotalConImpuestos = 0;
        decimal TotalImpuestos = 0;
        int fila = 0;
        int idMonedaSocio;
        String MonedaSocio = "";
        List<String> ListaArticulos = new List<string>();
        bool evento = true;
        #endregion

        #region inicializacion
        public Formulario()
        {
            InitializeComponent();
            panel.Show();
            panelServicios.Hide();
            agregarLineaDocumento();
        }
        #endregion


        #region eventos

        private void comboBoxTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void comboBoxSocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewComboBoxCell Articulos = ((DataGridViewComboBoxCell)dataGridView1.Rows[fila].Cells[0]);
            ListaArticulos = LogicaInsertarDocumentos.obtenerArticulos(comboBoxSocios.SelectedValue.ToString());
            Articulos.DataSource = ListaArticulos;
            DataGridViewTextBoxCell Moneda = ((DataGridViewTextBoxCell)dataGridView1.Rows[fila].Cells[3]);
            MonedaSocio = LogicaInsertarDocumentos.obtenerMoneda(comboBoxSocios.SelectedValue.ToString());
            Moneda.Value = MonedaSocio;
            idMonedaSocio = LogicaInsertarDocumentos.obtenerIdMonedaSocio(Moneda.Value.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = null;
            comboBox2.DataSource = LogicaInsertarDocumentos.obtenerDocumentosPrevios(comboBox1.SelectedIndex + 1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            evento = false;
            int DocPrevio = Int32.Parse(comboBox2.SelectedValue.ToString());
            int TipoDocPrevio = Int32.Parse(comboBox1.SelectedIndex+1.ToString());
            string Socio = comboBoxSocios.SelectedValue.ToString();
            List<string> InfoDocumentoPrevio = LogicaInsertarDocumentos.obtenerInfoDocumentoPrevio(DocPrevio, TipoDocPrevio, Socio);
            int filasGrid = LogicaInsertarDocumentos.ListaDocumentoPrevio.Count;
            int i;
            int cont = -1;
            for (i = 0; i < filasGrid; i++)
            {
                agregarLineaDocumento();
                DataGridViewComboBoxCell Articulos = ((DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[0]);
                DataGridViewTextBoxCell Descripcion = ((DataGridViewTextBoxCell)dataGridView1.Rows[i].Cells[1]);
                DataGridViewTextBoxCell Cantidad = ((DataGridViewTextBoxCell)dataGridView1.Rows[i].Cells[2]);
                DataGridViewTextBoxCell Moneda = ((DataGridViewTextBoxCell)dataGridView1.Rows[i].Cells[3]);
                DataGridViewTextBoxCell Precio = ((DataGridViewTextBoxCell)dataGridView1.Rows[i].Cells[4]);
                DataGridViewComboBoxCell Impuesto = ((DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[5]);
                DataGridViewTextBoxCell Total = ((DataGridViewTextBoxCell)dataGridView1.Rows[i].Cells[6]);
                DataGridViewComboBoxCell Bodegas = ((DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[7]);
                cont++;
                List<string> ListaArticulo = new List<string>();
                ListaArticulo.Add(InfoDocumentoPrevio.ElementAt(cont));
                Articulos.DataSource = ListaArticulo;
                Articulos.Value = ListaArticulo.ElementAt(0);
                Articulos.ReadOnly = true;
                cont++;
                Descripcion.Value = InfoDocumentoPrevio.ElementAt(cont);
                cont++;
                Cantidad.Value = InfoDocumentoPrevio.ElementAt(cont);
                cont++;
                Moneda.Value = InfoDocumentoPrevio.ElementAt(cont);
                cont++;
                Precio.Value = InfoDocumentoPrevio.ElementAt(cont);
                cont++;
                if(Decimal.Parse(InfoDocumentoPrevio.ElementAt(cont)) == 0)
                {
                    Impuesto.Value = "EXE";
                }
                else
                    Impuesto.Value = "IV";
                cont++;
                Total.Value = InfoDocumentoPrevio.ElementAt(cont);
                cont++;
                List<string> ListaBodega = new List<string>();
                ListaBodega.Add(InfoDocumentoPrevio.ElementAt(cont));
                Bodegas.DataSource = ListaBodega;
                Bodegas.Value = ListaBodega.ElementAt(0);
                calcularTotales(decimal.Parse(Precio.Value.ToString()),decimal.Parse(Cantidad.Value.ToString()), Impuesto.Value.ToString());
            }
            evento = true;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(evento == true){
                if (e.RowIndex >= 0)
                {
                    DataGridViewComboBoxCell Articulos = ((DataGridViewComboBoxCell)dataGridView1.Rows[e.RowIndex].Cells[0]);
                    DataGridViewTextBoxCell Descripcion = ((DataGridViewTextBoxCell)dataGridView1.Rows[e.RowIndex].Cells[1]);
                    DataGridViewTextBoxCell Cantidad = ((DataGridViewTextBoxCell)dataGridView1.Rows[e.RowIndex].Cells[2]);
                    DataGridViewTextBoxCell Moneda = ((DataGridViewTextBoxCell)dataGridView1.Rows[e.RowIndex].Cells[3]);
                    DataGridViewTextBoxCell Precio = ((DataGridViewTextBoxCell)dataGridView1.Rows[e.RowIndex].Cells[4]);
                    DataGridViewComboBoxCell Impuesto = ((DataGridViewComboBoxCell)dataGridView1.Rows[e.RowIndex].Cells[5]);
                    DataGridViewTextBoxCell Total = ((DataGridViewTextBoxCell)dataGridView1.Rows[e.RowIndex].Cells[6]);
                    DataGridViewComboBoxCell Bodegas = ((DataGridViewComboBoxCell)dataGridView1.Rows[e.RowIndex].Cells[7]);
                    Articulos.DataSource = ListaArticulos;
                    Moneda.Value = MonedaSocio;
                    if (e.ColumnIndex == 0)
                    {
                        Bodegas.DataSource = LogicaInsertarDocumentos.obtenerBodegas(Articulos.Value.ToString());
                    }
                    else if (e.ColumnIndex == 5)
                    {
                        decimal PrecioText = Decimal.Parse(Precio.Value.ToString());
                        decimal CantidadText = Decimal.Parse(Cantidad.Value.ToString());
                        String ImpuestoText = Impuesto.Value.ToString();
                        calcularTotales(PrecioText, CantidadText, ImpuestoText);
                        if (ImpuestoText == "EXE")
                            Total.Value = PrecioText * CantidadText;
                        else
                            Total.Value = ((PrecioText * CantidadText) + (PrecioText * CantidadText * Decimal.Parse("0,13"))).ToString();
                    }
                    else if (e.ColumnIndex == 7)
                    {
                        fila++;
                    }
                }

            }

        }

        private void botonAgregarLinea_Click(object sender, EventArgs e)
        {
            agregarLineaDocumento();
            DataGridViewComboBoxCell Articulos = ((DataGridViewComboBoxCell)dataGridView1.Rows[fila].Cells[0]);
            ListaArticulos = LogicaInsertarDocumentos.obtenerArticulos(comboBoxSocios.SelectedValue.ToString());
            Articulos.DataSource = ListaArticulos;
        }


        private void Crear_Click(object sender, EventArgs e)
        {
            int IdSocio = comboBoxSocios.SelectedIndex;
            int TipoDocumento = comboBoxTipoDoc.SelectedIndex+1;
            DateTime Fecha1 = dateTimePicker1.Value;
            DateTime Fecha2 = dateTimePicker2.Value;
            Decimal TotalAI = TotalAntesImpuestos;
            Decimal Impuestos = TotalImpuestos;
            int DocumentoPrevio;
            if (comboBox2.SelectedIndex == -1)
                DocumentoPrevio = 0;
            else
                DocumentoPrevio = (int)comboBox2.SelectedValue;
            int idDocumento = LogicaInsertarDocumentos.insertarDocumento(IdSocio, TipoDocumento, Fecha1, Fecha2, TotalAI, Impuestos, DocumentoPrevio, false, 1, idMonedaSocio);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                String IdBodega = ((DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[7]).Value.ToString();
                String Articulo = ((DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[0]).Value.ToString();
                int Cantidad = Int32.Parse(((DataGridViewTextBoxCell)dataGridView1.Rows[i].Cells[2]).Value.ToString());
                Decimal Precio = Decimal.Parse(((DataGridViewTextBoxCell)dataGridView1.Rows[i].Cells[4]).Value.ToString());
                String Descricpion = ((DataGridViewTextBoxCell)dataGridView1.Rows[i].Cells[1]).Value.ToString();
                Decimal Impuesto = 0;

                if (((DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[5]).Value.ToString() == "IV")
                {
                    Impuesto = Decimal.Parse("0,13");
                }     
                LogicaInsertarDocumentos.insertarLineaDetalleDocumento(idDocumento, IdBodega, Articulo, Cantidad, Precio, Descricpion, Impuesto, TipoDocumento, 1, idMonedaSocio);
            }
        }



        #endregion

        #region métodos

        public void obtenerDatos()
        {
            if (comboBoxTipoDoc.Text == "Factura de Servicios")
            {
                panel.Hide();
                botonAgregarLinea.Visible = false;
                panelServicios.Show();
            }
            else
            {
                panelServicios.Hide();
                panel.Show();
                int TipoDoc = comboBoxTipoDoc.SelectedIndex + 1;
                textBoxNumDoc.Text = (LogicaInsertarDocumentos.obtenerNumeroDocumento(TipoDoc)).ToString();
                obtenerSocios();
            }
        }

        public void obtenerSocios(){
            
            if (comboBoxTipoDoc.Text == "Orden de Compra" ||
                comboBoxTipoDoc.Text == "Entrada de Mercancías" ||
                comboBoxTipoDoc.Text == "Factura de Proveedores")
                    comboBoxSocios.DataSource = LogicaInsertarDocumentos.obtenerProveedores();
            else if(comboBoxTipoDoc.Text == "Orden de Venta" ||
                comboBoxTipoDoc.Text == "Entrega de Mercancías" ||
                comboBoxTipoDoc.Text == "Factura de Clientes" ||
                comboBoxTipoDoc.Text == "Notas de Crédito")
                    comboBoxSocios.DataSource = LogicaInsertarDocumentos.obtenerClientes();
        }

        public void agregarLineaDocumento()
        {
            dataGridView1.Rows.Add();

        }

        public void calcularTotales(decimal PrecioText, decimal CantidadText, string ImpuestoText)
        {
            if (ImpuestoText == "IV")
            {
                TotalAntesImpuestos = TotalAntesImpuestos + PrecioText * CantidadText;
                TotalImpuestos = TotalImpuestos + ((PrecioText * CantidadText) * Decimal.Parse("0,13"));
                TotalConImpuestos = TotalConImpuestos + (PrecioText * CantidadText) + ((PrecioText * CantidadText) * Decimal.Parse("0,13"));
            }
            else
            {
                TotalAntesImpuestos = TotalAntesImpuestos + (PrecioText * CantidadText);
                TotalConImpuestos = TotalConImpuestos + (PrecioText * CantidadText);
            }
                textBox2.Text = TotalAntesImpuestos.ToString();
                textBox3.Text = TotalImpuestos.ToString();
                textBox4.Text = TotalConImpuestos.ToString();
        }


        #endregion



    }
}
