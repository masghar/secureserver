using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Data.SQLite;
using MySecureServer.BLL;
namespace MySecureServer
{
    public partial class Cypher : Form
    {

        //BLL.Cypher c = new BLL.Cypher();
        public Cypher()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
          

            txtDecrypter.Clear();
            txtDecrypter.Text = BLL.Cypher.Encrypt(txtencrypter.Text.Trim());
        }


        
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //txtDecrypter.Clear();
            txtReverse.Text = BLL.Cypher.Decrypt(txtDecrypter.Text.Trim());
        }
        SQLiteConnection m_dbConnection;
        private void Cypher_Load(object sender, EventArgs e)
        {
            connectToDatabase();
        }
        public void connectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source=telecoDB.db;");
            m_dbConnection.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtencrypter.Text==""){
                MessageBox.Show("Please enter Password.");
                return;
            }
            using (SQLiteCommand command = new SQLiteCommand(m_dbConnection))
            {
                try
                {
                    command.CommandText =
                        "update tb_keys set password = :password";
                    command.Parameters.Add("password", DbType.String).Value = txtDecrypter.Text;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Password Changed.");
                }catch (Exception ex)
                
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}

    
