using Microsoft.EntityFrameworkCore.Metadata;
using MyLibrary.Interfaces;
using MyLibraryApp.Models;
using PostgreSQLDBManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyLibrary.Forms
{
    public partial class MainScreen : Form
    {
        public Label MainTitleLabel { get; set; } = new Label();
        private void CloseForm(Login login)
        {
            if (login.InvokeRequired)
            {
                login.Invoke(new MethodInvoker(delegate { login.Close(); }));
            }
            else
            {
                login.Close();
            }
        }
        public MainScreen()
        { 
            InitializeComponent();
            ColumnsInit();
            this.Enabled = false;
            userBooksList.Enabled = false;
            Login login = new Login(); // Creates a new instance of login screen.
            login.ShowDialog(); // Shows the login instance above all screens.
            
            if (login.DialogResult == DialogResult.OK)
            {
                this.MainTitleLabel = new Label();
                this.MainTitleLabel.Size = new Size(250, 50);
                this.MainTitleLabel.Text = $"Welcome, {Login.LoggedUser.Username}!";
                this.MainTitleLabel.Location = new Point(10, 10); // Set the position of the label.
                this.Controls.Add(this.MainTitleLabel);
                this.Enabled = true;
                userBooksList.Enabled = true;
                this.Show();
            }else if (login.DialogResult == DialogResult.None)
            {
              //  login.Close();
                this.Close();
            }
            InitializeListView();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.ShowDialog();
            this.InitializeListView();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
            FormClosingEventArgs closingEvent = new FormClosingEventArgs(CloseReason.UserClosing, true);
            base.OnFormClosing(closingEvent);

            if (closingEvent.CloseReason == CloseReason.UserClosing)
            {
                userBooksList.Items.Clear();

                this.InitializeListView();
            }
        }

        public void ColumnsInit()
        {
            userBooksList.View = View.Details;

            userBooksList.Columns.Add("Name", 250);
            userBooksList.Columns.Add("Author", 100);
            userBooksList.Columns.Add("Type", 100);
            userBooksList.Columns.Add("Language", 100);
            userBooksList.Columns.Add("Publish Date", 100);
            userBooksList.Columns.Add("Rank", 100);
            userBooksList.Columns.Add("Added The Library", 100);
            userBooksList.Columns.Add("Lent To", 100);
        }

        private async void InitializeListView()
        {
            Login.LoggedUser?.Books.Clear();
            userBooksList.Items.Clear();
            await User.SelectBooksFromTable(User.SELECT_BOOKS_PER_USER_QUERY);
            for (int i = 0; i < Login.LoggedUser?.Books.Count; i++)
            {
                ListViewItem book = new ListViewItem(Login.LoggedUser.Books[i].Title);
                
                book.SubItems.Add(Login.LoggedUser.Books[i].Author);
                book.SubItems.Add(Login.LoggedUser.Books[i].Type);
                book.SubItems.Add(Login.LoggedUser.Books[i].Language);
                book.SubItems.Add(Login.LoggedUser.Books[i]?.PublishDate.Value.ToString("dd/MM/yyyy"));
                book.SubItems.Add(Login.LoggedUser.Books[i].Rank);
                book.SubItems.Add(Login.LoggedUser.Books[i]?.AddedToMyLibrary.Value.ToShortDateString());
                book.SubItems.Add(Login.LoggedUser.Books[i].LentTo);
                book.SubItems.Add(Login.LoggedUser.Books[i].ForeignId);
                book.SubItems.Add(Login.LoggedUser.Books[i].Id);
                book.Tag = (Action)(() => this.Edit(book));

                userBooksList.Items.Add(book);
            }
            userBooksList.DrawSubItem += userBooksList_DrawSubItem;
            userBooksList.ItemActivate += userBooksList_ItemActivate;
            this.Controls.Add(userBooksList);
        }
        private void userBooksList_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;

            // Check if the column index is for the "Link" column (1 in this example)
            if (e.ColumnIndex != 1)
            {
                // Customize the hyperlink appearance
                e.Graphics.DrawString(e.SubItem.Text, new Font("Arial", 10, FontStyle.Underline),
                    new SolidBrush(Color.GreenYellow), e.Bounds.Location);

                // You can also change the cursor to a hand when hovering over the link
                if (e.Bounds.Contains(userBooksList.PointToClient(Cursor.Position)))
                    userBooksList.Cursor = Cursors.Hand;
            }
            else
            {
                // Reset the cursor to default for other columns
                userBooksList.Cursor = Cursors.Default;
            }
            e.DrawDefault = true;
            if (e.ColumnIndex == 1)
            {
                e.Graphics.DrawString(e.SubItem.Text, new Font("Arial", 10, FontStyle.Underline),
                    new SolidBrush(Color.Blue), e.Bounds.Location);
            }
        }


    public async Task<CoreReturns> Edit(ListViewItem book)
        {
            Edit edit = new Edit(book);
            edit.ShowDialog();
            InitializeListView();
            return CoreReturns.SUCCESS;
        }

        private void userBooksList_ItemActivate(object sender, EventArgs e)
        {
            /*if (userBooksList.SelectedItems.Count > 0)
            {*/
            var selectedItem = userBooksList.SelectedItems[0];
            var action = selectedItem.Tag as Action;
            action?.Invoke();
            //}
        }
    }
}