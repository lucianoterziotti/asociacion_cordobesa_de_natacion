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

        if ( parametro == "Clubes" )

        {
            dataGrid_generico.DataSource = tabla;
            dataGrid_generico.Columns[0].HeaderText = "Código";
            dataGrid_generico.Columns[1].HeaderText = "Nombre";
            dataGrid_generico.Columns[2].HeaderText = "Domicilio";
        }

         if ( parametro == "Especialidad" )

        {
            dataGrid_generico.DataSource = tabla;
            dataGrid_generico.Columns[0].HeaderText = "Código";
            dataGrid_generico.Columns[1].HeaderText = "Nombre";
        }

         if ( parametro == "Nadadores" )

        {
            dataGrid_generico.DataSource = tabla;
            dataGrid_generico.Columns[0].HeaderText = "Código";
            dataGrid_generico.Columns[1].HeaderText = "Nombre";
            dataGrid_generico.Columns[2].HeaderText = "Domicilio";
        }

         if ( parametro == "Profesores" )

        {
            dataGrid_generico.DataSource = tabla;
            dataGrid_generico.Columns[0].HeaderText = "Código";
            dataGrid_generico.Columns[1].HeaderText = "Nombre";
            dataGrid_generico.Columns[2].HeaderText = "Domicilio";
        }

         if ( parametro == "Torneos" )

        {
            dataGrid_generico.DataSource = tabla;
            dataGrid_generico.Columns[0].HeaderText = "Código";
            dataGrid_generico.Columns[1].HeaderText = "Nombre";
        }

         if ( parametro == "Inscriptos" )

        {
            dataGrid_generico.DataSource = tabla;
            dataGrid_generico.Columns[0].HeaderText = "Torneo";
            dataGrid_generico.Columns[1].HeaderText = "Año";
            dataGrid_generico.Columns[2].HeaderText = "Especialidad";
            dataGrid_generico.Columns[3].HeaderText = "Nadador";
            dataGrid_generico.Columns[4].HeaderText = "Tiempo";
        }


        dataGrid_generico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGrid_generico.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

        //dataGrid_generico.DataSource = tabla;
    }
    }
}
