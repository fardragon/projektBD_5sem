namespace CarDealership.Controls
{
    partial class ArchiveView
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODYEAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLOYEEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMERID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.VIN,
            this.Model,
            this.COLOR,
            this.PRODYEAR,
            this.EMPLOYEEID,
            this.CUSTOMERID,
            this.SALEDATE});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(912, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // VIN
            // 
            this.VIN.HeaderText = "VIN";
            this.VIN.Name = "VIN";
            this.VIN.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // COLOR
            // 
            this.COLOR.HeaderText = "Color";
            this.COLOR.Name = "COLOR";
            this.COLOR.ReadOnly = true;
            // 
            // PRODYEAR
            // 
            this.PRODYEAR.HeaderText = "Production Year";
            this.PRODYEAR.Name = "PRODYEAR";
            this.PRODYEAR.ReadOnly = true;
            // 
            // EMPLOYEEID
            // 
            this.EMPLOYEEID.HeaderText = "Employee ID";
            this.EMPLOYEEID.Name = "EMPLOYEEID";
            this.EMPLOYEEID.ReadOnly = true;
            // 
            // CUSTOMERID
            // 
            this.CUSTOMERID.HeaderText = "Customer ID";
            this.CUSTOMERID.Name = "CUSTOMERID";
            this.CUSTOMERID.ReadOnly = true;
            // 
            // SALEDATE
            // 
            this.SALEDATE.HeaderText = "Sale Date";
            this.SALEDATE.Name = "SALEDATE";
            this.SALEDATE.ReadOnly = true;
            // 
            // ArchiveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "ArchiveView";
            this.Size = new System.Drawing.Size(912, 418);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODYEAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMERID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALEDATE;
    }
}
