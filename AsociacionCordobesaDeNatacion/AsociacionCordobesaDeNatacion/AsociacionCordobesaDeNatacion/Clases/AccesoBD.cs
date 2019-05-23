using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using AsociacionCordobesaDeNatacion.Clases;

namespace AsociacionCordobesaDeNatacion.Clases
{
	class AccesoBD
	{
		public enum resultado_acceso { error, correcto }
		public enum tipo_conexion { simple, transaccion }

		OleDbConnection conexion = new OleDbConnection();
		OleDbCommand cmd = new OleDbCommand();

        string cadena_conexion = "Provider=SQLNCLI11;Data Source=BELENPC\\BELEN;Integrated Security=SSPI;Initial Catalog=PAV";

        //BELU: "Provider=SQLNCLI11;Data Source=DESKTOP-5RVUN41\\BELENSQL;Persist Security Info=True;User ID=sa;Initial Catalog=PAV;password=Belen123";
        //LUPO:   "Provider=SQLNCLI11;Data Source=LAP-030\\SERVERINSTANCE;User ID=sa;Initial Catalog=master;password=12345";

        resultado_acceso control_transaccion = resultado_acceso.correcto;
		tipo_conexion analisis_tipo_transaccion = tipo_conexion.simple;
		OleDbTransaction transaccion;
		public void iniciar_transaccion()
		{
			analisis_tipo_transaccion = tipo_conexion.transaccion;
			control_transaccion = resultado_acceso.correcto;
		}
		public void cerrar_transaccion()
		{
			if (analisis_tipo_transaccion == tipo_conexion.simple)
				return;
			if (control_transaccion == resultado_acceso.correcto)
			{
				transaccion.Commit();
			}
			else
			{
				transaccion.Rollback();
			}
			analisis_tipo_transaccion = tipo_conexion.simple;
			cerrarT();
		}
		private void conectarT()
		{
			if (conexion.State == System.Data.ConnectionState.Closed)
			{
				conexion.ConnectionString = cadena_conexion;
				conexion.Open();
				cmd.Connection = conexion;
				cmd.CommandType = System.Data.CommandType.Text;
				if (analisis_tipo_transaccion == tipo_conexion.transaccion)
				{
					transaccion = conexion.BeginTransaction(IsolationLevel.ReadUncommitted);
					cmd.Transaction = transaccion;
				}
			}
		}
		private void cerrarT()
		{
			if (analisis_tipo_transaccion == tipo_conexion.simple)
			{
				conexion.Close();
			}

		}
		public resultado_acceso insert_update_delete(string comando)
		{
			conectarT();
			cmd.CommandText = comando;
			try
			{
				cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				control_transaccion = resultado_acceso.error;
				MessageBox.Show("Error con la Base de Datos" + "\n"
					+ "En el comando:" + "\n"
					+ comando + "\n"
					+ "El mensaje es:" + "\n"
					+ e.Message);
				cerrarT();
				return resultado_acceso.error;
			}
			cerrarT();
			return resultado_acceso.correcto;
		}
		public DataTable consultaT(string comando)
		{
			conectarT();
			cmd.CommandText = comando;
			DataTable tabla = new DataTable();
			try
			{
				tabla.Load(cmd.ExecuteReader());
			}
			catch (Exception e)
			{
				control_transaccion = resultado_acceso.error;
				MessageBox.Show("Error con la Base de Datos" + "\n"
					+ "En el comando:" + "\n"
					+ comando + "\n"
					+ "El mensaje es:" + "\n"
					+ e.Message);
				cerrarT();
				return tabla;
				throw;
			}
			cerrarT();
			return tabla;
		}

		internal void grabar_modificarT(string sqlInsert)
		{
			throw new NotImplementedException();
		}

		private void conectar()
		{

			conexion.ConnectionString = cadena_conexion;
			conexion.Open();
			cmd.Connection = conexion;
			cmd.CommandType = CommandType.Text;
		}

		private void cerrar()
		{
			conexion.Close();
		}

		public DataTable consulta(string comando)
		{
			conectar();
			cmd.CommandText = comando;
			DataTable tabla = new DataTable();
			tabla.Load(cmd.ExecuteReader());
			cerrar();
			return tabla;
		}

		public void grabar_modificar(string comando)
		{
			conectar();
			cmd.CommandText = comando;
			cmd.ExecuteNonQuery();
			cerrar();
		}
	}
}
