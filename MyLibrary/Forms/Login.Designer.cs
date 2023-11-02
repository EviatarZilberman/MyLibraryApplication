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
            registerLinkLabel = new LinkLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.LimeGreen;
            loginButton.Location = new Point(476, 349);
            loginButton.Margin = new Padding(4, 3, 4, 3);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(146, 39);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login!";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(186, 121);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(121, 29);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(321, 114);
            usernameBox.Margin = new Padding(4, 3, 4, 3);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(299, 36);
            usernameBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(321, 196);
            passwordBox.Margin = new Padding(4, 3, 4, 3);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(299, 36);
            passwordBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(186, 200);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(114, 29);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // registerLinkLabel
            // 
            registerLinkLabel.AutoSize = true;
            registerLinkLabel.Location = new Point(490, 422);
            registerLinkLabel.Margin = new Padding(4, 0, 4, 0);
            registerLinkLabel.Name = "registerLinkLabel";
            registerLinkLabel.Size = new Size(108, 29);
            registerLinkLabel.TabIndex = 6;
            registerLinkLabel.TabStop = true;
            registerLinkLabel.Text = "Register!";
            registerLinkLabel.LinkClicked += registerLinkLabel_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(387, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 43);
            label1.TabIndex = 7;
            label1.Text = "Welcome!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1040, 522);
            Controls.Add(label1);
            Controls.Add(registerLinkLabel);
            Controls.Add(passwordBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameBox);
            Controls.Add(usernameLabel);
            Controls.Add(loginButton);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            Text = "MyLibrary- Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private Label usernameLabel;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label passwordLabel;
        private LinkLabel registerLinkLabel;
        private Label label1;
    }
}