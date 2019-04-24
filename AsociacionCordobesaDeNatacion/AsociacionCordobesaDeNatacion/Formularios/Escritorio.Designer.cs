namespace AsociacionCordobesaDeNatacion.Formularios
{
    partial class Escritorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escritorio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nadadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torneosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nadadoresToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.especialidadToolStripMenuItem,
            this.torneosToolStripMenuItem,
            this.inscripciónToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            resources.ApplyResources(this.sistemaToolStripMenuItem, "sistemaToolStripMenuItem");
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            // 
            // nadadoresToolStripMenuItem
            // 
            this.nadadoresToolStripMenuItem.Name = "nadadoresToolStripMenuItem";
            resources.ApplyResources(this.nadadoresToolStripMenuItem, "nadadoresToolStripMenuItem");
            // 
            // especialidadToolStripMenuItem
            // 
            this.especialidadToolStripMenuItem.Name = "especialidadToolStripMenuItem";
            resources.ApplyResources(this.especialidadToolStripMenuItem, "especialidadToolStripMenuItem");
            // 
            // torneosToolStripMenuItem
            // 
            this.torneosToolStripMenuItem.Name = "torneosToolStripMenuItem";
            resources.ApplyResources(this.torneosToolStripMenuItem, "torneosToolStripMenuItem");
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            resources.ApplyResources(this.profesoresToolStripMenuItem, "profesoresToolStripMenuItem");
            // 
            // inscripciónToolStripMenuItem
            // 
            this.inscripciónToolStripMenuItem.Name = "inscripciónToolStripMenuItem";
            resources.ApplyResources(this.inscripciónToolStripMenuItem, "inscripciónToolStripMenuItem");
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            resources.ApplyResources(this.salirDelSistemaToolStripMenuItem, "salirDelSistemaToolStripMenuItem");
            // 
            // Escritorio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Escritorio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nadadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
    }
}