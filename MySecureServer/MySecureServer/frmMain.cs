using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MySecureServer
{
    public partial class frmMain : Form
    {

        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        [DllImport("user32")]
        public static extern void LockWorkStation();
        System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo();
        string systemDir = Environment.SystemDirectory;
        string selected_path;
        public frmMain()
        {
            InitializeComponent();
            txtSearchSetings.Focus();
            getsettings();
            dgSettings.MultiSelect = true;
            connectToDatabase();
            getLogs(m_dbConnection);
            
        }

        public void getsettings()
        {

            //1st you must create columns to dgv, like:
            dataGridView1.Columns.Add("col1", "Key");
            dataGridView1.Columns.Add("col2", "Value");
            //and so on...
            using (StreamReader sr = new StreamReader("file1.inf"))
            {
                int row = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] columns = line.Split('=');
                    dataGridView1.Rows.Add();
                    for (int i = 0; i < columns.Length; i++)
                    {
                        dataGridView1[i, row].Value = columns[i];
                    }
                    row++;
                }
            }
            button1.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
         
        
    }

        private void encryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cypher c = new Cypher();
            c.ShowDialog();
        }
        SQLiteConnection m_dbConnection;
      
        public void connectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source=securedb.db;");
            m_dbConnection.Open();
        }

        private void getLogs(SQLiteConnection con)
        {
            DataSet data_set = new DataSet();

            string sql = "select name,path as Settings from settings";


            SQLiteDataAdapter sql_data_adapter = new SQLiteDataAdapter(sql, m_dbConnection);
            SQLiteCommandBuilder sql_command_builder = new SQLiteCommandBuilder(sql_data_adapter);

            sql_data_adapter.Fill(data_set);

            dgSettings.DataSource = data_set.Tables[0].DefaultView;
           
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            lbls_machine_name.Text = BLL.SystemProperties.SYSTEM_NAME;
            lblStatusIP.Text = BLL.SystemProperties.GetLocalIPAddress();

            this.dgSettings.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgSettings.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgSettings.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgSettings.Columns[1].Visible = false;
            this.ActiveControl = txtSearchSetings;
         

        }
        private void notepad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo proc2 = new System.Diagnostics.ProcessStartInfo();
            proc2.FileName = systemDir + "/notepad.exe";
            System.Diagnostics.Process.Start(proc2);
        }
        private void word_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "WINWORD.EXE";
                // startInfo.Arguments = file;
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MS Word Application Has not been Installed", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void excel_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "excel.exe";
                // startInfo.Arguments = file;
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MS Excel Application Has not been Installed", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void outlook_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "outlook.exe";
                // startInfo.Arguments = file;
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MS Outlook Application Has not been Installed", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnAdapters_Click(object sender, EventArgs e)
        {
            proc.FileName = systemDir + "/rundll32.exe";
            proc.Arguments = "shell32.dll,Control_RunDLL ncpa.cpl";
            System.Diagnostics.Process.Start(proc);
        }

        private void btnUpdates_Click(object sender, EventArgs e)
        {
            proc.FileName = systemDir + "/rundll32.exe";
            proc.Arguments = "url.dll,FileProtocolHandler wuapp.exe";
            System.Diagnostics.Process.Start(proc);
        }

        private void btnProxy_Click(object sender, EventArgs e)
        {
            proc.FileName = systemDir + "/control.exe";
            proc.Arguments = "inetcpl.cpl,,4";
            System.Diagnostics.Process.Start(proc);
            SendKeys.Send("{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "taskmgr.exe";
                // startInfo.Arguments = file;
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MS Outlook Application Has not been Installed", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo proc2 = new System.Diagnostics.ProcessStartInfo();
            proc2.FileName = systemDir + "/control.exe";
            System.Diagnostics.Process.Start(proc2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "explorer.exe";
                // startInfo.Arguments = file;
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("----d", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            proc.FileName = systemDir + "/rundll32.exe";
            proc.Arguments = "shell32.dll,Control_RunDLL firewall.cpl";
            System.Diagnostics.Process.Start(proc);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "services.msc";
                // startInfo.Arguments = file;
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MS Outlook Application Has not been Installed", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            proc.FileName = systemDir + "/control.exe";
            proc.Arguments = "system";
            System.Diagnostics.Process.Start(proc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            proc.FileName = systemDir + "/rundll32.exe";
            proc.Arguments = "shell32.dll,Control_RunDLL hdwwiz.cpl";
            System.Diagnostics.Process.Start(proc);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            proc.FileName = systemDir + "/SndVol.exe";
            proc.Arguments = "-f 49825268";
            System.Diagnostics.Process.Start(proc);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "msinfo32";
                // startInfo.Arguments = file;
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MS Outlook Application Has not been Installed", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                Process.Start("shutdown", "/s /t 0");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                LockWorkStation();
            }
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin l = new frmLogin();
            l.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iTalk_GroupBox1_Click(object sender, EventArgs e)
        {
           // lblLoggedUser.Text = lblLoggedUser.Text + " " + BLL.SystemProperties.SYSTEM_USERNAME;
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            ShellScriptor.FormPowerShellSample fs = new ShellScriptor.FormPowerShellSample();
            fs.ShowDialog();
        }

        private void manageConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettingsManager c = new frmSettingsManager();
            c.ShowDialog();
        }

        private void iTalk_GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void searchLogs(SQLiteConnection con, string search)
        {
            DataSet data_set = new DataSet();

            // string sql = "select * from logs where ";
            string sql = "SELECT name,path as Setting FROM settings WHERE name LIKE " + "'%" + search + "%'";

            SQLiteDataAdapter sql_data_adapter = new SQLiteDataAdapter(sql, m_dbConnection);
            SQLiteCommandBuilder sql_command_builder = new SQLiteCommandBuilder(sql_data_adapter);

            sql_data_adapter.Fill(data_set);

            dgSettings.DataSource = data_set.Tables[0].DefaultView;

            this.dgSettings.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgSettings.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgSettings.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgSettings.Columns[1].Visible = false;
        }
        private void txtSearchSetings_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchSetings.Text;

            searchLogs(m_dbConnection, searchValue);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int i = dgSettings.CurrentRow.Index;
                if (dgSettings.Rows[i].Cells[1].Value != null)
                {

                    execCommand(dgSettings.Rows[i].Cells[1].Value.ToString());
                    
                }
                
            }
        }

        private void execCommand(string cmd) {

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = cmd;
              //  MessageBox.Show(cmd.ToString());
                // startInfo.Arguments = file;
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }


        }

        private void dgSettings_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    int i = dgSettings.CurrentRow.Index;
            //    MessageBox.Show(i.ToString());
            //}
        }

        private void manageSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSettings fs = new frmAddSettings();
            fs.ShowDialog();

        }

        private void dgSettings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgSettings.CurrentRow.Index;
            execCommand(dgSettings.Rows[i].Cells[1].Value.ToString());
        }
    }
}
