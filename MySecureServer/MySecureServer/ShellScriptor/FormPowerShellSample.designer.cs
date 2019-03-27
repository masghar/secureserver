namespace MySecureServer.ShellScriptor
{
    partial class FormPowerShellSample
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxScript = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSampleScripts = new System.Windows.Forms.ComboBox();
            this.cmbtest = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStopScript = new System.Windows.Forms.Button();
            this.buttonStartScript = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.timerOutput = new System.Windows.Forms.Timer(this.components);
            this.iTalk_LinkLabel2 = new iTalk.iTalk_LinkLabel();
            this.iTalk_LinkLabel3 = new iTalk.iTalk_LinkLabel();
            this.iTalk_LinkLabel1 = new iTalk.iTalk_LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1029, 603);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxScript);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(11, 10, 11, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.groupBox1.Size = new System.Drawing.Size(1029, 341);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Script";
            // 
            // textBoxScript
            // 
            this.textBoxScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxScript.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScript.Location = new System.Drawing.Point(11, 25);
            this.textBoxScript.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxScript.MaxLength = 0;
            this.textBoxScript.Multiline = true;
            this.textBoxScript.Name = "textBoxScript";
            this.textBoxScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxScript.Size = new System.Drawing.Size(1007, 240);
            this.textBoxScript.TabIndex = 0;
            this.textBoxScript.Text = "New-Item -Name \"FEATURE_ENABLE_PRINT_INFO_DISCLOSURE_FIX\" -Path \'hklm:\\SOFTWARE\\W" +
    "OW6432Node\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\\' -type Directory";
            this.textBoxScript.WordWrap = false;
            this.textBoxScript.TextChanged += new System.EventHandler(this.textBoxScript_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iTalk_LinkLabel3);
            this.panel1.Controls.Add(this.iTalk_LinkLabel2);
            this.panel1.Controls.Add(this.iTalk_LinkLabel1);
            this.panel1.Controls.Add(this.comboBoxSampleScripts);
            this.panel1.Controls.Add(this.cmbtest);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonStopScript);
            this.panel1.Controls.Add(this.buttonStartScript);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(11, 265);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 66);
            this.panel1.TabIndex = 2;
            // 
            // comboBoxSampleScripts
            // 
            this.comboBoxSampleScripts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSampleScripts.FormattingEnabled = true;
            this.comboBoxSampleScripts.Location = new System.Drawing.Point(148, 38);
            this.comboBoxSampleScripts.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSampleScripts.Name = "comboBoxSampleScripts";
            this.comboBoxSampleScripts.Size = new System.Drawing.Size(357, 24);
            this.comboBoxSampleScripts.TabIndex = 3;
            // 
            // cmbtest
            // 
            this.cmbtest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtest.FormattingEnabled = true;
            this.cmbtest.Location = new System.Drawing.Point(148, 7);
            this.cmbtest.Name = "cmbtest";
            this.cmbtest.Size = new System.Drawing.Size(357, 24);
            this.cmbtest.TabIndex = 2;
            this.cmbtest.SelectedIndexChanged += new System.EventHandler(this.cmbtest_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loaded Scripts";
            // 
            // buttonStopScript
            // 
            this.buttonStopScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStopScript.BackColor = System.Drawing.Color.Crimson;
            this.buttonStopScript.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStopScript.Location = new System.Drawing.Point(881, 7);
            this.buttonStopScript.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStopScript.Name = "buttonStopScript";
            this.buttonStopScript.Size = new System.Drawing.Size(127, 38);
            this.buttonStopScript.TabIndex = 2;
            this.buttonStopScript.Text = "Sto&p Script";
            this.buttonStopScript.UseVisualStyleBackColor = false;
            this.buttonStopScript.Click += new System.EventHandler(this.buttonStopScript_Click);
            // 
            // buttonStartScript
            // 
            this.buttonStartScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartScript.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonStartScript.Location = new System.Drawing.Point(746, 7);
            this.buttonStartScript.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartScript.Name = "buttonStartScript";
            this.buttonStartScript.Size = new System.Drawing.Size(127, 38);
            this.buttonStartScript.TabIndex = 1;
            this.buttonStartScript.Text = "&Run Script";
            this.buttonStartScript.UseVisualStyleBackColor = false;
            this.buttonStartScript.Click += new System.EventHandler(this.buttonStartScript_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxOutput);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.groupBox2.Size = new System.Drawing.Size(1029, 257);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOutput.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOutput.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.HorizontalScrollbar = true;
            this.listBoxOutput.ItemHeight = 14;
            this.listBoxOutput.Location = new System.Drawing.Point(11, 25);
            this.listBoxOutput.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.ScrollAlwaysVisible = true;
            this.listBoxOutput.Size = new System.Drawing.Size(1007, 222);
            this.listBoxOutput.TabIndex = 1;
            // 
            // timerOutput
            // 
            this.timerOutput.Enabled = true;
            this.timerOutput.Tick += new System.EventHandler(this.timerOutput_Tick);
            // 
            // iTalk_LinkLabel2
            // 
            this.iTalk_LinkLabel2.ActiveLinkColor = System.Drawing.Color.Blue;
            this.iTalk_LinkLabel2.AutoSize = true;
            this.iTalk_LinkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_LinkLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.iTalk_LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.iTalk_LinkLabel2.Location = new System.Drawing.Point(518, 38);
            this.iTalk_LinkLabel2.Name = "iTalk_LinkLabel2";
            this.iTalk_LinkLabel2.Size = new System.Drawing.Size(66, 19);
            this.iTalk_LinkLabel2.TabIndex = 6;
            this.iTalk_LinkLabel2.TabStop = true;
            this.iTalk_LinkLabel2.Text = "GP Policy";
            this.iTalk_LinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(202)))));
            // 
            // iTalk_LinkLabel3
            // 
            this.iTalk_LinkLabel3.ActiveLinkColor = System.Drawing.Color.Blue;
            this.iTalk_LinkLabel3.AutoSize = true;
            this.iTalk_LinkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_LinkLabel3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_LinkLabel3.Image = global::MySecureServer.Properties.Resources.MetroUI_Folder_OS_Security_Denied_icon;
            this.iTalk_LinkLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.iTalk_LinkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.iTalk_LinkLabel3.Location = new System.Drawing.Point(608, 10);
            this.iTalk_LinkLabel3.Name = "iTalk_LinkLabel3";
            this.iTalk_LinkLabel3.Size = new System.Drawing.Size(128, 19);
            this.iTalk_LinkLabel3.TabIndex = 7;
            this.iTalk_LinkLabel3.TabStop = true;
            this.iTalk_LinkLabel3.Text = "        Security Policy";
            this.iTalk_LinkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(202)))));
            this.iTalk_LinkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.iTalk_LinkLabel3_LinkClicked);
            // 
            // iTalk_LinkLabel1
            // 
            this.iTalk_LinkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.iTalk_LinkLabel1.AutoSize = true;
            this.iTalk_LinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_LinkLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_LinkLabel1.Image = global::MySecureServer.Properties.Resources.Groups_icon;
            this.iTalk_LinkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.iTalk_LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.iTalk_LinkLabel1.Location = new System.Drawing.Point(517, 9);
            this.iTalk_LinkLabel1.Name = "iTalk_LinkLabel1";
            this.iTalk_LinkLabel1.Size = new System.Drawing.Size(90, 19);
            this.iTalk_LinkLabel1.TabIndex = 5;
            this.iTalk_LinkLabel1.TabStop = true;
            this.iTalk_LinkLabel1.Text = "      GP Policy";
            this.iTalk_LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(202)))));
            this.iTalk_LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.iTalk_LinkLabel1_LinkClicked);
            // 
            // FormPowerShellSample
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 603);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPowerShellSample";
            this.Text = "Config Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPowerShellSample_FormClosing);
            this.Load += new System.EventHandler(this.FormPowerShellSample_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormPowerShellSample_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormPowerShellSample_DragEnter);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxScript;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStartScript;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStopScript;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Timer timerOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSampleScripts;
        private System.Windows.Forms.ComboBox cmbtest;
        private iTalk.iTalk_LinkLabel iTalk_LinkLabel1;
        private iTalk.iTalk_LinkLabel iTalk_LinkLabel3;
        private iTalk.iTalk_LinkLabel iTalk_LinkLabel2;
    }
}

