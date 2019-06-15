using AsociacionCordobesaDeNatacion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsociacionCordobesaDeNatacion.Formularios
{
    public partial class Usuario : Form
    {
        AccesoBD _BD;
        public Usuario()
        {
            InitializeComponent();
        }

        private void btn_belen_Click(object sender, EventArgs e)
        {
            try
            {

                _BD = new AccesoBD(1);
                _BD.consulta("Select * from Clubes");
                Login frm_login = new Login(_BD);
                frm_login.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ups estas equivocado amigooo, intentalo de nuevo");
            }
            
        }

        private void btn_matias_Click(object sender, EventArgs e)
        {
            try
            {
                _BD = new AccesoBD(2);
                _BD.consulta("Select * from Clubes");
                Login frm_login = new Login(_BD);
                frm_login.ShowDialog();
            }
            catch(Exception)
            {
                MessageBox.Show("Ups estas equivocado amigooo, intentalo de nuevo");
            }
            
        }

        private void btn_lupo_Click(object sender, EventArgs e)
        {
            try
            {
                _BD = new AccesoBD(3);
                _BD.consulta("Select * from Clubes");
                Login frm_login = new Login(_BD);
                frm_login.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ups estas equivocado amigooo, intentalo de nuevo");
            }

        }

        private void btn_lourdes_Click(object sender, EventArgs e)
        {
            try
            {
                _BD = new AccesoBD(4);
                _BD.consulta("Select * from Clubes");
                Login frm_login = new Login(_BD);
                frm_login.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ups estas equivocado amigooo, intentalo de nuevo");
            }
        }
    }
}
