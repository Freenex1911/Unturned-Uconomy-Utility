using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Unturned_Uconomy_Utility
{
    public partial class frmCleanTables : Form
    {
        StringBuilder stringBuilder = new StringBuilder();

        public frmCleanTables()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            lbRenameItems.Items.Clear();
            lbRenameVehicles.Items.Clear();
            lbRemoveItems.Items.Clear();
            lbRemoveVehicles.Items.Clear();
            stringBuilder.Clear();

            foreach (ListViewItem lvItem in frmMain.listUserItemsDatabase)
            {
                ListViewItem lvSearchedItem = frmMain.listOriginalItems.FirstOrDefault(cus => cus.Text == lvItem.Text);
                if (lvSearchedItem == null && cbRemove.Checked)
                {
                    lbRemoveItems.Items.Add(lvItem.Text);
                    stringBuilder.AppendLine("DELETE FROM `" + frmMain.tableItems + "` WHERE `id`='" + lvItem.Text + "';");
                }
                else
                {
                    if (lvItem.SubItems[1].Text != lvSearchedItem.SubItems[1].Text && cbRename.Checked)
                    {
                        lbRenameItems.Items.Add(lvItem.Text);
                        stringBuilder.AppendLine("UPDATE `" + frmMain.tableItems + "` SET `itemname`='" + frmMain.listOriginalItems.FirstOrDefault(cus => cus.Text == lvItem.Text).SubItems[1].Text + "' WHERE `id`='" + lvItem.Text + "';");
                    }
                }
            }
            foreach (ListViewItem lvItem in frmMain.listUserVehiclesDatabase)
            {
                ListViewItem lvSearchedItem = frmMain.listOriginalVehicles.FirstOrDefault(cus => cus.Text == lvItem.Text);
                if (lvSearchedItem == null && cbRemove.Checked)
                {
                    lbRemoveVehicles.Items.Add(lvItem.Text);
                    stringBuilder.AppendLine("DELETE FROM `" + frmMain.tableVehicles + "` WHERE `id`='" + lvItem.Text + "';");
                }
                else
                {
                    if (lvItem.SubItems[1].Text != lvSearchedItem.SubItems[1].Text && cbRename.Checked)
                    {
                        lbRenameVehicles.Items.Add(lvItem.Text);
                        stringBuilder.AppendLine("UPDATE `" + frmMain.tableVehicles + "` SET `vehiclename`='" + frmMain.listOriginalVehicles.FirstOrDefault(cus => cus.Text == lvItem.Text).SubItems[1].Text + "' WHERE `id`='" + lvItem.Text + "';");
                    }
                }
            }

            if (stringBuilder.ToString() == string.Empty) { MessageBox.Show("Congratulations. Your tables are already clean.", frmMain.Instance.Text, MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (lbRenameItems.Items.Count == 0 && lbRenameVehicles.Items.Count == 0 && lbRemoveItems.Items.Count == 0 && lbRemoveVehicles.Items.Count == 0) { MessageBox.Show("There are no items/vehicles to clean. Analyze first.", frmMain.Instance.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            try
            {
                MySqlCommand dataCommand = new MySqlCommand(stringBuilder.ToString(), frmMain.dataConnection);
                dataCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex) { MessageBox.Show(ex.Message, frmMain.Instance.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            foreach (string lbItem in lbRenameItems.Items) { frmMain.listUserItemsDatabase.FirstOrDefault(cus => cus.Text == lbItem).SubItems[1].Text = frmMain.listOriginalItems.FirstOrDefault(cus => cus.Text == lbItem).SubItems[1].Text; }
            foreach (string lbItem in lbRenameVehicles.Items) { frmMain.listUserVehiclesDatabase.FirstOrDefault(cus => cus.Text == lbItem).SubItems[1].Text = frmMain.listOriginalVehicles.FirstOrDefault(cus => cus.Text == lbItem).SubItems[1].Text; }
            foreach (string lbItem in lbRemoveItems.Items) { frmMain.listUserItemsDatabase.Remove(frmMain.listUserItemsDatabase.FirstOrDefault(cus => cus.Text == lbItem)); }
            foreach (string lbItem in lbRemoveVehicles.Items) { frmMain.listUserVehiclesDatabase.Remove(frmMain.listUserVehiclesDatabase.FirstOrDefault(cus => cus.Text == lbItem)); }

            lbRenameItems.Items.Clear();
            lbRenameVehicles.Items.Clear();
            lbRemoveItems.Items.Clear();
            lbRemoveVehicles.Items.Clear();

            MessageBox.Show("Successfully cleaned tables!", frmMain.Instance.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
