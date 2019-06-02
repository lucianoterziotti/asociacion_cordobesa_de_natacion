using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsociacionCordobesaDeNatacion.Clases
{
    class Inscriptos
    {
        string _cod_torneo;
        string _anio;
        string _cod_especialidad;
        string _cod_nadador;
        string _posicion;
        float _tiempo;



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
        public string posicion
        {
            get { return this._posicion; }
            set { this._posicion = value; }
        }
        public float tiempo
        {
            get { return this._tiempo; }
            set { this._tiempo = value; }
        }

        AccesoBD _BD = new AccesoBD();

        public DataTable buscar_inscripcionXespecialidad()
        {
            int cod_espe_aux = Int32.Parse(this.cod_especialidad);
            string sqltxt = @"SELECT * FROM Inscriptos 
                             WHERE cod_espe =" + cod_espe_aux;

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
                             WHERE cod_nad =" + cod_nadador_aux;

            return _BD.consulta(sqltxt);
        }


        public void grabar_inscripto()
        {
            int cod_nad_aux = Int32.Parse(this.cod_nadador);
            int cod_esp_aux = Int32.Parse(this.cod_especialidad);
            int cod_torneo_aux = Int32.Parse(this.cod_torneo);
            int anio_aux = Int32.Parse(this.anio);
        //    int posicion_aux = Int32.Parse(this.posicion);
            
            string SqlInsert = @"INSERT INTO Inscriptos 
                         (cod_espe, cod_torneo, cod_nad, anio, tiempo) VALUES (" +
                         cod_esp_aux + "," +
                         cod_torneo_aux + "," +
                          cod_nad_aux + "," +
                          tiempo + "," +
                         anio_aux +")";
                   MessageBox.Show(SqlInsert);

            this._BD.grabar_modificar(SqlInsert);
        }
    }
}
