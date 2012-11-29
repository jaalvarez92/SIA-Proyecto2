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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            obtenerDocumentos(comboBox2.SelectedIndex, comboBox1.SelectedIndex);
        }

        private void obtenerDocumentos(int pSocio, int pTipoSocio)
        {
            Entidades.Entity nueva;
            LogicaInsertarDocumentos.obtenerDocumentos(pSocio, pTipoSocio);
            for (int i = 0; i < LogicaInsertarDocumentos.Documentos.Count; i++)
            {
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
