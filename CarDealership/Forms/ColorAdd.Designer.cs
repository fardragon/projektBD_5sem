namespace CarDealership.Forms
{
    partial class ColorAdd
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
            this.ConfirnButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ColorNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ConfirnButton
            // 
            this.ConfirnButton.Location = new System.Drawing.Point(189, 73);
            this.ConfirnButton.Name = "ConfirnButton";
            this.ConfirnButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirnButton.TabIndex = 2;
            this.ConfirnButton.Text = "Confirm";
            this.ConfirnButton.UseVisualStyleBackColor = true;
            this.ConfirnButton.Click += new System.EventHandler(this.ConfirnButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(93, 73);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ColorNameTextBox
            // 
            this.ColorNameTextBox.Location = new System.Drawing.Point(93, 30);
            this.ColorNameTextBox.Name = "ColorNameTextBox";
            this.ColorNameTextBox.Size = new System.Drawing.Size(171, 20);
            this.ColorNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color name:";
            // 
            // ColorAdd
            // 
            this.AcceptButton = this.ConfirnButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(288, 109);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorNameTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ConfirnButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ColorAdd";
            this.Text = "ColorAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirnButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox ColorNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip;
    }
}