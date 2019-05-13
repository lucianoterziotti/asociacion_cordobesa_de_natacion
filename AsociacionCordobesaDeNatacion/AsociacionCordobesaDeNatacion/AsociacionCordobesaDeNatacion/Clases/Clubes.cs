using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AsociacionCordobesaDeNatacion.Clases
{
    class Clubes
    {
      
        string _cod_club;
        string _nombre_club;
        string _calle_club;
        string _numero_club;
        int _id;


        public string nombre_club
        {
            get { return _nombre_club; }
            set { _nombre_club = value; }
        }
        public string calle_club
        {
            get { return _calle_club; }
            set { _calle_club = value; }
        }
        public string numero_club
        {
            get { return _numero_club; }
            set { _numero_club = value; }
        }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string cod_club
        {
            get { return this._cod_club; }
            set { this._cod_club = value; }
        }


        AccesoBD _BD = new AccesoBD();

        public DataTable buscar_club(string cod_club)
        {
            string sqltxt = @"SELECT * FROM clubes 
                             WHERE cod_club = '" + cod_club
                             +"'";

            return _BD.consulta(sqltxt);
        }


        public void grabar_club()
        {

            string SqlInsert = @" INSERT INTO clubes 
                         (
                         cod_club,nombre_club, calle_club, numero_club) VALUES ('" +
                         this._cod_club + "', '" +
                         this._nombre_club + "', '" +
                         this._calle_club + "', " +
                         this._numero_club + ")";
            MessageBox.Show(SqlInsert);
             
            this._BD.grabar_modificar(SqlInsert);
        }
        
        public void modificar_club(string _id)
        {
            string sqlupdate = @"UPDATE clubes 
                         SET( nombre_club, calle_club, numero_club) VALUES ('" +
                         this._nombre_club + "', '" +
                         this._calle_club + "', " +
                         this._numero_club + ")" +
                         " WHERE cod_club = " + _cod_club;
                         
            this._BD.grabar_modificar(sqlupdate);
        }
    }
}
