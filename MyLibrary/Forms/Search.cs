using APIApp;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyLibraryApp.Enums;
using MyLibraryApp.Models;
using Newtonsoft.Json.Linq;
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
using View = System.Windows.Forms.View;

namespace MyLibrary.Forms
{
    public partial class Search : Form
    {
        private static List<Book> Books = new List<Book>();
        public Search()
        {
            InitializeComponent();
            InitializeListView();
        }

        private async void searchButton_Click_OLD(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bookNameBox.Text) || string.IsNullOrWhiteSpace(bookNameBox.Text))
            {
                MessageBox.Show("Name is invalid!");
                return;
            }
            await APIAccessor.Instance().Get(bookNameBox.Text);

            List<Book> books = new List<Book>();


            string[] keys = new string[5] { "title", "creator", "language", "date", "subject" };
            string[] results = new string[5];

            for (int i = 0; i < APIAccessor.Data.Count; i++)
            {
                for (int j = 0; j < keys.Length; j++)
                {
                    if (APIAccessor.Data[i].ContainsKey(keys[j]) == true)
                    {
                        JArray parameter = (JArray)APIAccessor.Data[i][keys[j]];
                        string name = parameter.GetType().Name;
                        results[j] = parameter[j].ToString();
                    }
                }
                /*Newtonsoft.Json.Linq.JArray jsonArray = (Newtonsoft.Json.Linq.JArray)APIAccessor.Data[i][keys[j]];
                String a = jsonArray[0].ToString();
                temp2.Add(a);
                string[] newArray = new string[jsonArray.Count].Select(j => j).ToArray();

                object value = newArray[0];
                temp.Add(new string[jsonArray.Count].Select(x => (string)x).ToArray());
*/
            }
            /*string Author = (string)APIAccessor.Data[i][keys[1]];
            string Language = (string)APIAccessor.Data[i][keys[2]];
            DateTime PublishDate = (DateTime)APIAccessor.Data[i][keys[3]];
            string Type = (string)APIAccessor.Data[i][keys[4]];*/
            DateTime dt = DateTime.Now; // Year / Month / Day
            books.Add(new Book()
            {
                Title = results[0],
                Author = results[1],
                Language = results[2],
                PublishDate = dt,
                Type = results[4]

            });
            //    }
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

            for (int i = 0; i < APIAccessor.Data.Count; i++)
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
                    Title = Colboinik.ValidateQuery(results[0]),
                    Author = results[1],
                    Language = results[2],
                    PublishDate = Colboinik.ConvertStringToDate(results[3]),
                    Type = results[4]
                });
            }
        }
        private void InitializeListView()
        {
            // Create a new ListView
            //ListView listView = new ListView();

            // Set its View property to Details
            searchedBooksList.View = View.Details;

            // Add columns to the ListView
            searchedBooksList.Columns.Add("Column 1", 100);
            searchedBooksList.Columns.Add("Column 2", 150);

            // Add items to the ListView
            ListViewItem item1 = new ListViewItem("Item 1");
            item1.SubItems.Add("Subitem 1");

            ListViewItem item2 = new ListViewItem("Item 2");
            item2.SubItems.Add("Subitem 2");

            // Add the items to the ListView
            searchedBooksList.Items.Add(item1);
            searchedBooksList.Items.Add(item2);

            // Set the location and size of the ListView
           // listView.Location = new System.Drawing.Point(12, 12);
           // listView.Size = new System.Drawing.Size(260, 200);

            // Add the ListView to the form's Controls
            this.Controls.Add(searchedBooksList);
        }

        private void searchedBooksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Create a new ListView
            ListView listView = new ListView();

            // Set its View property to Details
            listView.View = System.Windows.Forms.View.Details;

            // Add columns to the ListView
            listView.Columns.Add("Name", 200);
            listView.Columns.Add("Author", 150);
            listView.Columns.Add("Subject", 150);
            listView.Columns.Add("Language", 150);
            listView.Columns.Add("Publish Date", 150);

            // Add items to the ListView
            ListViewItem item1 = new ListViewItem("Item 1");
            item1.SubItems.Add("Subitem 1");

            ListViewItem item2 = new ListViewItem("Item 2");
            item2.SubItems.Add("Subitem 2");

            // Add the items to the ListView
            listView.Items.Add(item1);
            listView.Items.Add(item2);

            // Set the location and size of the ListView
            listView.Location = new System.Drawing.Point(12, 12);
            listView.Size = new System.Drawing.Size(260, 200);

            // Add the ListView to the form's Controls
            this.Controls.Add(listView);
            this.Refresh();
        }
    }
}

