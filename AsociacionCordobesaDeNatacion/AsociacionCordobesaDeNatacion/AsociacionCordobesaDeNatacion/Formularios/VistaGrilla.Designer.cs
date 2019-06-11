namespace AsociacionCordobesaDeNatacion.Formularios
{
    partial class VistaGrilla
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
            this.dataGrid_generico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_generico)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_generico
            // 
            this.dataGrid_generico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_generico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_generico.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_generico.Name = "dataGrid_generico";
            this.dataGrid_generico.Size = new System.Drawing.Size(541, 347);
            this.dataGrid_generico.TabIndex = 0;
            // 
            // VistaGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(541, 347);
            this.Controls.Add(this.dataGrid_generico);
            this.Name = "VistaGrilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grilla";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_generico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_generico;
    }
}