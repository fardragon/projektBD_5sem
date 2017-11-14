namespace CarDealership
{
    partial class EmployeesView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.EMPLOYEE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SURNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEALERSHIP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOGIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EMPLOYEE_ID,
            this.NAME,
            this.SURNAME,
            this.DEALERSHIP_ID,
            this.ROLE_ID,
            this.LOGIN,
            this.PASSWORD});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(440, 341);
            this.dataGridView.TabIndex = 0;
            // 
            // EMPLOYEE_ID
            // 
            this.EMPLOYEE_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EMPLOYEE_ID.HeaderText = "ID";
            this.EMPLOYEE_ID.Name = "EMPLOYEE_ID";
            this.EMPLOYEE_ID.ReadOnly = true;
            this.EMPLOYEE_ID.Width = 43;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "Name";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // SURNAME
            // 
            this.SURNAME.HeaderText = "Surname";
            this.SURNAME.Name = "SURNAME";
            this.SURNAME.ReadOnly = true;
            // 
            // DEALERSHIP_ID
            // 
            this.DEALERSHIP_ID.FillWeight = 80F;
            this.DEALERSHIP_ID.HeaderText = "Dealership";
            this.DEALERSHIP_ID.Name = "DEALERSHIP_ID";
            this.DEALERSHIP_ID.ReadOnly = true;
            // 
            // ROLE_ID
            // 
            this.ROLE_ID.HeaderText = "Role";
            this.ROLE_ID.Name = "ROLE_ID";
            this.ROLE_ID.ReadOnly = true;
            // 
            // LOGIN
            // 
            this.LOGIN.HeaderText = "Username";
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.ReadOnly = true;
            // 
            // PASSWORD
            // 
            this.PASSWORD.HeaderText = "Password";
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.ReadOnly = true;
            // 
            // EmployeesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Name = "EmployeesView";
            this.Size = new System.Drawing.Size(440, 341);
            this.Enter += new System.EventHandler(this.EmployeesView_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SURNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEALERSHIP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROLE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOGIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSWORD;
    }
}
