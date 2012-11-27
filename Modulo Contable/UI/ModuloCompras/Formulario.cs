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
        List<String> ListaArticulos = new List<string>();
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = null;
            comboBox2.DataSource = LogicaInsertarDocumentos.obtenerDocumentosPrevios(comboBox1.SelectedIndex + 1);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
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
                if (e.ColumnIndex == 0)
                {
                    Bodegas.DataSource = LogicaInsertarDocumentos.obtenerBodegas(Articulos.Value.ToString());
                    Moneda.Value = LogicaInsertarDocumentos.obtenerMoneda(Articulos.Value.ToString());
                }
                else if (e.ColumnIndex == 5)
                {
                    decimal PrecioText = Decimal.Parse(Precio.Value.ToString());
                    decimal CantidadText = Decimal.Parse(Cantidad.Value.ToString());
                    if (Impuesto.Value.ToString() == "EXE")
                    {
                        Total.Value = PrecioText * CantidadText;
                        TotalAntesImpuestos = TotalAntesImpuestos + (PrecioText * CantidadText);
                        TotalConImpuestos = TotalConImpuestos + (PrecioText * CantidadText);
                        textBox2.Text = TotalAntesImpuestos.ToString();
                        textBox3.Text = (TotalImpuestos + 0).ToString();
                        textBox4.Text = TotalConImpuestos.ToString();
                    }
                    else 
                    {
                        Total.Value = ((PrecioText * CantidadText) + (PrecioText * CantidadText * Decimal.Parse("0,13"))).ToString();
                        TotalAntesImpuestos = TotalAntesImpuestos + PrecioText * CantidadText;
                        TotalImpuestos = TotalImpuestos + ((PrecioText * CantidadText) * Decimal.Parse("0,13"));
                        TotalConImpuestos = TotalConImpuestos + TotalAntesImpuestos + TotalImpuestos;
                        textBox2.Text = TotalAntesImpuestos.ToString();
                        textBox3.Text = TotalImpuestos.ToString();
                        textBox4.Text = TotalConImpuestos.ToString();
                    }
                }
                else if(e.ColumnIndex == 7)
                {
                    fila++;
                }

            }

        }

        private void botonAgregarLinea_Click(object sender, EventArgs e)
        {
            agregarLineaDocumento();
            DataGridViewComboBoxCell Articulos = ((DataGridViewComboBoxCell)dataGridView1.Rows[fila].Cells[0]);
            ListaArticulos = LogicaInsertarDocumentos.obtenerArticulos(comboBoxSocios.SelectedValue.ToString());
            Articulos.DataSource = ListaArticulos;
            fila++;
        }


        private void Crear_Click(object sender, EventArgs e)
        {
            int IdSocio = comboBoxSocios.SelectedIndex;
            int TipoDocumento = comboBoxTipoDoc.SelectedIndex+1;
            DateTime Fecha1 = dateTimePicker1.Value;
            DateTime Fecha2 = dateTimePicker2.Value;
            Decimal TotalAI = TotalAntesImpuestos;
            Decimal Impuestos = TotalImpuestos;
            int DocumentoPrevio = (int)comboBox2.SelectedValue;
            //se cae si no se pone un documento previo 
            int idDocumento = LogicaInsertarDocumentos.insertarDocumento(IdSocio, TipoDocumento, Fecha1, Fecha2, TotalAI, Impuestos, DocumentoPrevio, false, 1, 1);
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
                LogicaInsertarDocumentos.insertarLineaDetalleDocumento(idDocumento, IdBodega, Articulo, Cantidad, Precio, Descricpion, Impuesto, TipoDocumento, 1, 1);
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
        #endregion

    }
}
