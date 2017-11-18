namespace CarDealership
{
    partial class ManagerScreen
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.EmployeesView = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.employeesManagerView1 = new CarDealership.Controls.EmployeesManagerView();
            this.tabControl1.SuspendLayout();
            this.EmployeesView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.HomeTab);
            this.tabControl1.Controls.Add(this.EmployeesView);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 451);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // HomeTab
            // 
            this.HomeTab.Location = new System.Drawing.Point(4, 22);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(823, 425);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // EmployeesView
            // 
            this.EmployeesView.Controls.Add(this.splitContainer1);
            this.EmployeesView.Location = new System.Drawing.Point(4, 22);
            this.EmployeesView.Name = "EmployeesView";
            this.EmployeesView.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeesView.Size = new System.Drawing.Size(823, 425);
            this.EmployeesView.TabIndex = 1;
            this.EmployeesView.Text = "Employees";
            this.EmployeesView.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkGray;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer1.Panel2.Controls.Add(this.employeesManagerView1);
            this.splitContainer1.Size = new System.Drawing.Size(817, 419);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 0;
            // 
            // employeesManagerView1
            // 
            this.employeesManagerView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesManagerView1.Location = new System.Drawing.Point(0, 0);
            this.employeesManagerView1.Name = "employeesManagerView1";
            this.employeesManagerView1.Size = new System.Drawing.Size(643, 419);
            this.employeesManagerView1.TabIndex = 0;
            // 
            // ManagerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 451);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManagerScreen";
            this.Text = "ManagerScreencs";
            this.tabControl1.ResumeLayout(false);
            this.EmployeesView.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.TabPage EmployeesView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.EmployeesManagerView employeesManagerView1;
    }
}