namespace CarDealership
{
    partial class SellerScreen
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
            this.CarsTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.DealerShipSelector1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DGV_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Dealership = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.CarsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DealerShipSelector1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarsTab
            // 
            this.CarsTab.Controls.Add(this.splitContainer1);
            this.CarsTab.Controls.Add(this.dataGridView1);
            this.CarsTab.Location = new System.Drawing.Point(4, 22);
            this.CarsTab.Name = "CarsTab";
            this.CarsTab.Size = new System.Drawing.Size(686, 410);
            this.CarsTab.TabIndex = 2;
            this.CarsTab.Text = "Cars";
            this.CarsTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.DealerShipSelector1);
            this.splitContainer1.Size = new System.Drawing.Size(686, 410);
            this.splitContainer1.SplitterDistance = 196;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dealership ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DealerShipSelector1
            // 
            this.DealerShipSelector1.Location = new System.Drawing.Point(80, 13);
            this.DealerShipSelector1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.DealerShipSelector1.Name = "DealerShipSelector1";
            this.DealerShipSelector1.Size = new System.Drawing.Size(92, 20);
            this.DealerShipSelector1.TabIndex = 0;
            this.DealerShipSelector1.ThousandsSeparator = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_ID,
            this.DGV_Name,
            this.DGV_Surname,
            this.DGV_Role,
            this.DGV_Dealership});
            this.dataGridView1.Location = new System.Drawing.Point(545, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 423);
            this.dataGridView1.TabIndex = 0;
            // 
            // DGV_ID
            // 
            this.DGV_ID.HeaderText = "ID";
            this.DGV_ID.Name = "DGV_ID";
            this.DGV_ID.ReadOnly = true;
            // 
            // DGV_Name
            // 
            this.DGV_Name.HeaderText = "Name";
            this.DGV_Name.Name = "DGV_Name";
            this.DGV_Name.ReadOnly = true;
            // 
            // DGV_Surname
            // 
            this.DGV_Surname.HeaderText = "Surname";
            this.DGV_Surname.Name = "DGV_Surname";
            this.DGV_Surname.ReadOnly = true;
            this.DGV_Surname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DGV_Role
            // 
            this.DGV_Role.HeaderText = "Role";
            this.DGV_Role.Name = "DGV_Role";
            this.DGV_Role.ReadOnly = true;
            // 
            // DGV_Dealership
            // 
            this.DGV_Dealership.HeaderText = "Dealership";
            this.DGV_Dealership.Name = "DGV_Dealership";
            this.DGV_Dealership.ReadOnly = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.HomeTab);
            this.tabControl.Controls.Add(this.CarsTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(694, 436);
            this.tabControl.TabIndex = 1;
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.ExitButton);
            this.HomeTab.Controls.Add(this.LogoutButton);
            this.HomeTab.Location = new System.Drawing.Point(4, 22);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(686, 410);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(127, 363);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(46, 363);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // SellerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 436);
            this.Controls.Add(this.tabControl);
            this.Name = "SellerScreen";
            this.Text = "SellerScreen";
            this.CarsTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DealerShipSelector1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage CarsTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Dealership;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.NumericUpDown DealerShipSelector1;
        private System.Windows.Forms.Label label1;
    }
}