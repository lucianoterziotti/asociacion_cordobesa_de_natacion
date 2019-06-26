namespace AsociacionCordobesaDeNatacion.Formularios
{
    partial class Reporte_Torneos
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.cmb_anio = new System.Windows.Forms.ComboBox();
			this.anio = new System.Windows.Forms.Label();
			this.btn_CargarGrilla = new System.Windows.Forms.Button();
			this.dataGrid_Torneos = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Torneos)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(118, 163);
			this.chart1.Margin = new System.Windows.Forms.Padding(4);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(504, 388);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// cmb_anio
			// 
			this.cmb_anio.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmb_anio.FormattingEnabled = true;
			this.cmb_anio.Location = new System.Drawing.Point(118, 122);
			this.cmb_anio.Margin = new System.Windows.Forms.Padding(4);
			this.cmb_anio.Name = "cmb_anio";
			this.cmb_anio.Size = new System.Drawing.Size(160, 33);
			this.cmb_anio.TabIndex = 56;
			// 
			// anio
			// 
			this.anio.AutoSize = true;
			this.anio.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.anio.Location = new System.Drawing.Point(114, 97);
			this.anio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.anio.Name = "anio";
			this.anio.Size = new System.Drawing.Size(43, 23);
			this.anio.TabIndex = 55;
			this.anio.Text = "Año";
			// 
			// btn_CargarGrilla
			// 
			this.btn_CargarGrilla.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_CargarGrilla.Location = new System.Drawing.Point(306, 116);
			this.btn_CargarGrilla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_CargarGrilla.Name = "btn_CargarGrilla";
			this.btn_CargarGrilla.Size = new System.Drawing.Size(184, 41);
			this.btn_CargarGrilla.TabIndex = 57;
			this.btn_CargarGrilla.Text = "Buscar";
			this.btn_CargarGrilla.UseVisualStyleBackColor = true;
			this.btn_CargarGrilla.Click += new System.EventHandler(this.btn_CargarGrilla_Click);
			// 
			// dataGrid_Torneos
			// 
			this.dataGrid_Torneos.AllowUserToAddRows = false;
			this.dataGrid_Torneos.AllowUserToDeleteRows = false;
			this.dataGrid_Torneos.AllowUserToResizeColumns = false;
			this.dataGrid_Torneos.AllowUserToResizeRows = false;
			this.dataGrid_Torneos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.dataGrid_Torneos.BackgroundColor = System.Drawing.Color.White;
			this.dataGrid_Torneos.CausesValidation = false;
			this.dataGrid_Torneos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGrid_Torneos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGrid_Torneos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid_Torneos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGrid_Torneos.Location = new System.Drawing.Point(646, 163);
			this.dataGrid_Torneos.Margin = new System.Windows.Forms.Padding(4);
			this.dataGrid_Torneos.MultiSelect = false;
			this.dataGrid_Torneos.Name = "dataGrid_Torneos";
			this.dataGrid_Torneos.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGrid_Torneos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGrid_Torneos.RowHeadersVisible = false;
			this.dataGrid_Torneos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			this.dataGrid_Torneos.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGrid_Torneos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGrid_Torneos.Size = new System.Drawing.Size(731, 388);
			this.dataGrid_Torneos.TabIndex = 58;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(33, 42);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(342, 40);
			this.label6.TabIndex = 67;
			this.label6.Text = "Reporte de TORNEOS";
			// 
			// Reporte_Torneos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1436, 661);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dataGrid_Torneos);
			this.Controls.Add(this.cmb_anio);
			this.Controls.Add(this.anio);
			this.Controls.Add(this.btn_CargarGrilla);
			this.Controls.Add(this.chart1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Reporte_Torneos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reporte de Torneos";
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Torneos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cmb_anio;
        private System.Windows.Forms.Label anio;
        private System.Windows.Forms.Button btn_CargarGrilla;
        private System.Windows.Forms.DataGridView dataGrid_Torneos;
		private System.Windows.Forms.Label label6;
	}
}