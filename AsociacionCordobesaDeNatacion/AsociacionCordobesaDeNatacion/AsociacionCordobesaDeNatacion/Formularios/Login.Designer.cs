namespace AsociacionCordobesaDeNatacion
{
    partial class Login
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
            this.cmd_ingresar = new System.Windows.Forms.Button();
            this.BoxPassword = new System.Windows.Forms.TextBox();
            this.BoxUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_ingresar
            // 
            this.cmd_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_ingresar.Location = new System.Drawing.Point(246, 82);
            this.cmd_ingresar.Name = "cmd_ingresar";
            this.cmd_ingresar.Size = new System.Drawing.Size(90, 31);
            this.cmd_ingresar.TabIndex = 9;
            this.cmd_ingresar.Text = "Ingresar";
            this.cmd_ingresar.UseVisualStyleBackColor = true;
            this.cmd_ingresar.Click += new System.EventHandler(this.cmd_ingresar_Click);
            // 
            // BoxPassword
            // 
            this.BoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxPassword.Location = new System.Drawing.Point(140, 84);
            this.BoxPassword.Name = "BoxPassword";
            this.BoxPassword.Size = new System.Drawing.Size(100, 26);
            this.BoxPassword.TabIndex = 8;
            this.BoxPassword.UseSystemPasswordChar = true;
            // 
            // BoxUsuario
            // 
            this.BoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxUsuario.Location = new System.Drawing.Point(140, 52);
            this.BoxUsuario.Name = "BoxUsuario";
            this.BoxUsuario.Size = new System.Drawing.Size(100, 26);
            this.BoxUsuario.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 174);
            this.Controls.Add(this.cmd_ingresar);
            this.Controls.Add(this.BoxPassword);
            this.Controls.Add(this.BoxUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_ingresar;
        private System.Windows.Forms.TextBox BoxPassword;
        private System.Windows.Forms.TextBox BoxUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}