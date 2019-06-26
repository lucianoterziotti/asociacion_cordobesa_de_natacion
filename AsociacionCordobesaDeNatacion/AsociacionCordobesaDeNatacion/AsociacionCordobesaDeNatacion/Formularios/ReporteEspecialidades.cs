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
using System.Windows.Forms.DataVisualization.Charting;

namespace AsociacionCordobesaDeNatacion.Formularios
{
	internal partial class ReporteEspecialidades : Form
	{
		AccesoBD _BD;
	

		public ReporteEspecialidades(AccesoBD BD)
		{
			InitializeComponent();
			_BD = BD;
			cargarComboBoxAnios();
		}

		private void btn_CargarGrillaEspe_Click(object sender, EventArgs e)
		{
			DataTable tabla = new DataTable();

			dataGrid_Especialidad.DataSource = null;

			tabla = _BD.consulta("SELECT Inscriptos.cod_especialidad, Especialidad.descripcion, count(*) as cantidad, Min(Inscriptos.tiempo) as 'Mejor Tiempo', Avg(Inscriptos.tiempo) as 'Tiempo Promedio'  " +
								 "FROM Inscriptos , Especialidad " +
								 "WHERE Inscriptos.cod_especialidad = Especialidad.cod_especialidad " +
								 "AND anio = " + cmb_anio.SelectedValue +
								 "GROUP BY Especialidad.descripcion , Inscriptos.cod_especialidad");

			if (tabla.Rows.Count == 0)
			{
				MessageBox.Show("No hay Inscriptos registrados en las especialidades del año seleccionado");
				return;
			}

			dataGrid_Especialidad.DataSource = tabla;
			dataGrid_Especialidad.Columns[0].HeaderText = "Código";
			dataGrid_Especialidad.Columns[1].HeaderText = "Especialidad";
			dataGrid_Especialidad.Columns[2].HeaderText = "Cantidad de inscriptos";
			dataGrid_Especialidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGrid_Especialidad.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

			string[] x = new string[tabla.Rows.Count];
			int[] y = new int[tabla.Rows.Count];

			for (int i = 0; i < tabla.Rows.Count; i++)
			{
				x[i] = tabla.Rows[i][1].ToString();
				y[i] = Convert.ToInt32(tabla.Rows[i][2].ToString());
			}

			chart_espe.Series[0].Points.DataBindXY(x, y);
			chart_espe.Series[0].ChartType = SeriesChartType.Column;

		}

		public void cargarComboBoxAnios()
		{
			cmb_anio.DataSource = _BD.consulta("SELECT * FROM anioTorneo");
			cmb_anio.ValueMember = "anio";
			cmb_anio.DisplayMember = "anio";
		}


		private void ReporteEspecialidades_Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'dS_Especialidades.Especialidad' Puede moverla o quitarla según sea necesario.
			this.especialidadTableAdapter.Fill(this.dS_Especialidades.Especialidad);

		}
	}
}
