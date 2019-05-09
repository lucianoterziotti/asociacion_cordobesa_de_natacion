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
        }
        
        private void Escritorio_Load(object sender, EventArgs e)
        {
            

        }


        private void btn_comenzar_click(object sender, EventArgs e)
        {
            
            Login frm_login = new Login();

            frm_login.ShowDialog();

            frm_login.Dispose();
            
        }
    }
}