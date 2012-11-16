using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Logica.ModuloClientes;
using Logica;

namespace UI.ModuloClientes
{
    public partial class AgregarSocio : Form
    {

        private Entities _Tipos;
        private Entities _Cuentas;


        public String Nombre
        {
            get
            {
                return textBoxNombre.Text;
            }
            set
            {
                textBoxNombre.Text = value;
            }
        }


        public String Codigo
        {
            get
            {
                return textBoxCodigo.Text;
            }
            set
            {
                textBoxCodigo.Text = value;
            }
        }


        public int TipoSocio
        {
            get
            {
                int codigo;
                if (comboBoxCuenta.Text.Equals("")) codigo = 0;
                else
                {
                    Entity tipoSocio = _Tipos.Get("tipo", comboBoxTipo.Text);
                    codigo = (int)tipoSocio.Get("idtiposocio");
                }
                return codigo;
            }
        }

        public int IdCuenta
        {
            get
            {
                int codigo;
                if (comboBoxCuenta.Text.Equals("")) codigo = 0;
                else
                {
                    Entity cuenta = _Cuentas.Get("nombre", comboBoxCuenta.Text);
                    codigo = (int)cuenta.Get("idcuenta");
                }
                return codigo;
            }
        }



        public AgregarSocio()
        {
            InitializeComponent();
            LlenarComboBoxTipoSocio();
            LlenarComboBoxCuentas();
        }


        public void LlenarComboBoxTipoSocio()
        {
            comboBoxTipo.Items.Clear();
            _Tipos = SocioLogica.ObtenerTiposSocios();
            foreach (Entity tipo in _Tipos)
            {
                comboBoxTipo.Items.Add(tipo.Get("tipo"));
            }
        }

        public void LlenarComboBoxCuentas()
        {
            comboBoxCuenta.Items.Clear();
            _Cuentas = CuentaLogica.ObtenerCuentas();
            foreach (Entity cuenta in _Cuentas)
            {
                comboBoxCuenta.Items.Add(cuenta.Get("nombre"));
            }
        }


        public Boolean VerificarCampos()
        {
            if ((!Nombre.Equals("")) && (!Codigo.Equals("")) && (TipoSocio != 0) && (IdCuenta != 0))
                return true;
            else
                return false;
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Refresh();
            this.Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
                if (SocioLogica.CrearSocio(Nombre, Codigo, IdCuenta, TipoSocio))
                    MessageBox.Show("Creación exitosa de socio", "Creación de Socios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Creación fallida de socio. Verifique la completitud de los datos requeridos", "Creación de Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}
