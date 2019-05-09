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
        public partial class Login : Form
        {

        int _id = 0;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string usuario
        {
            get { return this.BoxUsuario.Text; }
            set { this.BoxUsuario.Text = value; }
        }
        public string password
        {
            get { return this.BoxPassword.Text; }
            set { this.BoxPassword.Text = value; }

        }

        public Login()
        {
            InitializeComponent();
        }

        private void cmd_ingresar_Click(object sender, EventArgs e)
        {
            if (this.BoxUsuario.Text == "")
            {
                MessageBox.Show("El campo 'Usuario' está vacío.");
                this.BoxUsuario.Focus();
                return;
            }
            if (this.BoxPassword.Text == "")
            {
                MessageBox.Show("El campo 'Password' está vacío");
                this.BoxPassword.Focus();
                return;
            }
            if(this.BoxUsuario.Text == "mati" && this.BoxPassword.Text == "1234")
            {
            
                Menus frm_menu = new Menus();

                frm_menu.ShowDialog();

                frm_menu.Dispose();
            }
            else
            {
                MessageBox.Show("El Login ha fallado.");
                
            }
            //Users validar_usuario = new Users();

            //DataTable tabla = new DataTable();

            ////tabla = validar_usuario.consulta_login(this.BoxUsuario.Text.Trim(), this.BoxPassword.Text.Trim());

            ////if (tabla.rows.count == 1)
            ////{
            ////    this._id = int.parse(tabla.rows[0][0].tostring());
            ////    this.close();
            ////}


        }

        ////private void login_formclosing(object sender, formclosingeventargs e)
        ////{
        ////    if (messagebox.show("está seguro de abandonar el formulario?"
        ////        , "importante", messageboxbuttons.yesno
        ////        , messageboxicon.question) == system.windows.forms.dialogresult.yes)
        ////    {
        ////        e.cancel = false;
        ////    }
        ////}

    }
}