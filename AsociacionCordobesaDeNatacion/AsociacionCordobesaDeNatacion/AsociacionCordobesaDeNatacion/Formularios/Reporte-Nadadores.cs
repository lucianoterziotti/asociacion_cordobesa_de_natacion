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
	internal partial class Reporte_Nadadores : Form
	{
		AccesoBD _BD;

		public Reporte_Nadadores(AccesoBD BD)
		{
			InitializeComponent();
			_BD = BD;
			cargarComboBoxNadadores();
			cargarComboBoxAños();
		}		

		

		private void btn_CargarGrilla_Click(object sender, EventArgs e)
		{
				DataTable tabla = new DataTable();

				dataGrid_Nadador.DataSource = null;

			tabla = _BD.consulta("SELECT Especialidad.descripcion, Torneos.descripcion, Inscriptos.tiempo " +
								 "FROM Inscriptos , Nadadores, Torneos, Especialidad " +
								 "WHERE Inscriptos.cod_especialidad = Especialidad.cod_especialidad AND " +
								 "Inscriptos.cod_torneo = Torneos.cod_torneo AND " +
								 "Inscriptos.cod_nadador = " + cmb_nadadores.SelectedValue + " AND " +
								 "Inscriptos.anio = " + cmb_anio.SelectedValue +
								 " GROUP BY Especialidad.descripcion, Torneos.descripcion, Inscriptos.tiempo ");

				if (tabla.Rows.Count == 0)
				{
					MessageBox.Show("No hay Inscriptos registrados en las especialidades del año seleccionado");
					return;
				}

				dataGrid_Nadador.DataSource = tabla;
				dataGrid_Nadador.Columns[0].HeaderText = "Especialidad";
				dataGrid_Nadador.Columns[1].HeaderText = "Torneo";
				dataGrid_Nadador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				dataGrid_Nadador.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

			}

		private void cargarComboBoxNadadores()
			{
				cmb_nadadores.DataSource = _BD.consulta("SELECT * FROM Nadadores");
				cmb_nadadores.ValueMember = "cod_nadador";
				cmb_nadadores.DisplayMember = "nombre";
			}
		private void cargarComboBoxAños()
		{
			cmb_anio.DataSource = _BD.consulta("SELECT * FROM anioTorneo");
			cmb_anio.ValueMember = "anio";
			cmb_anio.DisplayMember = "anio";
		}

	}
	}
