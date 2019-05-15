using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AsociacionCordobesaDeNatacion.Clases
{
    class Torneos
    {
        string _cod_torneo;
        string _descripcion_torneo;
        int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string cod_torneo
        {
            get { return _cod_torneo; }
            set { _cod_torneo = value; }
        }

        public string descripcion_torneo
        {
            get { return _descripcion_torneo; }
            set { _descripcion_torneo = value; }
        }

        AccesoBD _BD = new AccesoBD();

        public DataTable buscar_torneo(string cod_torneo)
        {
            int cod_torneo_aux = Int32.Parse(cod_torneo);
            string sqltxt = @"SELECT * FROM torneos 
                             WHERE cod_torneo =" + cod_torneo_aux;

            return _BD.consulta(sqltxt);
        }

        public DataTable buscar_prof()
        {
            string sqltxt = @"SELECT * FROM profesores 
                             WHERE cod_torneo =" + _cod_torneo;

            return _BD.consulta(sqltxt);
        }

        public void grabar_profesor()
        {

            string SqlInsert = @" INSERT INTO clubes 
                         (
                         _cod_torneo; _descripcion_torneo) VALUES (" +
                         this._cod_torneo + ", '" +
                         this._descripcion_torneo + "')" ;
            MessageBox.Show(SqlInsert);

            this._BD.grabar_modificar(SqlInsert);
        }

        public void modificar_nadador(string _id)
        {
            string sqlupdate = @"UPDATE clubes 
                         SET(  _cod_torneo; _descripcion_torneo VALUES ('" +
                         this._cod_torneo + "', '" +
                         this._descripcion_torneo + "', '" +
                         " WHERE _cod_torneo = " + _cod_torneo;

            this._BD.grabar_modificar(sqlupdate);
        }
    }
}
