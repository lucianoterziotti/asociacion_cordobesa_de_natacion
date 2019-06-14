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
    internal partial class ABM_Torneos : Form
    {
        Torneos torneos;
        AccesoBD _BD;
        public ABM_Torneos(AccesoBD BD)
        {
            InitializeComponent();
            _BD = BD;
            torneos = new Torneos(BD);
        }
        VistaGrilla listaTorneos;

        private void cmd_buscar01_Click(object sender, EventArgs e)
        {
            if (this.txt_cod_torneo.Text == "")
            {

                MessageBox.Show("El codigo no está cargado");

                this.txt_cod_torneo.Focus();

                return;
            }

            DataTable tabla = new DataTable();
            tabla = torneos.buscar_torneo(this.txt_cod_torneo.Text.Trim());

            if (tabla.Rows.Count == 1)
            {
                MessageBox.Show("El torneo con codigo: " + this.txt_cod_torneo.Text + " tiene la siguiente descripcion: "
                    + tabla.Rows[0]["descripccion"].ToString());

            }
            else
            {
                MessageBox.Show("No se encontro torneo con codigo especificado");
            }
        }

        private void cmd_grabar_Click(object sender, EventArgs e)
        {
            List<TextBox> array = crearArray();
            if (Utils.FormValidator.validacionesDeTextosVacios(array))
            {
                torneos.cod_torneo = txt_cod_torneo.Text;
                torneos.descripcion_torneo = txt_descripcion.Text;
                this.torneos.grabar_torneo();
                MessageBox.Show("La grabación fue correcta");
                this.blanquear_objetos();
            }
            else
            {
                MessageBox.Show("Falta ingresar algun dato");
            }
        }

        private void blanquear_objetos()
        {

            this.txt_cod_torneo.Text = "";
            this.txt_cod_torneo.Text = "";
        }

        private void cmd_nuevo_Click(object sender, EventArgs e)
        {
            blanquear_objetos();
        }

        private void cmd_actualizar_Click(object sender, EventArgs e)
        {
            List<TextBox> array = crearArray();
            if (Utils.FormValidator.validacionesDeTextosVacios(array))
            {
                torneos.cod_torneo = txt_cod_torneo.Text;
                torneos.descripcion_torneo = txt_descripcion.Text;
                this.torneos.modificar_torneo();
                MessageBox.Show("La modificacion fue correcta");
                this.blanquear_objetos();
            }
            else
            {
                MessageBox.Show("Falta ingresar algun dato");
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            torneos.cod_torneo = txt_cod_torneo.Text;
            DialogResult dialogResult = MessageBox.Show("Está seguro que desea eliminar el torneo Con codigo:" + torneos.cod_torneo + " ?"
                , "importante", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                torneos.eliminar_torneo();
            }
            else if (dialogResult == DialogResult.No)
            {
                dialogResult = DialogResult.Cancel;
            }
            MessageBox.Show("La eliminacion del torneo ha sido correcta");
            this.blanquear_objetos();
        }

        private List<TextBox> crearArray()
        {
            List<TextBox> array = new List<TextBox>();
            array.Add(this.txt_cod_torneo);
            array.Add(this.txt_descripcion);
            return array;
        }

        private void txt_cod_torneo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.FormValidator.restriccionDeLetras_KeyPress(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaTorneos = new VistaGrilla("Torneos", _BD);

            listaTorneos.ShowDialog();

            listaTorneos.Dispose();
        }
    }
}
