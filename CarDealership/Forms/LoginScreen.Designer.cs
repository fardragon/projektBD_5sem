namespace CarDealership.Forms
{
    partial class LoginScreen
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
            this.exitButton = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.toolTipLogin = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(79, 97);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPassword.Location = new System.Drawing.Point(79, 71);
            this.textBoxPassword.MaxLength = 30;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '×';
            this.textBoxPassword.Size = new System.Drawing.Size(156, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(16, 74);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(53, 13);
            this.label_password.TabIndex = 0;
            this.label_password.Text = "Password";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(16, 48);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(55, 13);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(160, 97);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(79, 45);
            this.textBoxUsername.MaxLength = 50;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(156, 20);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsername_KeyPress);
            // 
            // LoginScreen
            // 
            this.AcceptButton = this.loginButton;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Dealership Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.ToolTip toolTipLogin;
        private System.Windows.Forms.TextBox textBoxUsername;
    }
}

