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
            userBooksList.Location = new Point(29, 110);
            userBooksList.Name = "userBooksList";
            userBooksList.Size = new Size(749, 329);
            userBooksList.Sorting = SortOrder.Ascending;
            userBooksList.TabIndex = 1;
            userBooksList.UseCompatibleStateImageBehavior = false;
            userBooksList.View = View.Details;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(653, 22);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(112, 34);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
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
            // addNew_button
            // 
            addNew_button.Location = new Point(360, 22);
            addNew_button.Name = "addNew_button";
            addNew_button.Size = new Size(112, 34);
            addNew_button.TabIndex = 4;
            addNew_button.Text = "Add New";
            addNew_button.UseVisualStyleBackColor = true;
            addNew_button.Click += addNew_button_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addNew_button);
            Controls.Add(DeleteButton);
            Controls.Add(SearchButton);
            Controls.Add(userBooksList);
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