namespace AsociacionCordobesaDeNatacion.Formularios
{
    partial class Usuario
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
            this.btn_lupo = new System.Windows.Forms.Button();
            this.btn_lourdes = new System.Windows.Forms.Button();
            this.btn_belen = new System.Windows.Forms.Button();
            this.btn_matias = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_lupo);
            this.groupBox1.Controls.Add(this.btn_lourdes);
            this.groupBox1.Controls.Add(this.btn_belen);
            this.groupBox1.Controls.Add(this.btn_matias);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 318);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // btn_lupo
            // 
            this.btn_lupo.BackColor = System.Drawing.Color.White;
            this.btn_lupo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lupo.ForeColor = System.Drawing.Color.Black;
            this.btn_lupo.Location = new System.Drawing.Point(104, 192);
            this.btn_lupo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_lupo.Name = "btn_lupo";
            this.btn_lupo.Size = new System.Drawing.Size(162, 44);
            this.btn_lupo.TabIndex = 8;
            this.btn_lupo.Text = "LUPO";
            this.btn_lupo.UseVisualStyleBackColor = false;
            this.btn_lupo.Click += new System.EventHandler(this.btn_lupo_Click);
            // 
            // btn_lourdes
            // 
            this.btn_lourdes.BackColor = System.Drawing.Color.White;
            this.btn_lourdes.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lourdes.ForeColor = System.Drawing.Color.Black;
            this.btn_lourdes.Location = new System.Drawing.Point(301, 192);
            this.btn_lourdes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_lourdes.Name = "btn_lourdes";
            this.btn_lourdes.Size = new System.Drawing.Size(162, 44);
            this.btn_lourdes.TabIndex = 7;
            this.btn_lourdes.Text = "LOURDES";
            this.btn_lourdes.UseVisualStyleBackColor = false;
            this.btn_lourdes.Click += new System.EventHandler(this.btn_lourdes_Click);
            // 
            // btn_belen
            // 
            this.btn_belen.BackColor = System.Drawing.Color.White;
            this.btn_belen.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_belen.ForeColor = System.Drawing.Color.Black;
            this.btn_belen.Location = new System.Drawing.Point(104, 127);
            this.btn_belen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_belen.Name = "btn_belen";
            this.btn_belen.Size = new System.Drawing.Size(162, 44);
            this.btn_belen.TabIndex = 1;
            this.btn_belen.Text = "BELEN";
            this.btn_belen.UseVisualStyleBackColor = false;
            this.btn_belen.Click += new System.EventHandler(this.btn_belen_Click);
            // 
            // btn_matias
            // 
            this.btn_matias.BackColor = System.Drawing.Color.White;
            this.btn_matias.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_matias.ForeColor = System.Drawing.Color.Black;
            this.btn_matias.Location = new System.Drawing.Point(301, 127);
            this.btn_matias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_matias.Name = "btn_matias";
            this.btn_matias.Size = new System.Drawing.Size(162, 44);
            this.btn_matias.TabIndex = 5;
            this.btn_matias.Text = "MATIAS";
            this.btn_matias.UseVisualStyleBackColor = false;
            this.btn_matias.Click += new System.EventHandler(this.btn_matias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quien sos?";
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 348);
            this.Controls.Add(this.groupBox1);
            this.Name = "Usuario";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_lourdes;
        private System.Windows.Forms.Button btn_belen;
        private System.Windows.Forms.Button btn_matias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_lupo;
    }
}