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

        public DataTable buscar_prof()
        {
            int dni_profesor_aux = Int32.Parse(dni_profesor);
            string sqltxt = @"SELECT * FROM Profesores 
                             WHERE cod_prof =" + dni_profesor_aux;

            return _BD.consulta(sqltxt);
        }

        public void grabar_profesor()
        {
            int dni_profesor_aux = Int32.Parse(dni_profesor);
            string SqlInsert = @" INSERT INTO Profesores 
                         (cod_prof, nombre, calle) VALUES (" +
                         dni_profesor_aux + ", '" +
                         this.nombre_profesor + "', '" +
                         this.calle_profesor + "')";
            MessageBox.Show(SqlInsert);

            this._BD.grabar_modificar(SqlInsert);
        }

        public void modificar_profesor()
        {
            int dni_profesor_aux = Int32.Parse(dni_profesor);
            string sqlupdate = @"UPDATE Profesores 
                         SET cod_prof =" + dni_profesor_aux + "," +
                         "nombre ='" + this.nombre_profesor + "'," +
                         "calle ='" + this.calle_profesor + "'" +
                         "WHERE cod_prof =" + dni_profesor_aux;

            this._BD.grabar_modificar(sqlupdate);
        }
        public void eliminar_profesor()
        {
            int dni_profesor_aux = Int32.Parse(dni_profesor);
            string sqlDelete = @"DELETE FROM Profesores WHERE cod_prof =" + dni_profesor_aux;

            this._BD.grabar_modificar(sqlDelete);

        }

    }
}
