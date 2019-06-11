using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsociacionCordobesaDeNatacion.Formularios
{
    public partial class Menus : Form
    {
        ABM_Clubes frm_club;
        ABM_Nadadores frm_nadadores;
        ABM_Profesores   frm_profesores;
        ABM_Torneos frm_torneos;
        ABM_Inscriptos frm_inscriptos;
        ABM_Especialidad frm_especialidad;
        ResultadoTorneos frm_resultados;

        public Menus()
        {
            InitializeComponent();
        }
       
        private void btn_profesores_Click(object sender, EventArgs e)
        {
            frm_profesores = new ABM_Profesores();

            frm_profesores.ShowDialog();

            frm_profesores.Dispose();
        }

        private void btn_nadadores_Click(object sender, EventArgs e)
        {
            frm_nadadores = new ABM_Nadadores();

            frm_nadadores.ShowDialog();

            frm_nadadores.Dispose();
        }

        private void btn_clubes_Click(object sender, EventArgs e)
        {
            frm_club = new ABM_Clubes();

            frm_club.ShowDialog();

            frm_club.Dispose();
        }

        private void btn_torneos_Click(object sender, EventArgs e)
        {
            frm_torneos = new ABM_Torneos();
            frm_torneos.ShowDialog();
            frm_torneos.Dispose();
        }

        private void btn_inscriptos_Click(object sender, EventArgs e)
        {
            frm_inscriptos = new ABM_Inscriptos();
            frm_inscriptos.ShowDialog();
            frm_inscriptos.Dispose();

        }

        private void btn_especialidad_Click(object sender, EventArgs e)
        {
            frm_especialidad = new ABM_Especialidad();
            frm_especialidad.ShowDialog();
            frm_especialidad.Dispose();
        }

        private void btn_resultados_Click(object sender, EventArgs e)
        {
            frm_resultados = new ResultadoTorneos();
            frm_resultados.ShowDialog();
            frm_resultados.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
