namespace OpenFax
{
    partial class SingleDIDConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleDIDConfiguration));
            this.lblSingleTitle = new System.Windows.Forms.Label();
            this.lblSingleDIDAndName = new System.Windows.Forms.Label();
            this.rbUserDefaultSetting = new System.Windows.Forms.RadioButton();
            this.rbCustomSettings = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDefaultFaxImageType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDefaultFaxImageSavePath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDefaultPrefix = new System.Windows.Forms.Label();
            this.lblDefaultSuffix = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSampleFileOutput = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDefaultImageSavePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.chkAddPrefix = new System.Windows.Forms.CheckBox();
            this.txtFilePrefix = new System.Windows.Forms.TextBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.chkSuffix = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCustomSampleFileOutput = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveAndExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvSelectedConfig = new System.Windows.Forms.DataGridView();
            this.DID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIDName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldrBrowseDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tooltipDIDConfiguration = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMultipageTIFF = new System.Windows.Forms.RadioButton();
            this.rbPDF = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedConfig)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSingleTitle
            // 
            this.lblSingleTitle.AutoSize = true;
            this.lblSingleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingleTitle.Location = new System.Drawing.Point(16, 9);
            this.lblSingleTitle.Name = "lblSingleTitle";
            this.lblSingleTitle.Size = new System.Drawing.Size(108, 13);
            this.lblSingleTitle.TabIndex = 0;
            this.lblSingleTitle.Text = "DID Configuration";
            // 
            // lblSingleDIDAndName
            // 
            this.lblSingleDIDAndName.AutoSize = true;
            this.lblSingleDIDAndName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingleDIDAndName.Location = new System.Drawing.Point(16, 25);
            this.lblSingleDIDAndName.Name = "lblSingleDIDAndName";
            this.lblSingleDIDAndName.Size = new System.Drawing.Size(59, 20);
            this.lblSingleDIDAndName.TabIndex = 1;
            this.lblSingleDIDAndName.Text = "label1";
            // 
            // rbUserDefaultSetting
            // 
            this.rbUserDefaultSetting.AutoSize = true;
            this.rbUserDefaultSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUserDefaultSetting.Location = new System.Drawing.Point(8, 22);
            this.rbUserDefaultSetting.Name = "rbUserDefaultSetting";
            this.rbUserDefaultSetting.Size = new System.Drawing.Size(122, 17);
            this.rbUserDefaultSetting.TabIndex = 2;
            this.rbUserDefaultSetting.TabStop = true;
            this.rbUserDefaultSetting.Text = "Use Default Settings";
            this.tooltipDIDConfiguration.SetToolTip(this.rbUserDefaultSetting, "It will set default DID configuration");
            this.rbUserDefaultSetting.UseVisualStyleBackColor = true;
            // 
            // rbCustomSettings
            // 
            this.rbCustomSettings.AutoSize = true;
            this.rbCustomSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCustomSettings.Location = new System.Drawing.Point(10, 19);
            this.rbCustomSettings.Name = "rbCustomSettings";
            this.rbCustomSettings.Size = new System.Drawing.Size(123, 17);
            this.rbCustomSettings.TabIndex = 3;
            this.rbCustomSettings.TabStop = true;
            this.rbCustomSettings.Text = "Use Custom Settings";
            this.rbCustomSettings.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Default Fax Image Type";
            // 
            // lblDefaultFaxImageType
            // 
            this.lblDefaultFaxImageType.AutoSize = true;
            this.lblDefaultFaxImageType.Location = new System.Drawing.Point(6, 62);
            this.lblDefaultFaxImageType.Name = "lblDefaultFaxImageType";
            this.lblDefaultFaxImageType.Size = new System.Drawing.Size(35, 13);
            this.lblDefaultFaxImageType.TabIndex = 5;
            this.lblDefaultFaxImageType.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Default Fax Image Save Path";
            // 
            // lblDefaultFaxImageSavePath
            // 
            this.lblDefaultFaxImageSavePath.AutoSize = true;
            this.lblDefaultFaxImageSavePath.Location = new System.Drawing.Point(222, 62);
            this.lblDefaultFaxImageSavePath.Name = "lblDefaultFaxImageSavePath";
            this.lblDefaultFaxImageSavePath.Size = new System.Drawing.Size(35, 13);
            this.lblDefaultFaxImageSavePath.TabIndex = 7;
            this.lblDefaultFaxImageSavePath.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "File Prefix:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Suffix file with: ";
            // 
            // lblDefaultPrefix
            // 
            this.lblDefaultPrefix.AutoSize = true;
            this.lblDefaultPrefix.Location = new System.Drawing.Point(7, 98);
            this.lblDefaultPrefix.Name = "lblDefaultPrefix";
            this.lblDefaultPrefix.Size = new System.Drawing.Size(35, 13);
            this.lblDefaultPrefix.TabIndex = 10;
            this.lblDefaultPrefix.Text = "label1";
            // 
            // lblDefaultSuffix
            // 
            this.lblDefaultSuffix.AutoSize = true;
            this.lblDefaultSuffix.Location = new System.Drawing.Point(223, 98);
            this.lblDefaultSuffix.Name = "lblDefaultSuffix";
            this.lblDefaultSuffix.Size = new System.Drawing.Size(35, 13);
            this.lblDefaultSuffix.TabIndex = 11;
            this.lblDefaultSuffix.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sample file output";
            // 
            // lblSampleFileOutput
            // 
            this.lblSampleFileOutput.AutoSize = true;
            this.lblSampleFileOutput.Location = new System.Drawing.Point(7, 142);
            this.lblSampleFileOutput.Name = "lblSampleFileOutput";
            this.lblSampleFileOutput.Size = new System.Drawing.Size(35, 13);
            this.lblSampleFileOutput.TabIndex = 13;
            this.lblSampleFileOutput.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(214, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fax Image Save Path";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtDefaultImageSavePath
            // 
            this.txtDefaultImageSavePath.Location = new System.Drawing.Point(217, 68);
            this.txtDefaultImageSavePath.Name = "txtDefaultImageSavePath";
            this.txtDefaultImageSavePath.Size = new System.Drawing.Size(127, 20);
            this.txtDefaultImageSavePath.TabIndex = 18;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(350, 68);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(56, 23);
            this.btnBrowse.TabIndex = 19;
            this.btnBrowse.Text = "Browse";
            this.tooltipDIDConfiguration.SetToolTip(this.btnBrowse, "Browse folder for saving image path");
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // chkAddPrefix
            // 
            this.chkAddPrefix.AutoSize = true;
            this.chkAddPrefix.Location = new System.Drawing.Point(6, 116);
            this.chkAddPrefix.Name = "chkAddPrefix";
            this.chkAddPrefix.Size = new System.Drawing.Size(89, 17);
            this.chkAddPrefix.TabIndex = 20;
            this.chkAddPrefix.Text = "Add file prefix";
            this.chkAddPrefix.UseVisualStyleBackColor = true;
            // 
            // txtFilePrefix
            // 
            this.txtFilePrefix.Location = new System.Drawing.Point(125, 114);
            this.txtFilePrefix.Name = "txtFilePrefix";
            this.txtFilePrefix.Size = new System.Drawing.Size(278, 20);
            this.txtFilePrefix.TabIndex = 21;
            this.tooltipDIDConfiguration.SetToolTip(this.txtFilePrefix, "Set prefix for file");
            this.txtFilePrefix.TextChanged += new System.EventHandler(this.txtFilePrefix_TextChanged);
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(125, 145);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(278, 20);
            this.txtSuffix.TabIndex = 23;
            this.tooltipDIDConfiguration.SetToolTip(this.txtSuffix, "Set suffix for file");
            // 
            // chkSuffix
            // 
            this.chkSuffix.AutoSize = true;
            this.chkSuffix.Location = new System.Drawing.Point(5, 148);
            this.chkSuffix.Name = "chkSuffix";
            this.chkSuffix.Size = new System.Drawing.Size(88, 17);
            this.chkSuffix.TabIndex = 22;
            this.chkSuffix.Text = "Add file suffix";
            this.chkSuffix.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Sample file output";
            // 
            // lblCustomSampleFileOutput
            // 
            this.lblCustomSampleFileOutput.AutoSize = true;
            this.lblCustomSampleFileOutput.Location = new System.Drawing.Point(6, 195);
            this.lblCustomSampleFileOutput.Name = "lblCustomSampleFileOutput";
            this.lblCustomSampleFileOutput.Size = new System.Drawing.Size(35, 13);
            this.lblCustomSampleFileOutput.TabIndex = 25;
            this.lblCustomSampleFileOutput.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveAndExit);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 38);
            this.panel1.TabIndex = 26;
            // 
            // btnSaveAndExit
            // 
            this.btnSaveAndExit.Location = new System.Drawing.Point(588, 8);
            this.btnSaveAndExit.Name = "btnSaveAndExit";
            this.btnSaveAndExit.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAndExit.TabIndex = 1;
            this.btnSaveAndExit.Text = "Save & Exit";
            this.tooltipDIDConfiguration.SetToolTip(this.btnSaveAndExit, "Save your configuration changes");
            this.btnSaveAndExit.UseMnemonic = false;
            this.btnSaveAndExit.UseVisualStyleBackColor = true;
            this.btnSaveAndExit.Click += new System.EventHandler(this.btnSaveAndExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(494, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.tooltipDIDConfiguration.SetToolTip(this.btnCancel, "Discard your changes");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvSelectedConfig
            // 
            this.dgvSelectedConfig.AllowUserToAddRows = false;
            this.dgvSelectedConfig.AllowUserToDeleteRows = false;
            this.dgvSelectedConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DID,
            this.DIDName});
            this.dgvSelectedConfig.Location = new System.Drawing.Point(458, 53);
            this.dgvSelectedConfig.Name = "dgvSelectedConfig";
            this.dgvSelectedConfig.ReadOnly = true;
            this.dgvSelectedConfig.RowHeadersVisible = false;
            this.dgvSelectedConfig.Size = new System.Drawing.Size(205, 343);
            this.dgvSelectedConfig.TabIndex = 28;
            this.tooltipDIDConfiguration.SetToolTip(this.dgvSelectedConfig, "List of selected DIDs");
            // 
            // DID
            // 
            this.DID.DataPropertyName = "Did";
            this.DID.HeaderText = "DID";
            this.DID.Name = "DID";
            this.DID.ReadOnly = true;
            // 
            // DIDName
            // 
            this.DIDName.DataPropertyName = "Name";
            this.DIDName.HeaderText = "Name";
            this.DIDName.Name = "DIDName";
            this.DIDName.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblSampleFileOutput);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblDefaultFaxImageType);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblDefaultFaxImageSavePath);
            this.groupBox2.Controls.Add(this.rbUserDefaultSetting);
            this.groupBox2.Controls.Add(this.lblDefaultPrefix);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblDefaultSuffix);
            this.groupBox2.Location = new System.Drawing.Point(12, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 167);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Default Settings";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.rbCustomSettings);
            this.groupBox3.Controls.Add(this.lblCustomSampleFileOutput);
            this.groupBox3.Controls.Add(this.txtSuffix);
            this.groupBox3.Controls.Add(this.btnBrowse);
            this.groupBox3.Controls.Add(this.txtFilePrefix);
            this.groupBox3.Controls.Add(this.txtDefaultImageSavePath);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.chkSuffix);
            this.groupBox3.Controls.Add(this.chkAddPrefix);
            this.groupBox3.Location = new System.Drawing.Point(12, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 230);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custom Settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMultipageTIFF);
            this.groupBox1.Controls.Add(this.rbPDF);
            this.groupBox1.Location = new System.Drawing.Point(10, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 51);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save Fax Image Type";
            // 
            // rbMultipageTIFF
            // 
            this.rbMultipageTIFF.AutoSize = true;
            this.rbMultipageTIFF.Location = new System.Drawing.Point(14, 20);
            this.rbMultipageTIFF.Name = "rbMultipageTIFF";
            this.rbMultipageTIFF.Size = new System.Drawing.Size(96, 17);
            this.rbMultipageTIFF.TabIndex = 15;
            this.rbMultipageTIFF.TabStop = true;
            this.rbMultipageTIFF.Text = "Multipage TIFF";
            this.rbMultipageTIFF.UseVisualStyleBackColor = true;
            // 
            // rbPDF
            // 
            this.rbPDF.AutoSize = true;
            this.rbPDF.Location = new System.Drawing.Point(118, 20);
            this.rbPDF.Name = "rbPDF";
            this.rbPDF.Size = new System.Drawing.Size(46, 17);
            this.rbPDF.TabIndex = 16;
            this.rbPDF.TabStop = true;
            this.rbPDF.Text = "PDF";
            this.rbPDF.UseVisualStyleBackColor = true;
            // 
            // SingleDIDConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(675, 505);
            this.Controls.Add(this.dgvSelectedConfig);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSingleDIDAndName);
            this.Controls.Add(this.lblSingleTitle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SingleDIDConfiguration";
            this.Text = "DID Configuration";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedConfig)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSingleTitle;
        private System.Windows.Forms.Label lblSingleDIDAndName;
        private System.Windows.Forms.RadioButton rbUserDefaultSetting;
        private System.Windows.Forms.RadioButton rbCustomSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDefaultFaxImageType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDefaultFaxImageSavePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDefaultPrefix;
        private System.Windows.Forms.Label lblDefaultSuffix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSampleFileOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDefaultImageSavePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.CheckBox chkAddPrefix;
        private System.Windows.Forms.TextBox txtFilePrefix;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.CheckBox chkSuffix;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCustomSampleFileOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveAndExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvSelectedConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn DID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIDName;
        private System.Windows.Forms.FolderBrowserDialog fldrBrowseDialog;
        private System.Windows.Forms.ToolTip tooltipDIDConfiguration;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbPDF;
        private System.Windows.Forms.RadioButton rbMultipageTIFF;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}