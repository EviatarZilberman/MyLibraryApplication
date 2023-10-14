namespace MyLibrary.Forms
{
    partial class Login
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
            loginButton = new Button();
            usernameLabel = new Label();
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            passwordLabel = new Label();
            stayLoggedcheckBox = new CheckBox();
            registerLinkLabel = new LinkLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(366, 301);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(112, 34);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login!";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(143, 104);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(91, 25);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(247, 98);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(231, 31);
            usernameBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(247, 169);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(231, 31);
            passwordBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(143, 172);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 25);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // stayLoggedcheckBox
            // 
            stayLoggedcheckBox.AutoSize = true;
            stayLoggedcheckBox.Location = new Point(247, 238);
            stayLoggedcheckBox.Name = "stayLoggedcheckBox";
            stayLoggedcheckBox.Size = new Size(164, 29);
            stayLoggedcheckBox.TabIndex = 5;
            stayLoggedcheckBox.Text = "Stay Logged in?";
            stayLoggedcheckBox.UseVisualStyleBackColor = true;
            // 
            // registerLinkLabel
            // 
            registerLinkLabel.AutoSize = true;
            registerLinkLabel.Location = new Point(377, 364);
            registerLinkLabel.Name = "registerLinkLabel";
            registerLinkLabel.Size = new Size(80, 25);
            registerLinkLabel.TabIndex = 6;
            registerLinkLabel.TabStop = true;
            registerLinkLabel.Text = "Register!";
            registerLinkLabel.LinkClicked += registerLinkLabel_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(298, 40);
            label1.Name = "label1";
            label1.Size = new Size(176, 43);
            label1.TabIndex = 7;
            label1.Text = "Welcome!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(registerLinkLabel);
            Controls.Add(stayLoggedcheckBox);
            Controls.Add(passwordBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameBox);
            Controls.Add(usernameLabel);
            Controls.Add(loginButton);
            Name = "Login";
            Text = "MyLibrary- Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private Label usernameLabel;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label passwordLabel;
        private CheckBox stayLoggedcheckBox;
        private LinkLabel registerLinkLabel;
        private Label label1;
    }
}