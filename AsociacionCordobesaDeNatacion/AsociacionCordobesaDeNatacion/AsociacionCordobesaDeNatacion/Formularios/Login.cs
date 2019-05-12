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

        
        public Login()
        {
            InitializeComponent();
        }

        private void cmd_ingresar_Click(object sender, EventArgs e)
        {


            if (this.txt_usuario.Text == "")
            {
                MessageBox.Show("El campo 'Usuario' está vacío.");
                this.txt_usuario.Focus();
                return;
            }
            if (this.txt_pssw.Text == "")
            {
                MessageBox.Show("El campo 'Password' está vacío");
                this.txt_pssw.Focus();
                return;
            }

            LoginClass buscar_usuario_log = new LoginClass();

            DataTable tabla = new DataTable();

            tabla = buscar_usuario_log.buscar_usuario(this.txt_usuario.Text.Trim());

            if (tabla.Rows.Count == 1)
            {

                buscar_usuario_log.id = int.Parse(tabla.Rows[0][0].ToString());

                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontro club con codigo especificado");
            }

            if (this.txt_usuario.Text == "mati" && this.txt_pssw.Text == "1234")
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