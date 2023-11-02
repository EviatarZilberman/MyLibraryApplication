namespace MyLibrary.Forms
{
    partial class Register
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
            usernameLabel = new Label();
            FirstNameLabel = new Label();
            lastNameLabel = new Label();
            emailLabel = new Label();
            confirmedPassword = new Label();
            Password = new Label();
            birthDateLabel = new Label();
            UserNameBox = new TextBox();
            passwordBox = new TextBox();
            confirmPasswordBox = new TextBox();
            emailBox = new TextBox();
            lastNameBox = new TextBox();
            firstNameBox = new TextBox();
            registerButton = new Button();
            birthDateOnlyBox = new DateTimePicker();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(38, 31);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(121, 29);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(38, 80);
            FirstNameLabel.Margin = new Padding(4, 0, 4, 0);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(129, 29);
            FirstNameLabel.TabIndex = 2;
            FirstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(38, 132);
            lastNameLabel.Margin = new Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(127, 29);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(38, 184);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(69, 29);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email";
            // 
            // confirmedPassword
            // 
            confirmedPassword.AutoSize = true;
            confirmedPassword.Location = new Point(38, 361);
            confirmedPassword.Margin = new Padding(4, 0, 4, 0);
            confirmedPassword.Name = "confirmedPassword";
            confirmedPassword.Size = new Size(204, 29);
            confirmedPassword.TabIndex = 5;
            confirmedPassword.Text = "Confirm Password";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(38, 293);
            Password.Margin = new Padding(4, 0, 4, 0);
            Password.Name = "Password";
            Password.Size = new Size(114, 29);
            Password.TabIndex = 6;
            Password.Text = "Password";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new Point(38, 233);
            birthDateLabel.Margin = new Padding(4, 0, 4, 0);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(120, 29);
            birthDateLabel.TabIndex = 7;
            birthDateLabel.Text = "Birth Date";
            // 
            // UserNameBox
            // 
            UserNameBox.Location = new Point(263, 31);
            UserNameBox.Margin = new Padding(4, 3, 4, 3);
            UserNameBox.Name = "UserNameBox";
            UserNameBox.Size = new Size(389, 36);
            UserNameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(263, 293);
            passwordBox.Margin = new Padding(4, 3, 4, 3);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(389, 36);
            passwordBox.TabIndex = 5;
            // 
            // confirmPasswordBox
            // 
            confirmPasswordBox.Location = new Point(263, 361);
            confirmPasswordBox.Margin = new Padding(4, 3, 4, 3);
            confirmPasswordBox.Name = "confirmPasswordBox";
            confirmPasswordBox.Size = new Size(389, 36);
            confirmPasswordBox.TabIndex = 6;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(263, 181);
            emailBox.Margin = new Padding(4, 3, 4, 3);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(389, 36);
            emailBox.TabIndex = 3;
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(263, 129);
            lastNameBox.Margin = new Padding(4, 3, 4, 3);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(389, 36);
            lastNameBox.TabIndex = 2;
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(263, 80);
            firstNameBox.Margin = new Padding(4, 3, 4, 3);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(389, 36);
            firstNameBox.TabIndex = 1;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.LimeGreen;
            registerButton.Location = new Point(315, 449);
            registerButton.Margin = new Padding(4, 3, 4, 3);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(146, 39);
            registerButton.TabIndex = 7;
            registerButton.Text = "Register!";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // birthDateOnlyBox
            // 
            birthDateOnlyBox.Location = new Point(261, 242);
            birthDateOnlyBox.Margin = new Padding(4, 3, 4, 3);
            birthDateOnlyBox.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            birthDateOnlyBox.Name = "birthDateOnlyBox";
            birthDateOnlyBox.Size = new Size(389, 36);
            birthDateOnlyBox.TabIndex = 4;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(749, 522);
            Controls.Add(birthDateOnlyBox);
            Controls.Add(registerButton);
            Controls.Add(firstNameBox);
            Controls.Add(lastNameBox);
            Controls.Add(emailBox);
            Controls.Add(confirmPasswordBox);
            Controls.Add(passwordBox);
            Controls.Add(UserNameBox);
            Controls.Add(birthDateLabel);
            Controls.Add(Password);
            Controls.Add(confirmedPassword);
            Controls.Add(emailLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(FirstNameLabel);
            Controls.Add(usernameLabel);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Register";
            Text = "MyLibrary- Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label usernameLabel;
        private Label FirstNameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private Label confirmedPassword;
        private Label Password;
        private Label birthDateLabel;
        private TextBox UserNameBox;
        private TextBox passwordBox;
        private TextBox confirmPasswordBox;
        private TextBox emailBox;
        private TextBox lastNameBox;
        private TextBox firstNameBox;
        private Button registerButton;
        private DateTimePicker birthDateOnlyBox;
    }
}