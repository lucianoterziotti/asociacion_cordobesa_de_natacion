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
        int _posicion;
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
        public int posicion
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

            Random random = new Random();
            this.tiempo = randomNumberMethod(random);

            int cod_nad_aux = Int32.Parse(this.cod_nadador);
            int cod_esp_aux = Int32.Parse(this.cod_especialidad);
            int cod_torneo_aux = Int32.Parse(this.cod_torneo);
            int anio_aux = Int32.Parse(this.anio);
                        
            string SqlInsert = @"INSERT INTO Inscriptos 
                         (cod_espe, cod_torneo, cod_nad, tiempo, posicion, anio ) VALUES (" +
                         cod_esp_aux + "," +
                         cod_torneo_aux + "," +
                          cod_nad_aux + "," +
                          tiempo + "," +
                          posicion + "," +
                         anio_aux +")";
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
                         WHERE  cod_torneo =" + cod_torneo_aux+ " AND " +
                               "anio =" + anio_aux + " AND " +
                                "cod_nad =" + cod_nadador_aux + " AND " +
                                "cod_espe = " +cod_especialidad ;


            this._BD.query(sqlDelete);

        }

        public float randomNumberMethod(Random random)
        {
            double a = 22;
            double b = 30;
            double numero = a + random.NextDouble() * (b - a);

            return (float)(numero);
        }

        //private int setearPuesto()
        //{
        //    List<string> array = new List<string>();
        //    DataTable tabla = new DataTable();
        //    int puesto=0;
            
        //    tabla = _BD.consulta("SELECT * FROM Inscriptos");

        //    int counter = tabla.Rows.Count;
        //    foreach (DataTable row in tabla.Rows)
        //    {

        //        array.Add(row.Rows[5].ToString());
        //        array.Sort();
        //    }
        //    if (counter == 0)
        //    {

        //    }
        //    return ;
        //}
    }

    
}
