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
    public partial class ABM_Inscriptos : Form
    {

		AccesoBD _BD = new AccesoBD();

		Inscriptos inscriptos = new Inscriptos();
        Nadadores nadadores = new Nadadores();
        Torneos torneos = new Torneos();
        Especialidades especialidades = new Especialidades();
        DataTable tabla = new DataTable();


        public ABM_Inscriptos()
        {
            InitializeComponent();
        }


		//NO VA
		//private void btn_buscarXtorneo_Click(object sender, EventArgs e)
		//{
		//    if (this.txt_cod_torneo.Text == "")
		//    {

		//        MessageBox.Show("El codigo de torneo no está cargado");

		//        this.txt_cod_torneo.Focus();

		//        return;
		//    }
		//    DataTable tabla = new DataTable();

		//}

		private void cmd_grabar_Click(object sender, EventArgs e)
		{


			//VALIDACIONES QUE HIZO LUPO!!!!!!!
			//inscriptos.anio = txt_anio.Text;
			//especialidades.cod_esp = txt_cod_especialidad.Text;
			//nadadores.dni_nadador = txt_cod_nadador.Text;
			//torneos.cod_torneo = txt_cod_torneo.Text;
			//inscriptos.posicion = txt_posicion.Text;
			//inscriptos.tiempo = txt_tiempo.Text;
			//if (validarTorneo())
			//{
			//    if (validarEspecialidad())
			//    {
			//        if (validarNadador())
			//        {
			//            inscriptos.cod_especialidad = txt_cod_especialidad.Text;
			//            inscriptos.cod_nadador = txt_cod_nadador.Text;
			//            inscriptos.cod_torneo = txt_cod_torneo.Text;
			//            inscriptos.grabar_inscripto();
			//        }
			//        else
			//        {
			//            MessageBox.Show("No se ha ingresado codigo de nadador o es invalido");
			//        }
			//    }
			//    else
			//    {
			//        MessageBox.Show("No se ha ingresado codigo de especialidad o es invalido");
			//    }
			//}
			//else
			//{
			//    MessageBox.Show("No se ha ingresado codigo de torneo o es invalido");
			//}



			//bool validarTorneo()
			//{
			//    tabla = torneos.buscar_torneo(this.txt_cod_torneo.Text);
			//    if (tabla.Rows.Count == 1)
			//    {
			//        return true;
			//    }
			//    return false;
			//}

			//bool validarEspecialidad()
			//{
			//    tabla = especialidades.buscar_especialidad();
			//    if (tabla.Rows.Count == 1)
			//    {
			//        return true;
			//    }
			//    return false;
			//}

			//bool validarNadador()
			//{
			//    tabla = nadadores.buscar_nadador();
			//    if (tabla.Rows.Count == 1)
			//    {
			//        return true;
			//    }
			//    return false;
			//}

			inscriptos.anio = txt_anio.Text;
			especialidades.cod_esp = txt_cod_especialidad.Text;
			nadadores.dni_nadador = txt_cod_nadador.Text;
			torneos.cod_torneo = txt_cod_torneo.Text;
			inscriptos.posicion = txt_posicion.Text;
			inscriptos.tiempo = txt_tiempo.Text;
			
			string sql = @"INSERT INTO Inscriptos 
                         (cod_espe, cod_torneo, cod_nad, anio) VALUES(" +
						 txt_cod_especialidad.Text.Trim() + ", " +
						 txt_cod_torneo.Text.Trim() + ", " +
						 txt_cod_nadador.Text.Trim() + ", " +
						 txt_anio.Text.Trim() + ")";
			_BD.insert_update_delete(sql);
			this.cargar_grilla();
			this.label5.Text = "Transacción en Proceso";
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
			this.cargar_grilla();
			this.label5.Text = "Transacción iniciada";
		}

		private void btn_FinalizarTrans_Click(object sender, EventArgs e)
		{
			_BD.cerrar_transaccion();
			this.cargar_grilla();
			this.label5.Text = "Transacción Finalizada";
		}


		private void cmd_actualizar_Click(object sender, EventArgs e)
		{
			inscriptos.anio = txt_anio.Text;
			especialidades.cod_esp = txt_cod_especialidad.Text;
			nadadores.dni_nadador = txt_cod_nadador.Text;
			torneos.cod_torneo = txt_cod_torneo.Text;
			inscriptos.posicion = txt_posicion.Text;
			inscriptos.tiempo = txt_tiempo.Text;

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
			this.cargar_grilla();
			this.label5.Text = "Transacción en Proceso";
		}

		private void btn_eliminar_Click(object sender, EventArgs e)
		{
			string sql = @"DELETE FROM Inscriptos 
                         WHERE  cod_espe = " + txt_cod_especialidad.Text.Trim() +
								"cod_torneo = " + txt_cod_torneo.Text.Trim() +
								"cod_nad = " + txt_cod_nadador.Text.Trim() +
								"anio = " + txt_anio.Text.Trim();

			_BD.insert_update_delete(sql);
			this.cargar_grilla();
			this.label5.Text = "Transacción en Proceso";
		}
	}
}
