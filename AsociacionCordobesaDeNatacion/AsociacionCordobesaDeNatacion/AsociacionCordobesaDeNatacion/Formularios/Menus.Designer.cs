namespace AsociacionCordobesaDeNatacion.Formularios
{
    partial class Menus
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
            this.btn_clubes = new System.Windows.Forms.Button();
            this.btn_nadadores = new System.Windows.Forms.Button();
            this.btn_profesores = new System.Windows.Forms.Button();
            this.btn_torneos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_clubes
            // 
            this.btn_clubes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clubes.Location = new System.Drawing.Point(115, 135);
            this.btn_clubes.Name = "btn_clubes";
            this.btn_clubes.Size = new System.Drawing.Size(139, 37);
            this.btn_clubes.TabIndex = 0;
            this.btn_clubes.Text = "CLUBES";
            this.btn_clubes.UseVisualStyleBackColor = true;
            this.btn_clubes.Click += new System.EventHandler(this.btn_clubes_Click);
            // 
            // btn_nadadores
            // 
            this.btn_nadadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nadadores.Location = new System.Drawing.Point(262, 136);
            this.btn_nadadores.Name = "btn_nadadores";
            this.btn_nadadores.Size = new System.Drawing.Size(139, 36);
            this.btn_nadadores.TabIndex = 1;
            this.btn_nadadores.Text = "NADADORES";
            this.btn_nadadores.UseVisualStyleBackColor = true;
            this.btn_nadadores.Click += new System.EventHandler(this.btn_nadadores_Click);
            // 
            // btn_profesores
            // 
            this.btn_profesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profesores.Location = new System.Drawing.Point(407, 136);
            this.btn_profesores.Name = "btn_profesores";
            this.btn_profesores.Size = new System.Drawing.Size(139, 36);
            this.btn_profesores.TabIndex = 2;
            this.btn_profesores.Text = "PROFESORES";
            this.btn_profesores.UseVisualStyleBackColor = true;
            this.btn_profesores.Click += new System.EventHandler(this.btn_profesores_Click);
            // 
            // btn_torneos
            // 
            this.btn_torneos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_torneos.Location = new System.Drawing.Point(552, 136);
            this.btn_torneos.Name = "btn_torneos";
            this.btn_torneos.Size = new System.Drawing.Size(139, 36);
            this.btn_torneos.TabIndex = 3;
            this.btn_torneos.Text = "TORNEOS";
            this.btn_torneos.UseVisualStyleBackColor = true;
            this.btn_torneos.Click += new System.EventHandler(this.btn_torneos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione una opción:";
            // 
            // Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_torneos);
            this.Controls.Add(this.btn_profesores);
            this.Controls.Add(this.btn_nadadores);
            this.Controls.Add(this.btn_clubes);
            this.Name = "Menus";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_clubes;
        private System.Windows.Forms.Button btn_nadadores;
        private System.Windows.Forms.Button btn_profesores;
        private System.Windows.Forms.Button btn_torneos;
        private System.Windows.Forms.Label label1;
    }
}