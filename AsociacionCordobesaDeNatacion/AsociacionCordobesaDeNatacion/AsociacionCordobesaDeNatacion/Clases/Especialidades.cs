using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsociacionCordobesaDeNatacion.Clases
{

    class Especialidades
    {
        string _cod_esp;
        string _descripcion;
        string _tiempo_record;

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

        AccesoBD _BD = new AccesoBD();

        public DataTable buscar_especialiad(string cod_esp)
        {
            int cod_esp_aux = Int32.Parse(cod_esp);
            string sqltxt = @"SELECT * FROM Especialidad 
                             WHERE cod_espec = '" + cod_esp;

            return _BD.consulta(sqltxt);
        }
    }
}
