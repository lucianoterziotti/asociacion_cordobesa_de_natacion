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
    internal partial class ABM_Profesores : Form
    {
        Profesores profesores;
        AccesoBD _BD;
        public ABM_Profesores(AccesoBD BD)
        {
            InitializeComponent();
            _BD = BD;
            profesores = new Profesores(BD);

        }
        VistaGrilla listaProfesores;

        private void cmd_buscar01_Click(object sender, EventArgs e)
        {
            if (this.txt_dni.Text == "")
            {
                MessageBox.Show("El DNI no está cargado");

                this.txt_dni.Focus();

                return;
            }

            DataTable tabla = new DataTable();
            profesores.dni_profesor = this.txt_dni.Text;
            tabla = profesores.buscar_prof();

            if (tabla.Rows.Count == 1)
            {
                MessageBox.Show("El Profesor con DNI: " + this.txt_dni.Text + " su nombre es: "
                    + tabla.Rows[0]["nombre"].ToString() + " y su domicilio es: "
                    + tabla.Rows[0]["calle"].ToString());
            }
            else
            {
                MessageBox.Show("No se encontro profesor con dni especificado");
            }

        }

        private void blanquear_objetos()
        {

            this.txt_nombre_profesor.Text = "";
            this.txt_dni.Text = "";
            this.txt_calle.Text = "";
        }

        private void cmd_nuevo_Click(object sender, EventArgs e)
        {
            blanquear_objetos();
        }

        private void cmd_grabar_Click(object sender, EventArgs e)
        {
            List<TextBox> array = crearArray();
            if (Utils.FormValidator.validacionesDeTextosVacios(array))
            {
                profesores.calle_profesor = this.txt_calle.Text;
                profesores.dni_profesor = this.txt_dni.Text;
                profesores.nombre_profesor = this.txt_nombre_profesor.Text;
                this.profesores.grabar_profesor();
                MessageBox.Show("La grabacion fue correcta");
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
                profesores.calle_profesor = this.txt_calle.Text;
                profesores.dni_profesor = this.txt_dni.Text;
                profesores.nombre_profesor = this.txt_nombre_profesor.Text;
                this.profesores.modificar_profesor();
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
            profesores.dni_profesor = txt_dni.Text;
            DialogResult dialogResult = MessageBox.Show("Está seguro que desea eliminar el profesor con DNI:" + profesores.dni_profesor + " ?"
                , "importante", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                profesores.eliminar_profesor();
            }
            else if (dialogResult == DialogResult.No)
            {
                dialogResult = DialogResult.Cancel;
            }
            MessageBox.Show("La eliminacion del profesor elegido ha sido correcta");
            this.blanquear_objetos();
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.FormValidator.restriccionDeLetras_KeyPress(sender, e);
        }

        private List<TextBox> crearArray()
        {
            List<TextBox> array = new List<TextBox>();
            array.Add(this.txt_calle);
            array.Add(this.txt_dni);
            array.Add(this.txt_nombre_profesor);
            return array;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaProfesores = new VistaGrilla("Profesores", _BD);

            listaProfesores.ShowDialog();

            listaProfesores.Dispose();
        }
    }
}
