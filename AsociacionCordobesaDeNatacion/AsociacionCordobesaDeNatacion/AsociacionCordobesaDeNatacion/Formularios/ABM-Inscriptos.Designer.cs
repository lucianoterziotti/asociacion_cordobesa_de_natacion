﻿namespace AsociacionCordobesaDeNatacion.Formularios
{
    partial class ABM_Inscriptos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.cmd_nuevo = new System.Windows.Forms.Button();
            this.cmd_grabar = new System.Windows.Forms.Button();
            this.cmd_actualizar = new System.Windows.Forms.Button();
            this.txt_tiempo = new System.Windows.Forms.TextBox();
            this.txt_posicion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_cod_especialidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_cod_nadador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.txt_cod_torneo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.cmd_nuevo);
            this.groupBox1.Controls.Add(this.cmd_grabar);
            this.groupBox1.Controls.Add(this.cmd_actualizar);
            this.groupBox1.Controls.Add(this.txt_tiempo);
            this.groupBox1.Controls.Add(this.txt_posicion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 436);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INSCRIPTOS";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = global::AsociacionCordobesaDeNatacion.Properties.Resources.ACN2;
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Location = new System.Drawing.Point(489, 20);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(38, 35);
            this.btn_eliminar.TabIndex = 45;
            this.btn_eliminar.Text = "button1";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // cmd_nuevo
            // 
            this.cmd_nuevo.BackgroundImage = global::AsociacionCordobesaDeNatacion.Properties.Resources.nuevo1;
            this.cmd_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_nuevo.Location = new System.Drawing.Point(533, 20);
            this.cmd_nuevo.Name = "cmd_nuevo";
            this.cmd_nuevo.Size = new System.Drawing.Size(37, 35);
            this.cmd_nuevo.TabIndex = 42;
            this.cmd_nuevo.Tag = "Condiciones para crear un nuevo registro";
            this.cmd_nuevo.UseVisualStyleBackColor = true;
            // 
            // cmd_grabar
            // 
            this.cmd_grabar.BackgroundImage = global::AsociacionCordobesaDeNatacion.Properties.Resources.grabar1;
            this.cmd_grabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_grabar.Location = new System.Drawing.Point(575, 20);
            this.cmd_grabar.Name = "cmd_grabar";
            this.cmd_grabar.Size = new System.Drawing.Size(37, 35);
            this.cmd_grabar.TabIndex = 43;
            this.cmd_grabar.UseVisualStyleBackColor = true;
            this.cmd_grabar.Click += new System.EventHandler(this.cmd_grabar_Click);
            // 
            // cmd_actualizar
            // 
            this.cmd_actualizar.BackgroundImage = global::AsociacionCordobesaDeNatacion.Properties.Resources.icons8_actualizar_48;
            this.cmd_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_actualizar.Location = new System.Drawing.Point(618, 20);
            this.cmd_actualizar.Name = "cmd_actualizar";
            this.cmd_actualizar.Size = new System.Drawing.Size(37, 35);
            this.cmd_actualizar.TabIndex = 44;
            this.cmd_actualizar.UseVisualStyleBackColor = true;
            // 
            // txt_tiempo
            // 
            this.txt_tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tiempo.Location = new System.Drawing.Point(176, 387);
            this.txt_tiempo.Name = "txt_tiempo";
            this.txt_tiempo.Size = new System.Drawing.Size(132, 26);
            this.txt_tiempo.TabIndex = 36;
            // 
            // txt_posicion
            // 
            this.txt_posicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_posicion.Location = new System.Drawing.Point(176, 355);
            this.txt_posicion.Name = "txt_posicion";
            this.txt_posicion.Size = new System.Drawing.Size(28, 26);
            this.txt_posicion.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Tiempo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Posición";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_cod_especialidad);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(94, 187);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(251, 78);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Especialidad";
            // 
            // txt_cod_especialidad
            // 
            this.txt_cod_especialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_especialidad.Location = new System.Drawing.Point(82, 29);
            this.txt_cod_especialidad.Name = "txt_cod_especialidad";
            this.txt_cod_especialidad.Size = new System.Drawing.Size(51, 26);
            this.txt_cod_especialidad.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Código";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_cod_nadador);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(94, 271);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 78);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nadador";
            // 
            // txt_cod_nadador
            // 
            this.txt_cod_nadador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_nadador.Location = new System.Drawing.Point(82, 29);
            this.txt_cod_nadador.Name = "txt_cod_nadador";
            this.txt_cod_nadador.Size = new System.Drawing.Size(51, 26);
            this.txt_cod_nadador.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_anio);
            this.groupBox2.Controls.Add(this.txt_cod_torneo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(94, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 112);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Torneo";
            // 
            // txt_anio
            // 
            this.txt_anio.Location = new System.Drawing.Point(82, 66);
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(51, 22);
            this.txt_anio.TabIndex = 32;
            // 
            // txt_cod_torneo
            // 
            this.txt_cod_torneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_torneo.Location = new System.Drawing.Point(82, 33);
            this.txt_cod_torneo.Name = "txt_cod_torneo";
            this.txt_cod_torneo.Size = new System.Drawing.Size(51, 26);
            this.txt_cod_torneo.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Código";
            // 
            // ABM_Inscriptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 513);
            this.Controls.Add(this.groupBox1);
            this.Name = "ABM_Inscriptos";
            this.Text = "ABM_Inscriptos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_cod_especialidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_cod_nadador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_posicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tiempo;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button cmd_nuevo;
        private System.Windows.Forms.Button cmd_grabar;
        private System.Windows.Forms.Button cmd_actualizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_cod_torneo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_anio;
    }
}