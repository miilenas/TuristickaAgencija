namespace Client
{
    partial class FrmMain
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
            menuStrip1 = new MenuStrip();
            putnikToolStripMenuItem = new ToolStripMenuItem();
            rezervacijaToolStripMenuItem = new ToolStripMenuItem();
            licencaToolStripMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { putnikToolStripMenuItem, rezervacijaToolStripMenuItem, licencaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // putnikToolStripMenuItem
            // 
            putnikToolStripMenuItem.Name = "putnikToolStripMenuItem";
            putnikToolStripMenuItem.Size = new Size(77, 29);
            putnikToolStripMenuItem.Text = "Putnik";
            putnikToolStripMenuItem.Click += putnikToolStripMenuItem_Click;
            // 
            // rezervacijaToolStripMenuItem
            // 
            rezervacijaToolStripMenuItem.Name = "rezervacijaToolStripMenuItem";
            rezervacijaToolStripMenuItem.Size = new Size(113, 29);
            rezervacijaToolStripMenuItem.Text = "Rezervacija";
            rezervacijaToolStripMenuItem.Click += rezervacijaToolStripMenuItem_Click;
            // 
            // licencaToolStripMenuItem
            // 
            licencaToolStripMenuItem.Name = "licencaToolStripMenuItem";
            licencaToolStripMenuItem.Size = new Size(84, 29);
            licencaToolStripMenuItem.Text = "Licenca";
            licencaToolStripMenuItem.Click += licencaToolStripMenuItem_Click;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 33);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(800, 417);
            mainPanel.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Turisticka agencija";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem putnikToolStripMenuItem;
        private ToolStripMenuItem rezervacijaToolStripMenuItem;
        private ToolStripMenuItem licencaToolStripMenuItem;
        private Panel mainPanel;
    }
}