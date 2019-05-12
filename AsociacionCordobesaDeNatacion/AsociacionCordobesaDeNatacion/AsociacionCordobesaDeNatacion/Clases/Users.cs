using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AsociacionCordobesaDeNatacion.Clases;

namespace AsociacionCordobesaDeNatacion

{
    class Users
    {
        int _id = 0;
        string _usuario;
        string _password;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }

        }
        AccesoBD _BD = new AccesoBD();
        
        public DataTable consulta_login(string usuario, string pssw)
        {
            string sqltxt = @"SELECT * FROM Usuarios 
                             WHERE nombre = '" + usuario + "'"
                             + " AND password = '" + pssw + "'";

            return _BD.consulta(sqltxt);
        }
    }
}
