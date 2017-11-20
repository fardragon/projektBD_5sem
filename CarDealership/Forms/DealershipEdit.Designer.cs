namespace CarDealership
{
    partial class DealershipEdit
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxZipcode = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.comboBoxManager = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Zipcode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "City:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address:";
            // 
            // textBoxZipcode
            // 
            this.textBoxZipcode.Location = new System.Drawing.Point(93, 150);
            this.textBoxZipcode.MaxLength = 10;
            this.textBoxZipcode.Name = "textBoxZipcode";
            this.textBoxZipcode.Size = new System.Drawing.Size(141, 20);
            this.textBoxZipcode.TabIndex = 3;
            this.textBoxZipcode.Enter += new System.EventHandler(this.textBoxZipcode_Enter);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(93, 123);
            this.textBoxCity.MaxLength = 50;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(141, 20);
            this.textBoxCity.TabIndex = 2;
            this.textBoxCity.Enter += new System.EventHandler(this.textBoxCity_Enter);
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(93, 38);
            this.textBoxAdress.MaxLength = 100;
            this.textBoxAdress.Multiline = true;
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(141, 79);
            this.textBoxAdress.TabIndex = 1;
            this.textBoxAdress.Enter += new System.EventHandler(this.textBoxAdress_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Editing dealership with id: ";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(162, 13);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // comboBoxManager
            // 
            this.comboBoxManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManager.FormattingEnabled = true;
            this.comboBoxManager.Location = new System.Drawing.Point(93, 176);
            this.comboBoxManager.Name = "comboBoxManager";
            this.comboBoxManager.Size = new System.Drawing.Size(141, 21);
            this.comboBoxManager.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Manager:";
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(74, 217);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(178, 217);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 5;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // DealershipEdit
            // 
            this.AcceptButton = this.buttonConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxManager);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxZipcode);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxAdress);
            this.Name = "DealershipEdit";
            this.Text = "DealershipEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxZipcode;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox comboBoxManager;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.ToolTip toolTip;
    }
}