using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class MenuModuloClientes : Form
    {
        #region Constructor
        public MenuModuloClientes()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Owner.Refresh();
            this.Close();
        }
        #endregion

        private void buttonAgregarSocio_Click(object sender, EventArgs e)
        {
        }



    }
}
