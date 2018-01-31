namespace CarDealership.Forms
{
    partial class CarDetails
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
            this.PriceTreeView = new System.Windows.Forms.TreeView();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PriceTreeView
            // 
            this.PriceTreeView.Location = new System.Drawing.Point(12, 12);
            this.PriceTreeView.Name = "PriceTreeView";
            this.PriceTreeView.Size = new System.Drawing.Size(260, 208);
            this.PriceTreeView.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 226);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(260, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CarDetails
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.PriceTreeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CarDetails";
            this.Text = "Car Details";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView PriceTreeView;
        private System.Windows.Forms.Button OKButton;
    }
}