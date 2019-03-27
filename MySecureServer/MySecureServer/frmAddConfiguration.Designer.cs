namespace MySecureServer
{
    partial class frmSettingsManager
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgConfigs = new System.Windows.Forms.DataGridView();
            this.txtSearch = new iTalk.iTalk_TextBox_Small();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.btnRemoveConfig = new iTalk.iTalk_Button_2();
            this.btnUpdateConfig = new iTalk.iTalk_Button_2();
            this.iTalk_Button_21 = new iTalk.iTalk_Button_2();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.txtConfig_name = new iTalk.iTalk_TextBox_Small();
            this.txt_config = new iTalk.iTalk_RichTextBox();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConfigs)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MySecureServer.Properties.Resources.faq_migration;
            this.pictureBox1.Location = new System.Drawing.Point(174, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dgConfigs
            // 
            this.dgConfigs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgConfigs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConfigs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgConfigs.Location = new System.Drawing.Point(563, 273);
            this.dgConfigs.MultiSelect = false;
            this.dgConfigs.Name = "dgConfigs";
            this.dgConfigs.ReadOnly = true;
            this.dgConfigs.RowTemplate.Height = 24;
            this.dgConfigs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgConfigs.Size = new System.Drawing.Size(631, 281);
            this.dgConfigs.TabIndex = 6;
            this.dgConfigs.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgConfigs_CellContentDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(563, 217);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.Size = new System.Drawing.Size(631, 33);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(378, 69);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(459, 57);
            this.iTalk_HeaderLabel1.TabIndex = 9;
            this.iTalk_HeaderLabel1.Text = "Configuration Manager";
            // 
            // btnRemoveConfig
            // 
            this.btnRemoveConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveConfig.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnRemoveConfig.ForeColor = System.Drawing.Color.White;
            this.btnRemoveConfig.Image = global::MySecureServer.Properties.Resources.MetroUI_Folder_OS_Security_Denied_icon;
            this.btnRemoveConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveConfig.Location = new System.Drawing.Point(821, 583);
            this.btnRemoveConfig.Name = "btnRemoveConfig";
            this.btnRemoveConfig.Size = new System.Drawing.Size(252, 49);
            this.btnRemoveConfig.TabIndex = 8;
            this.btnRemoveConfig.Text = "Remove Config";
            this.btnRemoveConfig.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnUpdateConfig
            // 
            this.btnUpdateConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateConfig.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnUpdateConfig.ForeColor = System.Drawing.Color.White;
            this.btnUpdateConfig.Image = global::MySecureServer.Properties.Resources.proxy;
            this.btnUpdateConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateConfig.Location = new System.Drawing.Point(539, 583);
            this.btnUpdateConfig.Name = "btnUpdateConfig";
            this.btnUpdateConfig.Size = new System.Drawing.Size(265, 49);
            this.btnUpdateConfig.TabIndex = 7;
            this.btnUpdateConfig.Text = "Update Config";
            this.btnUpdateConfig.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // iTalk_Button_21
            // 
            this.iTalk_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_21.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_21.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_21.Image = global::MySecureServer.Properties.Resources.notepad_icon;
            this.iTalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_21.Location = new System.Drawing.Point(266, 583);
            this.iTalk_Button_21.Name = "iTalk_Button_21";
            this.iTalk_Button_21.Size = new System.Drawing.Size(258, 49);
            this.iTalk_Button_21.TabIndex = 4;
            this.iTalk_Button_21.Text = "Add Config";
            this.iTalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_21.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(12, 273);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(49, 19);
            this.iTalk_Label2.TabIndex = 3;
            this.iTalk_Label2.Text = "Config";
            // 
            // txtConfig_name
            // 
            this.txtConfig_name.BackColor = System.Drawing.Color.Transparent;
            this.txtConfig_name.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtConfig_name.ForeColor = System.Drawing.Color.DimGray;
            this.txtConfig_name.Location = new System.Drawing.Point(114, 217);
            this.txtConfig_name.MaxLength = 32767;
            this.txtConfig_name.Multiline = false;
            this.txtConfig_name.Name = "txtConfig_name";
            this.txtConfig_name.ReadOnly = false;
            this.txtConfig_name.Size = new System.Drawing.Size(425, 33);
            this.txtConfig_name.TabIndex = 2;
            this.txtConfig_name.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfig_name.UseSystemPasswordChar = false;
            // 
            // txt_config
            // 
            this.txt_config.AutoWordSelection = false;
            this.txt_config.BackColor = System.Drawing.Color.Transparent;
            this.txt_config.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_config.ForeColor = System.Drawing.Color.DimGray;
            this.txt_config.Location = new System.Drawing.Point(114, 273);
            this.txt_config.Name = "txt_config";
            this.txt_config.ReadOnly = false;
            this.txt_config.Size = new System.Drawing.Size(425, 281);
            this.txt_config.TabIndex = 1;
            this.txt_config.WordWrap = true;
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(12, 216);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(89, 19);
            this.iTalk_Label1.TabIndex = 0;
            this.iTalk_Label1.Text = "Config Name";
            // 
            // frmSettingsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1218, 664);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.iTalk_HeaderLabel1);
            this.Controls.Add(this.btnRemoveConfig);
            this.Controls.Add(this.btnUpdateConfig);
            this.Controls.Add(this.dgConfigs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iTalk_Button_21);
            this.Controls.Add(this.iTalk_Label2);
            this.Controls.Add(this.txtConfig_name);
            this.Controls.Add(this.txt_config);
            this.Controls.Add(this.iTalk_Label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettingsManager";
            this.Text = "Configuration Manager";
            this.Load += new System.EventHandler(this.frmAddConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConfigs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_RichTextBox txt_config;
        private iTalk.iTalk_TextBox_Small txtConfig_name;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_Button_2 iTalk_Button_21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgConfigs;
        private iTalk.iTalk_Button_2 btnUpdateConfig;
        private iTalk.iTalk_Button_2 btnRemoveConfig;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private iTalk.iTalk_TextBox_Small txtSearch;
    }
}