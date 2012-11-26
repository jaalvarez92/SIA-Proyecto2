using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UI.ModuloClientes;

namespace UI
{
    public partial class MenuModulos : Form
    {
        #region Constructor
        public MenuModulos()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void buttonFinanzas_Click(object sender, EventArgs e)
        {
            MenuModuloFinanciero _Menu = new MenuModuloFinanciero();
            _Menu.labNombreEmpresa.Text = this.labNombreEmpresa.Text;
            _Menu.labCedJuridica.Text = this.labCedJuridica.Text;
            _Menu.label5.Text = this.label5.Text;
            _Menu.Show(this);
            this.Hide();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            MenuModuloClientes _Menu = new MenuModuloClientes();
            _Menu.labNombreEmpresa.Text = this.labNombreEmpresa.Text;
            _Menu.labCedJuridica.Text = this.labCedJuridica.Text;
            _Menu.label5.Text = this.label5.Text;
            _Menu.Show(this);
            this.Hide();
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            ((Login)this.Owner).LLenarComboBoxEmpresas();
            this.Owner.Show();
            this.Owner.Refresh();
            this.Close();
        }


        private void buttonInventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventarios.VInventarios ds = new Inventarios.VInventarios();
            ds.Show();
        }
        #endregion
    }
}
