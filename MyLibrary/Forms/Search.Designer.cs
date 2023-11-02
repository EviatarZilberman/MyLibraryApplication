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
            bookNameBox = new TextBox();
            authorBox = new TextBox();
            searchButton = new Button();
            addButton = new Button();
            languageLabel = new Label();
            comboLanguageBox = new ComboBox();
            searchedBooksList = new ListView();
            publish_textBox = new TextBox();
            clear_button = new Button();
            SuspendLayout();
            // 
            // searchTitleLabel
            // 
            searchTitleLabel.AutoSize = true;
            searchTitleLabel.Location = new Point(31, 28);
            searchTitleLabel.Margin = new Padding(4, 0, 4, 0);
            searchTitleLabel.Name = "searchTitleLabel";
            searchTitleLabel.Size = new Size(174, 29);
            searchTitleLabel.TabIndex = 0;
            searchTitleLabel.Text = "Search a Book!";
            // 
            // bookNameLabel
            // 
            bookNameLabel.AutoSize = true;
            bookNameLabel.Location = new Point(31, 94);
            bookNameLabel.Margin = new Padding(4, 0, 4, 0);
            bookNameLabel.Name = "bookNameLabel";
            bookNameLabel.Size = new Size(135, 29);
            bookNameLabel.TabIndex = 1;
            bookNameLabel.Text = "Book Name";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(31, 157);
            authorLabel.Margin = new Padding(4, 0, 4, 0);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(83, 29);
            authorLabel.TabIndex = 2;
            authorLabel.Text = "Author";
            // 
            // publishDateLabel
            // 
            publishDateLabel.AutoSize = true;
            publishDateLabel.Location = new Point(31, 225);
            publishDateLabel.Margin = new Padding(4, 0, 4, 0);
            publishDateLabel.Name = "publishDateLabel";
            publishDateLabel.Size = new Size(143, 29);
            publishDateLabel.TabIndex = 3;
            publishDateLabel.Text = "publish Year";
            // 
            // bookNameBox
            // 
            bookNameBox.Location = new Point(199, 99);
            bookNameBox.Margin = new Padding(4, 3, 4, 3);
            bookNameBox.Name = "bookNameBox";
            bookNameBox.Size = new Size(389, 36);
            bookNameBox.TabIndex = 0;
            // 
            // authorBox
            // 
            authorBox.Location = new Point(199, 157);
            authorBox.Margin = new Padding(4, 3, 4, 3);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(389, 36);
            authorBox.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.BackColor = SystemColors.ActiveCaption;
            searchButton.Location = new Point(879, 99);
            searchButton.Margin = new Padding(4, 3, 4, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(146, 39);
            searchButton.TabIndex = 5;
            searchButton.Text = "Search!";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.LimeGreen;
            addButton.Location = new Point(879, 157);
            addButton.Margin = new Padding(4, 3, 4, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(146, 39);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // languageLabel
            // 
            languageLabel.AutoSize = true;
            languageLabel.Location = new Point(31, 285);
            languageLabel.Margin = new Padding(4, 0, 4, 0);
            languageLabel.Name = "languageLabel";
            languageLabel.Size = new Size(116, 29);
            languageLabel.TabIndex = 7;
            languageLabel.Text = "Language";
            // 
            // comboLanguageBox
            // 
            comboLanguageBox.FormattingEnabled = true;
            comboLanguageBox.Items.AddRange(new object[] { "Hebrew", "English", "Aeabic", "Russian", "Idish", "Spanish" });
            comboLanguageBox.Location = new Point(200, 285);
            comboLanguageBox.Margin = new Padding(4, 3, 4, 3);
            comboLanguageBox.Name = "comboLanguageBox";
            comboLanguageBox.Size = new Size(388, 37);
            comboLanguageBox.TabIndex = 3;
            comboLanguageBox.Text = "Hebrew";
            // 
            // searchedBooksList
            // 
            searchedBooksList.CheckBoxes = true;
            searchedBooksList.Location = new Point(22, 341);
            searchedBooksList.Margin = new Padding(4, 3, 4, 3);
            searchedBooksList.Name = "searchedBooksList";
            searchedBooksList.Size = new Size(1001, 280);
            searchedBooksList.TabIndex = 4;
            searchedBooksList.UseCompatibleStateImageBehavior = false;
            searchedBooksList.View = View.Details;
            // 
            // publish_textBox
            // 
            publish_textBox.Location = new Point(203, 222);
            publish_textBox.Margin = new Padding(4, 3, 4, 3);
            publish_textBox.Name = "publish_textBox";
            publish_textBox.Size = new Size(385, 36);
            publish_textBox.TabIndex = 2;
            // 
            // clear_button
            // 
            clear_button.BackColor = Color.Red;
            clear_button.Location = new Point(879, 218);
            clear_button.Margin = new Padding(4, 3, 4, 3);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(146, 39);
            clear_button.TabIndex = 7;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = false;
            clear_button.Click += clear_button_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1040, 636);
            Controls.Add(clear_button);
            Controls.Add(publish_textBox);
            Controls.Add(searchedBooksList);
            Controls.Add(comboLanguageBox);
            Controls.Add(languageLabel);
            Controls.Add(addButton);
            Controls.Add(searchButton);
            Controls.Add(authorBox);
            Controls.Add(bookNameBox);
            Controls.Add(publishDateLabel);
            Controls.Add(authorLabel);
            Controls.Add(bookNameLabel);
            Controls.Add(searchTitleLabel);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Search";
            Text = "MyLibrary- Search";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label searchTitleLabel;
        private Label bookNameLabel;
        private Label authorLabel;
        private Label publishDateLabel;
        private TextBox bookNameBox;
        private TextBox authorBox;
        private Button searchButton;
        private Button addButton;
        private Label languageLabel;
        private ComboBox comboLanguageBox;
        private ListView searchedBooksList;
        private TextBox publish_textBox;
        private Button clear_button;
    }
}