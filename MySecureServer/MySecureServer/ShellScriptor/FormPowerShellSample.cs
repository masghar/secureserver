using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Data.SQLite;
using System.Collections;
using System.Diagnostics;

namespace MySecureServer.ShellScriptor
{
    public partial class FormPowerShellSample : Form, IDisposable
    {
        /// <summary>
        /// Powershell runspace
        /// </summary>
        private Runspace runSpace;
        SQLiteConnection m_dbConnection;
        /// <summary>
        /// The active PipelineExecutor instance
        /// </summary>
        private PipelineExecutor pipelineExecutor;

        public FormPowerShellSample()
        {
            InitializeComponent();
            InitializeComboBox();
            // create Powershell runspace
            runSpace = RunspaceFactory.CreateRunspace();
            // open it
            runSpace.Open();
            //
       
            connectToDatabase();
            FillCombos(m_dbConnection);

        //

        } public void connectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source=securedb.db;");
            m_dbConnection.Open();
        }

        private void FormPowerShellSample_FormClosing(object sender, FormClosingEventArgs e)
        {
            // stop any running scripts
            StopScript();
            // close the powershell runspace
            runSpace.Close();
        }

        private void buttonStartScript_Click(object sender, EventArgs e)
        {
            StopScript();
            listBoxOutput.Items.Clear();
            AppendLine("Starting script...");
            pipelineExecutor = new PipelineExecutor(runSpace, this, textBoxScript.Text);
            pipelineExecutor.OnDataReady += new PipelineExecutor.DataReadyDelegate(pipelineExecutor_OnDataReady);
            pipelineExecutor.OnDataEnd += new PipelineExecutor.DataEndDelegate(pipelineExecutor_OnDataEnd);
            pipelineExecutor.OnErrorReady += new PipelineExecutor.ErrorReadyDelegate(pipelineExecutor_OnErrorReady);
            pipelineExecutor.Start();
        }

        private void buttonStopScript_Click(object sender, EventArgs e)
        {
            StopScript();
        }
       
        private void StopScript()
        {
            if (pipelineExecutor != null)
            {
                pipelineExecutor.OnDataReady -= new PipelineExecutor.DataReadyDelegate(pipelineExecutor_OnDataReady);
                pipelineExecutor.OnDataEnd -= new PipelineExecutor.DataEndDelegate(pipelineExecutor_OnDataEnd);
                pipelineExecutor.Stop();
                pipelineExecutor = null;
            }
        }

        private void pipelineExecutor_OnDataEnd(PipelineExecutor sender)
        {
            if (sender.Pipeline.PipelineStateInfo.State == PipelineState.Failed)
            {
                AppendLine(string.Format("Error in script: {0}", sender.Pipeline.PipelineStateInfo.Reason));
            }
            else
            {
                AppendLine("Ready.");
            }
        }

        private void pipelineExecutor_OnDataReady(PipelineExecutor sender, ICollection<PSObject> data)
        {
            foreach (PSObject obj in data)
            {
                AppendLine(obj.ToString());
            }
        }

        void pipelineExecutor_OnErrorReady(PipelineExecutor sender, ICollection<object> data)
        {
            foreach (object e in data)
            {
                AppendLine("Error : " + e.ToString());
            }
        }

        #region Drag-drop handling events
        // Represents the kind of drag drop formats we want to receive
        private const string dragDropFormat = "FileDrop";

        private void FormPowerShellSample_DragDrop(object sender, DragEventArgs e)
        {
            // is it the correct type of data?
            if (e.Data.GetDataPresent(dragDropFormat))
            {
                // dragging files onto the window yields an array of pathnames
                string[] files = (string[])e.Data.GetData(dragDropFormat);

                if (files.Length > 0)
                {
                    // just read the first file
                    using (StreamReader sr = new StreamReader(files[0]))
                    {
                        // and plunk the contents in the textbox
                        textBoxScript.Text = sr.ReadToEnd();
                    }
                }
            }
        }

        private void FormPowerShellSample_DragEnter(object sender, DragEventArgs e)
        {
            // only accept the dropped data if it has the correct format
            e.Effect = e.Data.GetDataPresent(dragDropFormat) ? DragDropEffects.Link : DragDropEffects.None;
        }
        #endregion

        #region ListboxOutput updating
        private bool listBoxChanged = false;

        private void AppendLine(string line)
        {
            listBoxChanged = true;
            if (listBoxOutput.Items.Count > 10000) listBoxOutput.Items.RemoveAt(0);
            listBoxOutput.Items.Add(line);
            listBoxOutput.TopIndex = listBoxOutput.Items.Count - 1;
        }

        private void timerOutput_Tick(object sender, EventArgs e)
        {
            if (listBoxChanged)
            {
                listBoxOutput.EndUpdate();
                listBoxOutput.Update();
                listBoxChanged = false;
                listBoxOutput.BeginUpdate();
            }
            else
            {
                listBoxOutput.EndUpdate();
            }
        }

        #endregion

        #region Combobox initialization and handling

        /// <summary>
        /// Private class for the script selection combobox items
        /// </summary>
        private class SampleScriptItem
        {
            private string name;
            private string script;

            public string Name
            {
                get { return name; }
            }

            public string Script
            {
                get { return script; }
            }

            public SampleScriptItem(string Name, string Script)
            {
                this.name = Name;
                this.script = Script;
            }
        };


        /// <summary>
        /// Fill combo from DB
        ArrayList l = new ArrayList();
        private void FillCombos(SQLiteConnection con)
        {
            string sql = "select * from config";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbtest.Items.Add(reader["config_name"].ToString());
                cmbtest.ValueMember = reader["id"].ToString();
                cmbtest.DisplayMember = reader["config_name"].ToString();
                l.Add(reader["config_text"].ToString());



            }
        }
    /// 
    /// </summary>
    private void InitializeComboBox()
        {
            // create and fill a list of sample script items
            List<SampleScriptItem> sampleScriptItems = new List<SampleScriptItem>();

            sampleScriptItems.Add(
                new SampleScriptItem("Hardening 1 - ",
                    ""));

            sampleScriptItems.Add(
                new SampleScriptItem( "Recursively list drive c: contents",
                    "Get-ChildItem c:\\ -recurse | Out-String -stream"));

            sampleScriptItems.Add(
                new SampleScriptItem( "Every second, list all processes",
                    "while(1)\r\n"                             +
                    "{\r\n"                                    +
                    "    Get-Process | Out-String -stream\r\n" +
                    "    Start-Sleep -milliseconds 1000\r\n"   +
                    "}\r\n" ));

            sampleScriptItems.Add(
                new SampleScriptItem("List all recent (1 wk) files on C:",  
                    "#filter script found at:  \r\n" +
                    "filter recently ($days=1) {\r\n" +
                    "  if ($_.LastWriteTime -gt\r\n" +
                    "    ([datetime]::now - (New-TimeSpan -days $days)))\r\n" +
                    "  {$_}\r\n" +
                    "}\r\n" +
                    "\r\n" +
                    "Get-ChildItem c:\\ -recurse | recently 7 | Out-String -stream"));

            sampleScriptItems.Add(
                new SampleScriptItem("List all open windows",
                    "#script found at:  \r\n" +
                    "Get-Process | \r\n"+
                    "    Where-Object {$_.MainWindowTitle -ne \"\"} |\r\n"+
                    "    Select-Object MainWindowTitle |\r\n"+
                    "    Out-String -stream"));

            sampleScriptItems.Add(
                new SampleScriptItem("List all user accounts on localhost",
                    "#script found at:  \r\n" +
                    "Get-WmiObject Win32_UserAccount -computername \"localhost\" | \r\n" +
                    "    Select-Object Domain,Name,Disabled"));

            sampleScriptItems.Add(
                new SampleScriptItem("List all local harddisks",
                    "#script found at:  \r\n" +
                    "Get-WMIObject Win32_LogicalDisk -filter \"DriveType = 3\" | \r\n" +
                    "    Select-Object DeviceID\r\n"));

            sampleScriptItems.Add(
                new SampleScriptItem("Error handling demonstration",
                    "for($i=0; $i -lt 4; $i++)\r\n" +
                    "{\r\n" +
                    "    dir NoSuchDirectory\r\n" +
                    "}\r\n" +
                    "NoSuchCommand\r\n"
                    ));

            // bind the sample scripts to the combobox
            comboBoxSampleScripts.DataSource = sampleScriptItems;
            comboBoxSampleScripts.DisplayMember = "Name";
            comboBoxSampleScripts.ValueMember = "Script";
            comboBoxSampleScripts.SelectedValueChanged+=new EventHandler(comboBoxSampleScripts_SelectedValueChanged);
            
            // force an update of the selected value
            comboBoxSampleScripts.SelectedIndex = -1;
            comboBoxSampleScripts.SelectedIndex = 0;
        }

        private void comboBoxSampleScripts_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxScript.Text = (string)comboBoxSampleScripts.SelectedValue;
        }
        #endregion

        #region IDisposable Members

        public new void Dispose()
        {
            throw new NotSupportedException("");
        }

        #endregion

        private void FormPowerShellSample_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmbtest_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxScript.Text = l[cmbtest.SelectedIndex].ToString();
        }

        private void iTalk_LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ///GP Edit
            ///
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "gpedit.msc";
                // startInfo.Arguments = file;
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MS Outlook Application Has not been Installed", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void textBoxScript_TextChanged(object sender, EventArgs e)
        {

        }

        private void iTalk_LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "secpol.msc";
                // startInfo.Arguments = file;
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MS Outlook Application Has not been Installed", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
///
