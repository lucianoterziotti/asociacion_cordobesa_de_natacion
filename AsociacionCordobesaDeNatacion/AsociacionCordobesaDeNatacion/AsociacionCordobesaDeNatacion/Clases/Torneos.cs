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
        AccesoBD _BD;

        public Torneos(AccesoBD BD)
        {
            this._BD = BD;
        }

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

        public void grabar_torneo()
        {
            int cod_torneo_aux = Int32.Parse(cod_torneo);
            string SqlInsert = @" INSERT INTO torneos 
                         (cod_torneo, descripccion) VALUES (" +
                         cod_torneo_aux + ", '" +
                         this._descripcion_torneo + "')";
            MessageBox.Show(SqlInsert);

            this._BD.query(SqlInsert);
        }

        public void modificar_torneo()
        {
            int cod_torneo_aux = Int32.Parse(cod_torneo);
            string sqlupdate = @"UPDATE Torneos 
                         SET cod_torneo = " + cod_torneo_aux + "," +
                         "descripccion ='" + this._descripcion_torneo + "'" +
                         "WHERE cod_torneo =" + cod_torneo_aux;

            this._BD.query(sqlupdate);
        }
        public void eliminar_torneo()
        {
            int cod_torneo_aux = Int32.Parse(cod_torneo);
            string sqlDelete = @"DELETE FROM torneos WHERE cod_torneo =" + cod_torneo_aux;

            this._BD.query(sqlDelete);

        }
    }
}
