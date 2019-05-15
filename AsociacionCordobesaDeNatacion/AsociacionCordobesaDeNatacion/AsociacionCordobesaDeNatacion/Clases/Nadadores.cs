using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsociacionCordobesaDeNatacion.Clases
{
    class Nadadores
    {
        string _nombre_nadador;
        string _dni_nadador;
        string _calle_nadador;
        string _numero_nadador;
        int _id;


        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string nombre_nadador
        {
            get { return _nombre_nadador; }
            set { _nombre_nadador = value; }
        }
        public string dni_nadador
        {
            get { return _dni_nadador; }
            set { _dni_nadador = value; }

        }

        public string calle_nadador
        {
            get { return _calle_nadador; }
            set { _calle_nadador = value; }

        }
        public string numero_nadador
        {
            get { return _numero_nadador; }
            set { _numero_nadador = value; }

        }

        AccesoBD _BD = new AccesoBD();
  
        public DataTable buscar_nadador(string cod_nacional)
        {
            
            string sqltxt = @"SELECT * FROM nadadores 
                             WHERE _cod_nadador = '" + _dni_nadador;

            return _BD.consulta(sqltxt);
        }

        public void grabar_nadador()
        {

            string SqlInsert = @" INSERT INTO clubes 
                         (
                         _nombre_nadador,_cod_nadador, calle_nadador, numero_nadador) VALUES ('" +
                         this._nombre_nadador + "', '" +
                         this._dni_nadador + "', '" +
                         this.calle_nadador + "', " +
                         this.numero_nadador + ")";
            MessageBox.Show(SqlInsert);

            this._BD.grabar_modificar(SqlInsert);
        }

        public void modificar_nadador(string _id)
        {
            string sqlupdate = @"UPDATE clubes 
                         SET( _nombre_nadador,_cod_nadador, calle_nadador, numero_nadador VALUES ('" +
                         this._nombre_nadador + "', '" +
                         this._dni_nadador + "', '" +
                         this.calle_nadador + "', " +
                         this.numero_nadador + ")" +
                         " WHERE _cod_nadador = " + _dni_nadador;

            this._BD.grabar_modificar(sqlupdate);
        }
    }
}

