
namespace PI_Store
{
    partial class Form1
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
            this.userNametextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.LoginTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNametextBox
            // 
            this.userNametextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.userNametextBox.Location = new System.Drawing.Point(908, 273);
            this.userNametextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.userNametextBox.Name = "userNametextBox";
            this.userNametextBox.Size = new System.Drawing.Size(520, 56);
            this.userNametextBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(693, 273);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(198, 49);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(693, 387);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(198, 49);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(908, 385);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(520, 56);
            this.passwordTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(908, 493);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(209, 59);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // LoginTitle
            // 
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("JetBrains Mono", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitle.Location = new System.Drawing.Point(894, 100);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(415, 84);
            this.LoginTitle.TabIndex = 6;
            this.LoginTitle.Text = "Login Page";
            this.LoginTitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 49F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2701, 1241);
            this.Controls.Add(this.LoginTitle);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.userNametextBox);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Font = new System.Drawing.Font("JetBrains Mono", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "PI Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNametextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label LoginTitle;
    }
}

