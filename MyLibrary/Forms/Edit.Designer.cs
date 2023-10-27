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
            editBook_button.BackgroundImageLayout = ImageLayout.Center;
            editBook_button.Location = new Point(320, 393);
            editBook_button.Name = "editBook_button";
            editBook_button.Size = new Size(112, 34);
            editBook_button.TabIndex = 8;
            editBook_button.Text = "Edit Book";
            editBook_button.UseVisualStyleBackColor = true;
            // 
            // title_textBox
            // 
            title_textBox.Location = new Point(221, 27);
            title_textBox.Name = "title_textBox";
            title_textBox.Size = new Size(300, 31);
            title_textBox.TabIndex = 1;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Location = new Point(28, 27);
            title_label.Name = "title_label";
            title_label.Size = new Size(44, 25);
            title_label.TabIndex = 2;
            title_label.Text = "Title";
            // 
            // author_label
            // 
            author_label.AutoSize = true;
            author_label.Location = new Point(28, 78);
            author_label.Name = "author_label";
            author_label.Size = new Size(67, 25);
            author_label.TabIndex = 4;
            author_label.Text = "Author";
            // 
            // author_textBox
            // 
            author_textBox.Location = new Point(221, 78);
            author_textBox.Name = "author_textBox";
            author_textBox.Size = new Size(300, 31);
            author_textBox.TabIndex = 2;
            // 
            // language_label
            // 
            language_label.AutoSize = true;
            language_label.Location = new Point(28, 181);
            language_label.Name = "language_label";
            language_label.Size = new Size(89, 25);
            language_label.TabIndex = 8;
            language_label.Text = "Language";
            // 
            // language_textBox
            // 
            language_textBox.Location = new Point(221, 181);
            language_textBox.Name = "language_textBox";
            language_textBox.Size = new Size(300, 31);
            language_textBox.TabIndex = 4;
            // 
            // type_label
            // 
            type_label.AutoSize = true;
            type_label.Location = new Point(28, 130);
            type_label.Name = "type_label";
            type_label.Size = new Size(49, 25);
            type_label.TabIndex = 6;
            type_label.Text = "Type";
            // 
            // type_textBox
            // 
            type_textBox.Location = new Point(221, 130);
            type_textBox.Name = "type_textBox";
            type_textBox.Size = new Size(300, 31);
            type_textBox.TabIndex = 3;
            // 
            // addedToMyLibrary_label
            // 
            addedToMyLibrary_label.AutoSize = true;
            addedToMyLibrary_label.Location = new Point(28, 238);
            addedToMyLibrary_label.Name = "addedToMyLibrary_label";
            addedToMyLibrary_label.Size = new Size(177, 25);
            addedToMyLibrary_label.TabIndex = 9;
            addedToMyLibrary_label.Text = "Added To My Library";
            // 
            // added_dateTimePicker
            // 
            added_dateTimePicker.Location = new Point(221, 238);
            added_dateTimePicker.Name = "added_dateTimePicker";
            added_dateTimePicker.Size = new Size(300, 31);
            added_dateTimePicker.TabIndex = 5;
            // 
            // lentTo_label
            // 
            lentTo_label.AutoSize = true;
            lentTo_label.Location = new Point(28, 340);
            lentTo_label.Name = "lentTo_label";
            lentTo_label.Size = new Size(68, 25);
            lentTo_label.TabIndex = 14;
            lentTo_label.Text = "Lent To";
            // 
            // lentTo_textBox
            // 
            lentTo_textBox.Location = new Point(221, 340);
            lentTo_textBox.Name = "lentTo_textBox";
            lentTo_textBox.Size = new Size(300, 31);
            lentTo_textBox.TabIndex = 7;
            // 
            // rank_label
            // 
            rank_label.AutoSize = true;
            rank_label.Location = new Point(28, 289);
            rank_label.Name = "rank_label";
            rank_label.Size = new Size(51, 25);
            rank_label.TabIndex = 12;
            rank_label.Text = "Rank";
            // 
            // rank_textBox
            // 
            rank_textBox.Location = new Point(221, 289);
            rank_textBox.Name = "rank_textBox";
            rank_textBox.Size = new Size(300, 31);
            rank_textBox.TabIndex = 6;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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