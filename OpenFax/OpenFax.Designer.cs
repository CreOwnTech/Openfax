namespace OpenFax
{
    partial class OpenFax
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenFax));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvFaxDownloadLog = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.btnRedownload = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tooltipOpenFaxDownloaderHome = new System.Windows.Forms.ToolTip(this.components);
            this.InTransID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaxImageFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Redownload = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaxDownloadLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.saveExitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.menuToolStripMenuItem.Text = "Configuration";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.configurationToolStripMenuItem.Text = "Account";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "Configure DID";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveExitToolStripMenuItem
            // 
            this.saveExitToolStripMenuItem.Name = "saveExitToolStripMenuItem";
            this.saveExitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.saveExitToolStripMenuItem.Text = "Save And Exit";
            this.saveExitToolStripMenuItem.Click += new System.EventHandler(this.saveExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dgvFaxDownloadLog
            // 
            this.dgvFaxDownloadLog.AllowUserToAddRows = false;
            this.dgvFaxDownloadLog.AllowUserToDeleteRows = false;
            this.dgvFaxDownloadLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaxDownloadLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InTransID,
            this.Received,
            this.DID,
            this.ReceivedFrom,
            this.Pages,
            this.FaxImageFile,
            this.Status,
            this.Redownload});
            this.dgvFaxDownloadLog.Location = new System.Drawing.Point(9, 66);
            this.dgvFaxDownloadLog.Name = "dgvFaxDownloadLog";
            this.dgvFaxDownloadLog.RowHeadersVisible = false;
            this.dgvFaxDownloadLog.Size = new System.Drawing.Size(760, 280);
            this.dgvFaxDownloadLog.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fax Download Log";
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(10, 3);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 29);
            this.btnClearLog.TabIndex = 3;
            this.btnClearLog.Text = "Clear Log";
            this.tooltipOpenFaxDownloaderHome.SetToolTip(this.btnClearLog, "It will delete your all log history");
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.Location = new System.Drawing.Point(515, 3);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(86, 29);
            this.btnClearSelection.TabIndex = 4;
            this.btnClearSelection.Text = "Clear Selection";
            this.tooltipOpenFaxDownloaderHome.SetToolTip(this.btnClearSelection, "It will clear selection");
            this.btnClearSelection.UseVisualStyleBackColor = true;
            this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);
            // 
            // btnRedownload
            // 
            this.btnRedownload.Location = new System.Drawing.Point(637, 3);
            this.btnRedownload.Name = "btnRedownload";
            this.btnRedownload.Size = new System.Drawing.Size(132, 29);
            this.btnRedownload.TabIndex = 5;
            this.btnRedownload.Text = "Redownload Selected";
            this.tooltipOpenFaxDownloaderHome.SetToolTip(this.btnRedownload, "It will download the selected files again");
            this.btnRedownload.UseVisualStyleBackColor = true;
            this.btnRedownload.Click += new System.EventHandler(this.btnRedownload_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClearLog);
            this.panel1.Controls.Add(this.btnRedownload);
            this.panel1.Controls.Add(this.btnClearSelection);
            this.panel1.Location = new System.Drawing.Point(0, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 40);
            this.panel1.TabIndex = 6;
            // 
            // InTransID
            // 
            this.InTransID.DataPropertyName = "IntransId";
            this.InTransID.HeaderText = "InTransID";
            this.InTransID.MinimumWidth = 3;
            this.InTransID.Name = "InTransID";
            this.InTransID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.InTransID.Width = 70;
            // 
            // Received
            // 
            this.Received.DataPropertyName = "Received";
            this.Received.HeaderText = "Received";
            this.Received.Name = "Received";
            this.Received.Width = 120;
            // 
            // DID
            // 
            this.DID.DataPropertyName = "Did";
            this.DID.HeaderText = "DID";
            this.DID.MinimumWidth = 3;
            this.DID.Name = "DID";
            this.DID.Width = 80;
            // 
            // ReceivedFrom
            // 
            this.ReceivedFrom.DataPropertyName = "ReceivedFrom";
            this.ReceivedFrom.HeaderText = "Received From";
            this.ReceivedFrom.Name = "ReceivedFrom";
            this.ReceivedFrom.Width = 90;
            // 
            // Pages
            // 
            this.Pages.DataPropertyName = "Pages";
            this.Pages.HeaderText = "Pages";
            this.Pages.MinimumWidth = 2;
            this.Pages.Name = "Pages";
            this.Pages.Width = 45;
            // 
            // FaxImageFile
            // 
            this.FaxImageFile.DataPropertyName = "FaxImageFile";
            this.FaxImageFile.HeaderText = "Fax Image File";
            this.FaxImageFile.Name = "FaxImageFile";
            this.FaxImageFile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FaxImageFile.Width = 220;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 60;
            // 
            // Redownload
            // 
            this.Redownload.DataPropertyName = "ReDownload";
            this.Redownload.HeaderText = "Redownload";
            this.Redownload.MinimumWidth = 2;
            this.Redownload.Name = "Redownload";
            this.Redownload.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Redownload.Width = 70;
            // 
            // OpenFax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFaxDownloadLog);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OpenFax";
            this.Text = "Openfax Inbound Fax Downloader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaxDownloadLog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvFaxDownloadLog;
        private System.Windows.Forms.ToolStripMenuItem saveExitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnClearSelection;
        private System.Windows.Forms.Button btnRedownload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip tooltipOpenFaxDownloaderHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn InTransID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Received;
        private System.Windows.Forms.DataGridViewTextBoxColumn DID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaxImageFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Redownload;
    }
}

