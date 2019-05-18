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
            clubes.cod_club = this.txt_cod_club.Text;
            tabla = clubes.buscar_club(this.txt_cod_club.Text.Trim());

            if (tabla.Rows.Count == 1)
            {
                MessageBox.Show("El Club con codigo: " + clubes.cod_club + " su nombre es: "
                    + tabla.Rows[0]["nombre"].ToString());
            }
            else
            {
                MessageBox.Show("No se encontro club con codigo especificado");
            }
        }

        private void cmd_nuevo_Click(object sender, EventArgs e)
        {
            this.blanquear_objetos();
        }

        private void cmd_grabar_Click(object sender, EventArgs e)
        {

            clubes.calle_club = this.txt_calle.Text;
            clubes.cod_club = this.txt_cod_club.Text;
            clubes.numero_club = this.txt_numero.Text;
            clubes.nombre_club = this.txt_nombre_club.Text;
            this.clubes.grabar_club();
            MessageBox.Show("La grabación fue correcta");
            this.blanquear_objetos();

        }

        private void cmd_actualizar_Click(object sender, EventArgs e)
        {
            clubes.calle_club = this.txt_calle.Text;
            clubes.cod_club = this.txt_cod_club.Text;
            clubes.numero_club = this.txt_numero.Text;
            clubes.nombre_club = this.txt_nombre_club.Text;
            this.clubes.modificar_club(this.txt_cod_club.Text);
            MessageBox.Show("La modificacion fue correcta");
            this.blanquear_objetos();
        }

        private void blanquear_objetos()
        {  
            this.txt_calle.Text = "";
            this.txt_cod_club.Text = "";
            this.txt_nombre_club.Text = "";
            this.txt_numero.Text = "";
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            clubes.cod_club = this.txt_cod_club.Text;
            DialogResult dialogResult = MessageBox.Show("está seguro que desea eliminar el club? Con codigo:" + clubes.cod_club
                , "importante", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                clubes.eliminar_club();
            }
            else if (dialogResult == DialogResult.No)
            {
                dialogResult = DialogResult.Cancel;
            }
        }
        private void restriccionDeLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void restriccionDeNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_cod_club_KeyPress(object sender, KeyPressEventArgs e)
        {
            restriccionDeLetras_KeyPress(sender,e);
            
            //no se encuentra en buen funcionamiento
            btn_buscar.Enabled = true;
        }

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            restriccionDeLetras_KeyPress(sender, e);
        }

        private void txt_nombre_club_KeyPress(object sender, KeyPressEventArgs e)
        {
            restriccionDeNumeros_KeyPress(sender, e);
        }

        
    }
    
}
