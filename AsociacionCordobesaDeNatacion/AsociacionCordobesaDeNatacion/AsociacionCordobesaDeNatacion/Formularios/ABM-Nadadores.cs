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
    public partial class ABM_Nadadores : Form
    {
        public ABM_Nadadores()
        {
            InitializeComponent();
        }

       
        private void cmd_buscar_1_Click(object sender, EventArgs e)
        {
            
            if (this.txt_dni.Text == "")
            {
                
                MessageBox.Show("El nombre no está cargado");
               
                this.txt_dni.Focus();
                
                return;
            }
            
            Nadadores nadadores = new Nadadores();
            
            DataTable tabla = new DataTable();
            
            tabla = nadadores.buscar_nadador(this.txt_nombre_nadador.Text.Trim());
            
            if (tabla.Rows.Count == 1)
            {


                nadadores.id = int.Parse(tabla.Rows[0][0].ToString());
                
                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontro nadador con dni especificado");
            }
        }
    }
}
