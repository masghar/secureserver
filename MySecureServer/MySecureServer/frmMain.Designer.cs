namespace MySecureServer
{
    partial class frmMain
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
            iTalk.ControlRenderer controlRenderer1 = new iTalk.ControlRenderer();
            iTalk.MSColorTable msColorTable1 = new iTalk.MSColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgSettings = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtSearchSetings = new iTalk.iTalk_TextBox_Big();
            this.iTalk_GroupBox2 = new iTalk.iTalk_GroupBox();
            this.btnRunConfig = new iTalk.iTalk_Button_2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.iTalk_GroupBox1 = new iTalk.iTalk_GroupBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdates = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnProxy = new System.Windows.Forms.Button();
            this.btnAdapters = new System.Windows.Forms.Button();
            this.outlook = new System.Windows.Forms.PictureBox();
            this.excel = new System.Windows.Forms.PictureBox();
            this.word = new System.Windows.Forms.PictureBox();
            this.notepad = new System.Windows.Forms.PictureBox();
            this.iTalk_StatusStrip1 = new iTalk.iTalk_StatusStrip();
            this.lbls_machine_name = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.iTalk_GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.iTalk_GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.word)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notepad)).BeginInit();
            this.iTalk_StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1347, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOffToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.logOffToolStripMenuItem.Text = "Log Off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptionToolStripMenuItem,
            this.manageConfigToolStripMenuItem,
            this.manageSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.settingsToolStripMenuItem.Text = "Administration";
            // 
            // encryptionToolStripMenuItem
            // 
            this.encryptionToolStripMenuItem.Name = "encryptionToolStripMenuItem";
            this.encryptionToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.encryptionToolStripMenuItem.Text = "Encryption";
            this.encryptionToolStripMenuItem.Click += new System.EventHandler(this.encryptionToolStripMenuItem_Click);
            // 
            // manageConfigToolStripMenuItem
            // 
            this.manageConfigToolStripMenuItem.Name = "manageConfigToolStripMenuItem";
            this.manageConfigToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.manageConfigToolStripMenuItem.Text = "Manage Config";
            this.manageConfigToolStripMenuItem.Click += new System.EventHandler(this.manageConfigToolStripMenuItem_Click);
            // 
            // manageSettingsToolStripMenuItem
            // 
            this.manageSettingsToolStripMenuItem.Name = "manageSettingsToolStripMenuItem";
            this.manageSettingsToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.manageSettingsToolStripMenuItem.Text = "Manage Settings";
            this.manageSettingsToolStripMenuItem.Click += new System.EventHandler(this.manageSettingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // dgSettings
            // 
            this.dgSettings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            this.dgSettings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSettings.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSettings.ColumnHeadersVisible = false;
            this.dgSettings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgSettings.Location = new System.Drawing.Point(1005, 189);
            this.dgSettings.MultiSelect = false;
            this.dgSettings.Name = "dgSettings";
            this.dgSettings.ReadOnly = true;
            this.dgSettings.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgSettings.RowHeadersVisible = false;
            this.dgSettings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgSettings.RowTemplate.Height = 24;
            this.dgSettings.ShowEditingIcon = false;
            this.dgSettings.Size = new System.Drawing.Size(332, 472);
            this.dgSettings.TabIndex = 1;
            this.dgSettings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSettings_CellContentClick);
            this.dgSettings.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgSettings_KeyDown);
            this.dgSettings.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgSettings_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(1054, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Settings Manager";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MySecureServer.Properties.Resources.search_icon;
            this.pictureBox5.Location = new System.Drawing.Point(1288, 141);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 46);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // txtSearchSetings
            // 
            this.txtSearchSetings.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchSetings.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSearchSetings.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchSetings.Image = null;
            this.txtSearchSetings.Location = new System.Drawing.Point(1005, 137);
            this.txtSearchSetings.MaxLength = 32767;
            this.txtSearchSetings.Multiline = false;
            this.txtSearchSetings.Name = "txtSearchSetings";
            this.txtSearchSetings.ReadOnly = false;
            this.txtSearchSetings.Size = new System.Drawing.Size(287, 46);
            this.txtSearchSetings.TabIndex = 0;
            this.txtSearchSetings.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchSetings.UseSystemPasswordChar = false;
            this.txtSearchSetings.TextChanged += new System.EventHandler(this.txtSearchSetings_TextChanged);
            // 
            // iTalk_GroupBox2
            // 
            this.iTalk_GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox2.Controls.Add(this.btnRunConfig);
            this.iTalk_GroupBox2.Controls.Add(this.dataGridView1);
            this.iTalk_GroupBox2.Controls.Add(this.button1);
            this.iTalk_GroupBox2.Location = new System.Drawing.Point(585, 64);
            this.iTalk_GroupBox2.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox2.Name = "iTalk_GroupBox2";
            this.iTalk_GroupBox2.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox2.Size = new System.Drawing.Size(412, 598);
            this.iTalk_GroupBox2.TabIndex = 5;
            this.iTalk_GroupBox2.Text = "Hardening Settings";
            this.iTalk_GroupBox2.Click += new System.EventHandler(this.iTalk_GroupBox2_Click);
            // 
            // btnRunConfig
            // 
            this.btnRunConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnRunConfig.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnRunConfig.ForeColor = System.Drawing.Color.White;
            this.btnRunConfig.Image = global::MySecureServer.Properties.Resources.app_settings_icon;
            this.btnRunConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunConfig.Location = new System.Drawing.Point(57, 39);
            this.btnRunConfig.Name = "btnRunConfig";
            this.btnRunConfig.Size = new System.Drawing.Size(305, 69);
            this.btnRunConfig.TabIndex = 6;
            this.btnRunConfig.Text = "Config Sys";
            this.btnRunConfig.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRunConfig.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(367, 421);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iTalk_GroupBox1
            // 
            this.iTalk_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox1.Controls.Add(this.btnCapture);
            this.iTalk_GroupBox1.Controls.Add(this.label5);
            this.iTalk_GroupBox1.Controls.Add(this.pictureBox4);
            this.iTalk_GroupBox1.Controls.Add(this.button9);
            this.iTalk_GroupBox1.Controls.Add(this.button8);
            this.iTalk_GroupBox1.Controls.Add(this.button7);
            this.iTalk_GroupBox1.Controls.Add(this.button6);
            this.iTalk_GroupBox1.Controls.Add(this.button5);
            this.iTalk_GroupBox1.Controls.Add(this.label4);
            this.iTalk_GroupBox1.Controls.Add(this.label3);
            this.iTalk_GroupBox1.Controls.Add(this.label2);
            this.iTalk_GroupBox1.Controls.Add(this.pictureBox3);
            this.iTalk_GroupBox1.Controls.Add(this.pictureBox2);
            this.iTalk_GroupBox1.Controls.Add(this.pictureBox1);
            this.iTalk_GroupBox1.Controls.Add(this.btnUpdates);
            this.iTalk_GroupBox1.Controls.Add(this.label1);
            this.iTalk_GroupBox1.Controls.Add(this.button4);
            this.iTalk_GroupBox1.Controls.Add(this.button3);
            this.iTalk_GroupBox1.Controls.Add(this.button2);
            this.iTalk_GroupBox1.Controls.Add(this.button10);
            this.iTalk_GroupBox1.Controls.Add(this.btnProxy);
            this.iTalk_GroupBox1.Controls.Add(this.btnAdapters);
            this.iTalk_GroupBox1.Controls.Add(this.outlook);
            this.iTalk_GroupBox1.Controls.Add(this.excel);
            this.iTalk_GroupBox1.Controls.Add(this.word);
            this.iTalk_GroupBox1.Controls.Add(this.notepad);
            this.iTalk_GroupBox1.Location = new System.Drawing.Point(26, 46);
            this.iTalk_GroupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox1.Name = "iTalk_GroupBox1";
            this.iTalk_GroupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox1.Size = new System.Drawing.Size(542, 616);
            this.iTalk_GroupBox1.TabIndex = 4;
            this.iTalk_GroupBox1.Text = "System Utilities";
            this.iTalk_GroupBox1.Click += new System.EventHandler(this.iTalk_GroupBox1_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(433, 578);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(100, 38);
            this.btnCapture.TabIndex = 46;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 547);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Lock";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MySecureServer.Properties.Resources.PadLock_icon;
            this.pictureBox4.Location = new System.Drawing.Point(386, 490);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 62);
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // button9
            // 
            this.button9.Image = global::MySecureServer.Properties.Resources.systempro;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(273, 424);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(255, 55);
            this.button9.TabIndex = 43;
            this.button9.Text = "MS Info";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Image = global::MySecureServer.Properties.Resources.Sound_on_icon;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(13, 424);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(255, 55);
            this.button8.TabIndex = 42;
            this.button8.Text = "Audio Settings";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Image = global::MySecureServer.Properties.Resources.App_service_manager_icon;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(273, 313);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(255, 55);
            this.button7.TabIndex = 41;
            this.button7.Text = "Services";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Image = global::MySecureServer.Properties.Resources.Computer_icon;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(273, 258);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(255, 55);
            this.button6.TabIndex = 40;
            this.button6.Text = "My Computer";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Image = global::MySecureServer.Properties.Resources.Apps_Task_Manager_alt_1_Metro_icon;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(273, 202);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(255, 55);
            this.button5.TabIndex = 39;
            this.button5.Text = "Task Manager";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 547);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Logoff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 546);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Restart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 546);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Shutdown";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MySecureServer.Properties.Resources.Sign_LogOff_icon;
            this.pictureBox3.Location = new System.Drawing.Point(298, 490);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 62);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MySecureServer.Properties.Resources.sleep_mode_prolonged_icon;
            this.pictureBox2.Location = new System.Drawing.Point(206, 490);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 62);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MySecureServer.Properties.Resources.shutdown_icon;
            this.pictureBox1.Location = new System.Drawing.Point(121, 490);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 62);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnUpdates
            // 
            this.btnUpdates.Image = global::MySecureServer.Properties.Resources.Apps_system_software_update_icon__1_;
            this.btnUpdates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdates.Location = new System.Drawing.Point(273, 143);
            this.btnUpdates.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdates.Name = "btnUpdates";
            this.btnUpdates.Size = new System.Drawing.Size(255, 55);
            this.btnUpdates.TabIndex = 31;
            this.btnUpdates.Text = "Windows Updates";
            this.btnUpdates.UseVisualStyleBackColor = true;
            this.btnUpdates.Click += new System.EventHandler(this.btnUpdates_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 528);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "                                 ";
            // 
            // button4
            // 
            this.button4.Image = global::MySecureServer.Properties.Resources.Devices_drive_removable_media_usb_pendrive_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(273, 368);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(255, 55);
            this.button4.TabIndex = 30;
            this.button4.Text = "Device Manager";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::MySecureServer.Properties.Resources.Devices_yast_HD_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(13, 368);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(255, 55);
            this.button3.TabIndex = 29;
            this.button3.Text = "System Properties";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::MySecureServer.Properties.Resources.fire;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(13, 313);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 55);
            this.button2.TabIndex = 28;
            this.button2.Text = "Windows Firewall";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button10
            // 
            this.button10.Image = global::MySecureServer.Properties.Resources.control;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(13, 258);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(255, 55);
            this.button10.TabIndex = 27;
            this.button10.Text = "Control Panel";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnProxy
            // 
            this.btnProxy.Image = global::MySecureServer.Properties.Resources.proxy;
            this.btnProxy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProxy.Location = new System.Drawing.Point(13, 202);
            this.btnProxy.Margin = new System.Windows.Forms.Padding(4);
            this.btnProxy.Name = "btnProxy";
            this.btnProxy.Size = new System.Drawing.Size(255, 55);
            this.btnProxy.TabIndex = 26;
            this.btnProxy.Text = "Proxy Settings";
            this.btnProxy.UseVisualStyleBackColor = true;
            this.btnProxy.Click += new System.EventHandler(this.btnProxy_Click);
            // 
            // btnAdapters
            // 
            this.btnAdapters.Image = global::MySecureServer.Properties.Resources.adapters;
            this.btnAdapters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdapters.Location = new System.Drawing.Point(14, 143);
            this.btnAdapters.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdapters.Name = "btnAdapters";
            this.btnAdapters.Size = new System.Drawing.Size(255, 55);
            this.btnAdapters.TabIndex = 25;
            this.btnAdapters.Text = "View Network Adapters";
            this.btnAdapters.UseVisualStyleBackColor = true;
            this.btnAdapters.Click += new System.EventHandler(this.btnAdapters_Click);
            // 
            // outlook
            // 
            this.outlook.Image = global::MySecureServer.Properties.Resources.Outlook_icon;
            this.outlook.Location = new System.Drawing.Point(352, 66);
            this.outlook.Margin = new System.Windows.Forms.Padding(4);
            this.outlook.Name = "outlook";
            this.outlook.Size = new System.Drawing.Size(65, 59);
            this.outlook.TabIndex = 8;
            this.outlook.TabStop = false;
            this.outlook.Click += new System.EventHandler(this.outlook_Click);
            // 
            // excel
            // 
            this.excel.Image = global::MySecureServer.Properties.Resources.Excel_icon;
            this.excel.Location = new System.Drawing.Point(274, 66);
            this.excel.Margin = new System.Windows.Forms.Padding(4);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(65, 59);
            this.excel.TabIndex = 9;
            this.excel.TabStop = false;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // word
            // 
            this.word.Image = global::MySecureServer.Properties.Resources.Word_icon;
            this.word.Location = new System.Drawing.Point(197, 66);
            this.word.Margin = new System.Windows.Forms.Padding(4);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(65, 59);
            this.word.TabIndex = 10;
            this.word.TabStop = false;
            this.word.Click += new System.EventHandler(this.word_Click);
            // 
            // notepad
            // 
            this.notepad.Image = global::MySecureServer.Properties.Resources.notepad_icon;
            this.notepad.Location = new System.Drawing.Point(120, 66);
            this.notepad.Margin = new System.Windows.Forms.Padding(4);
            this.notepad.Name = "notepad";
            this.notepad.Size = new System.Drawing.Size(65, 59);
            this.notepad.TabIndex = 11;
            this.notepad.TabStop = false;
            this.notepad.Click += new System.EventHandler(this.notepad_Click);
            // 
            // iTalk_StatusStrip1
            // 
            this.iTalk_StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.iTalk_StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbls_machine_name,
            this.lblStatusIP,
            this.toolStripStatusLabel1});
            this.iTalk_StatusStrip1.Location = new System.Drawing.Point(0, 677);
            this.iTalk_StatusStrip1.Name = "iTalk_StatusStrip1";
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            this.iTalk_StatusStrip1.Renderer = controlRenderer1;
            this.iTalk_StatusStrip1.Size = new System.Drawing.Size(1347, 25);
            this.iTalk_StatusStrip1.SizingGrip = false;
            this.iTalk_StatusStrip1.TabIndex = 3;
            this.iTalk_StatusStrip1.Text = "iTalk_StatusStrip1";
            // 
            // lbls_machine_name
            // 
            this.lbls_machine_name.ForeColor = System.Drawing.Color.Red;
            this.lbls_machine_name.Name = "lbls_machine_name";
            this.lbls_machine_name.Size = new System.Drawing.Size(76, 20);
            this.lbls_machine_name.Text = "MACHINR";
            // 
            // lblStatusIP
            // 
            this.lblStatusIP.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblStatusIP.Name = "lblStatusIP";
            this.lblStatusIP.Size = new System.Drawing.Size(21, 20);
            this.lblStatusIP.Text = "IP";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Lime;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(284, 20);
            this.toolStripStatusLabel1.Text = "Afiniti Hardening System - Dev by Zaheer";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MySecureServer.Properties.Resources.GettyImages_622184706;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1347, 702);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearchSetings);
            this.Controls.Add(this.dgSettings);
            this.Controls.Add(this.iTalk_GroupBox2);
            this.Controls.Add(this.iTalk_GroupBox1);
            this.Controls.Add(this.iTalk_StatusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Afiniti Hardening System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.iTalk_GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.iTalk_GroupBox1.ResumeLayout(false);
            this.iTalk_GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.word)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notepad)).EndInit();
            this.iTalk_StatusStrip1.ResumeLayout(false);
            this.iTalk_StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptionToolStripMenuItem;
        private iTalk.iTalk_StatusStrip iTalk_StatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbls_machine_name;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusIP;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private iTalk.iTalk_GroupBox iTalk_GroupBox1;
        private System.Windows.Forms.PictureBox outlook;
        private System.Windows.Forms.PictureBox excel;
        private System.Windows.Forms.PictureBox word;
        private System.Windows.Forms.PictureBox notepad;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpdates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnProxy;
        private System.Windows.Forms.Button btnAdapters;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private iTalk.iTalk_GroupBox iTalk_GroupBox2;
        private iTalk.iTalk_Button_2 btnRunConfig;
        private System.Windows.Forms.ToolStripMenuItem manageConfigToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgSettings;
        private iTalk.iTalk_TextBox_Big txtSearchSetings;
        private System.Windows.Forms.ToolStripMenuItem manageSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}