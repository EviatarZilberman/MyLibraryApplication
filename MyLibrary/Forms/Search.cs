using APIApp;
using MyLibraryApp.Enums;
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

namespace MyLibrary.Forms
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bookNameBox.Text) || string.IsNullOrWhiteSpace(bookNameBox.Text))
            {
                MessageBox.Show("Name is invalid!");
                return;
            }
            await APIAccessor.Instance().Get(bookNameBox.Text);

            List<Book> books = new List<Book>();
            if (authorBox.Text != null)
            {
                for (int i = 0; i < APIAccessor.Data.Count; i++)
                {
                    string Title = (string)APIAccessor.Data[i]["title"];
                    string Author = (string)APIAccessor.Data[i]["creator"];
                    string Language = (string)APIAccessor.Data[i]["language"];
                    DateTime PublishDate = (DateTime)APIAccessor.Data[i]["date"];
                    string Type = (string)APIAccessor.Data[i]["type"];

                    books.Add(new Book()
                    {
                        Title = (string) APIAccessor.Data[i]["title"],
                        Author = (string) APIAccessor.Data[i]["creator"],
                        Language = (string) APIAccessor.Data[i]["language"],
                        PublishDate = (DateTime) APIAccessor.Data[i]["date"],
                        Type = (string) APIAccessor.Data[i]["type"]

                    });
                }
            }
        }

        private void comboLanguageBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

