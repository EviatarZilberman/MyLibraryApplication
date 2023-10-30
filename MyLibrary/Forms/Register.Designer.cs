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
            vScrollBar1 = new VScrollBar();
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
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(752, 9);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(39, 432);
            vScrollBar1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(29, 27);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(91, 25);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(29, 69);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(97, 25);
            FirstNameLabel.TabIndex = 2;
            FirstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(29, 114);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(95, 25);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(29, 159);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(54, 25);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email";
            // 
            // confirmedPassword
            // 
            confirmedPassword.AutoSize = true;
            confirmedPassword.Location = new Point(29, 311);
            confirmedPassword.Name = "confirmedPassword";
            confirmedPassword.Size = new Size(156, 25);
            confirmedPassword.TabIndex = 5;
            confirmedPassword.Text = "Confirm Password";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(29, 253);
            Password.Name = "Password";
            Password.Size = new Size(87, 25);
            Password.TabIndex = 6;
            Password.Text = "Password";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new Point(29, 201);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(90, 25);
            birthDateLabel.TabIndex = 7;
            birthDateLabel.Text = "Birth Date";
            // 
            // UserNameBox
            // 
            UserNameBox.Location = new Point(202, 27);
            UserNameBox.Name = "UserNameBox";
            UserNameBox.Size = new Size(300, 31);
            UserNameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(202, 253);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(300, 31);
            passwordBox.TabIndex = 5;
            // 
            // confirmPasswordBox
            // 
            confirmPasswordBox.Location = new Point(202, 311);
            confirmPasswordBox.Name = "confirmPasswordBox";
            confirmPasswordBox.Size = new Size(300, 31);
            confirmPasswordBox.TabIndex = 6;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(202, 156);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(300, 31);
            emailBox.TabIndex = 3;
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(202, 111);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(300, 31);
            lastNameBox.TabIndex = 2;
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(202, 69);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(300, 31);
            firstNameBox.TabIndex = 1;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(349, 384);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(112, 34);
            registerButton.TabIndex = 7;
            registerButton.Text = "Register!";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // birthDateOnlyBox
            // 
            birthDateOnlyBox.Location = new Point(201, 209);
            birthDateOnlyBox.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            birthDateOnlyBox.Name = "birthDateOnlyBox";
            birthDateOnlyBox.Size = new Size(300, 31);
            birthDateOnlyBox.TabIndex = 4;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(vScrollBar1);
            Name = "Register";
            Text = "MyLibrary- Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private VScrollBar vScrollBar1;
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