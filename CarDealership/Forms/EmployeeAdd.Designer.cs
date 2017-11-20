namespace CarDealership
{
    partial class EmployeeAdd
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
            this.buttonCONFIRM = new System.Windows.Forms.Button();
            this.buttonEXIT = new System.Windows.Forms.Button();
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSURNAME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUSERNAME = new System.Windows.Forms.TextBox();
            this.textBoxPASSWORD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.roleSelector1 = new CarDealership.Controls.RoleSelector();
            this.dealershipSelector1 = new CarDealership.Controls.DealershipSelector();
            this.toolTipEdit = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonCONFIRM
            // 
            this.buttonCONFIRM.Location = new System.Drawing.Point(177, 178);
            this.buttonCONFIRM.Name = "buttonCONFIRM";
            this.buttonCONFIRM.Size = new System.Drawing.Size(73, 23);
            this.buttonCONFIRM.TabIndex = 7;
            this.buttonCONFIRM.Text = "Confirm";
            this.buttonCONFIRM.UseVisualStyleBackColor = true;
            this.buttonCONFIRM.Click += new System.EventHandler(this.buttonCONFIRM_Click);
            // 
            // buttonEXIT
            // 
            this.buttonEXIT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEXIT.Location = new System.Drawing.Point(105, 178);
            this.buttonEXIT.Name = "buttonEXIT";
            this.buttonEXIT.Size = new System.Drawing.Size(66, 23);
            this.buttonEXIT.TabIndex = 8;
            this.buttonEXIT.Text = "Exit";
            this.buttonEXIT.UseVisualStyleBackColor = true;
            this.buttonEXIT.Click += new System.EventHandler(this.buttonEXIT_Click);
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.Location = new System.Drawing.Point(105, 19);
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(145, 20);
            this.textBoxNAME.TabIndex = 1;
            this.textBoxNAME.Enter += new System.EventHandler(this.textBoxNAME_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname:";
            // 
            // textBoxSURNAME
            // 
            this.textBoxSURNAME.Location = new System.Drawing.Point(105, 46);
            this.textBoxSURNAME.Name = "textBoxSURNAME";
            this.textBoxSURNAME.Size = new System.Drawing.Size(145, 20);
            this.textBoxSURNAME.TabIndex = 2;
            this.textBoxSURNAME.Enter += new System.EventHandler(this.textBoxSURNAME_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dealership:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Role:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Username:";
            // 
            // textBoxUSERNAME
            // 
            this.textBoxUSERNAME.Location = new System.Drawing.Point(105, 126);
            this.textBoxUSERNAME.MaxLength = 50;
            this.textBoxUSERNAME.Name = "textBoxUSERNAME";
            this.textBoxUSERNAME.Size = new System.Drawing.Size(145, 20);
            this.textBoxUSERNAME.TabIndex = 5;
            this.textBoxUSERNAME.Enter += new System.EventHandler(this.textBoxUSERNAME_Enter);
            this.textBoxUSERNAME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUSERNAME_KeyPress);
            // 
            // textBoxPASSWORD
            // 
            this.textBoxPASSWORD.Location = new System.Drawing.Point(105, 152);
            this.textBoxPASSWORD.MaxLength = 30;
            this.textBoxPASSWORD.Name = "textBoxPASSWORD";
            this.textBoxPASSWORD.PasswordChar = '×';
            this.textBoxPASSWORD.Size = new System.Drawing.Size(145, 20);
            this.textBoxPASSWORD.TabIndex = 6;
            this.textBoxPASSWORD.Enter += new System.EventHandler(this.textBoxPASSWORD_Enter);
            this.textBoxPASSWORD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPASSWORD_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "New Password:";
            // 
            // roleSelector1
            // 
            this.roleSelector1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleSelector1.Location = new System.Drawing.Point(105, 99);
            this.roleSelector1.Name = "roleSelector1";
            this.roleSelector1.Size = new System.Drawing.Size(145, 21);
            this.roleSelector1.TabIndex = 4;
            // 
            // dealershipSelector1
            // 
            this.dealershipSelector1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dealershipSelector1.FormattingEnabled = true;
            this.dealershipSelector1.Location = new System.Drawing.Point(105, 73);
            this.dealershipSelector1.Name = "dealershipSelector1";
            this.dealershipSelector1.Size = new System.Drawing.Size(145, 21);
            this.dealershipSelector1.TabIndex = 3;
            // 
            // EmployeeAdd
            // 
            this.AcceptButton = this.buttonCONFIRM;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonEXIT;
            this.ClientSize = new System.Drawing.Size(310, 219);
            this.Controls.Add(this.dealershipSelector1);
            this.Controls.Add(this.roleSelector1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPASSWORD);
            this.Controls.Add(this.textBoxUSERNAME);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSURNAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNAME);
            this.Controls.Add(this.buttonEXIT);
            this.Controls.Add(this.buttonCONFIRM);
            this.Name = "EmployeeAdd";
            this.Text = "EmployeeAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCONFIRM;
        private System.Windows.Forms.Button buttonEXIT;
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSURNAME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUSERNAME;
        private System.Windows.Forms.TextBox textBoxPASSWORD;
        private System.Windows.Forms.Label label7;
        private Controls.RoleSelector roleSelector1;
        private Controls.DealershipSelector dealershipSelector1;
        private System.Windows.Forms.ToolTip toolTipEdit;
    }
}