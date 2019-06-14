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
        string cadena_conexion_definitiva;
        public AccesoBD(int numeroUsuario)
        {
            cadena_conexion_definitiva = cadenaDeConexionCorrecta(numeroUsuario);
        }
        

        public enum resultado_acceso { error, correcto }
		public enum tipo_conexion { simple, transaccion }

        OleDbConnection conexion = new OleDbConnection();
		OleDbCommand cmd = new OleDbCommand();


        //LOURDES: 
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
            conexion.ConnectionString = cadena_conexion_definitiva;
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

		public void query(string comando)
		{
			conectar();
			cmd.CommandText = comando;
			cmd.ExecuteNonQuery();
			cerrar();
		}

        public string cadenaDeConexionCorrecta(int numeroUsuario)
        {
            string cadena_conexion;
            string CADENA_CONEXION_BELEN = "Provider=SQLNCLI11;Data Source=BELENPC\\BELEN;Integrated Security=SSPI;Initial Catalog=PAV";
            string CADENA_CONEXION_MATI = "Provider=SQLNCLI11;Data Source=MATIAS;Integrated Security=SSPI;Initial Catalog=PAV";
            string CADENA_CONEXION_LUPO = "Provider=SQLNCLI11;Data Source=LAP-030\\SERVERINSTANCE;User ID=sa;Initial Catalog=master;password=12345";
            string CADENA_CONEXION_LOURDES = "Provider=SQLNCLI11;Data Source=DESKTOP-5EFA1ET\\LOURDESSQL;User ID=sa;Initial Catalog=PAV;password=voley123";
            switch (numeroUsuario)
            {

                case 1:
                      cadena_conexion = CADENA_CONEXION_BELEN;
                    break;
                case 2:
                      cadena_conexion = CADENA_CONEXION_MATI;
                    break;
                case 3:
                      cadena_conexion = CADENA_CONEXION_LUPO;
                    break;
                case 4:
                    cadena_conexion = CADENA_CONEXION_LOURDES;
                    break;
                default:
                    cadena_conexion = "";
                    break;
            }
            return cadena_conexion;
        }

        
    }
}
