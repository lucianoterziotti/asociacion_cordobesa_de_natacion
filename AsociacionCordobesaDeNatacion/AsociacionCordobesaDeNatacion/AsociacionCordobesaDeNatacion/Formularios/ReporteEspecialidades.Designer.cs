namespace AsociacionCordobesaDeNatacion.Formularios
{
	partial class ReporteEspecialidades
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cmb_anio = new System.Windows.Forms.ComboBox();
			this.anio = new System.Windows.Forms.Label();
			this.btn_CargarGrillaEspe = new System.Windows.Forms.Button();
			this.chart_espe = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.dataGrid_Especialidad = new System.Windows.Forms.DataGridView();
			this.especialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dS_Especialidades = new AsociacionCordobesaDeNatacion.DS_Especialidades();
			this.especialidadTableAdapter = new AsociacionCordobesaDeNatacion.DS_EspecialidadesTableAdapters.EspecialidadTableAdapter();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chart_espe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Especialidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dS_Especialidades)).BeginInit();
			this.SuspendLayout();
			// 
			// cmb_anio
			// 
			this.cmb_anio.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmb_anio.FormattingEnabled = true;
			this.cmb_anio.Location = new System.Drawing.Point(110, 126);
			this.cmb_anio.Margin = new System.Windows.Forms.Padding(4);
			this.cmb_anio.Name = "cmb_anio";
			this.cmb_anio.Size = new System.Drawing.Size(160, 33);
			this.cmb_anio.TabIndex = 60;
			// 
			// anio
			// 
			this.anio.AutoSize = true;
			this.anio.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.anio.Location = new System.Drawing.Point(106, 101);
			this.anio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.anio.Name = "anio";
			this.anio.Size = new System.Drawing.Size(43, 23);
			this.anio.TabIndex = 59;
			this.anio.Text = "Año";
			// 
			// btn_CargarGrillaEspe
			// 
			this.btn_CargarGrillaEspe.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_CargarGrillaEspe.Location = new System.Drawing.Point(298, 120);
			this.btn_CargarGrillaEspe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_CargarGrillaEspe.Name = "btn_CargarGrillaEspe";
			this.btn_CargarGrillaEspe.Size = new System.Drawing.Size(184, 41);
			this.btn_CargarGrillaEspe.TabIndex = 61;
			this.btn_CargarGrillaEspe.Text = "Buscar";
			this.btn_CargarGrillaEspe.UseVisualStyleBackColor = true;
			this.btn_CargarGrillaEspe.Click += new System.EventHandler(this.btn_CargarGrillaEspe_Click);
			// 
			// chart_espe
			// 
			chartArea5.Name = "ChartArea1";
			this.chart_espe.ChartAreas.Add(chartArea5);
			legend5.Name = "Legend1";
			this.chart_espe.Legends.Add(legend5);
			this.chart_espe.Location = new System.Drawing.Point(110, 167);
			this.chart_espe.Margin = new System.Windows.Forms.Padding(4);
			this.chart_espe.Name = "chart_espe";
			series5.ChartArea = "ChartArea1";
			series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series5.Legend = "Legend1";
			series5.Name = "Series1";
			this.chart_espe.Series.Add(series5);
			this.chart_espe.Size = new System.Drawing.Size(504, 388);
			this.chart_espe.TabIndex = 58;
			this.chart_espe.Text = "chart1";
			// 
			// dataGrid_Especialidad
			// 
			this.dataGrid_Especialidad.AllowUserToAddRows = false;
			this.dataGrid_Especialidad.AllowUserToDeleteRows = false;
			this.dataGrid_Especialidad.AllowUserToResizeColumns = false;
			this.dataGrid_Especialidad.AllowUserToResizeRows = false;
			this.dataGrid_Especialidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.dataGrid_Especialidad.BackgroundColor = System.Drawing.Color.White;
			this.dataGrid_Especialidad.CausesValidation = false;
			this.dataGrid_Especialidad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGrid_Especialidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
			this.dataGrid_Especialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid_Especialidad.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGrid_Especialidad.Location = new System.Drawing.Point(648, 167);
			this.dataGrid_Especialidad.Margin = new System.Windows.Forms.Padding(4);
			this.dataGrid_Especialidad.MultiSelect = false;
			this.dataGrid_Especialidad.Name = "dataGrid_Especialidad";
			this.dataGrid_Especialidad.ReadOnly = true;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGrid_Especialidad.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.dataGrid_Especialidad.RowHeadersVisible = false;
			this.dataGrid_Especialidad.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
			this.dataGrid_Especialidad.RowsDefaultCellStyle = dataGridViewCellStyle15;
			this.dataGrid_Especialidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGrid_Especialidad.Size = new System.Drawing.Size(696, 388);
			this.dataGrid_Especialidad.TabIndex = 62;
			// 
			// especialidadBindingSource
			// 
			this.especialidadBindingSource.DataMember = "Especialidad";
			this.especialidadBindingSource.DataSource = this.dS_Especialidades;
			// 
			// dS_Especialidades
			// 
			this.dS_Especialidades.DataSetName = "DS_Especialidades";
			this.dS_Especialidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// especialidadTableAdapter
			// 
			this.especialidadTableAdapter.ClearBeforeFill = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(38, 39);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(449, 40);
			this.label6.TabIndex = 68;
			this.label6.Text = "Reporte de ESPECIALIDADES";
			// 
			// ReporteEspecialidades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1416, 673);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dataGrid_Especialidad);
			this.Controls.Add(this.cmb_anio);
			this.Controls.Add(this.anio);
			this.Controls.Add(this.btn_CargarGrillaEspe);
			this.Controls.Add(this.chart_espe);
			this.Name = "ReporteEspecialidades";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reporte de Especialidades";
			this.Load += new System.EventHandler(this.ReporteEspecialidades_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart_espe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Especialidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dS_Especialidades)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmb_anio;
		private System.Windows.Forms.Label anio;
		private System.Windows.Forms.Button btn_CargarGrillaEspe;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart_espe;
		private System.Windows.Forms.DataGridView dataGrid_Especialidad;
		private DS_Especialidades dS_Especialidades;
		private System.Windows.Forms.BindingSource especialidadBindingSource;
		private DS_EspecialidadesTableAdapters.EspecialidadTableAdapter especialidadTableAdapter;
		private System.Windows.Forms.Label label6;
	}
}