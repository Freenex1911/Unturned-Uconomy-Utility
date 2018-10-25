using System;
using System.Net;
using System.Windows.Forms;

namespace Unturned_Uconomy_Utility
{
    public partial class frmImport : Form
    {
        public frmImport()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (tbItems.Text == string.Empty && tbVehicles.Text == string.Empty) { MessageBox.Show("You need to insert at least one link to a text file.", frmMain.Instance.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            try
            {
                using (WebClient wcImport = new WebClient())
                {
                    foreach (string strLink in tbItems.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        string[] items = wcImport.DownloadString(strLink).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string item in items)
                        {
                            string[] strSplit = item.Trim().Split(new string[] { "; " }, StringSplitOptions.RemoveEmptyEntries);
                            ListViewItem lvItem = new ListViewItem(strSplit);
                            if (!frmMain.listOriginalItems.Exists(cus => cus.Text == strSplit[0]))
                            {
                                frmMain.listOriginalItems.Add(lvItem);
                                if (!frmMain.listUserItemsDatabase.Exists(cus => cus.Text == strSplit[0]))
                                {
                                    frmMain.listUserItemsLocal.Add(lvItem);
                                }
                            }
                        }
                    }
                    foreach (string strLink in tbVehicles.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        string[] vehicles = wcImport.DownloadString(strLink).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string vehicle in vehicles)
                        {
                            string[] strSplit = vehicle.Trim().Split(new string[] { "; " }, StringSplitOptions.RemoveEmptyEntries);
                            ListViewItem lvItem = new ListViewItem(strSplit);
                            if (!frmMain.listOriginalVehicles.Exists(cus => cus.Text == strSplit[0]))
                            {
                                frmMain.listOriginalVehicles.Add(lvItem);
                                if (!frmMain.listUserVehiclesDatabase.Exists(cus => cus.Text == strSplit[0]))
                                {
                                    frmMain.listUserVehiclesLocal.Add(lvItem);
                                }
                            }
                        }
                    }
                }

                frmMain.listOriginalItems.Sort((s1, s2) => Convert.ToInt64(s1.Text).CompareTo(Convert.ToInt64(s2.Text)));
                frmMain.listUserItemsLocal.Sort((s1, s2) => Convert.ToInt64(s1.Text).CompareTo(Convert.ToInt64(s2.Text)));
                frmMain.listOriginalVehicles.Sort((s1, s2) => Convert.ToInt64(s1.Text).CompareTo(Convert.ToInt64(s2.Text)));
                frmMain.listUserVehiclesLocal.Sort((s1, s2) => Convert.ToInt64(s1.Text).CompareTo(Convert.ToInt64(s2.Text)));
                frmMain.Instance.searchList();
                MessageBox.Show("Successfully imported items/vehicles!", frmMain.Instance.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not import items/vehicles. Make sure your link/s is/are correct.", frmMain.Instance.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
