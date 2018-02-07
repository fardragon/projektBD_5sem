namespace CarDealership.Forms
{
    partial class OrderReassign
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
            this.components = new System.ComponentModel.Container();
            this.SellerComboBox = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellersDataSet = new CarDealership.SellersDataSet();
            this.employeesTableAdapter = new CarDealership.SellersDataSetTableAdapters.EmployeesTableAdapter();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.NewSellerLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SellerComboBox
            // 
            this.SellerComboBox.DataSource = this.employeesBindingSource;
            this.SellerComboBox.DisplayMember = "NAME";
            this.SellerComboBox.FormattingEnabled = true;
            this.SellerComboBox.Location = new System.Drawing.Point(79, 21);
            this.SellerComboBox.Name = "SellerComboBox";
            this.SellerComboBox.Size = new System.Drawing.Size(190, 21);
            this.SellerComboBox.TabIndex = 0;
            this.SellerComboBox.ValueMember = "EMPLOYEE_ID";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.sellersDataSet;
            // 
            // sellersDataSet
            // 
            this.sellersDataSet.DataSetName = "SellersDataSet";
            this.sellersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(194, 76);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 1;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // NewSellerLabel
            // 
            this.NewSellerLabel.AutoSize = true;
            this.NewSellerLabel.Location = new System.Drawing.Point(12, 24);
            this.NewSellerLabel.Name = "NewSellerLabel";
            this.NewSellerLabel.Size = new System.Drawing.Size(61, 13);
            this.NewSellerLabel.TabIndex = 2;
            this.NewSellerLabel.Text = "New Seller:";
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(15, 73);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OrderReassign
            // 
            this.AcceptButton = this.ConfirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(284, 108);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NewSellerLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.SellerComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OrderReassign";
            this.Text = "Reassign Order ";
            this.Load += new System.EventHandler(this.OrderReassign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SellerComboBox;
        private SellersDataSet sellersDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private SellersDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label NewSellerLabel;
        private System.Windows.Forms.Button CancelButton;
    }
}