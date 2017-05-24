namespace OpenFax
{
    partial class DIDConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DIDConfiguration));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveConfigurationAndExit = new System.Windows.Forms.Button();
            this.btnConfigureSelected = new System.Windows.Forms.Button();
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxLe = new System.Windows.Forms.GroupBox();
            this.dgvDIDConfiguration = new System.Windows.Forms.DataGridView();
            this.Poll = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIDName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suffix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.S = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsDefault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBoxLe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDIDConfiguration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inbound Fax Number Configuration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "D : Indicates DID uses default poll configuration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "E : Indicates DID has configuration for fax email notification";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "P : Indicates DID has configuration for fax URL post - back notification";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "S : Indicates DID has configuration for fax upload to Amazon AWS S3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "You may modify the cloud service configuration at";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(252, 87);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(147, 15);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://portal.openfax.com";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnSaveConfigurationAndExit);
            this.panel1.Controls.Add(this.btnConfigureSelected);
            this.panel1.Controls.Add(this.btnClearSelection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 439);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 40);
            this.panel1.TabIndex = 9;
            // 
            // btnSaveConfigurationAndExit
            // 
            this.btnSaveConfigurationAndExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConfigurationAndExit.Location = new System.Drawing.Point(738, 5);
            this.btnSaveConfigurationAndExit.Name = "btnSaveConfigurationAndExit";
            this.btnSaveConfigurationAndExit.Size = new System.Drawing.Size(88, 30);
            this.btnSaveConfigurationAndExit.TabIndex = 2;
            this.btnSaveConfigurationAndExit.Text = "Save & Exit";
            this.toolTip1.SetToolTip(this.btnSaveConfigurationAndExit, "It will save the selection of poll");
            this.btnSaveConfigurationAndExit.UseMnemonic = false;
            this.btnSaveConfigurationAndExit.UseVisualStyleBackColor = true;
            this.btnSaveConfigurationAndExit.Click += new System.EventHandler(this.btnSaveConfigurationAndExit_Click);
            // 
            // btnConfigureSelected
            // 
            this.btnConfigureSelected.Location = new System.Drawing.Point(610, 5);
            this.btnConfigureSelected.Name = "btnConfigureSelected";
            this.btnConfigureSelected.Size = new System.Drawing.Size(122, 30);
            this.btnConfigureSelected.TabIndex = 1;
            this.btnConfigureSelected.Text = "Configure Selected";
            this.toolTip1.SetToolTip(this.btnConfigureSelected, "Configure selected DID");
            this.btnConfigureSelected.UseVisualStyleBackColor = true;
            this.btnConfigureSelected.Click += new System.EventHandler(this.btnConfigureSelected_Click);
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.Location = new System.Drawing.Point(499, 5);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(105, 30);
            this.btnClearSelection.TabIndex = 0;
            this.btnClearSelection.Text = "Clear Selection";
            this.toolTip1.SetToolTip(this.btnClearSelection, "It will clear your DID selection");
            this.btnClearSelection.UseVisualStyleBackColor = true;
            this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);
            // 
            // groupBoxLe
            // 
            this.groupBoxLe.Controls.Add(this.label5);
            this.groupBoxLe.Controls.Add(this.linkLabel1);
            this.groupBoxLe.Controls.Add(this.label3);
            this.groupBoxLe.Controls.Add(this.label7);
            this.groupBoxLe.Controls.Add(this.label4);
            this.groupBoxLe.Controls.Add(this.label6);
            this.groupBoxLe.Location = new System.Drawing.Point(13, 307);
            this.groupBoxLe.Name = "groupBoxLe";
            this.groupBoxLe.Size = new System.Drawing.Size(814, 113);
            this.groupBoxLe.TabIndex = 10;
            this.groupBoxLe.TabStop = false;
            this.groupBoxLe.Text = "Legend";
            this.groupBoxLe.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvDIDConfiguration
            // 
            this.dgvDIDConfiguration.AllowUserToAddRows = false;
            this.dgvDIDConfiguration.AllowUserToDeleteRows = false;
            this.dgvDIDConfiguration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDIDConfiguration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Poll,
            this.DID,
            this.DIDName,
            this.Type,
            this.FilePath,
            this.Prefix,
            this.Suffix,
            this.D,
            this.E,
            this.P,
            this.S,
            this.Select,
            this.IsDefault});
            this.dgvDIDConfiguration.Location = new System.Drawing.Point(13, 62);
            this.dgvDIDConfiguration.Name = "dgvDIDConfiguration";
            this.dgvDIDConfiguration.RowHeadersVisible = false;
            this.dgvDIDConfiguration.Size = new System.Drawing.Size(814, 233);
            this.dgvDIDConfiguration.TabIndex = 11;
            // 
            // Poll
            // 
            this.Poll.DataPropertyName = "Poll";
            this.Poll.HeaderText = "Poll";
            this.Poll.Name = "Poll";
            this.Poll.Width = 50;
            // 
            // DID
            // 
            this.DID.DataPropertyName = "Did";
            this.DID.HeaderText = "DID";
            this.DID.Name = "DID";
            this.DID.ReadOnly = true;
            this.DID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DIDName
            // 
            this.DIDName.DataPropertyName = "Name";
            this.DIDName.HeaderText = "Name";
            this.DIDName.Name = "DIDName";
            this.DIDName.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 50;
            // 
            // FilePath
            // 
            this.FilePath.DataPropertyName = "FilePath";
            this.FilePath.HeaderText = "File Path";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            // 
            // Prefix
            // 
            this.Prefix.DataPropertyName = "Prefix";
            this.Prefix.HeaderText = "Prefix";
            this.Prefix.Name = "Prefix";
            this.Prefix.ReadOnly = true;
            this.Prefix.Width = 80;
            // 
            // Suffix
            // 
            this.Suffix.DataPropertyName = "Suffix";
            this.Suffix.HeaderText = "Suffix";
            this.Suffix.Name = "Suffix";
            this.Suffix.ReadOnly = true;
            this.Suffix.Width = 80;
            // 
            // D
            // 
            this.D.DataPropertyName = "D";
            this.D.HeaderText = "D";
            this.D.Name = "D";
            this.D.ReadOnly = true;
            this.D.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.D.Width = 50;
            // 
            // E
            // 
            this.E.DataPropertyName = "E";
            this.E.HeaderText = "E";
            this.E.Name = "E";
            this.E.ReadOnly = true;
            this.E.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.E.Width = 50;
            // 
            // P
            // 
            this.P.DataPropertyName = "P";
            this.P.HeaderText = "P";
            this.P.Name = "P";
            this.P.ReadOnly = true;
            this.P.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.P.Width = 50;
            // 
            // S
            // 
            this.S.DataPropertyName = "S";
            this.S.HeaderText = "S";
            this.S.Name = "S";
            this.S.ReadOnly = true;
            this.S.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.S.Width = 50;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Width = 50;
            // 
            // IsDefault
            // 
            this.IsDefault.DataPropertyName = "IsDefault";
            this.IsDefault.HeaderText = "IsDefault";
            this.IsDefault.Name = "IsDefault";
            this.IsDefault.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsDefault.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IsDefault.Visible = false;
            // 
            // DIDConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(839, 479);
            this.Controls.Add(this.dgvDIDConfiguration);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxLe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DIDConfiguration";
            this.Text = "Openfax Inbound Fax Downloader";
            this.Load += new System.EventHandler(this.DIDConfiguration_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxLe.ResumeLayout(false);
            this.groupBoxLe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDIDConfiguration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveConfigurationAndExit;
        private System.Windows.Forms.Button btnConfigureSelected;
        private System.Windows.Forms.Button btnClearSelection;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBoxLe;
        private System.Windows.Forms.DataGridView dgvDIDConfiguration;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Poll;
        private System.Windows.Forms.DataGridViewTextBoxColumn DID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIDName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suffix;
        private System.Windows.Forms.DataGridViewCheckBoxColumn D;
        private System.Windows.Forms.DataGridViewCheckBoxColumn E;
        private System.Windows.Forms.DataGridViewCheckBoxColumn P;
        private System.Windows.Forms.DataGridViewCheckBoxColumn S;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDefault;
    }
}