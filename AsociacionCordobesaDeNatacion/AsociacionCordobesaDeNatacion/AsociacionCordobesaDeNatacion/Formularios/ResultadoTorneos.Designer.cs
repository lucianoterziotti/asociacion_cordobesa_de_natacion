namespace AsociacionCordobesaDeNatacion.Formularios
{
    partial class ResultadoTorneos
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGrid_Resultados = new System.Windows.Forms.DataGridView();
			this.anio = new System.Windows.Forms.Label();
			this.especialidad = new System.Windows.Forms.Label();
			this.torneo = new System.Windows.Forms.Label();
			this.cmb_anio = new System.Windows.Forms.ComboBox();
			this.cmb_especialidad = new System.Windows.Forms.ComboBox();
			this.cmb_torneo = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btn_CargarGrilla = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Resultados)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGrid_Resultados
			// 
			this.dataGrid_Resultados.AllowUserToAddRows = false;
			this.dataGrid_Resultados.AllowUserToDeleteRows = false;
			this.dataGrid_Resultados.AllowUserToResizeColumns = false;
			this.dataGrid_Resultados.AllowUserToResizeRows = false;
			this.dataGrid_Resultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.dataGrid_Resultados.BackgroundColor = System.Drawing.Color.White;
			this.dataGrid_Resultados.CausesValidation = false;
			this.dataGrid_Resultados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGrid_Resultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGrid_Resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid_Resultados.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGrid_Resultados.Location = new System.Drawing.Point(468, 76);
			this.dataGrid_Resultados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGrid_Resultados.MultiSelect = false;
			this.dataGrid_Resultados.Name = "dataGrid_Resultados";
			this.dataGrid_Resultados.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGrid_Resultados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGrid_Resultados.RowHeadersVisible = false;
			this.dataGrid_Resultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			this.dataGrid_Resultados.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGrid_Resultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGrid_Resultados.Size = new System.Drawing.Size(619, 283);
			this.dataGrid_Resultados.TabIndex = 0;
			this.dataGrid_Resultados.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGrid_Resultados_RowPostPaint);
			// 
			// anio
			// 
			this.anio.AutoSize = true;
			this.anio.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.anio.Location = new System.Drawing.Point(165, 121);
			this.anio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.anio.Name = "anio";
			this.anio.Size = new System.Drawing.Size(43, 23);
			this.anio.TabIndex = 18;
			this.anio.Text = "Año";
			// 
			// especialidad
			// 
			this.especialidad.AutoSize = true;
			this.especialidad.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.especialidad.Location = new System.Drawing.Point(124, 156);
			this.especialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.especialidad.Name = "especialidad";
			this.especialidad.Size = new System.Drawing.Size(112, 23);
			this.especialidad.TabIndex = 19;
			this.especialidad.Text = "Especialidad";
			// 
			// torneo
			// 
			this.torneo.AutoSize = true;
			this.torneo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.torneo.Location = new System.Drawing.Point(124, 222);
			this.torneo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.torneo.Name = "torneo";
			this.torneo.Size = new System.Drawing.Size(68, 23);
			this.torneo.TabIndex = 20;
			this.torneo.Text = "Torneo";
			// 
			// cmb_anio
			// 
			this.cmb_anio.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmb_anio.FormattingEnabled = true;
			this.cmb_anio.Location = new System.Drawing.Point(169, 145);
			this.cmb_anio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmb_anio.Name = "cmb_anio";
			this.cmb_anio.Size = new System.Drawing.Size(160, 33);
			this.cmb_anio.TabIndex = 21;
			this.cmb_anio.SelectedIndexChanged += new System.EventHandler(this.cmb_anio_SelectedIndexChanged);
			// 
			// cmb_especialidad
			// 
			this.cmb_especialidad.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmb_especialidad.FormattingEnabled = true;
			this.cmb_especialidad.Location = new System.Drawing.Point(128, 180);
			this.cmb_especialidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmb_especialidad.Name = "cmb_especialidad";
			this.cmb_especialidad.Size = new System.Drawing.Size(160, 33);
			this.cmb_especialidad.TabIndex = 22;
			// 
			// cmb_torneo
			// 
			this.cmb_torneo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmb_torneo.FormattingEnabled = true;
			this.cmb_torneo.Location = new System.Drawing.Point(128, 245);
			this.cmb_torneo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmb_torneo.Name = "cmb_torneo";
			this.cmb_torneo.Size = new System.Drawing.Size(160, 33);
			this.cmb_torneo.TabIndex = 23;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(604, 41);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(311, 31);
			this.label6.TabIndex = 55;
			this.label6.Text = "GRILLA DE RESULTADOS";
			// 
			// btn_CargarGrilla
			// 
			this.btn_CargarGrilla.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_CargarGrilla.Location = new System.Drawing.Point(128, 294);
			this.btn_CargarGrilla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_CargarGrilla.Name = "btn_CargarGrilla";
			this.btn_CargarGrilla.Size = new System.Drawing.Size(184, 41);
			this.btn_CargarGrilla.TabIndex = 54;
			this.btn_CargarGrilla.Text = "Buscar";
			this.btn_CargarGrilla.UseVisualStyleBackColor = true;
			this.btn_CargarGrilla.Click += new System.EventHandler(this.btn_CargarGrilla_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmb_torneo);
			this.groupBox1.Controls.Add(this.torneo);
			this.groupBox1.Controls.Add(this.btn_CargarGrilla);
			this.groupBox1.Controls.Add(this.especialidad);
			this.groupBox1.Controls.Add(this.cmb_especialidad);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.dataGrid_Resultados);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(41, 37);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(1137, 619);
			this.groupBox1.TabIndex = 56;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "RESULTADOS";
			// 
			// ResultadoTorneos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1233, 692);
			this.Controls.Add(this.cmb_anio);
			this.Controls.Add(this.anio);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ResultadoTorneos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Resultado de Torneos";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Resultados)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Resultados;
        private System.Windows.Forms.Label anio;
        private System.Windows.Forms.Label especialidad;
        private System.Windows.Forms.Label torneo;
        private System.Windows.Forms.ComboBox cmb_anio;
        private System.Windows.Forms.ComboBox cmb_especialidad;
        private System.Windows.Forms.ComboBox cmb_torneo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_CargarGrilla;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}