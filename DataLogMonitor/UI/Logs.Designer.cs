namespace DataLogMonitor.UI
{
    partial class Logs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logs));
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtBoxSearchLogs = new MetroFramework.Controls.MetroTextBox();
            this.mGridLogs = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.mGridLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(34, 70);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 25);
            this.metroLabel6.TabIndex = 36;
            this.metroLabel6.Text = "Search";
            // 
            // txtBoxSearchLogs
            // 
            // 
            // 
            // 
            this.txtBoxSearchLogs.CustomButton.Image = null;
            this.txtBoxSearchLogs.CustomButton.Location = new System.Drawing.Point(277, 2);
            this.txtBoxSearchLogs.CustomButton.Name = "";
            this.txtBoxSearchLogs.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtBoxSearchLogs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxSearchLogs.CustomButton.TabIndex = 1;
            this.txtBoxSearchLogs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxSearchLogs.CustomButton.UseSelectable = true;
            this.txtBoxSearchLogs.CustomButton.Visible = false;
            this.txtBoxSearchLogs.Lines = new string[0];
            this.txtBoxSearchLogs.Location = new System.Drawing.Point(128, 70);
            this.txtBoxSearchLogs.MaxLength = 32767;
            this.txtBoxSearchLogs.Name = "txtBoxSearchLogs";
            this.txtBoxSearchLogs.PasswordChar = '\0';
            this.txtBoxSearchLogs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSearchLogs.SelectedText = "";
            this.txtBoxSearchLogs.SelectionLength = 0;
            this.txtBoxSearchLogs.SelectionStart = 0;
            this.txtBoxSearchLogs.ShortcutsEnabled = true;
            this.txtBoxSearchLogs.Size = new System.Drawing.Size(305, 30);
            this.txtBoxSearchLogs.TabIndex = 35;
            this.txtBoxSearchLogs.UseSelectable = true;
            this.txtBoxSearchLogs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxSearchLogs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxSearchLogs.TextChanged += new System.EventHandler(this.txtBoxSearchLogs_TextChanged);
            // 
            // mGridLogs
            // 
            this.mGridLogs.AllowUserToResizeRows = false;
            this.mGridLogs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mGridLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridLogs.DefaultCellStyle = dataGridViewCellStyle2;
            this.mGridLogs.EnableHeadersVisualStyles = false;
            this.mGridLogs.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridLogs.Location = new System.Drawing.Point(23, 166);
            this.mGridLogs.Name = "mGridLogs";
            this.mGridLogs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mGridLogs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridLogs.Size = new System.Drawing.Size(847, 411);
            this.mGridLogs.TabIndex = 34;
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtBoxSearchLogs);
            this.Controls.Add(this.mGridLogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Logs";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Logs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Logs_FormClosed);
            this.Load += new System.EventHandler(this.Logs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mGridLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtBoxSearchLogs;
        private MetroFramework.Controls.MetroGrid mGridLogs;
    }
}