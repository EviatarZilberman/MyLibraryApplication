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
            SuspendLayout();
            // 
            // userBooksList
            // 
            userBooksList.AccessibleName = "userBooks";
            userBooksList.FormattingEnabled = true;
            userBooksList.ItemHeight = 25;
            userBooksList.Location = new Point(29, 60);
            userBooksList.Name = "userBooksList";
            userBooksList.Size = new Size(749, 379);
            userBooksList.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userBooksList);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion
        private ListBox userBooksList;
    }
}