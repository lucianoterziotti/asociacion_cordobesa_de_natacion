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
    public partial class ABM_Profesores : Form
    {
        public ABM_Profesores()
        {
            InitializeComponent();
        }

       

        private void cmd_buscar_1_Click(object sender, EventArgs e)
        {
            if(this.txt_dni.Text == "")
            {
                MessageBox.Show("El DNI no está cargado");

                this.txt_dni.Focus();

                return;
            }

            Profesores buscar_profesor = new Profesores();

            DataTable tabla = new DataTable();

            tabla = buscar_profesor.buscar_prof(this.txt_dni.Text.Trim());

            if (tabla.Rows.Count == 1)
            {

                buscar_profesor.id = int.Parse(tabla.Rows[0][0].ToString());

                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontro profesor con dni especificado");
            }

        }
    }
}
