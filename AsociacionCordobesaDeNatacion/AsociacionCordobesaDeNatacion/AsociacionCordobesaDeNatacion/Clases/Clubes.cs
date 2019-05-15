﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AsociacionCordobesaDeNatacion.Clases
{
    class Clubes
    {
      
        string _cod_club;
        string _nombre_club;
        string _calle_club;
        string _numero_club;
       


        public string nombre_club
        {
            get { return _nombre_club; }
            set { _nombre_club = value; }
        }
        public string calle_club
        {
            get { return _calle_club; }
            set { _calle_club = value; }
        }
        public string numero_club
        {
            get { return _numero_club; }
            set { _numero_club = value; }
        }
        

        public string cod_club
        {
            get { return this._cod_club; }
            set { this._cod_club = value; }
        }


        AccesoBD _BD = new AccesoBD();

        public DataTable buscar_club(string cod_club)
        {
            string sqltxt = @"SELECT * FROM clubes 
                             WHERE cod_club = '" + cod_club
                             +"'";

            return _BD.consulta(sqltxt);
        }
        
        public void grabar_club()
        {
            int _cod_club = Int32.Parse(this.cod_club);
            int _numero_club = Int32.Parse(this._numero_club);
            string SqlInsert = @" INSERT INTO Clubes 
                         (cod_club, nombre , calle, numero) VALUES (" +
                         _cod_club + ", '" +
                         this._nombre_club + "', '" +
                         this._calle_club + "', " +
                         _numero_club + ")";
            MessageBox.Show(SqlInsert);
             
            this._BD.grabar_modificar(SqlInsert);
        }
        
        public void modificar_club(string _cod_club)
        {
            int cod_club_aux = Int32.Parse(_cod_club);
            int _numero_club = Int32.Parse(this._numero_club);
            string sqlupdate = @"UPDATE Clubes 
                         SET cod_club =" + cod_club_aux + "," +
                         "nombre ='" +this._nombre_club+ "'," +
                         "calle ='"+ this.calle_club + "'," +
                         "numero ="+_numero_club  +
                         " WHERE cod_club =" + cod_club_aux;

            this._BD.grabar_modificar(sqlupdate);
        }

        public void eliminar_club()
        {
            int cod_club_aux = Int32.Parse(cod_club);
            string sqlDelete = @"DELETE FROM Clubes WHERE cod_club ="+ cod_club_aux;

            this._BD.grabar_modificar(sqlDelete);

        }
    }
}