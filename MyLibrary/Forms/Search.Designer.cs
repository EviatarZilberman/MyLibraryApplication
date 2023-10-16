namespace MyLibrary.Forms
{
    partial class Search
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
            searchTitleLabel = new Label();
            bookNameLabel = new Label();
            authorLabel = new Label();
            publishDateLabel = new Label();
            searchedBooksList = new ListBox();
            bookNameBox = new TextBox();
            authorBox = new TextBox();
            publishDateBox = new DateTimePicker();
            searchButton = new Button();
            addButton = new Button();
            SuspendLayout();
            // 
            // searchTitleLabel
            // 
            searchTitleLabel.AutoSize = true;
            searchTitleLabel.Location = new Point(24, 24);
            searchTitleLabel.Name = "searchTitleLabel";
            searchTitleLabel.Size = new Size(129, 25);
            searchTitleLabel.TabIndex = 0;
            searchTitleLabel.Text = "Search a Book!";
            // 
            // bookNameLabel
            // 
            bookNameLabel.AutoSize = true;
            bookNameLabel.Location = new Point(24, 81);
            bookNameLabel.Name = "bookNameLabel";
            bookNameLabel.Size = new Size(105, 25);
            bookNameLabel.TabIndex = 1;
            bookNameLabel.Text = "Book Name";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(24, 135);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(67, 25);
            authorLabel.TabIndex = 2;
            authorLabel.Text = "Author";
            // 
            // publishDateLabel
            // 
            publishDateLabel.AutoSize = true;
            publishDateLabel.Location = new Point(24, 194);
            publishDateLabel.Name = "publishDateLabel";
            publishDateLabel.Size = new Size(112, 25);
            publishDateLabel.TabIndex = 3;
            publishDateLabel.Text = "publish Date";
            // 
            // searchedBooksList
            // 
            searchedBooksList.FormattingEnabled = true;
            searchedBooksList.ItemHeight = 25;
            searchedBooksList.Location = new Point(12, 237);
            searchedBooksList.Name = "searchedBooksList";
            searchedBooksList.Size = new Size(776, 204);
            searchedBooksList.TabIndex = 4;
            // 
            // bookNameBox
            // 
            bookNameBox.Location = new Point(153, 85);
            bookNameBox.Name = "bookNameBox";
            bookNameBox.Size = new Size(300, 31);
            bookNameBox.TabIndex = 0;
            // 
            // authorBox
            // 
            authorBox.Location = new Point(153, 135);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(300, 31);
            authorBox.TabIndex = 1;
            // 
            // publishDateBox
            // 
            publishDateBox.Location = new Point(153, 188);
            publishDateBox.Name = "publishDateBox";
            publishDateBox.Size = new Size(300, 31);
            publishDateBox.TabIndex = 2;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(676, 81);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 34);
            searchButton.TabIndex = 5;
            searchButton.Text = "Search!";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(676, 135);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 34);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addButton);
            Controls.Add(searchButton);
            Controls.Add(publishDateBox);
            Controls.Add(authorBox);
            Controls.Add(bookNameBox);
            Controls.Add(searchedBooksList);
            Controls.Add(publishDateLabel);
            Controls.Add(authorLabel);
            Controls.Add(bookNameLabel);
            Controls.Add(searchTitleLabel);
            Name = "Search";
            Text = "Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label searchTitleLabel;
        private Label bookNameLabel;
        private Label authorLabel;
        private Label publishDateLabel;
        private ListBox searchedBooksList;
        private TextBox bookNameBox;
        private TextBox authorBox;
        private DateTimePicker publishDateBox;
        private Button searchButton;
        private Button addButton;
    }
}