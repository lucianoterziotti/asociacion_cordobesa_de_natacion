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
    public partial class Inicio : Form
    {
       public Inicio()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

      
        private void btn_comenzar_click(object sender, EventArgs e)
        {
            
            Usuario frm_CheckUserlogin = new Usuario();

            frm_CheckUserlogin.ShowDialog();

            frm_CheckUserlogin.Dispose();
            
        }
    }
}