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
        AccesoBD _BD;
        public Profesores(AccesoBD BD)
        {
            _BD = BD;
        }
        string _nombre_profesor;
        string _cod_profesor;
        string _calle_profesor;



        public string cod_profesor
        {
            get { return _cod_profesor; }
            set { _cod_profesor = value; }
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

        public DataTable buscar_prof()
        {
            int cod_profesor_aux = Int32.Parse(cod_profesor);
            string sqltxt = @"SELECT * FROM Profesores 
                             WHERE cod_profesor =" + cod_profesor_aux;

            return _BD.consulta(sqltxt);
        }

        public void grabar_profesor()
        {
            int cod_profesor_aux = Int32.Parse(cod_profesor);
            string SqlInsert = @" INSERT INTO Profesores 
                         (cod_profesor, nombre, calle) VALUES (" +
                         cod_profesor_aux + ", '" +
                         this.nombre_profesor + "', '" +
                         this.calle_profesor + "')";
            MessageBox.Show(SqlInsert);

            this._BD.query(SqlInsert);
        }

        public void modificar_profesor()
        {
            int cod_profesor_aux = Int32.Parse(cod_profesor);
            string sqlupdate = @"UPDATE Profesores 
                         SET cod_profesor =" + cod_profesor_aux + "," +
                         "nombre ='" + this.nombre_profesor + "'," +
                         "calle ='" + this.calle_profesor + "'" +
                         "WHERE cod_profesor =" + cod_profesor_aux;

            this._BD.query(sqlupdate);
        }
        public void eliminar_profesor()
        {
            int cod_profesor_aux = Int32.Parse(cod_profesor);
            string sqlDelete = @"DELETE FROM Profesores WHERE cod_profesor =" + cod_profesor_aux;

            this._BD.query(sqlDelete);

        }

    }
}
