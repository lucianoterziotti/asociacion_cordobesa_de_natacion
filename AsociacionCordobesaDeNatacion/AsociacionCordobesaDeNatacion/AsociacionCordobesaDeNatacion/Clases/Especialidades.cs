using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsociacionCordobesaDeNatacion.Clases
{

    class Especialidades
    {
        AccesoBD _BD;
        string _cod_especialidad;
        string _descripcion;
        
        public Especialidades(AccesoBD BD)
        {
            _BD = BD;
        }

        public string cod_especialidad
        {
            get { return _cod_especialidad; }
            set { _cod_especialidad = value; }
        }
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        
        public DataTable buscar_especialidad()
        {
            int cod_especialidad_aux = Int32.Parse(cod_especialidad);
            string sqltxt = @"SELECT * FROM Especialidad 
                             WHERE cod_especialidad =" + cod_especialidad_aux;

            return _BD.consulta(sqltxt);
        }

        public void grabar_especialidad()
        {
            int cod_especialidad_aux = Int32.Parse(cod_especialidad);
            string SqlInsert = @" INSERT INTO Especialidad 
                         (cod_especialidad, descripcion) VALUES (" +
                         cod_especialidad_aux + ", '" +
                         this.descripcion + "')";
            MessageBox.Show(SqlInsert);

            this._BD.query(SqlInsert);
        }

        public void modificar_especialidad()
        {
            int cod_especialidad_aux = Int32.Parse(cod_especialidad);
            string sqlupdate = @"UPDATE Especialidad 
                         SET cod_espec = " + cod_especialidad_aux + "," +
                         "descripcion ='" + this.descripcion + "'" +
                         "WHERE cod_especialidad =" + cod_especialidad_aux;

            this._BD.query(sqlupdate);
        }
        public void eliminar_especialidad()
        {
            int cod_especialidad_aux = Int32.Parse(cod_especialidad);
            string sqlDelete = @"DELETE FROM Especialidad WHERE cod_espec =" + cod_especialidad_aux;

            this._BD.query(sqlDelete);

        }
    }
}
