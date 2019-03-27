using MySecureServer;
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
    public partial class frmLogin : Form
    {
        SQLiteConnection m_dbConnection;
        public frmLogin()
        {
            
            InitializeComponent();
            lblCopy.Text = "© "+DateTime.Now.Year+" Afiniti GDOT - Team";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            string sql = "select count(*) from users where username="+"'"+txtusername.Text+"'"+ "and "+ "password="+"'"+txtPassword.Text+"'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            Int32 a = Int32.Parse(command.ExecuteScalar().ToString());
            if (a>0)
            {
                m_dbConnection.Close();
                frmMain m = new frmMain();
                this.Hide();
                m.Show();
            }
            else
            {
                MessageBox.Show("Incorrect, Username or Password.. Try Again","Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            connectToDatabase();
        }
        public void connectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source=securedb.db;");
            m_dbConnection.Open();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                pictureBox2_Click(sender, e);
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
