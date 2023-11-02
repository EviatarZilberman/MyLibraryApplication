namespace MyLibrary.Forms
{
    partial class Edit
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
            editBook_button = new Button();
            title_textBox = new TextBox();
            title_label = new Label();
            author_label = new Label();
            author_textBox = new TextBox();
            language_label = new Label();
            language_textBox = new TextBox();
            type_label = new Label();
            type_textBox = new TextBox();
            addedToMyLibrary_label = new Label();
            added_dateTimePicker = new DateTimePicker();
            lentTo_label = new Label();
            lentTo_textBox = new TextBox();
            rank_label = new Label();
            rank_textBox = new TextBox();
            SuspendLayout();
            // 
            // editBook_button
            // 
            editBook_button.BackColor = Color.Red;
            editBook_button.BackgroundImageLayout = ImageLayout.Center;
            editBook_button.Location = new Point(416, 456);
            editBook_button.Margin = new Padding(4, 3, 4, 3);
            editBook_button.Name = "editBook_button";
            editBook_button.Size = new Size(146, 39);
            editBook_button.TabIndex = 8;
            editBook_button.Text = "Edit Book";
            editBook_button.UseVisualStyleBackColor = false;
            editBook_button.Click += editBook_button_Click;
            // 
            // title_textBox
            // 
            title_textBox.Location = new Point(287, 31);
            title_textBox.Margin = new Padding(4, 3, 4, 3);
            title_textBox.Name = "title_textBox";
            title_textBox.Size = new Size(389, 36);
            title_textBox.TabIndex = 1;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Location = new Point(36, 31);
            title_label.Margin = new Padding(4, 0, 4, 0);
            title_label.Name = "title_label";
            title_label.Size = new Size(58, 29);
            title_label.TabIndex = 2;
            title_label.Text = "Title";
            // 
            // author_label
            // 
            author_label.AutoSize = true;
            author_label.Location = new Point(36, 90);
            author_label.Margin = new Padding(4, 0, 4, 0);
            author_label.Name = "author_label";
            author_label.Size = new Size(83, 29);
            author_label.TabIndex = 4;
            author_label.Text = "Author";
            // 
            // author_textBox
            // 
            author_textBox.Location = new Point(287, 90);
            author_textBox.Margin = new Padding(4, 3, 4, 3);
            author_textBox.Name = "author_textBox";
            author_textBox.Size = new Size(389, 36);
            author_textBox.TabIndex = 2;
            // 
            // language_label
            // 
            language_label.AutoSize = true;
            language_label.Location = new Point(36, 210);
            language_label.Margin = new Padding(4, 0, 4, 0);
            language_label.Name = "language_label";
            language_label.Size = new Size(116, 29);
            language_label.TabIndex = 8;
            language_label.Text = "Language";
            // 
            // language_textBox
            // 
            language_textBox.Location = new Point(287, 210);
            language_textBox.Margin = new Padding(4, 3, 4, 3);
            language_textBox.Name = "language_textBox";
            language_textBox.Size = new Size(389, 36);
            language_textBox.TabIndex = 4;
            // 
            // type_label
            // 
            type_label.AutoSize = true;
            type_label.Location = new Point(36, 151);
            type_label.Margin = new Padding(4, 0, 4, 0);
            type_label.Name = "type_label";
            type_label.Size = new Size(65, 29);
            type_label.TabIndex = 6;
            type_label.Text = "Type";
            // 
            // type_textBox
            // 
            type_textBox.Location = new Point(287, 151);
            type_textBox.Margin = new Padding(4, 3, 4, 3);
            type_textBox.Name = "type_textBox";
            type_textBox.Size = new Size(389, 36);
            type_textBox.TabIndex = 3;
            // 
            // addedToMyLibrary_label
            // 
            addedToMyLibrary_label.AutoSize = true;
            addedToMyLibrary_label.Location = new Point(36, 276);
            addedToMyLibrary_label.Margin = new Padding(4, 0, 4, 0);
            addedToMyLibrary_label.Name = "addedToMyLibrary_label";
            addedToMyLibrary_label.Size = new Size(234, 29);
            addedToMyLibrary_label.TabIndex = 9;
            addedToMyLibrary_label.Text = "Added To My Library";
            // 
            // added_dateTimePicker
            // 
            added_dateTimePicker.Location = new Point(287, 276);
            added_dateTimePicker.Margin = new Padding(4, 3, 4, 3);
            added_dateTimePicker.Name = "added_dateTimePicker";
            added_dateTimePicker.Size = new Size(389, 36);
            added_dateTimePicker.TabIndex = 5;
            // 
            // lentTo_label
            // 
            lentTo_label.AutoSize = true;
            lentTo_label.Location = new Point(36, 394);
            lentTo_label.Margin = new Padding(4, 0, 4, 0);
            lentTo_label.Name = "lentTo_label";
            lentTo_label.Size = new Size(94, 29);
            lentTo_label.TabIndex = 14;
            lentTo_label.Text = "Lent To";
            // 
            // lentTo_textBox
            // 
            lentTo_textBox.Location = new Point(287, 394);
            lentTo_textBox.Margin = new Padding(4, 3, 4, 3);
            lentTo_textBox.Name = "lentTo_textBox";
            lentTo_textBox.Size = new Size(389, 36);
            lentTo_textBox.TabIndex = 7;
            // 
            // rank_label
            // 
            rank_label.AutoSize = true;
            rank_label.Location = new Point(36, 335);
            rank_label.Margin = new Padding(4, 0, 4, 0);
            rank_label.Name = "rank_label";
            rank_label.Size = new Size(66, 29);
            rank_label.TabIndex = 12;
            rank_label.Text = "Rank";
            // 
            // rank_textBox
            // 
            rank_textBox.Location = new Point(287, 335);
            rank_textBox.Margin = new Padding(4, 3, 4, 3);
            rank_textBox.Name = "rank_textBox";
            rank_textBox.Size = new Size(389, 36);
            rank_textBox.TabIndex = 6;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1040, 522);
            Controls.Add(lentTo_label);
            Controls.Add(lentTo_textBox);
            Controls.Add(rank_label);
            Controls.Add(rank_textBox);
            Controls.Add(added_dateTimePicker);
            Controls.Add(addedToMyLibrary_label);
            Controls.Add(language_label);
            Controls.Add(language_textBox);
            Controls.Add(type_label);
            Controls.Add(type_textBox);
            Controls.Add(author_label);
            Controls.Add(author_textBox);
            Controls.Add(title_label);
            Controls.Add(title_textBox);
            Controls.Add(editBook_button);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Edit";
            Text = "MyLibrary- Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button editBook_button;
        private TextBox title_textBox;
        private Label title_label;
        private Label author_label;
        private TextBox author_textBox;
        private Label language_label;
        private TextBox language_textBox;
        private Label type_label;
        private TextBox type_textBox;
        private Label addedToMyLibrary_label;
        private DateTimePicker added_dateTimePicker;
        private Label lentTo_label;
        private TextBox lentTo_textBox;
        private Label rank_label;
        private TextBox rank_textBox;
    }
}