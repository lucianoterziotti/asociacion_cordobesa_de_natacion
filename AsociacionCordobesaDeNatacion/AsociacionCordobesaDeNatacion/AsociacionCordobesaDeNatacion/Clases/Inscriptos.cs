using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsociacionCordobesaDeNatacion.Clases
{
    class Inscriptos
    {
        AccesoBD _BD;
        string _cod_torneo;
        string _anio;
        string _cod_especialidad;
        string _cod_nadador;
        double _tiempo;

        public Inscriptos(AccesoBD BD)
        {
            _BD = BD;
        }

        public string anio
        {
            get { return _anio; }
            set { _anio = value; }
        }
        public string cod_especialidad
        {
            get { return _cod_especialidad; }
            set { _cod_especialidad = value; }
        }
        public string cod_nadador
        {
            get { return _cod_nadador; }
            set { _cod_nadador = value; }
        }
        public string cod_torneo
        {
            get { return this._cod_torneo; }
            set { this._cod_torneo = value; }
        }

        public double tiempo
        {
            get { return this._tiempo; }
            set { this._tiempo = value; }
        }

        public DataTable buscar_inscripcionXespecialidad()
        {
            int cod_espe_aux = Int32.Parse(this.cod_especialidad);
            string sqltxt = @"SELECT * FROM Inscriptos 
                             WHERE cod_especialidad =" + cod_espe_aux;

            return _BD.consulta(sqltxt);
        }

        public DataTable buscar_inscripcionXtorneo()
        {
            int cod_torneo_aux = Int32.Parse(this.cod_torneo);
            string sqltxt = @"SELECT * FROM Inscriptos 
                             WHERE cod_torneo =" + cod_torneo_aux;

            return _BD.consulta(sqltxt);
        }

        public DataTable buscar_inscripcionXnadador(string cod_club)
        {
            int cod_nadador_aux = Int32.Parse(this.cod_nadador);
            string sqltxt = @"SELECT * FROM Inscriptos 
                             WHERE cod_nadador =" + cod_nadador_aux;

            return _BD.consulta(sqltxt);
        }

        public void grabar_inscripto()

        {
            double tiempo_aux = this.tiempo;
            int cod_nad_aux = Int32.Parse(this.cod_nadador);
            int cod_esp_aux = Int32.Parse(this.cod_especialidad);
            int cod_torneo_aux = Int32.Parse(this.cod_torneo);
            int anio_aux = Int32.Parse(this.anio);

            string SqlInsert = @"INSERT INTO Inscriptos 
                         (cod_especialidad, cod_torneo, cod_nadador,tiempo, anio) VALUES (" +
                         cod_esp_aux + "," +
                         cod_torneo_aux + "," +
                         cod_nad_aux + ", '" +
                         tiempo_aux + "', " +
                         anio_aux +
                         ")";
            string SqlInsert1 = @"INSERT INTO Inscriptos(tiempo) VALUES ('"+ tiempo_aux + "')";
            MessageBox.Show(SqlInsert);
            this._BD.query(SqlInsert);

        }

        public void eliminar_Inscripto()
        {
            int anio_aux = Int32.Parse(anio);
            int cod_nadador_aux = Int32.Parse(this.cod_nadador);
            int cod_torneo_aux = Int32.Parse(this.cod_torneo);
            int cod_especialidad = Int32.Parse(this.cod_especialidad);

            string sqlDelete = @"DELETE FROM Inscriptos 
                                 WHERE  cod_torneo =" + cod_torneo_aux + " AND " +
                                "anio =" + anio_aux + " AND " +
                                "cod_nadador =" + cod_nadador_aux + " AND " +
                                "cod_especialidad = " + cod_especialidad;


            this._BD.query(sqlDelete);

        }

        public void modificar_Inscripto(string cod_nadador, string cod_especialidad, string cod_torneo, string anio)
        {
            int cod_nad_aux = Int32.Parse(this.cod_nadador);
            int cod_esp_aux = Int32.Parse(this.cod_especialidad);
            int cod_torneo_aux = Int32.Parse(this.cod_torneo);
            int anio_aux = Int32.Parse(this.anio);
            double tiempo_aux = this.tiempo;

            string sqlUpdate = "UPDATE Inscriptos SET cod_torneo =" + cod_torneo_aux +
                                ", anio =" + anio_aux +
                                ", cod_especialidad =" + cod_esp_aux +
                                ", cod_nadador =" + cod_nad_aux +
                                ", tiempo = '" + tiempo_aux + "'" +
                                " WHERE  cod_torneo =" + cod_torneo_aux + " AND " +
                                "anio =" + anio_aux + " AND " +
                                "cod_nadador =" + cod_nad_aux + " AND " +
                                "cod_especialidad = " + cod_esp_aux + " AND " +
                                "tiempo = '" + tiempo_aux + "'";

            MessageBox.Show(sqlUpdate);
            this._BD.query(sqlUpdate);

        }
        
    }
}
