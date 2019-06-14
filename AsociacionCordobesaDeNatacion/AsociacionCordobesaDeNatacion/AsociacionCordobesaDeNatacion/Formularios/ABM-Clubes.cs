using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using AsociacionCordobesaDeNatacion.Clases;
using AsociacionCordobesaDeNatacion.Utils;
namespace AsociacionCordobesaDeNatacion.Formularios
{
    internal partial class ABM_Clubes : Form
    {
        Clubes clubes;
        VistaGrilla listaClubes;
        AccesoBD _BD;
        public ABM_Clubes(AccesoBD BD)
        {
            InitializeComponent();
            _BD = BD;
            clubes = new Clubes(BD);

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_cod_club.Text == "")
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

            List<TextBox> array = crearArray();
            if (Utils.FormValidator.validacionesDeTextosVacios(array))
            {
                clubes.calle_club = this.txt_calle.Text;
                clubes.cod_club = this.txt_cod_club.Text;
                clubes.numero_club = this.txt_numero.Text;
                clubes.nombre_club = this.txt_nombre_club.Text;
                this.clubes.grabar_club();
                MessageBox.Show("La grabación fue correcta");
                this.blanquear_objetos();
            }
            else
            {
                MessageBox.Show("Falta ingresar algun dato");
            }
        }

        private void cmd_actualizar_Click(object sender, EventArgs e)
        {
            List<TextBox> array = crearArray();
            if (Utils.FormValidator.validacionesDeTextosVacios(array))
            {
                clubes.calle_club = this.txt_calle.Text;
                clubes.cod_club = this.txt_cod_club.Text;
                clubes.numero_club = this.txt_numero.Text;
                clubes.nombre_club = this.txt_nombre_club.Text;
                this.clubes.modificar_club(this.txt_cod_club.Text);
                MessageBox.Show("La modificacion fue correcta");
                this.blanquear_objetos();
            }
            else
            {
                MessageBox.Show("Falta ingresar algun dato");
            }

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
            if (txt_cod_club.Text != "")
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
            else
            {
                MessageBox.Show("No ingreso un codigo de club");
            }
        }


        private void txt_cod_club_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.FormValidator.restriccionDeLetras_KeyPress(sender, e);
        }

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.FormValidator.restriccionDeLetras_KeyPress(sender, e);
        }

        private List<TextBox> crearArray()
        {
            List<TextBox> array = new List<TextBox>();
            array.Add(this.txt_calle);
            array.Add(this.txt_cod_club);
            array.Add(this.txt_numero);
            array.Add(this.txt_nombre_club);

            return array;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaClubes = new VistaGrilla("Clubes", _BD);

            listaClubes.ShowDialog();

            listaClubes.Dispose();
        }
    }

}
