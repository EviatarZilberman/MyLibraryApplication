using APIApp;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyLibraryApp.Models;
using Newtonsoft.Json.Linq;
using PostgreSQLDBManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using View = System.Windows.Forms.View;

namespace MyLibrary.Forms
{
    public partial class Search : Form
    {
        private static List<Book> Books { get; set; } = new List<Book>();
        public Search()
        {
            Books.Clear();
            this.InitializeComponent();
            this.ColumnsInit();
        }

        private async void searchButton_Click(object sender, EventArgs e) // Searchs books by the book name.
        {
            if (string.IsNullOrEmpty(bookNameBox.Text) || string.IsNullOrWhiteSpace(bookNameBox.Text))
            {
                MessageBox.Show("Name is invalid!");
                return;
            }
            Search.Books?.Clear();
            searchedBooksList.Items.Clear();
            await APIAccessor.Instance().Get(bookNameBox.Text);

            string[] keys = new string[5] { "title", "creator", "language", "date", "subject" };
            string[] results = new string[5];

            for (int i = 0; i < APIAccessor.Data?.Count; i++)
            {
                for (int j = 0; j < keys.Length; j++)
                {
                    if (APIAccessor.Data[i].ContainsKey(keys[j]))
                    {
                        JToken parameter = (JToken)APIAccessor.Data[i][keys[j]];

                        if (parameter.Type == JTokenType.Array && ((JArray)parameter).Count > 0)
                        {
                            results[j] = Colboinik.ValidateQuery(string.Join(", ", ((JArray)parameter).Select(p => p.ToString())));
                        }
                        else if (parameter.Type == JTokenType.String)
                        {
                            results[j] = Colboinik.ValidateQuery(parameter.ToString());
                        }
                    }
                }
                Books?.Add(new Book()
                {
                    Title = results[0],
                    Author = results[1],
                    Language = results[2],
                    PublishDate = Colboinik.ConvertStringToDate(results[3]),
                    Type = results[4]
                });
            }
            InitializeListView();
        }

        public void ColumnsInit() // Function to declare the columns of a specific table.
        {
            searchedBooksList.View = View.Details;

            searchedBooksList.Columns.Add("", 50);
            searchedBooksList.Columns.Add("Number", 50);
            searchedBooksList.Columns.Add("Name", 250);
            searchedBooksList.Columns.Add("Author", 100);
            searchedBooksList.Columns.Add("Type", 100);
            searchedBooksList.Columns.Add("Language", 100);
            searchedBooksList.Columns.Add("Publish Date", 100);
        }

        public void InitializeListView() // Represents all the found books in the ListView.
        {
            for (int i = 0; i < Books.Count; i++)
            {
                try
                {
                    string? year = Search.DateValidation(publish_textBox.Text);
                    if (Books[i].Author.Contains(authorBox.Text) &&
                        (comboLanguageBox.Text.ToLower().Contains(Books[i].Language) || string.IsNullOrEmpty(Books[i].Language))
                          && (Books[i].PublishDate.Value.Year.ToString().Equals(year)
                          ||
                          string.IsNullOrWhiteSpace(year) ||
                          string.IsNullOrEmpty(year))
                        )
                    {
                        ListViewItem book = new ListViewItem("");
                        book.SubItems.Add($"{searchedBooksList.Items.Count + 1}");
                        book.SubItems.Add(Books[i].Title);
                        book.SubItems.Add(Books[i].Author);
                        book.SubItems.Add(Books[i].Type);
                        book.SubItems.Add(Books[i].Language);
                        book.SubItems.Add(Books[i]?.PublishDate.Value.ToString("dd/MM/yyyy"));

                        searchedBooksList.Items.Add(book);
                    }
                }
                catch (Exception ex)
                {
                    LogWriter.Instance().WriteLog(System.Reflection.MethodBase.GetCurrentMethod().Name, $"Error in initial books list in Search screen! Error: {ex.Message}");

                }
            }
            this.Controls.Add(searchedBooksList);
        }

        private static string DateValidation(string year)
        {
            if (string.IsNullOrEmpty(year) || string.IsNullOrWhiteSpace(year)) return "";
            if (year.Length > 4) return "";
            for (int i = 0; i < year.Length; i++)
            {
                if (year[i] > '9' || year[i] < '0')
                {
                    return "";
                }
            }
            return year;
        }

        private async void addButton_Click(object sender, EventArgs e) // Functions well!
        {
            int count = 0, added = 0;
            foreach (ListViewItem item in searchedBooksList.Items)
            {
                if (item.Checked)
                {
                    count++;
                    Book book = new Book()
                    {
                        Title = item.SubItems[2].Text,
                        Author = item.SubItems[3].Text,
                        Type = item.SubItems[4].Text,
                        Language = item.SubItems[5].Text,
                        PublishDate = Colboinik.ConvertStringToDate(item.SubItems[6].Text),
                        ForeignId = Login.LoggedUser?.Id,
                        AddedToMyLibrary = DateTime.Now,
                        LentTo = "Nobody",
                        Rank = "Unknown"
                    };
                    if (await DBManager.Instance().Insert(book.InsertQuery()) == CoreReturns.SUCCESS)
                    {
                        added++;
                    }
                }
            }
            MessageBox.Show($"{added} of {count} Book(s) Added Seccessfully!", "Seccessfully Book(s) Add!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            bookNameBox.Text = string.Empty;
            authorBox.Text = string.Empty;
            publish_textBox.Text = string.Empty;
            comboLanguageBox.SelectedIndex = 0;
        }
    }
}

