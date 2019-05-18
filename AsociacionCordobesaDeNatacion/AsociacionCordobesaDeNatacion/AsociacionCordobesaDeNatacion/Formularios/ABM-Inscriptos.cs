using AsociacionCordobesaDeNatacion.Clases;
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
    public partial class ABM_Inscriptos : Form
    {

        
        Inscriptos inscriptos = new Inscriptos();
        Nadadores nadadores = new Nadadores();
        Torneos torneos = new Torneos();
        Especialidades especialidades = new Especialidades();
        DataTable tabla = new DataTable();

        public ABM_Inscriptos()
        {
            InitializeComponent();
        }

        private void btn_buscarXtorneo_Click(object sender, EventArgs e)
        {
            if (this.txt_cod_torneo.Text == "")
            {

                MessageBox.Show("El codigo de torneo no está cargado");

                this.txt_cod_torneo.Focus();
                
                return;
            }
            DataTable tabla = new DataTable();


        }

        private void cmd_grabar_Click(object sender, EventArgs e)
        {
            inscriptos.anio = txt_anio.Text;
            especialidades.cod_esp = txt_cod_especialidad.Text;
            nadadores.dni_nadador = txt_cod_nadador.Text;
            torneos.cod_torneo = txt_cod_torneo.Text;
            inscriptos.posicion = txt_posicion.Text;
            inscriptos.tiempo = txt_tiempo.Text;
            if (validarTorneo())
            {
                if (validarEspecialidad())
                {
                    if (validarNadador())
                    {
                        inscriptos.cod_especialidad = txt_cod_especialidad.Text;
                        inscriptos.cod_nadador = txt_cod_nadador.Text;
                        inscriptos.cod_torneo = txt_cod_torneo.Text;
                        inscriptos.grabar_inscripto();
                    }
                    else
                    {
                        MessageBox.Show("No se ha ingresado codigo de nadador o es invalido");
                    }
                }
                else
                {
                    MessageBox.Show("No se ha ingresado codigo de especialidad o es invalido");
                }
            }
            else
            {
                MessageBox.Show("No se ha ingresado codigo de torneo o es invalido");
            }



            bool validarTorneo()
            {
                tabla = torneos.buscar_torneo(this.txt_cod_torneo.Text);
                if (tabla.Rows.Count == 1)
                {
                    return true;
                }
                return false;
            }

            bool validarEspecialidad()
            {
                tabla = especialidades.buscar_especialidad();
                if (tabla.Rows.Count == 1)
                {
                    return true;
                }
                return false;
            }

            bool validarNadador()
            {
                tabla = nadadores.buscar_nadador();
                if (tabla.Rows.Count == 1)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
