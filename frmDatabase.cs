using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Unturned_Uconomy_Utility
{
    public partial class frmDatabase : Form
    {
        public frmDatabase()
        {
            InitializeComponent();

            if (regKeyExists())
            {
                RegistryKey regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
                regKey = regKey.OpenSubKey("Freenex's Unturned Uconomy Utility", true);

                tbHost.Text = regKey.GetValue("Host").ToString();
                tbPort.Text = regKey.GetValue("Port").ToString();
                tbUser.Text = Encoding.UTF8.GetString(Convert.FromBase64String(regKey.GetValue("User").ToString()));
                tbPassword.Text = Encoding.UTF8.GetString(Convert.FromBase64String(regKey.GetValue("Password").ToString()));
                tbDatabase.Text = regKey.GetValue("Database").ToString();
                tbTableItems.Text = regKey.GetValue("TableItems").ToString();
                tbTableVehicles.Text = regKey.GetValue("TableVehicles").ToString();

                cbSave.Checked = true;
            }
            else
            {
                tbHost.Text = frmMain.host;
                tbPort.Text = frmMain.port;
                tbUser.Text = frmMain.user;
                tbPassword.Text = frmMain.password;
                tbDatabase.Text = frmMain.database;
                tbTableItems.Text = frmMain.tableItems;
                tbTableVehicles.Text = frmMain.tableVehicles;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (frmMain.dataConnection.State == ConnectionState.Closed || frmMain.dataConnection.State == ConnectionState.Broken)
            {
                btnConnect.Enabled = false;
                this.Cursor = Cursors.AppStarting;
                try
                {
                    frmMain.Instance.lblStatus.Text = "Connecting to MySQL host...";
                    frmMain.host = tbHost.Text;
                    frmMain.port = tbPort.Text;
                    frmMain.user = tbUser.Text;
                    frmMain.password = tbPassword.Text;
                    frmMain.database = tbDatabase.Text;
                    frmMain.tableItems = tbTableItems.Text;
                    frmMain.tableVehicles = tbTableVehicles.Text;
                    frmMain.dataConnection.ConnectionString = String.Format("SERVER={0};PORT={1};UID={2};PASSWORD={3};DATABASE={4};", tbHost.Text, tbPort.Text, tbUser.Text, tbPassword.Text, tbDatabase.Text);
                    frmMain.dataConnection.Open();
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    btnConnect.Enabled = true;
                    this.Cursor = Cursors.Default;

                    if (frmMain.dataConnection.State == ConnectionState.Open)
                        frmMain.dataConnection.Close();

                    frmMain.Instance.lblStatus.Text = "Can't connect to database.";
                    MessageBox.Show(ex.Message, frmMain.Instance.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (cbSave.Checked)
                {
                    RegistryKey regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
                    regKey.CreateSubKey("Freenex's Unturned Uconomy Utility");
                    regKey = regKey.OpenSubKey("Freenex's Unturned Uconomy Utility", true);

                    regKey.SetValue("Host", tbHost.Text);
                    regKey.SetValue("Port", tbPort.Text);
                    regKey.SetValue("User", Convert.ToBase64String(Encoding.UTF8.GetBytes(tbUser.Text)));
                    regKey.SetValue("Password", Convert.ToBase64String(Encoding.UTF8.GetBytes(tbPassword.Text)));
                    regKey.SetValue("Database", tbDatabase.Text);
                    regKey.SetValue("TableItems", tbTableItems.Text);
                    regKey.SetValue("TableVehicles", tbTableVehicles.Text);
                }
            }
        }

        private void btnDeleteInformation_Click(object sender, EventArgs e)
        {
            if (regKeyExists())
            {
                RegistryKey regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
                regKey.DeleteSubKey("Freenex's Unturned Uconomy Utility");
                MessageBox.Show("Information deleted!", frmMain.Instance.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No information saved.", frmMain.Instance.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool regKeyExists()
        {
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
            regKey = regKey.OpenSubKey("Freenex's Unturned Uconomy Utility", true);
            if (regKey == null) { return false; }

            if (regKey.GetValue("Host") == null) { return false; }
            if (regKey.GetValue("Port") == null) { return false; }
            if (regKey.GetValue("User") == null) { return false; }
            if (regKey.GetValue("Password") == null) { return false; }
            if (regKey.GetValue("Database") == null) { return false; }
            if (regKey.GetValue("TableItems") == null) { return false; }
            if (regKey.GetValue("TableVehicles") == null) { return false; }
            return true;
        }
    }
}
