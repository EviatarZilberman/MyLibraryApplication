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
            FirstNameLabel.Location = new Point(29, 85);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(97, 25);
            FirstNameLabel.TabIndex = 2;
            FirstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(29, 154);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(95, 25);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lastNameLabel);
            Controls.Add(FirstNameLabel);
            Controls.Add(usernameLabel);
            Controls.Add(vScrollBar1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private VScrollBar vScrollBar1;
        private Label usernameLabel;
        private Label FirstNameLabel;
        private Label lastNameLabel;
    }
}