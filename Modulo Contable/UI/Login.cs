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
using System.Configuration;

namespace UI
{

    public partial class Login : Form
    {
        private String _TituloMessageBox = "No se pudo ingresar";
        private String _MensajeErrorI = "Debe digitar todos los campos para poder ingresar";
        private String _MensajeErrorII = "El nombre de usuario o contraseña son incorrectos.";
        private Entities _Empresas;

        public Login()
        {
            InitializeComponent();
            LLenarComboBoxEmpresas();
        }



        public String NombreUsuario
        {
            get { return textBoxUsuario.Text; }
            set { textBoxUsuario.Text = value; }
        }


        public String Contrasena
        {
            get { return textBoxcontrasena.Text; }
            set { textBoxcontrasena.Text = value; }
        }


        public String NombreEmpresa
        {
            get { return comboBoxEmpresa.Text; }
            set { comboBoxEmpresa.Text = value; }
        }


        public void LLenarComboBoxEmpresas()
        {
            try
            {
                comboBoxEmpresa.Items.Clear();
                _Empresas = GrupoLogica.ObtenerEmpresasGrupo();
                foreach (Entity empresa in _Empresas)
                {
                    comboBoxEmpresa.Items.Add((String)empresa.Get("nombreempresa"));
                }
                comboBoxEmpresa.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {
                String empresa = comboBoxEmpresa.SelectedItem + "";

                if (UsuarioLogica.LogIn(NombreUsuario, Contrasena))
                {
                    MenuPrincipal _Menu = new MenuPrincipal();
                    Entity empresa_seleccionada = _Empresas.Get("nombreempresa", NombreEmpresa);
                    ConfigurationManager.AppSettings.Set("Empresa", ((int)empresa_seleccionada.Get("idempresa")).ToString());
                    _Menu.labNombreEmpresa.Text = comboBoxEmpresa.Text;
                    _Menu.Show(this);
                    this.Hide();
                }
                else
                {
                    MuestraMensaje(_MensajeErrorII, _TituloMessageBox);
                }
                NombreUsuario="";
                Contrasena="";
                NombreEmpresa = "";
            }
        }


        private Boolean verificaCampos()
        {
            if (!NombreUsuario.Equals("") && !Contrasena.Equals("") && comboBoxEmpresa.SelectedItem != null)
            {
                return true;
            }
            else
            {
                MuestraMensaje(_MensajeErrorI, _TituloMessageBox);
                return false;
            }
        }

        private void MuestraMensaje(String titulo, String mensaje)
        {
            var result = MessageBox.Show(titulo, mensaje);
        }

        private void comboBoxEmpresa_SelectedValueChanged(object sender, EventArgs e)
        {
            String empresa = comboBoxEmpresa.SelectedItem + "";
            Entity empresa_seleccionada = _Empresas.Get("nombreempresa", NombreEmpresa);
            String schema =(String)empresa_seleccionada.Get("schemagrupo").ToString();
            ConfigurationManager.AppSettings.Set("Esquema", schema);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
       
    }
}
