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
        Nadadores nadadores = new Nadadores();

        private void btn_buscar_nad_Click(object sender, EventArgs e)
        {
            
            if (this.txt_dni.Text == "")
            {
                
                MessageBox.Show("El nombre no está cargado");
               
                this.txt_dni.Focus();
                
                return;
            }
           
            
            DataTable tabla = new DataTable();
            nadadores.dni_nadador = txt_dni.Text;
            tabla = nadadores.buscar_nadador();
            
            if (tabla.Rows.Count == 1)
            {
                MessageBox.Show("El Nadador con DNI: " + this.txt_dni.Text + " su nombre es: "
                    + tabla.Rows[0]["nombre"].ToString() + " y su domicilio es: "
                    + tabla.Rows[0]["calle"].ToString());
            }
            else
            {
                MessageBox.Show("No se encontro nadador con dni especificado");
            }
        }
 

        private void blanquear_objetos()
        {

            this.txt_calle.Text = "";
            this.txt_dni.Text = "";
            this.txt_nombre_nadador.Text = "";
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
                nadadores.calle_nadador = this.txt_calle.Text;
                nadadores.dni_nadador = this.txt_dni.Text;
                nadadores.nombre_nadador = this.txt_nombre_nadador.Text;
                this.nadadores.grabar_nadador();
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
                nadadores.dni_nadador = txt_dni.Text;
                nadadores.nombre_nadador = txt_nombre_nadador.Text;
                nadadores.calle_nadador = txt_calle.Text;
                this.nadadores.modificar_nadador();
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
            nadadores.dni_nadador = txt_dni.Text;
            DialogResult dialogResult = MessageBox.Show("Está seguro que desea eliminar el nadador de DNI:" + nadadores.dni_nadador + " ?"
                , "importante", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                nadadores.eliminar_nadador();
            }
            else if (dialogResult == DialogResult.No)
            {
                dialogResult = DialogResult.Cancel;
            }
            MessageBox.Show("La eliminacion del nadador elegido ha sido correcta");
            this.blanquear_objetos();
        }

        private List<TextBox> crearArray()
        {
            List<TextBox> array = new List<TextBox>();
            array.Add(this.txt_calle);
            array.Add(this.txt_dni);
            array.Add(this.txt_nombre_nadador);
            return array;
        }
    }
}
