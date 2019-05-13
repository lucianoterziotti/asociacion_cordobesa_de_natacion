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

namespace AsociacionCordobesaDeNatacion.Formularios
{
    public partial class ABM_Clubes : Form
    {

        public ABM_Clubes()
        {
            InitializeComponent();
        }
  
        private void btn_buscar_Click(object sender, EventArgs e)
        {


            
                if (this.txt_id.Text == "")
                {

                    MessageBox.Show("El codigo no está cargado");

                    this.txt_id.Focus();

                    return;
                }

                Clubes buscar_club = new Clubes();

                DataTable tabla = new DataTable();

                tabla = buscar_club.buscar_club(this.txt_id.Text.Trim());

                if (tabla.Rows.Count == 1)
                {   

                    dgv_clubes.DataSource = tabla;
                //  buscar_club.id = int.Parse(tabla.Rows[0][0].ToString());
                //this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontro club con codigo especificado");
                }
            }

        private void cmd_nuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
