namespace MyLibrary.Forms
{
    partial class MainScreen
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
            userBooksList = new ListView();
            SearchButton = new Button();
            DeleteButton = new Button();
            addNew_button = new Button();
            SuspendLayout();
            // 
            // userBooksList
            // 
            userBooksList.AccessibleName = "userBooks";
            userBooksList.Location = new Point(38, 128);
            userBooksList.Margin = new Padding(4, 3, 4, 3);
            userBooksList.Name = "userBooksList";
            userBooksList.Size = new Size(972, 381);
            userBooksList.Sorting = SortOrder.Ascending;
            userBooksList.TabIndex = 1;
            userBooksList.UseCompatibleStateImageBehavior = false;
            userBooksList.View = View.Details;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = SystemColors.ActiveCaption;
            SearchButton.Location = new Point(849, 26);
            SearchButton.Margin = new Padding(4, 3, 4, 3);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(146, 39);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Red;
            DeleteButton.Location = new Point(660, 26);
            DeleteButton.Margin = new Padding(4, 3, 4, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(146, 39);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // addNew_button
            // 
            addNew_button.BackColor = Color.LimeGreen;
            addNew_button.Location = new Point(468, 26);
            addNew_button.Margin = new Padding(4, 3, 4, 3);
            addNew_button.Name = "addNew_button";
            addNew_button.Size = new Size(146, 39);
            addNew_button.TabIndex = 4;
            addNew_button.Text = "Add New";
            addNew_button.UseVisualStyleBackColor = false;
            addNew_button.Click += addNew_button_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1040, 522);
            Controls.Add(addNew_button);
            Controls.Add(DeleteButton);
            Controls.Add(SearchButton);
            Controls.Add(userBooksList);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainScreen";
            Text = "MyLibrary- Main";
            ResumeLayout(false);
        }

        #endregion
        private ListView userBooksList;
        private Button SearchButton;
        private Button DeleteButton;
        private Button addNew_button;
    }
}