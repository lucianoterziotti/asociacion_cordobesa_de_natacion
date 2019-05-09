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
        
        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        
        string cadena_conexion = "Provider=SQLNCLI11;Data Source=LAP-030\\SERVERINSTANCE;User ID=sa;Initial Catalog=master;password=12345";
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
