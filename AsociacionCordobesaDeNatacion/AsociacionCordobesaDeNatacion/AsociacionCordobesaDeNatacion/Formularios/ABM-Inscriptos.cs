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
using AsociacionCordobesaDeNatacion.Formularios;

namespace AsociacionCordobesaDeNatacion.Formularios
{
    public partial class ABM_Inscriptos : Form
    {

		AccesoBD _BD = new AccesoBD();

        Nadadores nadadores = new Nadadores();
        Torneos torneos = new Torneos();
        Especialidades especialidades = new Especialidades();
        DataTable tabla = new DataTable();
        float randomNumber;


        public ABM_Inscriptos()
        {
            InitializeComponent();
           
        }


		private void cmd_grabar_Click(object sender, EventArgs e)
		{
            Random random = new Random();
            this.randomNumber = randomNumberMethod(random);

            string sql = @"INSERT INTO Inscriptos 
                         (cod_espe, cod_torneo, cod_nad, anio, tiempo) VALUES(" +
                         txt_cod_especialidad.Text.Trim() + ", " +
                         txt_cod_torneo.Text.Trim() + ", " +
                         txt_cod_nadador.Text.Trim() + ", " +
                         txt_anio.Text.Trim() + ", " +
                         this.randomNumber + ")";
            _BD.insert_update_delete(sql);
            this.label5.Text = "En proceso";
        }

		

		private void cargar_grilla()
		{
			DataTable tabla = new DataTable();
			tabla = _BD.consulta("SELECT * FROM Inscriptos");
			if (tabla.Rows.Count == 0)
			{
				return;
			}
			dataGrid_Inscriptos.DataSource = tabla;
			dataGrid_Inscriptos.Columns[0].Width = 150;
			dataGrid_Inscriptos.Columns[1].Width = 300;
		}

		private void btn_CargarGrilla_Click(object sender, EventArgs e)
		{
			this.cargar_grilla();
		}

		private void btn_IniciarTrans_Click(object sender, EventArgs e)
		{
			_BD.iniciar_transaccion();
			this.label5.Text = "Iniciada";
		}

		private void btn_FinalizarTrans_Click(object sender, EventArgs e)
		{
			_BD.cerrar_transaccion();
			this.cargar_grilla();
			this.label5.Text = "Finalizada";
		}


		private void cmd_actualizar_Click(object sender, EventArgs e)
		{
			string sql = @"UPDATE Inscriptos 
                         SET (cod_espe, cod_torneo, cod_nad, anio) = ( '" +
						 txt_cod_especialidad.Text.Trim() + "," +
						 txt_cod_torneo.Text.Trim() + "," +
						 txt_cod_nadador.Text.Trim() + "," +
						 txt_anio.Text.Trim() + "' )" +
						 " WHERE cod_espe = " + txt_cod_especialidad.Text.Trim() +
								"cod_torneo = " + txt_cod_torneo.Text.Trim() + 
								"cod_nad = " + txt_cod_nadador.Text.Trim() + 
								"anio = " + txt_anio.Text.Trim();

			_BD.insert_update_delete(sql);
			this.label5.Text = "En proceso";
		}

		private void btn_eliminar_Click(object sender, EventArgs e)
		{
			string sql = @"DELETE FROM Inscriptos 
                         WHERE  cod_espe = " + txt_cod_especialidad.Text.Trim() +
								"cod_torneo = " + txt_cod_torneo.Text.Trim() +
								"cod_nad = " + txt_cod_nadador.Text.Trim() +
								"anio = " + txt_anio.Text.Trim();

			_BD.insert_update_delete(sql);
			this.label5.Text = "En proceso";
		}

        private void ABM_Inscriptos_Load(object sender, EventArgs e)
        {
            ////DATA SET DE LOURDES
            //// TODO: esta línea de código carga datos en la tabla 'dS_Nadadores_Lourdes.Nadadores' Puede moverla o quitarla según sea necesario.
            //this.nadadoresTableAdapter3.Fill(this.dS_Nadadores_Lourdes.Nadadores);
            //// TODO: esta línea de código carga datos en la tabla 'dS_Especialidades_Lourdes.Especialidad' Puede moverla o quitarla según sea necesario.
            //this.especialidadTableAdapter3.Fill(this.dS_Especialidades_Lourdes.Especialidad);
            //// TODO: esta línea de código carga datos en la tabla 'dS_Torneos_Lourdes.Torneos' Puede moverla o quitarla según sea necesario.
            //this.torneosTableAdapter3.Fill(this.dS_Torneos_Lourdes.Torneos);


            //DATA SET DE LUPO
            // TODO: This line of code loads data into the 'dataSet7.Inscriptos' table. You can move, or remove it, as needed.
            this.inscriptosTableAdapter2.Fill(this.dataSet7.Inscriptos);
            // TODO: This line of code loads data into the 'dS_Nadador_Lupo.Nadadores' table. You can move, or remove it, as needed.
            this.nadadoresTableAdapter2.Fill(this.dS_Nadador_Lupo.Nadadores);
            // TODO: This line of code loads data into the 'dS_Especialidad_Lupo.Especialidad' table. You can move, or remove it, as needed.
            this.especialidadTableAdapter2.Fill(this.dS_Especialidad_Lupo.Especialidad);
            // TODO: This line of code loads data into the 'dS_Lupo_Torneo.Torneos' table. You can move, or remove it, as needed.
            this.torneosTableAdapter2.Fill(this.dS_Lupo_Torneo.Torneos);

            ////DATA SET DE BELEN
            // TODO: esta línea de código carga datos en la tabla 'dataSet6.Inscriptos' Puede moverla o quitarla según sea necesario.
            //this.inscriptosTableAdapter1.Fill(this.dataSet6.Inscriptos);
            // TODO: esta línea de código carga datos en la tabla 'dataSet5.Nadadores' Puede moverla o quitarla según sea necesario.
            //this.nadadoresTableAdapter1.Fill(this.dataSet5.Nadadores);
            // TODO: esta línea de código carga datos en la tabla 'dataSet4.Especialidad' Puede moverla o quitarla según sea necesario.
            //this.especialidadTableAdapter1.Fill(this.dataSet4.Especialidad);
            // TODO: esta línea de código carga datos en la tabla 'dataSet3.Torneos' Puede moverla o quitarla según sea necesario.
            //this.torneosTableAdapter1.Fill(this.dataSet3.Torneos);

            ////DATA SET DE MATI
            //// TODO: esta línea de código carga datos en la tabla 'dataSet2.Nadadores' Puede moverla o quitarla según sea necesario.
            //this.nadadoresTableAdapter.Fill(this.dataSet2.Nadadores);
            //// TODO: esta línea de código carga datos en la tabla 'dataSet1.Especialidad' Puede moverla o quitarla según sea necesario.
            //         this.especialidadTableAdapter.Fill(this.dataSet1.Especialidad);
            //// TODO: esta línea de código carga datos en la tabla 'dS_Torneos.Torneos' Puede moverla o quitarla según sea necesario.
            //         this.torneosTableAdapter.Fill(this.dS_Torneos.Torneos);

        }


        private void dataGridTorneo_SelectionChanged(object sender, EventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;
            txt_cod_torneo.Text = row.Cells[0].Value.ToString();
        }

        private void dataGridEspecialidad_SelectionChanged(object sender, EventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;
            txt_cod_especialidad.Text = row.Cells[0].Value.ToString();
        }

        private void dataGridNadador_SelectionChanged(object sender, EventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;
            txt_cod_nadador.Text = row.Cells[0].Value.ToString();
        }


        public float randomNumberMethod(Random random)
         {
            double a = 22;
            double b = 30;
            double numero = a + random.NextDouble()*(b-a);

            return (float)(numero);
        }
    }
}
