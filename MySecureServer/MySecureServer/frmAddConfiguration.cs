using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySecureServer
{
    public partial class frmSettingsManager : Form
    {
        SQLiteConnection m_dbConnection;
        public frmSettingsManager()
        {
            InitializeComponent();
        }

        private void frmAddConfiguration_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
           
            
            connectToDatabase();

            getConfig();
        }
        public void connectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source=securedb.db;");
            m_dbConnection.Open();
        }
        private void getConfig()
        {
            DataSet data_set = new DataSet();

            string sql = "select config_name as Name, config_text as Config_Command from config";


            SQLiteDataAdapter sql_data_adapter = new SQLiteDataAdapter(sql, m_dbConnection);
            SQLiteCommandBuilder sql_command_builder = new SQLiteCommandBuilder(sql_data_adapter);

            sql_data_adapter.Fill(data_set);

            dgConfigs.DataSource = data_set.Tables[0].DefaultView;
            this.dgConfigs.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgConfigs.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgConfigs.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void searchSettings(SQLiteConnection con, string search)
        {
            DataSet data_set = new DataSet();

            // string sql = "select * from logs where ";
            string sql = "SELECT config_name as Config_Name, config_text as Config FROM config WHERE config_name LIKE " + "'%" + search + "%'";

            SQLiteDataAdapter sql_data_adapter = new SQLiteDataAdapter(sql, m_dbConnection);
            SQLiteCommandBuilder sql_command_builder = new SQLiteCommandBuilder(sql_data_adapter);

            sql_data_adapter.Fill(data_set);

            dgConfigs.DataSource = data_set.Tables[0].DefaultView;

            this.dgConfigs.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgConfigs.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgConfigs.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           // this.dgConfigs.Columns[1].Visible = false;
        }


        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            if (txtConfig_name.Text == "" || txt_config.Text == "")
            {
                MessageBox.Show("Can not add Empty Config", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            writeconfig();
         }
        public void writeconfig()
        {
            
            string txtSQLQuery = "insert into  config (config_name,config_text) values( '" + txtConfig_name.Text + "','" + txt_config.Text + "' )";
            SQLiteCommand command = new SQLiteCommand(txtSQLQuery, m_dbConnection);
            command = m_dbConnection.CreateCommand();
            command.CommandText = txtSQLQuery;
            command.ExecuteNonQuery();
            MessageBox.Show("New Config added...");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchSettings(m_dbConnection, txtSearch.Text);
        }

        private void dgConfigs_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string config_name;
            string config;
            if (dgConfigs.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgConfigs.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgConfigs.Rows[selectedrowindex];

                 txtConfig_name.Text = Convert.ToString(selectedRow.Cells["Name"].Value);

                 txt_config.Text = Convert.ToString(selectedRow.Cells["config_command"].Value);

            }
        }
    }
}

