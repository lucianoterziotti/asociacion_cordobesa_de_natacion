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
        string _cod_esp;
        string _descripcion;
        string _tiempo_record;

        public Especialidades(AccesoBD BD)
        {
            _BD = BD;
        }

        public string cod_esp
        {
            get { return _cod_esp; }
            set { _cod_esp = value; }
        }
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public string tiempo_record
        {
            get { return _tiempo_record; }
            set { _tiempo_record = value; }
        }


        public DataTable buscar_especialidad()
        {
            int cod_esp_aux = Int32.Parse(cod_esp);
            string sqltxt = @"SELECT * FROM Especialidad 
                             WHERE cod_espec =" + cod_esp_aux;

            return _BD.consulta(sqltxt);
        }

        public void grabar_especialidad()
        {
            int cod_esp_aux = Int32.Parse(cod_esp);
            string SqlInsert = @" INSERT INTO Especialidad 
                         (cod_espec, descripcion) VALUES (" +
                         cod_esp_aux + ", '" +
                         this.descripcion + "')";
            MessageBox.Show(SqlInsert);

            this._BD.query(SqlInsert);
        }

        public void modificar_especialidad()
        {
            int cod_esp_aux = Int32.Parse(cod_esp);
            string sqlupdate = @"UPDATE Especialidad 
                         SET cod_espec = " + cod_esp_aux + "," +
                         "descripcion ='" + this.descripcion + "'" +
                         "WHERE cod_espec =" + cod_esp_aux;

            this._BD.query(sqlupdate);
        }
        public void eliminar_especialidad()
        {
            int cod_torneo_aux = Int32.Parse(cod_esp);
            string sqlDelete = @"DELETE FROM Especialidad WHERE cod_espec =" + cod_torneo_aux;

            this._BD.query(sqlDelete);

        }
    }
}
