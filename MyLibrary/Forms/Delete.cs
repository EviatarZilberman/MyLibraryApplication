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

namespace MyLibrary.Forms
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
            ColumnsInit();
            InitializeListView();
        }

        public void ColumnsInit()
        {
            deleteListView.View = View.Details;

            deleteListView.Columns.Add("", 50);
            deleteListView.Columns.Add("Number", 50);
            deleteListView.Columns.Add("Name", 250);
            deleteListView.Columns.Add("Author", 100);
            deleteListView.Columns.Add("Type", 100);
            deleteListView.Columns.Add("Language", 100);
            deleteListView.Columns.Add("Publish Date", 100);
            deleteListView.Columns.Add("Rank", 100);
            deleteListView.Columns.Add("Added The Library", 100);
            deleteListView.Columns.Add("Lent To", 100);
        }
        private async void InitializeListView()
        {
            Login.LoggedUser?.Books.Clear();
            await User.SelectBooksFromTable(User.SELECT_BOOKS_PER_USER_QUERY);
            for (int i = 0; i < Login.LoggedUser?.Books.Count; i++)
            {
                ListViewItem book = new ListViewItem("");
                book.SubItems.Add($"#{i + 1}");
                book.SubItems.Add(Login.LoggedUser.Books[i].Title);
                book.SubItems.Add(Login.LoggedUser.Books[i].Author);
                book.SubItems.Add(Login.LoggedUser.Books[i].Type);
                book.SubItems.Add(Login.LoggedUser.Books[i].Language);
                book.SubItems.Add(Login.LoggedUser.Books[i]?.PublishDate.Value.ToString("dd/MM/yyyy"));
                book.SubItems.Add(Login.LoggedUser.Books[i].Rank);
                book.SubItems.Add(Login.LoggedUser.Books[i]?.AddedToMyLibrary.Value.ToString("dd/MM/yyyy"));
                book.SubItems.Add(Login.LoggedUser.Books[i].LentTo);
                book.SubItems.Add(Login.LoggedUser.Books[i].ForeignId);
                book.SubItems.Add(Login.LoggedUser.Books[i].Id);

                deleteListView.Items.Add(book);
            }
        }

        private async void deleteInScreenButton_Click(object sender, EventArgs e)
        {
            int isChecked = 0;

            foreach (ListViewItem item in deleteListView.Items)
            {
                if (item.Checked)
                {
                    isChecked++;
                    break;
                }
            }
            if (isChecked == 0) // If the variable equals 0 nothing happens.
            {
                MessageBox.Show("No Items are checked!", "Delete Books", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }

            DialogResult messageBox = MessageBox.Show("Are you sure you want to delete?", "Delete Books", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (messageBox == DialogResult.Cancel)
            {
                return;
            }
            if (messageBox == DialogResult.OK)
            {
                int deleted = 0;
                foreach (ListViewItem item in deleteListView.Items)
                {
                    if (item.Checked)
                    {
                        if (await DBManager.Instance().Delete($@"DELETE FROM public.books WHERE foreign_id = '{item.SubItems[10].Text}' AND internal_id = '{item.SubItems[11].Text}';") == CoreReturns.SUCCESS)
                        {
                            deleted++;
                        }
                    }
                }
                Login.LoggedUser?.Books.Clear();
                deleteListView.Items.Clear();
                this.InitializeListView();
                MessageBox.Show($"{deleted} book(s) was deleted!", "Delete Books", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
