using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AsociacionCordobesaDeNatacion.Clases
{
    class Profesores
    {
        AccesoBD _BD = new AccesoBD();


        string _nombre_profesor;
        string _dni_profesor;
        string _calle_profesor;
        string _numero_profesor;
        int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string dni_profesor
        {
            get { return _dni_profesor; }
            set { _dni_profesor = value; }
        }

        public string nombre_profesor
        {
            get { return _nombre_profesor; }
            set { _nombre_profesor = value; ; }

        }
        public string calle_profesor
        {
            get { return _calle_profesor; }
            set { _calle_profesor = value; }
        }

        public string numero_profesor
        {
            get { return _numero_profesor; }
            set { _numero_profesor = value; }
        }


        public DataTable buscar_prof(string dni)
        {
            string sqltxt = @"SELECT * FROM profesores 
                             WHERE cod_prof = '" + dni_profesor;

            return _BD.consulta(sqltxt);
        }

        public void grabar_profesor()
        {

            string SqlInsert = @" INSERT INTO clubes 
                         (
                         _nombre_profesor,_cod_profesor, _calle_profesor, _numero_profesor) VALUES ('" +
                         this._nombre_profesor + "', '" +
                         this._dni_profesor + "', '" +
                         this._calle_profesor + "', " +
                         this._numero_profesor + ")";
            MessageBox.Show(SqlInsert);

            this._BD.grabar_modificar(SqlInsert);
        }

        public void modificar_nadador(string _id)
        {
            string sqlupdate = @"UPDATE clubes 
                         SET(  _nombre_profesor,_cod_profesor, _calle_profesor, _numero_profesor VALUES ('" +
                         this._nombre_profesor + "', '" +
                         this._dni_profesor + "', '" +
                         this._calle_profesor + "', " +
                         this._numero_profesor + ")" +
                         " WHERE _cod_nadador = " + _dni_profesor;

            this._BD.grabar_modificar(sqlupdate);
        }

    }
}
