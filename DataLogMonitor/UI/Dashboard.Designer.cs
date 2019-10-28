namespace DataLogMonitor
{
    partial class DataLogMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataLogMonitor));
            this.menuStripDLM = new System.Windows.Forms.MenuStrip();
            this.toolStripLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripDLM.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripDLM
            // 
            this.menuStripDLM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLogs,
            this.toolStripUsers});
            this.menuStripDLM.Location = new System.Drawing.Point(20, 60);
            this.menuStripDLM.Name = "menuStripDLM";
            this.menuStripDLM.Size = new System.Drawing.Size(760, 24);
            this.menuStripDLM.TabIndex = 1;
            this.menuStripDLM.Text = "menuStripDLM";
            // 
            // toolStripLogs
            // 
            this.toolStripLogs.Name = "toolStripLogs";
            this.toolStripLogs.Size = new System.Drawing.Size(44, 20);
            this.toolStripLogs.Text = "Logs";
            this.toolStripLogs.Click += new System.EventHandler(this.toolStripLogs_Click);
            // 
            // toolStripUsers
            // 
            this.toolStripUsers.Name = "toolStripUsers";
            this.toolStripUsers.Size = new System.Drawing.Size(47, 20);
            this.toolStripUsers.Text = "Users";
            this.toolStripUsers.Click += new System.EventHandler(this.toolStripUsers_Click);
            // 
            // DataLogMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.menuStripDLM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripDLM;
            this.Name = "DataLogMonitor";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Data Log Monitor";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripDLM.ResumeLayout(false);
            this.menuStripDLM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripDLM;
        private System.Windows.Forms.ToolStripMenuItem toolStripLogs;
        private System.Windows.Forms.ToolStripMenuItem toolStripUsers;
    }
}

