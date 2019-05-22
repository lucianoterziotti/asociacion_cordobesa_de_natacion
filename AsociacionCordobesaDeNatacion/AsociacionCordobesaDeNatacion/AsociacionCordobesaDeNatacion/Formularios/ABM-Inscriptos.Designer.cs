namespace AsociacionCordobesaDeNatacion.Formularios
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Inscriptos));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
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
			this.btn_eliminar = new System.Windows.Forms.Button();
			this.cmd_nuevo = new System.Windows.Forms.Button();
			this.cmd_grabar = new System.Windows.Forms.Button();
			this.cmd_actualizar = new System.Windows.Forms.Button();
			this.btn_IniciarTrans = new System.Windows.Forms.Button();
			this.btn_FinalizarTrans = new System.Windows.Forms.Button();
			this.inscriptosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dS_Inscriptos = new AsociacionCordobesaDeNatacion.DS_Inscriptos();
			this.inscriptosTableAdapter = new AsociacionCordobesaDeNatacion.DS_InscriptosTableAdapters.InscriptosTableAdapter();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_CargarGrilla = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.dSInscriptosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGrid_Inscriptos = new System.Windows.Forms.DataGridView();
			this.inscriptosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.codtorneoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.anioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codespeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codnadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.posicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tiempoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.inscriptosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dS_Inscriptos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dSInscriptosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Inscriptos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inscriptosBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_tiempo);
			this.groupBox1.Controls.Add(this.txt_posicion);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.groupBox5);
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(44, 50);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(664, 602);
			this.groupBox1.TabIndex = 32;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "INSCRIPTOS";
			// 
			// txt_tiempo
			// 
			this.txt_tiempo.BackColor = System.Drawing.Color.White;
			this.txt_tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_tiempo.Location = new System.Drawing.Point(60, 553);
			this.txt_tiempo.Margin = new System.Windows.Forms.Padding(4);
			this.txt_tiempo.Name = "txt_tiempo";
			this.txt_tiempo.Size = new System.Drawing.Size(113, 30);
			this.txt_tiempo.TabIndex = 36;
			// 
			// txt_posicion
			// 
			this.txt_posicion.BackColor = System.Drawing.Color.White;
			this.txt_posicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_posicion.Location = new System.Drawing.Point(60, 490);
			this.txt_posicion.Margin = new System.Windows.Forms.Padding(4);
			this.txt_posicion.Name = "txt_posicion";
			this.txt_posicion.Size = new System.Drawing.Size(39, 30);
			this.txt_posicion.TabIndex = 36;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(55, 526);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 23);
			this.label4.TabIndex = 32;
			this.label4.Text = "Tiempo";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(55, 463);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 23);
			this.label3.TabIndex = 32;
			this.label3.Text = "Posición";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.txt_cod_especialidad);
			this.groupBox5.Controls.Add(this.label11);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(25, 239);
			this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox5.Size = new System.Drawing.Size(285, 107);
			this.groupBox5.TabIndex = 30;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Especialidad";
			// 
			// txt_cod_especialidad
			// 
			this.txt_cod_especialidad.BackColor = System.Drawing.Color.White;
			this.txt_cod_especialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_cod_especialidad.Location = new System.Drawing.Point(35, 55);
			this.txt_cod_especialidad.Margin = new System.Windows.Forms.Padding(4);
			this.txt_cod_especialidad.Name = "txt_cod_especialidad";
			this.txt_cod_especialidad.Size = new System.Drawing.Size(73, 30);
			this.txt_cod_especialidad.TabIndex = 12;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(29, 28);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(70, 23);
			this.label11.TabIndex = 17;
			this.label11.Text = "Código";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txt_cod_nadador);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(25, 354);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox4.Size = new System.Drawing.Size(285, 106);
			this.groupBox4.TabIndex = 30;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Nadador";
			// 
			// txt_cod_nadador
			// 
			this.txt_cod_nadador.BackColor = System.Drawing.Color.White;
			this.txt_cod_nadador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_cod_nadador.Location = new System.Drawing.Point(35, 55);
			this.txt_cod_nadador.Margin = new System.Windows.Forms.Padding(4);
			this.txt_cod_nadador.Name = "txt_cod_nadador";
			this.txt_cod_nadador.Size = new System.Drawing.Size(73, 30);
			this.txt_cod_nadador.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(29, 28);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 23);
			this.label8.TabIndex = 17;
			this.label8.Text = "Código";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txt_anio);
			this.groupBox2.Controls.Add(this.txt_cod_torneo);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(25, 61);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(285, 171);
			this.groupBox2.TabIndex = 30;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Torneo";
			// 
			// txt_anio
			// 
			this.txt_anio.BackColor = System.Drawing.Color.White;
			this.txt_anio.Location = new System.Drawing.Point(35, 118);
			this.txt_anio.Margin = new System.Windows.Forms.Padding(4);
			this.txt_anio.Name = "txt_anio";
			this.txt_anio.Size = new System.Drawing.Size(73, 32);
			this.txt_anio.TabIndex = 32;
			// 
			// txt_cod_torneo
			// 
			this.txt_cod_torneo.BackColor = System.Drawing.Color.White;
			this.txt_cod_torneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_cod_torneo.Location = new System.Drawing.Point(35, 55);
			this.txt_cod_torneo.Margin = new System.Windows.Forms.Padding(4);
			this.txt_cod_torneo.MaxLength = 10;
			this.txt_cod_torneo.Name = "txt_cod_torneo";
			this.txt_cod_torneo.Size = new System.Drawing.Size(73, 30);
			this.txt_cod_torneo.TabIndex = 31;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(29, 91);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 23);
			this.label1.TabIndex = 23;
			this.label1.Text = "Año";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(29, 28);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 23);
			this.label2.TabIndex = 17;
			this.label2.Text = "Código";
			// 
			// btn_eliminar
			// 
			this.btn_eliminar.BackColor = System.Drawing.Color.White;
			this.btn_eliminar.BackgroundImage = global::AsociacionCordobesaDeNatacion.Properties.Resources.basket;
			this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_eliminar.Location = new System.Drawing.Point(683, 253);
			this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
			this.btn_eliminar.Name = "btn_eliminar";
			this.btn_eliminar.Size = new System.Drawing.Size(51, 43);
			this.btn_eliminar.TabIndex = 45;
			this.btn_eliminar.UseVisualStyleBackColor = false;
			this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
			// 
			// cmd_nuevo
			// 
			this.cmd_nuevo.BackColor = System.Drawing.Color.White;
			this.cmd_nuevo.BackgroundImage = global::AsociacionCordobesaDeNatacion.Properties.Resources.archive__2_;
			this.cmd_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmd_nuevo.Location = new System.Drawing.Point(683, 94);
			this.cmd_nuevo.Margin = new System.Windows.Forms.Padding(4);
			this.cmd_nuevo.Name = "cmd_nuevo";
			this.cmd_nuevo.Size = new System.Drawing.Size(49, 43);
			this.cmd_nuevo.TabIndex = 42;
			this.cmd_nuevo.Tag = "Condiciones para crear un nuevo registro";
			this.cmd_nuevo.UseVisualStyleBackColor = false;
			// 
			// cmd_grabar
			// 
			this.cmd_grabar.BackColor = System.Drawing.Color.White;
			this.cmd_grabar.BackgroundImage = global::AsociacionCordobesaDeNatacion.Properties.Resources.archive;
			this.cmd_grabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmd_grabar.Location = new System.Drawing.Point(685, 145);
			this.cmd_grabar.Margin = new System.Windows.Forms.Padding(4);
			this.cmd_grabar.Name = "cmd_grabar";
			this.cmd_grabar.Size = new System.Drawing.Size(49, 43);
			this.cmd_grabar.TabIndex = 43;
			this.cmd_grabar.UseVisualStyleBackColor = false;
			this.cmd_grabar.Click += new System.EventHandler(this.cmd_grabar_Click);
			// 
			// cmd_actualizar
			// 
			this.cmd_actualizar.BackColor = System.Drawing.Color.White;
			this.cmd_actualizar.BackgroundImage = global::AsociacionCordobesaDeNatacion.Properties.Resources.archive__3_;
			this.cmd_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmd_actualizar.Location = new System.Drawing.Point(683, 202);
			this.cmd_actualizar.Margin = new System.Windows.Forms.Padding(4);
			this.cmd_actualizar.Name = "cmd_actualizar";
			this.cmd_actualizar.Size = new System.Drawing.Size(49, 43);
			this.cmd_actualizar.TabIndex = 44;
			this.cmd_actualizar.UseVisualStyleBackColor = false;
			this.cmd_actualizar.Click += new System.EventHandler(this.cmd_actualizar_Click);
			// 
			// btn_IniciarTrans
			// 
			this.btn_IniciarTrans.Location = new System.Drawing.Point(875, 139);
			this.btn_IniciarTrans.Name = "btn_IniciarTrans";
			this.btn_IniciarTrans.Size = new System.Drawing.Size(75, 39);
			this.btn_IniciarTrans.TabIndex = 46;
			this.btn_IniciarTrans.Text = "Iniciar";
			this.btn_IniciarTrans.UseVisualStyleBackColor = true;
			this.btn_IniciarTrans.Click += new System.EventHandler(this.btn_IniciarTrans_Click);
			// 
			// btn_FinalizarTrans
			// 
			this.btn_FinalizarTrans.Location = new System.Drawing.Point(968, 145);
			this.btn_FinalizarTrans.Name = "btn_FinalizarTrans";
			this.btn_FinalizarTrans.Size = new System.Drawing.Size(75, 33);
			this.btn_FinalizarTrans.TabIndex = 47;
			this.btn_FinalizarTrans.Text = "Finalizar";
			this.btn_FinalizarTrans.UseVisualStyleBackColor = true;
			this.btn_FinalizarTrans.Click += new System.EventHandler(this.btn_FinalizarTrans_Click);
			// 
			// inscriptosBindingSource
			// 
			this.inscriptosBindingSource.DataMember = "Inscriptos";
			this.inscriptosBindingSource.DataSource = this.dS_Inscriptos;
			// 
			// dS_Inscriptos
			// 
			this.dS_Inscriptos.DataSetName = "DS_Inscriptos";
			this.dS_Inscriptos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// inscriptosTableAdapter
			// 
			this.inscriptosTableAdapter.ClearBeforeFill = true;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "tiempo";
			this.dataGridViewTextBoxColumn1.HeaderText = "tiempo";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// btn_CargarGrilla
			// 
			this.btn_CargarGrilla.Location = new System.Drawing.Point(853, 459);
			this.btn_CargarGrilla.Name = "btn_CargarGrilla";
			this.btn_CargarGrilla.Size = new System.Drawing.Size(148, 30);
			this.btn_CargarGrilla.TabIndex = 49;
			this.btn_CargarGrilla.Text = "Cargar grilla";
			this.btn_CargarGrilla.UseVisualStyleBackColor = true;
			this.btn_CargarGrilla.Click += new System.EventHandler(this.btn_CargarGrilla_Click);
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(898, 265);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(349, 31);
			this.label5.TabIndex = 50;
			this.label5.Text = "estado";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dSInscriptosBindingSource
			// 
			this.dSInscriptosBindingSource.DataSource = this.dS_Inscriptos;
			this.dSInscriptosBindingSource.Position = 0;
			// 
			// dataGrid_Inscriptos
			// 
			this.dataGrid_Inscriptos.AutoGenerateColumns = false;
			this.dataGrid_Inscriptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid_Inscriptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codtorneoDataGridViewTextBoxColumn,
            this.anioDataGridViewTextBoxColumn,
            this.codespeDataGridViewTextBoxColumn,
            this.codnadDataGridViewTextBoxColumn,
            this.posicionDataGridViewTextBoxColumn,
            this.tiempoDataGridViewTextBoxColumn});
			this.dataGrid_Inscriptos.DataSource = this.inscriptosBindingSource1;
			this.dataGrid_Inscriptos.Location = new System.Drawing.Point(901, 299);
			this.dataGrid_Inscriptos.Name = "dataGrid_Inscriptos";
			this.dataGrid_Inscriptos.RowTemplate.Height = 24;
			this.dataGrid_Inscriptos.Size = new System.Drawing.Size(240, 150);
			this.dataGrid_Inscriptos.TabIndex = 51;
			// 
			// inscriptosBindingSource1
			// 
			this.inscriptosBindingSource1.DataMember = "Inscriptos";
			this.inscriptosBindingSource1.DataSource = this.dSInscriptosBindingSource;
			// 
			// codtorneoDataGridViewTextBoxColumn
			// 
			this.codtorneoDataGridViewTextBoxColumn.DataPropertyName = "cod_torneo";
			this.codtorneoDataGridViewTextBoxColumn.HeaderText = "cod_torneo";
			this.codtorneoDataGridViewTextBoxColumn.Name = "codtorneoDataGridViewTextBoxColumn";
			// 
			// anioDataGridViewTextBoxColumn
			// 
			this.anioDataGridViewTextBoxColumn.DataPropertyName = "anio";
			this.anioDataGridViewTextBoxColumn.HeaderText = "anio";
			this.anioDataGridViewTextBoxColumn.Name = "anioDataGridViewTextBoxColumn";
			// 
			// codespeDataGridViewTextBoxColumn
			// 
			this.codespeDataGridViewTextBoxColumn.DataPropertyName = "cod_espe";
			this.codespeDataGridViewTextBoxColumn.HeaderText = "cod_espe";
			this.codespeDataGridViewTextBoxColumn.Name = "codespeDataGridViewTextBoxColumn";
			// 
			// codnadDataGridViewTextBoxColumn
			// 
			this.codnadDataGridViewTextBoxColumn.DataPropertyName = "cod_nad";
			this.codnadDataGridViewTextBoxColumn.HeaderText = "cod_nad";
			this.codnadDataGridViewTextBoxColumn.Name = "codnadDataGridViewTextBoxColumn";
			// 
			// posicionDataGridViewTextBoxColumn
			// 
			this.posicionDataGridViewTextBoxColumn.DataPropertyName = "posicion";
			this.posicionDataGridViewTextBoxColumn.HeaderText = "posicion";
			this.posicionDataGridViewTextBoxColumn.Name = "posicionDataGridViewTextBoxColumn";
			// 
			// tiempoDataGridViewTextBoxColumn
			// 
			this.tiempoDataGridViewTextBoxColumn.DataPropertyName = "tiempo";
			this.tiempoDataGridViewTextBoxColumn.HeaderText = "tiempo";
			this.tiempoDataGridViewTextBoxColumn.Name = "tiempoDataGridViewTextBoxColumn";
			// 
			// ABM_Inscriptos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1336, 706);
			this.Controls.Add(this.dataGrid_Inscriptos);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btn_CargarGrilla);
			this.Controls.Add(this.btn_FinalizarTrans);
			this.Controls.Add(this.btn_IniciarTrans);
			this.Controls.Add(this.cmd_grabar);
			this.Controls.Add(this.btn_eliminar);
			this.Controls.Add(this.cmd_nuevo);
			this.Controls.Add(this.cmd_actualizar);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ABM_Inscriptos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Inscriptos";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.inscriptosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dS_Inscriptos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dSInscriptosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Inscriptos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inscriptosBindingSource1)).EndInit();
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
		private System.Windows.Forms.Button btn_IniciarTrans;
		private System.Windows.Forms.Button btn_FinalizarTrans;
		private DS_Inscriptos dS_Inscriptos;
		private System.Windows.Forms.BindingSource inscriptosBindingSource;
		private DS_InscriptosTableAdapters.InscriptosTableAdapter inscriptosTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.Button btn_CargarGrilla;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.BindingSource dSInscriptosBindingSource;
		private System.Windows.Forms.DataGridView dataGrid_Inscriptos;
		private System.Windows.Forms.DataGridViewTextBoxColumn codtorneoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn anioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn codespeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn codnadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn posicionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tiempoDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource inscriptosBindingSource1;
	}
}