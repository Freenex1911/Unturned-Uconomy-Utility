namespace Unturned_Uconomy_Utility
{
    partial class frmCleanTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCleanTables));
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRenameItems = new System.Windows.Forms.ListBox();
            this.lbRemoveItems = new System.Windows.Forms.ListBox();
            this.lbRenameVehicles = new System.Windows.Forms.ListBox();
            this.lbRemoveVehicles = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRename = new System.Windows.Forms.CheckBox();
            this.cbRemove = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(12, 420);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(230, 25);
            this.btnAnalyze.TabIndex = 0;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(12, 451);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(230, 25);
            this.btnClean.TabIndex = 1;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Rename";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Remove";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRenameItems
            // 
            this.lbRenameItems.FormattingEnabled = true;
            this.lbRenameItems.Location = new System.Drawing.Point(12, 45);
            this.lbRenameItems.Name = "lbRenameItems";
            this.lbRenameItems.Size = new System.Drawing.Size(110, 147);
            this.lbRenameItems.TabIndex = 100;
            this.lbRenameItems.TabStop = false;
            // 
            // lbRemoveItems
            // 
            this.lbRemoveItems.FormattingEnabled = true;
            this.lbRemoveItems.Location = new System.Drawing.Point(12, 237);
            this.lbRemoveItems.Name = "lbRemoveItems";
            this.lbRemoveItems.Size = new System.Drawing.Size(110, 147);
            this.lbRemoveItems.TabIndex = 100;
            this.lbRemoveItems.TabStop = false;
            // 
            // lbRenameVehicles
            // 
            this.lbRenameVehicles.FormattingEnabled = true;
            this.lbRenameVehicles.Location = new System.Drawing.Point(132, 45);
            this.lbRenameVehicles.Name = "lbRenameVehicles";
            this.lbRenameVehicles.Size = new System.Drawing.Size(110, 147);
            this.lbRenameVehicles.TabIndex = 100;
            this.lbRenameVehicles.TabStop = false;
            // 
            // lbRemoveVehicles
            // 
            this.lbRemoveVehicles.FormattingEnabled = true;
            this.lbRemoveVehicles.Location = new System.Drawing.Point(132, 237);
            this.lbRemoveVehicles.Name = "lbRemoveVehicles";
            this.lbRemoveVehicles.Size = new System.Drawing.Size(110, 147);
            this.lbRemoveVehicles.TabIndex = 100;
            this.lbRemoveVehicles.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 1);
            this.panel1.TabIndex = 100;
            // 
            // cbRename
            // 
            this.cbRename.AutoSize = true;
            this.cbRename.Checked = true;
            this.cbRename.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRename.Location = new System.Drawing.Point(12, 397);
            this.cbRename.Name = "cbRename";
            this.cbRename.Size = new System.Drawing.Size(66, 17);
            this.cbRename.TabIndex = 2;
            this.cbRename.Text = "Rename";
            this.cbRename.UseVisualStyleBackColor = true;
            // 
            // cbRemove
            // 
            this.cbRemove.AutoSize = true;
            this.cbRemove.Checked = true;
            this.cbRemove.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemove.Location = new System.Drawing.Point(176, 397);
            this.cbRemove.Name = "cbRemove";
            this.cbRemove.Size = new System.Drawing.Size(66, 17);
            this.cbRemove.TabIndex = 3;
            this.cbRemove.Text = "Remove";
            this.cbRemove.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(12, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 1);
            this.panel2.TabIndex = 101;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(12, 390);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 1);
            this.panel3.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "Items:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 104;
            this.label4.Text = "Vehicles:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 105;
            this.label5.Text = "Items:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 106;
            this.label6.Text = "Vehicles:";
            // 
            // frmCleanTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 488);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbRemove);
            this.Controls.Add(this.cbRename);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbRemoveVehicles);
            this.Controls.Add(this.lbRenameVehicles);
            this.Controls.Add(this.lbRemoveItems);
            this.Controls.Add(this.lbRenameItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnAnalyze);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCleanTables";
            this.Text = "Clean up ZaupShop tables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbRenameItems;
        private System.Windows.Forms.ListBox lbRemoveItems;
        private System.Windows.Forms.ListBox lbRenameVehicles;
        private System.Windows.Forms.ListBox lbRemoveVehicles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbRename;
        private System.Windows.Forms.CheckBox cbRemove;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}