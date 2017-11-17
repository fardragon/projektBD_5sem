namespace CarDealership
{
    partial class AdminScreen
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.EmployeesTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonEditEmp = new System.Windows.Forms.Button();
            this.employeesView1 = new CarDealership.EmployeesView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DGV_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Dealership = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebugTab = new System.Windows.Forms.TabPage();
            this.ResetButton = new System.Windows.Forms.Button();
            this.buttonDelEmp = new System.Windows.Forms.Button();
            this.buttonAddEmp = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.EmployeesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DebugTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.HomeTab);
            this.tabControl.Controls.Add(this.EmployeesTab);
            this.tabControl.Controls.Add(this.DebugTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(855, 516);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.ExitButton);
            this.HomeTab.Controls.Add(this.LogoutButton);
            this.HomeTab.Location = new System.Drawing.Point(4, 22);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(847, 490);
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
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(46, 363);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // EmployeesTab
            // 
            this.EmployeesTab.Controls.Add(this.splitContainer1);
            this.EmployeesTab.Controls.Add(this.dataGridView1);
            this.EmployeesTab.Location = new System.Drawing.Point(4, 22);
            this.EmployeesTab.Name = "EmployeesTab";
            this.EmployeesTab.Size = new System.Drawing.Size(847, 490);
            this.EmployeesTab.TabIndex = 2;
            this.EmployeesTab.Text = "Employees";
            this.EmployeesTab.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddEmp);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDelEmp);
            this.splitContainer1.Panel1.Controls.Add(this.buttonEditEmp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.employeesView1);
            this.splitContainer1.Size = new System.Drawing.Size(847, 490);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 1;
            // 
            // buttonEditEmp
            // 
            this.buttonEditEmp.Location = new System.Drawing.Point(31, 104);
            this.buttonEditEmp.Name = "buttonEditEmp";
            this.buttonEditEmp.Size = new System.Drawing.Size(75, 23);
            this.buttonEditEmp.TabIndex = 0;
            this.buttonEditEmp.Text = "Edit";
            this.buttonEditEmp.UseVisualStyleBackColor = true;
            this.buttonEditEmp.Click += new System.EventHandler(this.buttonEDIT_Click);
            // 
            // employeesView1
            // 
            this.employeesView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesView1.Location = new System.Drawing.Point(0, 0);
            this.employeesView1.Name = "employeesView1";
            this.employeesView1.Size = new System.Drawing.Size(666, 490);
            this.employeesView1.TabIndex = 0;
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
            // DebugTab
            // 
            this.DebugTab.Controls.Add(this.ResetButton);
            this.DebugTab.Location = new System.Drawing.Point(4, 22);
            this.DebugTab.Name = "DebugTab";
            this.DebugTab.Padding = new System.Windows.Forms.Padding(3);
            this.DebugTab.Size = new System.Drawing.Size(847, 490);
            this.DebugTab.TabIndex = 1;
            this.DebugTab.Text = "Debug";
            this.DebugTab.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(8, 6);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "Reset DB";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // buttonDelEmp
            // 
            this.buttonDelEmp.Location = new System.Drawing.Point(31, 75);
            this.buttonDelEmp.Name = "buttonDelEmp";
            this.buttonDelEmp.Size = new System.Drawing.Size(75, 23);
            this.buttonDelEmp.TabIndex = 1;
            this.buttonDelEmp.Text = "Delete";
            this.buttonDelEmp.UseVisualStyleBackColor = true;
            this.buttonDelEmp.Click += new System.EventHandler(this.buttonDelEmp_Click);
            // 
            // buttonAddEmp
            // 
            this.buttonAddEmp.Location = new System.Drawing.Point(31, 46);
            this.buttonAddEmp.Name = "buttonAddEmp";
            this.buttonAddEmp.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEmp.TabIndex = 2;
            this.buttonAddEmp.Text = "Add";
            this.buttonAddEmp.UseVisualStyleBackColor = true;
            this.buttonAddEmp.Click += new System.EventHandler(this.buttonAddEmp_Click);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 516);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminScreen";
            this.Text = "AdminScreen";
            this.tabControl.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.EmployeesTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DebugTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.TabPage DebugTab;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.TabPage EmployeesTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Dealership;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private EmployeesView employeesView1;
        private System.Windows.Forms.Button buttonEditEmp;
        private System.Windows.Forms.Button buttonDelEmp;
        private System.Windows.Forms.Button buttonAddEmp;
    }
}