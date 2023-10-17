using APIApp;
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

namespace MyLibrary.Forms
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private async void searchButton_Click2(object sender, EventArgs e)
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

            List<Book> books = new List<Book>();

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
                            // Assuming you want to concatenate the array elements as a single string
                            results[j] = string.Join(", ", ((JArray)parameter).Select(p => p.ToString()));
                        }
                        else if (parameter.Type == JTokenType.String)
                        {
                            results[j] = parameter.ToString();
                        }
                    }
                }
                    DateTime dt = DateTime.Now; // You might need to get the actual publish date from the JSON data
                    books.Add(new Book()
                    {
                        Title = results[0],
                        Author = results[1],
                        Language = results[2],
                        PublishDate = dt,
                        Type = results[4]
                    });
            }
        }


    }
}

