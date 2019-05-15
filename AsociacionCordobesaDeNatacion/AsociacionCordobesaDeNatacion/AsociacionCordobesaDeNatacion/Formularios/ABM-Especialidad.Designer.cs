namespace AsociacionCordobesaDeNatacion.Formularios
{
    partial class ABM_Especialidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Especialidad));
            this.cmd_buscar01 = new System.Windows.Forms.Button();
            this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmd_nuevo = new System.Windows.Forms.Button();
            this.cmd_grabar = new System.Windows.Forms.Button();
            this.cmd_actualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_buscar01
            // 
            this.cmd_buscar01.BackColor = System.Drawing.Color.White;
            this.cmd_buscar01.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_buscar01.Location = new System.Drawing.Point(180, 61);
            this.cmd_buscar01.Name = "cmd_buscar01";
            this.cmd_buscar01.Size = new System.Drawing.Size(69, 26);
            this.cmd_buscar01.TabIndex = 34;
            this.cmd_buscar01.Text = "Buscar";
            this.cmd_buscar01.UseVisualStyleBackColor = false;
            this.cmd_buscar01.Visible = false;
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.BackColor = System.Drawing.Color.White;
            this.txt_nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_usuario.Location = new System.Drawing.Point(118, 112);
            this.txt_nombre_usuario.MaxLength = 50;
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(161, 26);
            this.txt_nombre_usuario.TabIndex = 33;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.White;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(118, 61);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(56, 26);
            this.txt_id.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nombre_usuario);
            this.groupBox1.Controls.Add(this.cmd_buscar01);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(60, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 209);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ESPECIALIDAD";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(118, 164);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 26);
            this.textBox1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tiempo Récord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Descripción";
            // 
            // cmd_nuevo
            // 
            this.cmd_nuevo.BackColor = System.Drawing.Color.White;
            this.cmd_nuevo.BackgroundImage = global::AsociacionCordobesaDeNatacion.Properties.Resources.archive__2_;
            this.cmd_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_nuevo.Location = new System.Drawing.Point(397, 65);
            this.cmd_nuevo.Name = "cmd_nuevo";
            this.cmd_nuevo.Size = new System.Drawing.Size(37, 35);
            this.cmd_nuevo.TabIndex = 34;
            this.cmd_nuevo.Tag = "Condiciones para crear un nuevo registro";
            this.cmd_nuevo.UseVisualStyleBackColor = false;
            // 
            // cmd_grabar
            // 
            this.cmd_grabar.BackColor = System.Drawing.Color.White;
            this.cmd_grabar.BackgroundImage = global::AsociacionCordobesaDeNatacion.Properties.Resources.archive;
            this.cmd_grabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_grabar.Enabled = false;
            this.cmd_grabar.Location = new System.Drawing.Point(397, 103);
            this.cmd_grabar.Name = "cmd_grabar";
            this.cmd_grabar.Size = new System.Drawing.Size(37, 35);
            this.cmd_grabar.TabIndex = 35;
            this.cmd_grabar.UseVisualStyleBackColor = false;
            // 
            // cmd_actualizar
            // 
            this.cmd_actualizar.BackColor = System.Drawing.Color.White;
            this.cmd_actualizar.BackgroundImage = global::AsociacionCordobesaDeNatacion.Properties.Resources.archive__3_;
            this.cmd_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_actualizar.Enabled = false;
            this.cmd_actualizar.Location = new System.Drawing.Point(397, 144);
            this.cmd_actualizar.Name = "cmd_actualizar";
            this.cmd_actualizar.Size = new System.Drawing.Size(37, 35);
            this.cmd_actualizar.TabIndex = 36;
            this.cmd_actualizar.UseVisualStyleBackColor = false;
            // 
            // ABM_Especialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 277);
            this.Controls.Add(this.cmd_actualizar);
            this.Controls.Add(this.cmd_grabar);
            this.Controls.Add(this.cmd_nuevo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABM_Especialidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM_Especialidad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_buscar01;
        private System.Windows.Forms.TextBox txt_nombre_usuario;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_nuevo;
        private System.Windows.Forms.Button cmd_grabar;
        private System.Windows.Forms.Button cmd_actualizar;
    }
}