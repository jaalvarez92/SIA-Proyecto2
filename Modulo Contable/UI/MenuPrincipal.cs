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
    public partial class MenuPrincipal : Form
    {
        #region Constructor
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void buttonCuentas_Click(object sender, EventArgs e)
        {
            new CrearCuenta().Show(this);
            this.Hide();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            ((Login)this.Owner).LLenarComboBoxEmpresas();
            this.Owner.Show();
            this.Owner.Refresh();
            this.Close();
        }

        private void buttonEmpresa_Click(object sender, EventArgs e)
        {
            new CrearEmpresa().Show(this);
            this.Hide();
        }

        private void buttonAsientos_Click(object sender, EventArgs e)
        {
            new CrearAsiento().Show(this);
            this.Hide();
        }

        private void buttonAgregarPeriodoContable_Click(object sender, EventArgs e)
        {
            new Configuracion().Show(this);
            this.Hide();
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            new Reportes(labNombreEmpresa.Text).Show(this);
            this.Hide();
        }

        private void buttonCierre_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realizar el cierre contable?", "Alerta", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Logica.BDLogica accesoDB = new Logica.BDLogica();
                if(accesoDB.RealizarCierre("SP_REALIZAR_CIERREPERIODO")!=null){
                    MessageBox.Show("Se realizó el cierre contable correctamente","Mensaje",MessageBoxButtons.OK);
                }else{
                    MessageBox.Show("Hubo un error al ejecutar el procedimiento","Mensaje",MessageBoxButtons.OK);
                }
            }
        }
        #endregion



    }
}
