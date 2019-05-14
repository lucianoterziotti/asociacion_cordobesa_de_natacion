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
        Clubes clubes = new Clubes();

        public ABM_Clubes()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {



            if (this.txt_cod_club.Text == "")
            {

                MessageBox.Show("El codigo no está cargado");

                this.txt_cod_club.Focus();

                return;
            }

            DataTable tabla = new DataTable();

            tabla = clubes.buscar_club(this.txt_cod_club.Text.Trim());

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

        private void cmd_grabar_Click(object sender, EventArgs e)
        {

            clubes.calle_club = this.txt_calle.Text;
            clubes.cod_club = this.txt_cod_club.Text;
            clubes.numero_club = this.txt_numero.Text;
            clubes.nombre_club = this.txt_nombre_club.Text;
            this.clubes.grabar_club();
            MessageBox.Show("La grabación fue correcta");

        }


    }
}
