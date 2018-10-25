namespace Unturned_Uconomy_Utility
{
    partial class frmImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImport));
            this.btnImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbItems = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVehicles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 230);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(360, 30);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Items:";
            // 
            // tbItems
            // 
            this.tbItems.Location = new System.Drawing.Point(12, 25);
            this.tbItems.Multiline = true;
            this.tbItems.Name = "tbItems";
            this.tbItems.Size = new System.Drawing.Size(360, 88);
            this.tbItems.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Vehicles:";
            // 
            // tbVehicles
            // 
            this.tbVehicles.Location = new System.Drawing.Point(12, 136);
            this.tbVehicles.Multiline = true;
            this.tbVehicles.Name = "tbVehicles";
            this.tbVehicles.Size = new System.Drawing.Size(360, 88);
            this.tbVehicles.TabIndex = 2;
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 272);
            this.Controls.Add(this.tbVehicles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImport);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImport";
            this.Text = "Import items/vehicles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVehicles;
    }
}