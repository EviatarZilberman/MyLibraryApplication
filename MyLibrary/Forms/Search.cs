﻿using APIApp;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyLibraryApp.Enums;
using MyLibraryApp.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using View = System.Windows.Forms.View;

namespace MyLibrary.Forms
{
    public partial class Search : Form
    {
        private static List<Book> Books { get; set; } = new List<Book>();
        public Search()
        {
            ReInit();
            InitializeComponent();
            ColumnsInit();
        }

        private void comboLanguageBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bookNameBox.Text) || string.IsNullOrWhiteSpace(bookNameBox.Text))
            {
                MessageBox.Show("Name is invalid!");
                return;
            }

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
                Books.Add(new Book()
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

        private void ReInit()
        {
            if (Books.Count > 0)
            {
                Books.Clear();
            }
        }

        private void ColumnsInit ()
        {
            searchedBooksList.View = View.Details;

            searchedBooksList.Columns.Add("Number", 30);
            searchedBooksList.Columns.Add("Name", 200);
            searchedBooksList.Columns.Add("Author", 100);
            searchedBooksList.Columns.Add("Type", 100);
            searchedBooksList.Columns.Add("Language", 100);
            searchedBooksList.Columns.Add("Publish Date", 100);
        }
        private void InitializeListView()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                // Add items to the ListView
                ListViewItem book = new ListViewItem($"{i + 1}");
                book.SubItems.Add(Books[i].Title);
                book.SubItems.Add(Books[i].Author);
                book.SubItems.Add(Books[i].Type);
                book.SubItems.Add(Books[i].Language);
                book.SubItems.Add(Books[i].PublishDate.Value.ToString("dd/MM/yyyy"));

                // Add the items to the ListView
                searchedBooksList.Items.Add(book);
            }
            // Add the ListView to the form's Controls
            this.Controls.Add(searchedBooksList);
        }

        private void searchedBooksList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

