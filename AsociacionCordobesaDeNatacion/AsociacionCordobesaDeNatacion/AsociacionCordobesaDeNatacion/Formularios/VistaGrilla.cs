using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsociacionCordobesaDeNatacion.Clases;

namespace AsociacionCordobesaDeNatacion.Formularios
{
    internal partial class VistaGrilla : Form
    {

        AccesoBD _BD ;
        DataTable tabla = new DataTable();


        public VistaGrilla(string parametro, AccesoBD BD)
        {
            InitializeComponent();
            _BD = BD;
            cargar_grilla(parametro);
        }

    private void cargar_grilla(string parametro)
    {
        DataTable tabla = new DataTable();
        tabla = _BD.consulta("SELECT * FROM " + parametro + "");

        if (tabla.Rows.Count == 0)

        {
            MessageBox.Show("No se encontraron registros.");
            return;
        }

        dataGrid_generico.DataSource = tabla;
    }
    }
}
