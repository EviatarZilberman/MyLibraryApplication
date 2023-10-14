namespace MyLibrary.Forms
{
    partial class Main
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
            userBooksList = new ListBox();
            SearchButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            SuspendLayout();
            // 
            // userBooksList
            // 
            userBooksList.AccessibleName = "userBooks";
            userBooksList.FormattingEnabled = true;
            userBooksList.ItemHeight = 25;
            userBooksList.Location = new Point(29, 110);
            userBooksList.Name = "userBooksList";
            userBooksList.Size = new Size(749, 329);
            userBooksList.TabIndex = 1;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(653, 22);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(112, 34);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(508, 22);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(112, 34);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(361, 22);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(112, 34);
            EditButton.TabIndex = 4;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EditButton);
            Controls.Add(DeleteButton);
            Controls.Add(SearchButton);
            Controls.Add(userBooksList);
            Name = "Main";
            Text = "MyLibrary- Main";
            ResumeLayout(false);
        }

        #endregion
        private ListBox userBooksList;
        private Button SearchButton;
        private Button DeleteButton;
        private Button EditButton;
    }
}