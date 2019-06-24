using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsociacionCordobesaDeNatacion.Clases;
using AsociacionCordobesaDeNatacion.Formularios;

namespace AsociacionCordobesaDeNatacion

{
    internal partial class Login : Form
    {
        Users usuario;
        Menus frm_menu;

        public Login(AccesoBD BD)
        {
            InitializeComponent();
            frm_menu = new Menus(BD);
            usuario = new Users(BD);
        }

        private void cmd_ingresar_Click(object sender, EventArgs e)
        {
            if (this.txt_usuario.Text == "")
            {
                MessageBox.Show("El campo 'USUARIO' está vacío.");
                this.txt_usuario.Focus();
                return;
            }
            if (this.txt_pssw.Text == "")
            {
                MessageBox.Show("El campo 'CONTRASEÑA' está vacío");
                this.txt_pssw.Focus();
                return;
            }

            DataTable tabla = new DataTable();
            tabla = usuario.consulta_login(this.txt_usuario.Text.Trim(), this.txt_pssw.Text.Trim());

            if (tabla.Rows.Count == 1)
            {
                string nombreUsuario = this.txt_usuario.Text.Trim();
                frm_menu.ShowDialog();

            }
            else
            {
                MessageBox.Show("La CONTRASEÑA o el USUARIO es invalido");
            }
        }

        private void login_formclosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro de abandonar el formulario?"
                , "IMPORTANTE", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }
    }
}