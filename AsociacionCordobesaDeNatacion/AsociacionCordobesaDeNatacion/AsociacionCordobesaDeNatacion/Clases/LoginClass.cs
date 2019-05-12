using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsociacionCordobesaDeNatacion.Clases
{
    class LoginClass
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
    }
}
