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
        AccesoBD _BD = new AccesoBD();
        
        public DataTable consulta_login(string usuario, string pssw)
        {
            string sqltxt = @"SELECT * FROM users 
                             WHERE n_usuario = '" + usuario + "'"
                             + " AND password = '" + pssw + "'";

            return _BD.consulta(sqltxt);
        }
    }
}
