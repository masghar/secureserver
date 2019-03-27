namespace MySecureServer
{
    partial class frmAddSettings
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
            this.txtSearch = new iTalk.iTalk_TextBox_Small();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.dgConfigs = new System.Windows.Forms.DataGridView();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.txtConfig_name = new iTalk.iTalk_TextBox_Small();
            this.txt_config = new iTalk.iTalk_RichTextBox();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.btnRemoveConfig = new iTalk.iTalk_Button_2();
            this.btnUpdateConfig = new iTalk.iTalk_Button_2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iTalk_Button_21 = new iTalk.iTalk_Button_2();
            ((System.ComponentModel.ISupportInitialize)(this.dgConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(621, 233);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.Size = new System.Drawing.Size(631, 33);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(436, 85);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(352, 57);
            this.iTalk_HeaderLabel1.TabIndex = 20;
            this.iTalk_HeaderLabel1.Text = "Settings Manager";
            // 
            // dgConfigs
            // 
            this.dgConfigs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConfigs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgConfigs.Location = new System.Drawing.Point(621, 289);
            this.dgConfigs.Name = "dgConfigs";
            this.dgConfigs.ReadOnly = true;
            this.dgConfigs.RowTemplate.Height = 24;
            this.dgConfigs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgConfigs.Size = new System.Drawing.Size(631, 281);
            this.dgConfigs.TabIndex = 17;
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(70, 289);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(49, 19);
            this.iTalk_Label2.TabIndex = 14;
            this.iTalk_Label2.Text = "Config";
            // 
            // txtConfig_name
            // 
            this.txtConfig_name.BackColor = System.Drawing.Color.Transparent;
            this.txtConfig_name.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtConfig_name.ForeColor = System.Drawing.Color.DimGray;
            this.txtConfig_name.Location = new System.Drawing.Point(172, 233);
            this.txtConfig_name.MaxLength = 32767;
            this.txtConfig_name.Multiline = false;
            this.txtConfig_name.Name = "txtConfig_name";
            this.txtConfig_name.ReadOnly = false;
            this.txtConfig_name.Size = new System.Drawing.Size(425, 33);
            this.txtConfig_name.TabIndex = 13;
            this.txtConfig_name.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfig_name.UseSystemPasswordChar = false;
            // 
            // txt_config
            // 
            this.txt_config.AutoWordSelection = false;
            this.txt_config.BackColor = System.Drawing.Color.Transparent;
            this.txt_config.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_config.ForeColor = System.Drawing.Color.DimGray;
            this.txt_config.Location = new System.Drawing.Point(172, 289);
            this.txt_config.Name = "txt_config";
            this.txt_config.ReadOnly = false;
            this.txt_config.Size = new System.Drawing.Size(425, 281);
            this.txt_config.TabIndex = 12;
            this.txt_config.WordWrap = true;
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(70, 232);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(89, 19);
            this.iTalk_Label1.TabIndex = 11;
            this.iTalk_Label1.Text = "Config Name";
            // 
            // btnRemoveConfig
            // 
            this.btnRemoveConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveConfig.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnRemoveConfig.ForeColor = System.Drawing.Color.White;
            this.btnRemoveConfig.Image = global::MySecureServer.Properties.Resources.MetroUI_Folder_OS_Security_Denied_icon;
            this.btnRemoveConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveConfig.Location = new System.Drawing.Point(879, 599);
            this.btnRemoveConfig.Name = "btnRemoveConfig";
            this.btnRemoveConfig.Size = new System.Drawing.Size(252, 49);
            this.btnRemoveConfig.TabIndex = 19;
            this.btnRemoveConfig.Text = "Remove Settings";
            this.btnRemoveConfig.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnUpdateConfig
            // 
            this.btnUpdateConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateConfig.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnUpdateConfig.ForeColor = System.Drawing.Color.White;
            this.btnUpdateConfig.Image = global::MySecureServer.Properties.Resources.proxy;
            this.btnUpdateConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateConfig.Location = new System.Drawing.Point(597, 599);
            this.btnUpdateConfig.Name = "btnUpdateConfig";
            this.btnUpdateConfig.Size = new System.Drawing.Size(265, 49);
            this.btnUpdateConfig.TabIndex = 18;
            this.btnUpdateConfig.Text = "Update Settings";
            this.btnUpdateConfig.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MySecureServer.Properties.Resources.System_settings_icon;
            this.pictureBox1.Location = new System.Drawing.Point(232, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // iTalk_Button_21
            // 
            this.iTalk_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_21.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_21.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_21.Image = global::MySecureServer.Properties.Resources.notepad_icon;
            this.iTalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_21.Location = new System.Drawing.Point(324, 599);
            this.iTalk_Button_21.Name = "iTalk_Button_21";
            this.iTalk_Button_21.Size = new System.Drawing.Size(258, 49);
            this.iTalk_Button_21.TabIndex = 15;
            this.iTalk_Button_21.Text = "Add Settings";
            this.iTalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frmAddSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 706);
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
            this.Name = "frmAddSettings";
            this.Text = "Settings Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_TextBox_Small txtSearch;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private iTalk.iTalk_Button_2 btnRemoveConfig;
        private iTalk.iTalk_Button_2 btnUpdateConfig;
        private System.Windows.Forms.DataGridView dgConfigs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_Button_2 iTalk_Button_21;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_TextBox_Small txtConfig_name;
        private iTalk.iTalk_RichTextBox txt_config;
        private iTalk.iTalk_Label iTalk_Label1;
    }
}