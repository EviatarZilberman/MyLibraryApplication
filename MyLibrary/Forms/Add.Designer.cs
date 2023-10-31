namespace MyLibrary.Forms
{
    partial class Add
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
            add_button = new Button();
            title_textBox = new TextBox();
            title_label = new Label();
            author_label = new Label();
            author_textBox = new TextBox();
            label1 = new Label();
            type_textBox = new TextBox();
            label2 = new Label();
            language_textBox = new TextBox();
            publish_dateTimePicker = new DateTimePicker();
            publishDate_label = new Label();
            unknownPublish_checkBox = new CheckBox();
            add_checkBox = new CheckBox();
            addDate_label = new Label();
            add_dateTimePicker = new DateTimePicker();
            lentTo_label = new Label();
            lentTo_textBox = new TextBox();
            rank_label = new Label();
            rank_textBox = new TextBox();
            SuspendLayout();
            // 
            // add_button
            // 
            add_button.Location = new Point(214, 562);
            add_button.Name = "add_button";
            add_button.Size = new Size(112, 34);
            add_button.TabIndex = 0;
            add_button.Text = "Add!";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // title_textBox
            // 
            title_textBox.Location = new Point(169, 63);
            title_textBox.Name = "title_textBox";
            title_textBox.Size = new Size(300, 31);
            title_textBox.TabIndex = 1;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Location = new Point(41, 63);
            title_label.Name = "title_label";
            title_label.Size = new Size(44, 25);
            title_label.TabIndex = 2;
            title_label.Text = "Title";
            // 
            // author_label
            // 
            author_label.AutoSize = true;
            author_label.Location = new Point(41, 113);
            author_label.Name = "author_label";
            author_label.Size = new Size(67, 25);
            author_label.TabIndex = 4;
            author_label.Text = "Author";
            // 
            // author_textBox
            // 
            author_textBox.Location = new Point(169, 113);
            author_textBox.Name = "author_textBox";
            author_textBox.Size = new Size(300, 31);
            author_textBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 210);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 8;
            label1.Text = "Type";
            // 
            // type_textBox
            // 
            type_textBox.Location = new Point(169, 210);
            type_textBox.Name = "type_textBox";
            type_textBox.Size = new Size(300, 31);
            type_textBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 160);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 6;
            label2.Text = "Language";
            // 
            // language_textBox
            // 
            language_textBox.Location = new Point(169, 160);
            language_textBox.Name = "language_textBox";
            language_textBox.Size = new Size(300, 31);
            language_textBox.TabIndex = 5;
            // 
            // publish_dateTimePicker
            // 
            publish_dateTimePicker.Location = new Point(169, 258);
            publish_dateTimePicker.Name = "publish_dateTimePicker";
            publish_dateTimePicker.Size = new Size(300, 31);
            publish_dateTimePicker.TabIndex = 9;
            // 
            // publishDate_label
            // 
            publishDate_label.AutoSize = true;
            publishDate_label.Location = new Point(41, 258);
            publishDate_label.Name = "publishDate_label";
            publishDate_label.Size = new Size(111, 25);
            publishDate_label.TabIndex = 10;
            publishDate_label.Text = "Publish Date";
            // 
            // unknownPublish_checkBox
            // 
            unknownPublish_checkBox.AutoSize = true;
            unknownPublish_checkBox.Location = new Point(169, 305);
            unknownPublish_checkBox.Name = "unknownPublish_checkBox";
            unknownPublish_checkBox.Size = new Size(217, 29);
            unknownPublish_checkBox.TabIndex = 11;
            unknownPublish_checkBox.Text = "Unknown Publish Date";
            unknownPublish_checkBox.UseVisualStyleBackColor = true;
            // 
            // add_checkBox
            // 
            add_checkBox.AutoSize = true;
            add_checkBox.Location = new Point(169, 408);
            add_checkBox.Name = "add_checkBox";
            add_checkBox.Size = new Size(194, 29);
            add_checkBox.TabIndex = 15;
            add_checkBox.Text = "Unknown Add Date";
            add_checkBox.UseVisualStyleBackColor = true;
            // 
            // addDate_label
            // 
            addDate_label.AutoSize = true;
            addDate_label.Location = new Point(41, 365);
            addDate_label.Name = "addDate_label";
            addDate_label.Size = new Size(88, 25);
            addDate_label.TabIndex = 14;
            addDate_label.Text = "Add Date";
            // 
            // add_dateTimePicker
            // 
            add_dateTimePicker.Location = new Point(169, 359);
            add_dateTimePicker.Name = "add_dateTimePicker";
            add_dateTimePicker.Size = new Size(300, 31);
            add_dateTimePicker.TabIndex = 13;
            // 
            // lentTo_label
            // 
            lentTo_label.AutoSize = true;
            lentTo_label.Location = new Point(41, 493);
            lentTo_label.Name = "lentTo_label";
            lentTo_label.Size = new Size(68, 25);
            lentTo_label.TabIndex = 19;
            lentTo_label.Text = "Lent To";
            // 
            // lentTo_textBox
            // 
            lentTo_textBox.Location = new Point(169, 493);
            lentTo_textBox.Name = "lentTo_textBox";
            lentTo_textBox.Size = new Size(300, 31);
            lentTo_textBox.TabIndex = 18;
            // 
            // rank_label
            // 
            rank_label.AutoSize = true;
            rank_label.Location = new Point(41, 443);
            rank_label.Name = "rank_label";
            rank_label.Size = new Size(51, 25);
            rank_label.TabIndex = 17;
            rank_label.Text = "Rank";
            // 
            // rank_textBox
            // 
            rank_textBox.Location = new Point(169, 443);
            rank_textBox.Name = "rank_textBox";
            rank_textBox.Size = new Size(300, 31);
            rank_textBox.TabIndex = 16;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 624);
            Controls.Add(lentTo_label);
            Controls.Add(lentTo_textBox);
            Controls.Add(rank_label);
            Controls.Add(rank_textBox);
            Controls.Add(add_checkBox);
            Controls.Add(addDate_label);
            Controls.Add(add_dateTimePicker);
            Controls.Add(unknownPublish_checkBox);
            Controls.Add(publishDate_label);
            Controls.Add(publish_dateTimePicker);
            Controls.Add(label1);
            Controls.Add(type_textBox);
            Controls.Add(label2);
            Controls.Add(language_textBox);
            Controls.Add(author_label);
            Controls.Add(author_textBox);
            Controls.Add(title_label);
            Controls.Add(title_textBox);
            Controls.Add(add_button);
            Name = "Add";
            Text = "MyLibrary- Add New";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_button;
        private TextBox title_textBox;
        private Label title_label;
        private Label author_label;
        private TextBox author_textBox;
        private Label label1;
        private TextBox type_textBox;
        private Label label2;
        private TextBox language_textBox;
        private DateTimePicker publish_dateTimePicker;
        private Label publishDate_label;
        private CheckBox unknownPublish_checkBox;
        private CheckBox add_checkBox;
        private Label addDate_label;
        private DateTimePicker add_dateTimePicker;
        private Label lentTo_label;
        private TextBox lentTo_textBox;
        private Label rank_label;
        private TextBox rank_textBox;
    }
}