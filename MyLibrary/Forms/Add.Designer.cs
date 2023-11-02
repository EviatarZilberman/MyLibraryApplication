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
            add_button.BackColor = Color.LimeGreen;
            add_button.Location = new Point(278, 652);
            add_button.Margin = new Padding(4, 3, 4, 3);
            add_button.Name = "add_button";
            add_button.Size = new Size(146, 39);
            add_button.TabIndex = 0;
            add_button.Text = "Add!";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += add_button_Click;
            // 
            // title_textBox
            // 
            title_textBox.Location = new Point(220, 73);
            title_textBox.Margin = new Padding(4, 3, 4, 3);
            title_textBox.Name = "title_textBox";
            title_textBox.Size = new Size(389, 36);
            title_textBox.TabIndex = 1;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Location = new Point(53, 73);
            title_label.Margin = new Padding(4, 0, 4, 0);
            title_label.Name = "title_label";
            title_label.Size = new Size(58, 29);
            title_label.TabIndex = 2;
            title_label.Text = "Title";
            // 
            // author_label
            // 
            author_label.AutoSize = true;
            author_label.Location = new Point(53, 131);
            author_label.Margin = new Padding(4, 0, 4, 0);
            author_label.Name = "author_label";
            author_label.Size = new Size(83, 29);
            author_label.TabIndex = 4;
            author_label.Text = "Author";
            // 
            // author_textBox
            // 
            author_textBox.Location = new Point(220, 131);
            author_textBox.Margin = new Padding(4, 3, 4, 3);
            author_textBox.Name = "author_textBox";
            author_textBox.Size = new Size(389, 36);
            author_textBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 244);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 29);
            label1.TabIndex = 8;
            label1.Text = "Type";
            // 
            // type_textBox
            // 
            type_textBox.Location = new Point(220, 244);
            type_textBox.Margin = new Padding(4, 3, 4, 3);
            type_textBox.Name = "type_textBox";
            type_textBox.Size = new Size(389, 36);
            type_textBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 186);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 29);
            label2.TabIndex = 6;
            label2.Text = "Language";
            // 
            // language_textBox
            // 
            language_textBox.Location = new Point(220, 186);
            language_textBox.Margin = new Padding(4, 3, 4, 3);
            language_textBox.Name = "language_textBox";
            language_textBox.Size = new Size(389, 36);
            language_textBox.TabIndex = 5;
            // 
            // publish_dateTimePicker
            // 
            publish_dateTimePicker.Location = new Point(220, 299);
            publish_dateTimePicker.Margin = new Padding(4, 3, 4, 3);
            publish_dateTimePicker.Name = "publish_dateTimePicker";
            publish_dateTimePicker.Size = new Size(389, 36);
            publish_dateTimePicker.TabIndex = 9;
            // 
            // publishDate_label
            // 
            publishDate_label.AutoSize = true;
            publishDate_label.Location = new Point(53, 299);
            publishDate_label.Margin = new Padding(4, 0, 4, 0);
            publishDate_label.Name = "publishDate_label";
            publishDate_label.Size = new Size(144, 29);
            publishDate_label.TabIndex = 10;
            publishDate_label.Text = "Publish Date";
            // 
            // unknownPublish_checkBox
            // 
            unknownPublish_checkBox.AutoSize = true;
            unknownPublish_checkBox.Location = new Point(220, 354);
            unknownPublish_checkBox.Margin = new Padding(4, 3, 4, 3);
            unknownPublish_checkBox.Name = "unknownPublish_checkBox";
            unknownPublish_checkBox.Size = new Size(276, 33);
            unknownPublish_checkBox.TabIndex = 11;
            unknownPublish_checkBox.Text = "Unknown Publish Date";
            unknownPublish_checkBox.UseVisualStyleBackColor = true;
            // 
            // add_checkBox
            // 
            add_checkBox.AutoSize = true;
            add_checkBox.Location = new Point(220, 473);
            add_checkBox.Margin = new Padding(4, 3, 4, 3);
            add_checkBox.Name = "add_checkBox";
            add_checkBox.Size = new Size(243, 33);
            add_checkBox.TabIndex = 15;
            add_checkBox.Text = "Unknown Add Date";
            add_checkBox.UseVisualStyleBackColor = true;
            // 
            // addDate_label
            // 
            addDate_label.AutoSize = true;
            addDate_label.Location = new Point(53, 423);
            addDate_label.Margin = new Padding(4, 0, 4, 0);
            addDate_label.Name = "addDate_label";
            addDate_label.Size = new Size(111, 29);
            addDate_label.TabIndex = 14;
            addDate_label.Text = "Add Date";
            // 
            // add_dateTimePicker
            // 
            add_dateTimePicker.Location = new Point(220, 416);
            add_dateTimePicker.Margin = new Padding(4, 3, 4, 3);
            add_dateTimePicker.Name = "add_dateTimePicker";
            add_dateTimePicker.Size = new Size(389, 36);
            add_dateTimePicker.TabIndex = 13;
            // 
            // lentTo_label
            // 
            lentTo_label.AutoSize = true;
            lentTo_label.Location = new Point(53, 572);
            lentTo_label.Margin = new Padding(4, 0, 4, 0);
            lentTo_label.Name = "lentTo_label";
            lentTo_label.Size = new Size(94, 29);
            lentTo_label.TabIndex = 19;
            lentTo_label.Text = "Lent To";
            // 
            // lentTo_textBox
            // 
            lentTo_textBox.Location = new Point(220, 572);
            lentTo_textBox.Margin = new Padding(4, 3, 4, 3);
            lentTo_textBox.Name = "lentTo_textBox";
            lentTo_textBox.Size = new Size(389, 36);
            lentTo_textBox.TabIndex = 18;
            // 
            // rank_label
            // 
            rank_label.AutoSize = true;
            rank_label.Location = new Point(53, 514);
            rank_label.Margin = new Padding(4, 0, 4, 0);
            rank_label.Name = "rank_label";
            rank_label.Size = new Size(66, 29);
            rank_label.TabIndex = 17;
            rank_label.Text = "Rank";
            // 
            // rank_textBox
            // 
            rank_textBox.Location = new Point(220, 514);
            rank_textBox.Margin = new Padding(4, 3, 4, 3);
            rank_textBox.Name = "rank_textBox";
            rank_textBox.Size = new Size(389, 36);
            rank_textBox.TabIndex = 16;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(688, 724);
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
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
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