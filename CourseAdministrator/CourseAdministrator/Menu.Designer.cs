namespace CourseAdministrator
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SkillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PositionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfesionalFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CoursesToolStripMenuItem,
            this.SkillsToolStripMenuItem,
            this.PositionsToolStripMenuItem,
            this.ProfesionalFieldToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CoursesToolStripMenuItem
            // 
            this.CoursesToolStripMenuItem.Name = "CoursesToolStripMenuItem";
            this.CoursesToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.CoursesToolStripMenuItem.Text = "Специалности";
            this.CoursesToolStripMenuItem.Click += new System.EventHandler(this.CoursesToolStripMenuItem_Click);
            // 
            // SkillsToolStripMenuItem
            // 
            this.SkillsToolStripMenuItem.Name = "SkillsToolStripMenuItem";
            this.SkillsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.SkillsToolStripMenuItem.Text = "Умения";
            this.SkillsToolStripMenuItem.Click += new System.EventHandler(this.SkillsToolStripMenuItem_Click);
            // 
            // PositionsToolStripMenuItem
            // 
            this.PositionsToolStripMenuItem.Name = "PositionsToolStripMenuItem";
            this.PositionsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.PositionsToolStripMenuItem.Text = "Длъжности";
            this.PositionsToolStripMenuItem.Click += new System.EventHandler(this.PositionsToolStripMenuItem_Click);
            // 
            // ProfesionalFieldToolStripMenuItem
            // 
            this.ProfesionalFieldToolStripMenuItem.Name = "ProfesionalFieldToolStripMenuItem";
            this.ProfesionalFieldToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.ProfesionalFieldToolStripMenuItem.Text = "Професионална област";
            this.ProfesionalFieldToolStripMenuItem.Click += new System.EventHandler(this.ProfesionalFieldToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ExitToolStripMenuItem.Text = "Изход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 262);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SkillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PositionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProfesionalFieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}