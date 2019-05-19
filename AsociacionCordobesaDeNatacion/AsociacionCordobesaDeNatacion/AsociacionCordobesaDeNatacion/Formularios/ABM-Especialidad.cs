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
    public partial class ABM_Especialidad : Form
    {
        public ABM_Especialidad()
        {
            InitializeComponent();
        }

        Especialidades especialidades = new Especialidades();


        private void cmd_buscar01_Click(object sender, EventArgs e)
        {
            if (this.txt_cod_especialidad.Text == "")
            {

                MessageBox.Show("El codigo no está cargado");

                this.txt_cod_especialidad.Focus();

                return;
            }

            DataTable tabla = new DataTable();
            especialidades.cod_esp = txt_cod_especialidad.Text;
            tabla = especialidades.buscar_especialidad();

            if (tabla.Rows.Count == 1)
            {
                MessageBox.Show("La especialidad con codigo: " + this.txt_cod_especialidad.Text + " tiene la siguiente descripcion: "
                    + tabla.Rows[0]["descripcion"].ToString());

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
                especialidades.cod_esp = txt_cod_especialidad.Text;
                especialidades.descripcion = txt_descripcion.Text;
                this.especialidades.grabar_especialidad();
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

            this.txt_cod_especialidad.Text = "";
            this.txt_descripcion.Text = "";
        }

        private void cmd_nuevo_Click_1(object sender, EventArgs e)
        {
            blanquear_objetos();
        }

        private void cmd_actualizar_Click(object sender, EventArgs e)
        {
            List<TextBox> array = crearArray();
            if (Utils.FormValidator.validacionesDeTextosVacios(array))
            {
                especialidades.cod_esp = txt_cod_especialidad.Text;
                especialidades.descripcion = txt_descripcion.Text;
                this.especialidades.modificar_especialidad();
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
            especialidades.cod_esp = txt_cod_especialidad.Text;
            DialogResult dialogResult = MessageBox.Show("Está seguro que desea eliminar la Especialidad con codigo:" + especialidades.cod_esp + " ?"
                , "importante", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                especialidades.eliminar_especialidad();
            }
            else if (dialogResult == DialogResult.No)
            {
                dialogResult = DialogResult.Cancel;
            }
            MessageBox.Show("La eliminacion de la especialidad ha sido correcta");
            this.blanquear_objetos();
        }

        private List<TextBox> crearArray()
        {
            List<TextBox> array = new List<TextBox>();
            array.Add(this.txt_cod_especialidad);
            array.Add(this.txt_descripcion);
            return array;
        }
    }
}
