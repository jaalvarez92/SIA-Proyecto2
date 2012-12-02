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
    public partial class FacturasSocio : Form
    {
        public FacturasSocio()
        {
            InitializeComponent();
            //dataGridView1.Rows.RemoveAt(0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarDataGrid();
            obtenerDocumentos(comboBox2.SelectedIndex, comboBox1.SelectedIndex);
        }

        private void limpiarDataGrid()
        {
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
            catch (Exception e) { }
        }

        private void obtenerDocumentos(int pSocio, int pTipoSocio)
        {
            Entidades.Entity nueva;
            LogicaInsertarDocumentos.obtenerDocumentos(pSocio, pTipoSocio);
            for (int i = 0; i < LogicaInsertarDocumentos.Documentos.Count; i++)
            {
                dataGridView1.Rows.Add();
                nueva = LogicaInsertarDocumentos.Documentos.ElementAt(i);
                dataGridView1.Rows[i].Cells[0].Value = nueva.Get("numero");
                dataGridView1.Rows[i].Cells[1].Value = nueva.Get("Fecha1");
                dataGridView1.Rows[i].Cells[3].Value = nueva.Get("Fecha2");
                dataGridView1.Rows[i].Cells[2].Value = nueva.Get("totalai");
                dataGridView1.Rows[i].Cells[4].Value = nueva.Get("impuestos");
                dataGridView1.Rows[i].Cells[5].Value = nueva.Get("total");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            obtenerSocios(comboBox1.SelectedIndex);
        }

        private void obtenerSocios(int p)
        {
            if(p==0)
                comboBox2.DataSource = LogicaInsertarDocumentos.obtenerProveedores();
            else
                comboBox2.DataSource = LogicaInsertarDocumentos.obtenerClientes();
        }
    }
}
