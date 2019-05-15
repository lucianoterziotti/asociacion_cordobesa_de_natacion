﻿using System;
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
    public partial class ABM_Torneos : Form
    {
        public ABM_Torneos()
        {
            InitializeComponent();
        }


        private void cmd_buscar_1_Click(object sender, EventArgs e)
        {
            if (this.txt_cod_torneo.Text == "")
            {

                MessageBox.Show("El nombre no está cargado");

                this.txt_cod_torneo.Focus();

                return;
            }

            Torneos buscar_torneo = new Torneos();

            DataTable tabla = new DataTable();

            tabla = buscar_torneo.buscar_torneo(this.txt_cod_torneo.Text.Trim());

            if (tabla.Rows.Count == 1)
            {

                buscar_torneo.id = int.Parse(tabla.Rows[0][0].ToString());

                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontro torneo con codigo especificado");
            }
        }
    }
}