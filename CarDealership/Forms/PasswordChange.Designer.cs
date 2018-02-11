namespace CarDealership.Forms
{
    partial class PasswordChange
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
            this.textBoxOldPWD = new System.Windows.Forms.TextBox();
            this.textBoxNewPWD = new System.Windows.Forms.TextBox();
            this.textBoxRepeatPWD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBoxOldPWD
            // 
            this.textBoxOldPWD.Location = new System.Drawing.Point(122, 29);
            this.textBoxOldPWD.Name = "textBoxOldPWD";
            this.textBoxOldPWD.PasswordChar = '×';
            this.textBoxOldPWD.Size = new System.Drawing.Size(150, 20);
            this.textBoxOldPWD.TabIndex = 1;
            this.textBoxOldPWD.Enter += new System.EventHandler(this.textBoxOldPWD_Enter);
            this.textBoxOldPWD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOldPWD_KeyPress);
            // 
            // textBoxNewPWD
            // 
            this.textBoxNewPWD.Location = new System.Drawing.Point(122, 55);
            this.textBoxNewPWD.Name = "textBoxNewPWD";
            this.textBoxNewPWD.PasswordChar = '×';
            this.textBoxNewPWD.Size = new System.Drawing.Size(150, 20);
            this.textBoxNewPWD.TabIndex = 2;
            this.textBoxNewPWD.Enter += new System.EventHandler(this.textBoxNewPWD_Enter);
            this.textBoxNewPWD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewPWD_KeyPress);
            // 
            // textBoxRepeatPWD
            // 
            this.textBoxRepeatPWD.Location = new System.Drawing.Point(122, 81);
            this.textBoxRepeatPWD.Name = "textBoxRepeatPWD";
            this.textBoxRepeatPWD.PasswordChar = '×';
            this.textBoxRepeatPWD.Size = new System.Drawing.Size(150, 20);
            this.textBoxRepeatPWD.TabIndex = 3;
            this.textBoxRepeatPWD.Enter += new System.EventHandler(this.textBoxRepeatPWD_Enter);
            this.textBoxRepeatPWD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRepeatPWD_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "New password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Repeat:";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(197, 120);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 5;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(116, 120);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // PasswordChange
            // 
            this.AcceptButton = this.buttonConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(298, 155);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRepeatPWD);
            this.Controls.Add(this.textBoxNewPWD);
            this.Controls.Add(this.textBoxOldPWD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PasswordChange";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOldPWD;
        private System.Windows.Forms.TextBox textBoxNewPWD;
        private System.Windows.Forms.TextBox textBoxRepeatPWD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ToolTip toolTip;
    }
}