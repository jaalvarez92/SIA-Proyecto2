using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Logica.ModuloInventario;
using System.IO;
using Entidades.Inventario;

namespace UI.Inventarios
{
    public partial class VInventarios : Form
    {
        public VInventarios()
        {
            InitializeComponent();
            inicializarEventos();
            inicializarDatos(0);
        }

        private void inicializarEventos()
        {
            btnAsociarArticulo.Click += new EventHandler(btnAsociarArticulo_Click);
            btnGuardarArticulo.Click += new EventHandler(btnGuardarArticulo_Click);
            btnGuardarBodega.Click += new EventHandler(btnGuardarBodega_Click);

            btnCancelarAsociar.Click+=new EventHandler(btnCancelar_Click);
            btnCancelarBodega.Click+=new EventHandler(btnCancelar_Click);
        }

        private void inicializarDatos(int tipoInicializar)
        {
            

            if (tipoInicializar == 0)
            {
                cmbBodegas.DisplayMember = "Nombre";
                cmbBodegas.ValueMember = "IdBodega";

                cmbArticuloAsociar.DisplayMember = "Descripcion";
                cmbArticuloAsociar.ValueMember = "IdArticulo";

                cmbBodegaArt.DisplayMember = "Nombre";
                cmbBodegaArt.ValueMember = "IdBodega";

                cmbBodegaAsociar.DisplayMember = "Nombre";
                cmbBodegaAsociar.ValueMember = "IdBodega";

                cmbSocio.Items.AddRange(ArticuloLogica.Instancia.obtenerSocios().ToArray());
                cmbSocio.DisplayMember = "Nombre";
                cmbSocio.ValueMember = "IdSocio";
            }

            cmbBodegas.Items.Clear();
            cmbBodegaArt.Items.Clear();
            cmbBodegaAsociar.Items.Clear();
            cmbArticuloAsociar.Items.Clear();

            foreach (var item in ArticuloLogica.Instancia.obtenerBodegas())
            {
                cmbBodegas.Items.Add(item);
                cmbBodegaArt.Items.Add(item);
                cmbBodegaAsociar.Items.Add(item);
            }

            cmbArticuloAsociar.Items.AddRange(ArticuloLogica.Instancia.obtenerArticulos().ToArray());
        }

        void btnGuardarBodega_Click(object sender, EventArgs e)
        {
            ArticuloLogica.Instancia.ingresarBodega(txtNombreBodega.Text, txtCodBodega.Text);
        }

        void btnGuardarArticulo_Click(object sender, EventArgs e)
        {
            bool resul = ArticuloLogica.Instancia.ingresarArticulo(txtCodigo.Text, txtDescripcion.Text, txtUndMedida.Text,
                txtComentarios.Text, imageToByteArray(pictureBox.Image), ((Bodega)cmbBodegaArt.SelectedItem).IdBodega,
                Convert.ToInt32(txtCantidadMinima.Text), Convert.ToInt32(txtCantidadMaxima.Text), ((Socio)cmbSocio.SelectedItem).IdSocio);

            if (resul)
            {
                MessageBox.Show("Artículo guardado");
                limpiarDatosArticulo();
            }
            else
            {
                MessageBox.Show("Error al guardar artículo");
            }
        }

        void btnAsociarArticulo_Click(object sender, EventArgs e)
        {
            //ArticuloLogica.Instancia.
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //mostrar imagen
                var fileName = openFileDialog.FileName;
                txtFoto.Text = fileName;
                var bmp = new Bitmap(fileName);
                pictureBox.Image = bmp;
            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void limpiarDatosArticulo()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtUndMedida.Text = "";
            txtComentarios.Text = "";
            txtPrecio.Text = "";
            txtFoto.Text = "";
            pictureBox.Image = null;
            cmbBodegaArt.SelectedIndex = 0;
            txtCantidadMaxima.Text = "";
            txtCantidadMinima.Text = "";
        }

        private void cmbBodegas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreBodega = ((Bodega)cmbBodegas.SelectedItem).Nombre;
            var lstArticulos = ArticuloLogica.Instancia.obtenerArticulosBodega(nombreBodega);
            grvArticulos.DataSource = lstArticulos;
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            inicializarDatos(1);
        }

        private void btnAsociarArticulo_Click_1(object sender, EventArgs e)
        {
            int idArticulo, idBodega;
            idBodega =((Bodega)cmbBodegaAsociar.SelectedItem).IdBodega;
            idArticulo =  ((Articulo)cmbArticuloAsociar.SelectedItem).IdArticulo;

            if (ArticuloLogica.Instancia.existeArticuloEnBodega(idBodega,idArticulo))
            {
                bool resul = ArticuloLogica.Instancia.asociarArticuloABodega(idBodega, Convert.ToInt32(txtCantidadMinimaAsociar.Text),
                Convert.ToInt32(txtCantidadMaximaAsociar.Text), idArticulo);
                if (resul)
                {
                    MessageBox.Show("Artículo guardado");
                }
                else
                {
                    MessageBox.Show("Error al guardar artículo");
                }
            }
            else
            {
                MessageBox.Show("El artículo ya existe en esa bodega");
            }
            
        }
        
    }
}
