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
        AccesoBD _BD;
        string _nombre_nadador;
        string _dni_nadador;
        string _calle_nadador;

        public Nadadores(AccesoBD BD)
        {
            _BD = BD;
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



        public DataTable buscar_nadador()
        {
            int dni_nadador_aux = Int32.Parse(_dni_nadador);
            string sqltxt = @"SELECT * FROM nadadores 
                             WHERE cod_nacional =" + dni_nadador;

            return _BD.consulta(sqltxt);
        }

        public void grabar_nadador()
        {
            int dni_nadador_aux = Int32.Parse(dni_nadador);
            string SqlInsert = @" INSERT INTO Nadadores 
                         (cod_nacional, nombre, calle) VALUES (" +
                         dni_nadador_aux + ", '" +
                         this.nombre_nadador + "', '" +
                         this.calle_nadador + "')";
            MessageBox.Show(SqlInsert);

            this._BD.query(SqlInsert);
        }

        public void modificar_nadador()
        {
            int dni_nadador_aux = Int32.Parse(dni_nadador);
            string sqlupdate = @"UPDATE Nadadores 
                         SET cod_nacional =" + dni_nadador_aux + "," +
                         "nombre ='" + this.nombre_nadador + "'," +
                         "calle ='" + this.calle_nadador + "'" +
                         "WHERE cod_nacional =" + dni_nadador_aux;

            this._BD.query(sqlupdate);
        }
        public void eliminar_nadador()
        {
            int dni_nadador_aux = Int32.Parse(dni_nadador);
            string sqlDelete = @"DELETE FROM nadadores WHERE cod_nacional =" + dni_nadador_aux;

            this._BD.query(sqlDelete);

        }
    }
}

