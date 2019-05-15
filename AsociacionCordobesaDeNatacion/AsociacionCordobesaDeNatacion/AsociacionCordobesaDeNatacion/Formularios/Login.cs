﻿using System;
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

            Users usuario = new Users();

            DataTable tabla = new DataTable();

            tabla = usuario.consulta_login(this.txt_usuario.Text.Trim(),this.txt_pssw.Text.Trim());

            if (tabla.Rows.Count == 1)
            {

                usuario.id = int.Parse(tabla.Rows[0][0].ToString());
                
                Menus frm_menu = new Menus();
                frm_menu.ShowDialog();
                  
            }
            else
            {
                MessageBox.Show("La contrasenia o el usuario es invalido");
            }
           
        }

        private void login_formclosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("está seguro de abandonar el formulario?"
                , "importante", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }

    }

}