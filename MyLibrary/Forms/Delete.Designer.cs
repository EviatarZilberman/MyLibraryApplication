namespace MyLibrary.Forms
{
    partial class Delete
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
            deleteInScreenButton = new Button();
            deleteListView = new ListView();
            SuspendLayout();
            // 
            // deleteInScreenButton
            // 
            deleteInScreenButton.BackColor = Color.Red;
            deleteInScreenButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteInScreenButton.ForeColor = Color.Black;
            deleteInScreenButton.Location = new Point(339, 404);
            deleteInScreenButton.Name = "deleteInScreenButton";
            deleteInScreenButton.Size = new Size(112, 34);
            deleteInScreenButton.TabIndex = 0;
            deleteInScreenButton.Text = "Delete!";
            deleteInScreenButton.UseVisualStyleBackColor = false;
            deleteInScreenButton.Click += deleteInScreenButton_Click;
            // 
            // deleteListView
            // 
            deleteListView.CheckBoxes = true;
            deleteListView.Location = new Point(12, 27);
            deleteListView.Name = "deleteListView";
            deleteListView.Size = new Size(776, 353);
            deleteListView.TabIndex = 1;
            deleteListView.UseCompatibleStateImageBehavior = false;
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteListView);
            Controls.Add(deleteInScreenButton);
            Name = "Delete";
            Text = "MyLibrary- Delete";
            ResumeLayout(false);
        }

        #endregion

        private Button deleteInScreenButton;
        private ListView deleteListView;
    }
}