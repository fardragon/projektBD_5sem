namespace CarDealership.Controls
{
    partial class CustomersView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CUST_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUST_ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUST_CITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUST_ZIPCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUST_PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUST_MAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUST_ID,
            this.CUST_NAME,
            this.CUST_ADDRESS,
            this.CUST_CITY,
            this.CUST_ZIPCODE,
            this.CUST_PHONE,
            this.CUST_MAIL});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(743, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // CUST_ID
            // 
            this.CUST_ID.HeaderText = "ID";
            this.CUST_ID.Name = "CUST_ID";
            this.CUST_ID.ReadOnly = true;
            // 
            // CUST_NAME
            // 
            this.CUST_NAME.HeaderText = "Name";
            this.CUST_NAME.Name = "CUST_NAME";
            this.CUST_NAME.ReadOnly = true;
            // 
            // CUST_ADDRESS
            // 
            this.CUST_ADDRESS.HeaderText = "Address";
            this.CUST_ADDRESS.Name = "CUST_ADDRESS";
            this.CUST_ADDRESS.ReadOnly = true;
            // 
            // CUST_CITY
            // 
            this.CUST_CITY.HeaderText = "City";
            this.CUST_CITY.Name = "CUST_CITY";
            this.CUST_CITY.ReadOnly = true;
            // 
            // CUST_ZIPCODE
            // 
            this.CUST_ZIPCODE.HeaderText = "Zipcode";
            this.CUST_ZIPCODE.Name = "CUST_ZIPCODE";
            this.CUST_ZIPCODE.ReadOnly = true;
            // 
            // CUST_PHONE
            // 
            this.CUST_PHONE.HeaderText = "Phone";
            this.CUST_PHONE.Name = "CUST_PHONE";
            this.CUST_PHONE.ReadOnly = true;
            // 
            // CUST_MAIL
            // 
            this.CUST_MAIL.HeaderText = "Mail";
            this.CUST_MAIL.Name = "CUST_MAIL";
            this.CUST_MAIL.ReadOnly = true;
            // 
            // CustomersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomersView";
            this.Size = new System.Drawing.Size(743, 299);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_CITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_ZIPCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_MAIL;
    }
}
