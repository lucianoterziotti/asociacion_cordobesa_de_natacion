namespace AsociacionCordobesaDeNatacion.Formularios
{
    partial class ABM_Profesores
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Profesores));
			this.cmd_buscar01 = new System.Windows.Forms.Button();
			this.txt_nombre_profesor = new System.Windows.Forms.TextBox();
			this.txt_dni = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txt_calle = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmd_nuevo = new System.Windows.Forms.Button();
			this.cmd_grabar = new System.Windows.Forms.Button();
			this.cmd_actualizar = new System.Windows.Forms.Button();
			this.btn_eliminar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmd_buscar01
			// 
			this.cmd_buscar01.BackColor = System.Drawing.Color.White;
			this.cmd_buscar01.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmd_buscar01.Location = new System.Drawing.Point(292, 79);
			this.cmd_buscar01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmd_buscar01.Name = "cmd_buscar01";
			this.cmd_buscar01.Size = new System.Drawing.Size(100, 32);
			this.cmd_buscar01.TabIndex = 34;
			this.cmd_buscar01.Text = "Buscar";
			this.cmd_buscar01.UseVisualStyleBackColor = true;
			this.cmd_buscar01.Click += new System.EventHandler(this.cmd_buscar01_Click);
			// 
			// txt_nombre_profesor
			// 
			this.txt_nombre_profesor.BackColor = System.Drawing.Color.White;
			this.txt_nombre_profesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_nombre_profesor.Location = new System.Drawing.Point(89, 142);
			this.txt_nombre_profesor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_nombre_profesor.MaxLength = 50;
			this.txt_nombre_profesor.Name = "txt_nombre_profesor";
			this.txt_nombre_profesor.Size = new System.Drawing.Size(195, 30);
			this.txt_nombre_profesor.TabIndex = 33;
			// 
			// txt_dni
			// 
			this.txt_dni.BackColor = System.Drawing.Color.White;
			this.txt_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_dni.Location = new System.Drawing.Point(89, 79);
			this.txt_dni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_dni.MaxLength = 10;
			this.txt_dni.Name = "txt_dni";
			this.txt_dni.Size = new System.Drawing.Size(177, 30);
			this.txt_dni.TabIndex = 32;
			this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_nombre_profesor);
			this.groupBox1.Controls.Add(this.cmd_buscar01);
			this.groupBox1.Controls.Add(this.txt_dni);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(88, 57);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(537, 288);
			this.groupBox1.TabIndex = 35;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "PROFESORES";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txt_calle);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(89, 181);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Size = new System.Drawing.Size(303, 84);
			this.groupBox2.TabIndex = 30;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Domicilio";
			// 
			// txt_calle
			// 
			this.txt_calle.BackColor = System.Drawing.Color.White;
			this.txt_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_calle.Location = new System.Drawing.Point(84, 34);
			this.txt_calle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_calle.MaxLength = 50;
			this.txt_calle.Name = "txt_calle";
			this.txt_calle.Size = new System.Drawing.Size(195, 30);
			this.txt_calle.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 34);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 23);
			this.label1.TabIndex = 23;
			this.label1.Text = "Calle";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(84, 52);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 23);
			this.label2.TabIndex = 17;
			this.label2.Text = "DNI";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(84, 114);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 23);
			this.label3.TabIndex = 23;
			this.label3.Text = "Nombre";
			// 
			// cmd_nuevo
			// 
			this.cmd_nuevo.BackColor = System.Drawing.Color.White;
			this.cmd_nuevo.BackgroundImage = global::AsociacionCordobesaDeNatacion.Properties.Resources.archive__2_;
			this.cmd_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmd_nuevo.Location = new System.Drawing.Point(600, 96);
			this.cmd_nuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmd_nuevo.Name = "cmd_nuevo";
			this.cmd_nuevo.Size = new System.Drawing.Size(49, 43);
			this.cmd_nuevo.TabIndex = 28;
			this.cmd_nuevo.Tag = "Condiciones para crear un nuevo registro";
			this.cmd_nuevo.UseVisualStyleBackColor = false;
			this.cmd_nuevo.Click += new System.EventHandler(this.cmd_nuevo_Click);
			// 
			// cmd_grabar
			// 
			this.cmd_grabar.BackColor = System.Drawing.Color.White;
			this.cmd_grabar.BackgroundImage = global::AsociacionCordobesaDeNatacion.Properties.Resources.archive;
			this.cmd_grabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmd_grabar.Location = new System.Drawing.Point(600, 146);
			this.cmd_grabar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmd_grabar.Name = "cmd_grabar";
			this.cmd_grabar.Size = new System.Drawing.Size(49, 43);
			this.cmd_grabar.TabIndex = 29;
			this.cmd_grabar.UseVisualStyleBackColor = false;
			this.cmd_grabar.Click += new System.EventHandler(this.cmd_grabar_Click);
			// 
			// cmd_actualizar
			// 
			this.cmd_actualizar.BackColor = System.Drawing.Color.White;
			this.cmd_actualizar.BackgroundImage = global::AsociacionCordobesaDeNatacion.Properties.Resources.archive__3_;
			this.cmd_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmd_actualizar.Location = new System.Drawing.Point(600, 197);
			this.cmd_actualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmd_actualizar.Name = "cmd_actualizar";
			this.cmd_actualizar.Size = new System.Drawing.Size(49, 43);
			this.cmd_actualizar.TabIndex = 30;
			this.cmd_actualizar.UseVisualStyleBackColor = false;
			this.cmd_actualizar.Click += new System.EventHandler(this.cmd_actualizar_Click);
			// 
			// btn_eliminar
			// 
			this.btn_eliminar.BackColor = System.Drawing.Color.White;
			this.btn_eliminar.BackgroundImage = global::AsociacionCordobesaDeNatacion.Properties.Resources.basket;
			this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_eliminar.Location = new System.Drawing.Point(599, 247);
			this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_eliminar.Name = "btn_eliminar";
			this.btn_eliminar.Size = new System.Drawing.Size(51, 43);
			this.btn_eliminar.TabIndex = 46;
			this.btn_eliminar.UseVisualStyleBackColor = false;
			this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
			// 
			// ABM_Profesores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(741, 389);
			this.Controls.Add(this.btn_eliminar);
			this.Controls.Add(this.cmd_actualizar);
			this.Controls.Add(this.cmd_grabar);
			this.Controls.Add(this.cmd_nuevo);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ABM_Profesores";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Profesores";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_buscar01;
        private System.Windows.Forms.TextBox txt_nombre_profesor;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmd_nuevo;
        private System.Windows.Forms.Button cmd_grabar;
        private System.Windows.Forms.Button cmd_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
    }
}