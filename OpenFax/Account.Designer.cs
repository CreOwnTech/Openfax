namespace OpenFax
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.lnkWhereAPI = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbMultipageTiff = new System.Windows.Forms.RadioButton();
            this.rbPDF = new System.Windows.Forms.RadioButton();
            this.fileDailogueImagePath = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSaveImagePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.chkDefaultPrefix = new System.Windows.Forms.CheckBox();
            this.chkDefaultSuffix = new System.Windows.Forms.CheckBox();
            this.txtDefaultPrefix = new System.Windows.Forms.TextBox();
            this.txtDefaultSuffix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCheckNewFaxes = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AccountToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Openfax Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Openfax API key";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(13, 33);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(144, 20);
            this.txtAccountNumber.TabIndex = 2;
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Location = new System.Drawing.Point(186, 33);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(144, 20);
            this.txtAPIKey.TabIndex = 3;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(368, 31);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(112, 22);
            this.btnTestConnection.TabIndex = 4;
            this.btnTestConnection.Text = "Test Connection";
            this.AccountToolTip.SetToolTip(this.btnTestConnection, "Test your connection by account number and API key");
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // lnkWhereAPI
            // 
            this.lnkWhereAPI.ActiveLinkColor = System.Drawing.Color.PeachPuff;
            this.lnkWhereAPI.AutoSize = true;
            this.lnkWhereAPI.Location = new System.Drawing.Point(365, 68);
            this.lnkWhereAPI.Name = "lnkWhereAPI";
            this.lnkWhereAPI.Size = new System.Drawing.Size(142, 13);
            this.lnkWhereAPI.TabIndex = 5;
            this.lnkWhereAPI.TabStop = true;
            this.lnkWhereAPI.Text = "Where do I find my API key?";
            this.AccountToolTip.SetToolTip(this.lnkWhereAPI, "It will give you information about how to get your API key");
            this.lnkWhereAPI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWhereAPI_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Default Fax Image Output Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Default Save Fax Image Type";
            // 
            // rbMultipageTiff
            // 
            this.rbMultipageTiff.AutoSize = true;
            this.rbMultipageTiff.Location = new System.Drawing.Point(9, 53);
            this.rbMultipageTiff.Name = "rbMultipageTiff";
            this.rbMultipageTiff.Size = new System.Drawing.Size(96, 17);
            this.rbMultipageTiff.TabIndex = 8;
            this.rbMultipageTiff.Text = "Multipage TIFF";
            this.rbMultipageTiff.UseVisualStyleBackColor = true;
            // 
            // rbPDF
            // 
            this.rbPDF.AutoSize = true;
            this.rbPDF.Checked = true;
            this.rbPDF.Location = new System.Drawing.Point(111, 53);
            this.rbPDF.Name = "rbPDF";
            this.rbPDF.Size = new System.Drawing.Size(46, 17);
            this.rbPDF.TabIndex = 9;
            this.rbPDF.TabStop = true;
            this.rbPDF.Text = "PDF";
            this.rbPDF.UseVisualStyleBackColor = true;
            // 
            // txtSaveImagePath
            // 
            this.txtSaveImagePath.Location = new System.Drawing.Point(364, 50);
            this.txtSaveImagePath.Name = "txtSaveImagePath";
            this.txtSaveImagePath.Size = new System.Drawing.Size(199, 20);
            this.txtSaveImagePath.TabIndex = 10;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(572, 48);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(79, 23);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.AccountToolTip.SetToolTip(this.btnBrowse, "Browse Folder for Fax Save Image Path");
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // chkDefaultPrefix
            // 
            this.chkDefaultPrefix.AutoSize = true;
            this.chkDefaultPrefix.Location = new System.Drawing.Point(11, 115);
            this.chkDefaultPrefix.Name = "chkDefaultPrefix";
            this.chkDefaultPrefix.Size = new System.Drawing.Size(124, 17);
            this.chkDefaultPrefix.TabIndex = 12;
            this.chkDefaultPrefix.Text = "Add default file prefix";
            this.chkDefaultPrefix.UseVisualStyleBackColor = true;
            // 
            // chkDefaultSuffix
            // 
            this.chkDefaultSuffix.AutoSize = true;
            this.chkDefaultSuffix.Location = new System.Drawing.Point(11, 146);
            this.chkDefaultSuffix.Name = "chkDefaultSuffix";
            this.chkDefaultSuffix.Size = new System.Drawing.Size(123, 17);
            this.chkDefaultSuffix.TabIndex = 13;
            this.chkDefaultSuffix.Text = "Add default file suffix";
            this.chkDefaultSuffix.UseVisualStyleBackColor = true;
            // 
            // txtDefaultPrefix
            // 
            this.txtDefaultPrefix.Location = new System.Drawing.Point(154, 112);
            this.txtDefaultPrefix.Name = "txtDefaultPrefix";
            this.txtDefaultPrefix.Size = new System.Drawing.Size(144, 20);
            this.txtDefaultPrefix.TabIndex = 14;
            this.txtDefaultPrefix.TextChanged += new System.EventHandler(this.txtDefaultPrefix_TextChanged);
            // 
            // txtDefaultSuffix
            // 
            this.txtDefaultSuffix.Location = new System.Drawing.Point(154, 146);
            this.txtDefaultSuffix.Name = "txtDefaultSuffix";
            this.txtDefaultSuffix.Size = new System.Drawing.Size(144, 20);
            this.txtDefaultSuffix.TabIndex = 15;
            this.txtDefaultSuffix.TextChanged += new System.EventHandler(this.txtDefaultSuffix_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Check for new faxes";
            // 
            // cmbCheckNewFaxes
            // 
            this.cmbCheckNewFaxes.FormattingEnabled = true;
            this.cmbCheckNewFaxes.Items.AddRange(new object[] {
            "Every 2 Minutes",
            "Every 5 Minutes",
            "Every 15 Minutes",
            "Every 30 Minutes",
            "Every 1 hour"});
            this.cmbCheckNewFaxes.Location = new System.Drawing.Point(507, 116);
            this.cmbCheckNewFaxes.Name = "cmbCheckNewFaxes";
            this.cmbCheckNewFaxes.Size = new System.Drawing.Size(144, 21);
            this.cmbCheckNewFaxes.TabIndex = 17;
            this.AccountToolTip.SetToolTip(this.cmbCheckNewFaxes, "It is the time for checking new faxes ");
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(454, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 29);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.AccountToolTip.SetToolTip(this.btnCancel, "Discard your changes");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(569, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 29);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save & Exit";
            this.AccountToolTip.SetToolTip(this.btnSave, "It will save your changes and then exit");
            this.btnSave.UseMnemonic = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 40);
            this.panel1.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAccountNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAPIKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lnkWhereAPI);
            this.groupBox1.Controls.Add(this.btnTestConnection);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSaveImagePath);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rbPDF);
            this.groupBox2.Controls.Add(this.rbMultipageTiff);
            this.groupBox2.Controls.Add(this.txtDefaultPrefix);
            this.groupBox2.Controls.Add(this.chkDefaultPrefix);
            this.groupBox2.Controls.Add(this.cmbCheckNewFaxes);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.txtDefaultSuffix);
            this.groupBox2.Controls.Add(this.chkDefaultSuffix);
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 186);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Default Fax Configuration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(361, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Windows Service Interval";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "File Name Modifications";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Account && Default Configuration";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(691, 401);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Account";
            this.Text = "Openfax Account";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtAPIKey;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.LinkLabel lnkWhereAPI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbMultipageTiff;
        private System.Windows.Forms.RadioButton rbPDF;
        private System.Windows.Forms.FolderBrowserDialog fileDailogueImagePath;
        private System.Windows.Forms.TextBox txtSaveImagePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.CheckBox chkDefaultPrefix;
        private System.Windows.Forms.CheckBox chkDefaultSuffix;
        private System.Windows.Forms.TextBox txtDefaultPrefix;
        private System.Windows.Forms.TextBox txtDefaultSuffix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCheckNewFaxes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip AccountToolTip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}