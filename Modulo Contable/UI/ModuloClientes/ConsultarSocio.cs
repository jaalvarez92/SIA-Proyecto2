using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica.ModuloClientes;
using Entidades;

namespace UI.ModuloClientes
{
    public partial class ConsultarSocio : Form
    {
        Entity _Socio;
        Entities _Documentos;

        public String Codigo
        {
            get { return textBoxCodigo.Text; }
            set { textBoxCodigo.Text = value; }
        }


        public String Nombre
        {
            get { return labelNombre.Text; }
            set { labelNombre.Text = value; }
        }

        public String Saldo
        {
            get { return labelSaldo.Text; }
            set { labelSaldo.Text = value; }
        }

        public ConsultarSocio()
        {
            InitializeComponent();
        }


        public void LimpiarCampos()
        {
            dataGridViewDcoumentos.Rows.Clear();
            Nombre = "";
            Saldo = "";
        }


        public void ObtenerDocumentosAbiertosSocio()
        {
            _Documentos = SocioLogica.ObtenerDocumentosAbiertosSocio((int)_Socio.Get("idsocio"));
            dataGridViewDcoumentos.Rows.Clear();
            foreach (Entity e in _Documentos)
            {
                DateTime fecha = (DateTime)e.Get("fecha");
                String tipo = (String)e.Get("tipodocumento");
                Decimal total = (Decimal)e.Get("total");
                if ((tipo.Equals("Factura de Clientes")) || (tipo.Equals("Factura de Servicios")) || (tipo.Equals("Factura de Proveedores")) || (tipo.Equals("Nota de Credito")))
                    dataGridViewDcoumentos.Rows.Add(fecha.ToString(), tipo, total.ToString(), "Consultar"); 
                
            }
        }


        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            Entities result = SocioLogica.ObtenerSocio(Codigo);
            if (result.Count > 0)
            {
                _Socio = result[0];
                Nombre = (String)_Socio.Get("nombre");
                Saldo = ((Decimal)_Socio.Get("saldo")).ToString() + " " + (String)_Socio.Get("moneda");
                ObtenerDocumentosAbiertosSocio();
            }
            else
                MessageBox.Show("El codigo no corresponde a ningún socio", "Consultar Socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Refresh();
            this.Owner.Show();
            this.Close();
        }
    }
}
