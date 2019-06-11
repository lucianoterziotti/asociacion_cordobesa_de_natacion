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
    public partial class ResultadoTorneos : Form
    {
        AccesoBD _BD = new AccesoBD();

        public ResultadoTorneos()
        {
            InitializeComponent();
            cargarComboBoxAnios();
            cargarComboBoxEspecialidad();
            cargarComboBoxTorneos();
        }

        private void cargar_grilla()
        {
            DataTable tabla = new DataTable();

            tabla = _BD.consulta("SELECT n.nombre, i.tiempo FROM Nadadores n, Inscriptos i " +
                                 "WHERE i.cod_nad = n.cod_nacional " +
                                 "AND i.anio = " + cmb_anio.SelectedValue.ToString() +
                                 "AND i.cod_torneo = " + cmb_torneo.SelectedValue.ToString() +
                                 "AND i.cod_espe = " + cmb_especialidad.SelectedValue.ToString() +
                                 "ORDER BY i.tiempo");

            tabla.Columns.Add("Posición", typeof(int));

            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay resultados registrados del Torneo seleccionado");
                return;
            }

            dataGrid_Resultados.DataSource = tabla;
            dataGrid_Resultados.Columns[0].HeaderText = "Nadador";
            dataGrid_Resultados.Columns[1].HeaderText = "Tiempo";
            dataGrid_Resultados.Columns[2].HeaderText = "Posición";
            dataGrid_Resultados.Columns["Posición"].DisplayIndex = 0;

        }

        public void cargarComboBoxEspecialidad()
            {
                cmb_especialidad.DataSource = _BD.consulta("SELECT * FROM Especialidad");
                cmb_especialidad.ValueMember = "cod_espec";
                cmb_especialidad.DisplayMember = "descripcion";
            }

            public void cargarComboBoxTorneos()
            {
                cmb_torneo.DataSource = _BD.consulta("SELECT * FROM Torneos");
                cmb_torneo.ValueMember = "cod_torneo";
                cmb_torneo.DisplayMember = "descripccion";

            }

            public void cargarComboBoxAnios()
            {
                cmb_anio.DataSource = _BD.consulta("SELECT * FROM anioTorneo");
                cmb_anio.ValueMember = "anio";
                cmb_anio.DisplayMember = "anio";
            }


        private void btn_CargarGrilla_Click(object sender, EventArgs e)
        {
            this.cargar_grilla();
        }

        private void dataGrid_Resultados_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            {
                this.dataGrid_Resultados.Rows[e.RowIndex].Cells[2].Value
                 = (e.RowIndex + 1).ToString();
            }
        }
    }
}
