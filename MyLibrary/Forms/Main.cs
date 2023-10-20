using Microsoft.EntityFrameworkCore.Metadata;
using MyLibrary.Interfaces;
using MyLibraryApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace MyLibrary.Forms
{
    public partial class Main : Form, MyITable
    {
        public Label MainTitleLabel { get; set; } = new Label();
        private static readonly string SELECT_BOOKS_PER_USER_QUERY = @$"SELECT internal_id, creation_date, last_change, title, author, language, type, publish_date, add_to_my_library, lent_to, foreign_id, rank
	    FROM public.books where foreign_id = '{Login.LoggedUser.Id}';";
        public Main()
        {
            InitializeComponent();
            ColumnsInit();
            Login login = new Login(); // Creates a new instance of login screen.
            login.ShowDialog(); // Shows the login instance above all screens.

            if (login.DialogResult == DialogResult.OK && Login.LoggedUser.Username != null)
            {
                this.MainTitleLabel = new Label();
                this.MainTitleLabel.Size = new Size(250, 50);
                this.MainTitleLabel.Text = $"Welcome, {Login.LoggedUser.Username}!";
                this.MainTitleLabel.Location = new Point(10, 10); // Set the position of the label.
                this.Controls.Add(this.MainTitleLabel);
                this.Show();
            }
            InitializeListView();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Are you sure you want to delete?");
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
            this.userBooksList.Refresh();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        public void ColumnsInit()
        {
            userBooksList.View = View.Details;

            userBooksList.Columns.Add("", 50);
            userBooksList.Columns.Add("Number", 50);
            userBooksList.Columns.Add("Name", 250);
            userBooksList.Columns.Add("Author", 100);
            userBooksList.Columns.Add("Type", 100);
            userBooksList.Columns.Add("Language", 100);
            userBooksList.Columns.Add("Publish Date", 100);
            userBooksList.Columns.Add("Rank", 100);
            userBooksList.Columns.Add("Added The Library", 100);
            userBooksList.Columns.Add("Lent To", 100);

        }

        public async void InitializeListView()
        {
            this.Refresh();
            await User.SelectBooksFromTable(SELECT_BOOKS_PER_USER_QUERY);
            for (int i = 0; i < Login.LoggedUser.Books.Count; i++)
            {
                ListViewItem book = new ListViewItem("");
                book.SubItems.Add($"{i + 1}");
                book.SubItems.Add(Login.LoggedUser.Books[i].Title);
                book.SubItems.Add(Login.LoggedUser.Books[i].Author);
                book.SubItems.Add(Login.LoggedUser.Books[i].Type);
                book.SubItems.Add(Login.LoggedUser.Books[i].Language);
                book.SubItems.Add(Login.LoggedUser.Books[i]?.PublishDate.Value.ToString("dd/MM/yyyy"));
                book.SubItems.Add(Login.LoggedUser.Books[i].Rank);
                book.SubItems.Add(Login.LoggedUser.Books[i]?.AddedToMyLibrary.Value.ToString("dd/MM/yyyy"));
                book.SubItems.Add(Login.LoggedUser.Books[i].LentTo);

                userBooksList.Items.Add(book);
            }
            this.Controls.Add(userBooksList);
        }
    }
}
