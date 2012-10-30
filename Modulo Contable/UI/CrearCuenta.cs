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

namespace UI
{
    public partial class CrearCuenta : Form
    {
        #region Atributos
        private Entities _Tipos;
        private Entities _Monedas;
        private Entities _Cuentas;
        #endregion

        #region Propiedades
        public String NombreCuenta
        {
            get { return textBoxNombreCuenta.Text; }
            set { textBoxNombreCuenta.Text = value; }
        }

        public String NombreCuentaExtranjera
        {
            get { return textBoxNombreCuentaExtranjera.Text; }
            set { textBoxNombreCuentaExtranjera.Text = value; }
        }

        public String Codigo
        {
            get { return TipoCuenta+"-"+textBoxCodigo.Text; }
            set { textBoxCodigo.Text = value; }
        }

        public int Moneda
        {
            get {
                int codigo;
                if (comboBoxMoneda.Text.Equals("")) codigo = 0;
                else
                {
                    Entity moneda = _Monedas.Get("simbolo", comboBoxMoneda.Text);
                    codigo = (int)moneda.Get("idmoneda");
                }
                return codigo;
            }
        }

        public int IdTipoCuenta
        {
            get
            {
                Entity tipoCambio = _Tipos.Get("nombre", comboBoxTipoCuenta.Text);
                int codigo = (int)tipoCambio.Get("idtipocuenta");
                return codigo;
            }
        }

        public int TipoCuenta
        {
            get
            {
                Entity tipoCambio = _Tipos.Get("nombre", comboBoxTipoCuenta.Text);
                int codigo = (int)tipoCambio.Get("numerotipocuenta");
                return codigo;
            }
        }

        public int CuentaPadre
        {
            get
            {
                int codigo;
                if (comboBoxCuentaPadre.Text.Equals("")) codigo = 0;
                else
                {
                    Entity cuenta = _Cuentas.Get("nombre", comboBoxCuentaPadre.Text);
                    codigo = (int)cuenta.Get("idcuenta");
                }
                return codigo;
            }
        }

        public Boolean CuentaTitulo
        {
            get
            {
                return checkBoxCuentaTitulo.Checked;
            }
        }
    #endregion

        #region Constructor

        public CrearCuenta()
        {
            InitializeComponent();
            LlenarComboBoxTiposCuenta();
            LlenarComboBoxMonedas();
            LlenarComboBoxCuentas();
            LlenarArbolCuentas();
        }
        #endregion

        #region Métodos

        public void LlenarComboBoxTiposCuenta()
        {
            comboBoxTipoCuenta.Items.Clear();
            _Tipos = CuentaLogica.ObtenerTiposCuenta();
            foreach (Entity tipo in _Tipos)
            {
                comboBoxTipoCuenta.Items.Add(tipo.Get("nombre"));
            }
        }

        public void LlenarComboBoxMonedas()
        {
            comboBoxMoneda.Items.Clear();
            _Monedas = MonedaLogica.ObtenerMonedas();
            foreach (Entity moneda in _Monedas)
            {
                comboBoxMoneda.Items.Add(moneda.Get("simbolo"));
            }
        }

        public void LlenarComboBoxCuentas()
        {
            comboBoxCuentaPadre.Items.Clear();
            _Cuentas = CuentaLogica.ObtenerCuentas();
            foreach (Entity cuenta in _Cuentas)
            {
                comboBoxCuentaPadre.Items.Add(cuenta.Get("nombre"));
            }
        }

        public void LlenarArbolCuentas() 
        {
            limpiarArbol();
            foreach (Entity cuenta in _Cuentas)
            {
                if ((cuenta.Get("cuentaPadre")).Equals((DBNull.Value)))
                    treeViewCuentas.Nodes.Add(new TreeNode((String)cuenta.Get("nombre")));
                else
                {
                    Entity padre = _Cuentas.Get("idCuenta", (int)cuenta.Get("cuentaPadre"));
                    String nombrePadre = (String)padre.Get("nombre");
                    insertaNodo(nombrePadre, (String)cuenta.Get("nombre"));
                }
                    
            }
        }

        public void limpiarArbol() 
        {
            int cantidadNodos = treeViewCuentas.Nodes.Count;
            for (int indice = cantidadNodos-1; indice+1 > 0; indice--)
            {
                treeViewCuentas.Nodes.RemoveAt(indice);
            }
        }

        public void insertaNodo(String pPadre, String pHijo) 
        {
            for (int indice = 0; indice < treeViewCuentas.Nodes.Count; indice++)
            {
              if (treeViewCuentas.Nodes[indice].Text == pPadre)
                {
                    treeViewCuentas.Nodes[indice].Nodes.Add(new TreeNode(pHijo));
                    treeViewCuentas.Nodes[indice].Expand();
                    continue;
                }

                for (int indice2 = 0; indice2 < treeViewCuentas.Nodes[indice].Nodes.Count; indice2++)
                {
                    if (treeViewCuentas.Nodes[indice].Nodes[indice2].Text == pPadre)
                        {
                            treeViewCuentas.Nodes[indice].Nodes[indice2].Nodes.Add(new TreeNode(pHijo));
                            treeViewCuentas.Nodes[indice].Nodes[indice2].Expand();
                            break;
                        }
                    for (int indice3 = 0; indice3 < treeViewCuentas.Nodes[indice].Nodes[indice2].Nodes.Count; indice3++)
                    {
                        if (treeViewCuentas.Nodes[indice].Nodes[indice2].Nodes[indice3].Text == pPadre)
                        {
                            treeViewCuentas.Nodes[indice].Nodes[indice2].Nodes[indice3].Nodes.Add(new TreeNode(pHijo));
                            treeViewCuentas.Nodes[indice].Nodes[indice2].Nodes[indice3].Expand();
                            break;
                        }

                        for (int indice4 = 0; indice4 < treeViewCuentas.Nodes[indice].Nodes[indice2].Nodes[indice3].Nodes.Count; indice4++)
                        {
                            if (treeViewCuentas.Nodes[indice].Nodes[indice2].Nodes[indice3].Nodes[indice4].Text == pPadre)
                            {
                                treeViewCuentas.Nodes[indice].Nodes[indice2].Nodes[indice3].Nodes[indice4].Nodes.Add(new TreeNode(pHijo));
                                treeViewCuentas.Nodes[indice].Nodes[indice2].Nodes[indice3].Nodes[indice4].Expand();
                                break;
                            }

                            for (int indice5 = 0; indice5 < treeViewCuentas.Nodes[indice].Nodes[indice2].Nodes[indice3].Nodes[indice4].Nodes.Count; indice5++)
                            {
                                if (treeViewCuentas.Nodes[indice].Nodes[indice2].Nodes[indice3].Nodes[indice4].Nodes[indice5].Text == pPadre)
                                {
                                    treeViewCuentas.Nodes[indice].Nodes[indice2].Nodes[indice3].Nodes[indice4].Nodes[indice5].Nodes.Add(new TreeNode(pHijo));
                                    treeViewCuentas.Nodes[indice].Nodes[indice2].Nodes[indice3].Nodes[indice4].Nodes[indice5].Expand();
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        public Boolean EliminarCuenta(int pIdCuenta) 
        {
            return CuentaLogica.EliminarCuenta(pIdCuenta);
        }

        public Boolean ValidarCampos()
        {
            return (!NombreCuenta.Equals("") && !NombreCuentaExtranjera.Equals("") && !Codigo.Equals("")
                    && !comboBoxTipoCuenta.Text.Equals(""));
            
        }

        public int devuelveIdCuenta(String pNombreCuenta) 
        {
            Entity padre = _Cuentas.Get("nombre", pNombreCuenta);
            return (int)padre.Get("idCuenta");
        }

        public void LimpiarCampos()
        {
            NombreCuenta = "";
            NombreCuentaExtranjera = "";
            Codigo = "";
        }
        #endregion 

        #region Eventos

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Owner.Refresh();
            this.Close();
        }

        private void botonCrearCuenta_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (CuentaLogica.CrearCuenta(Codigo, NombreCuenta, NombreCuentaExtranjera, CuentaTitulo, IdTipoCuenta, CuentaPadre, Moneda))
                {
                    MessageBox.Show("Creación exitosa de cuenta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    LlenarComboBoxCuentas();
                    LlenarArbolCuentas();
                }
                else
                {
                    MessageBox.Show("Creación de cuenta no pudo ser completada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Creación de cuenta no pudo ser completada. Faltan datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxCuentaTitulo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCuentaTitulo.Checked)
            {
                comboBoxMoneda.SelectedItem = null;
                comboBoxMoneda.Enabled = false;
            }
            else
            {
                comboBoxMoneda.Enabled = true;
            }

        }

        private void treeViewCuentas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch ((e.Action))
            {
                case TreeViewAction.ByMouse:
                    eventoMouseTreeviewCuentas();
                    break;
            }

        }

        private void eventoMouseTreeviewCuentas() 
        {
            TreeNode node = treeViewCuentas.SelectedNode;
           /* treeViewCuentas.SelectedNode = null;
            if (treeViewCuentas.Enabled != true)
                return;*/
            if (node.Nodes.Count != 0) 
            {
                MessageBox.Show("Solamente se pueden eliminar cuentas que no tengan cuentas hijas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                    

            if (EliminarCuenta(devuelveIdCuenta(node.Text)))
            {
                node.Remove();
                MessageBox.Show("Eliminación exitosa de cuenta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBoxEliminarCuentas.Checked = false;
                treeViewCuentas.Enabled = false;
                LlenarComboBoxCuentas();
                return;
            }
            else
            {
                MessageBox.Show("La eliminacion de la cuenta no pudo ser completada, la cuenta poseee un saldo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBoxEliminarCuentas.Checked = true;
                treeViewCuentas.Enabled = true;
                return;
            }
        }

        private void checkBoxEliminarCuentas_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxEliminarCuentas.Checked==true)
                treeViewCuentas.Enabled = true;
            else
                treeViewCuentas.Enabled = false;
        }

        #endregion

    }
}
