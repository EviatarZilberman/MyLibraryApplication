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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private async void add_button_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            if (string.IsNullOrEmpty(title_textBox.Text) && string.IsNullOrWhiteSpace(title_textBox.Text))
            {
                MessageBox.Show("Title Is Invalid!", "Invalid Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                book.Title = title_textBox.Text;
            }
            if (!string.IsNullOrEmpty(author_textBox.Text) && !string.IsNullOrWhiteSpace(author_textBox.Text))
            {
                book.Author = author_textBox.Text;
            }
            if (!string.IsNullOrEmpty(type_textBox.Text) && !string.IsNullOrWhiteSpace(type_textBox.Text))
            {
                book.Type = type_textBox.Text;
            }
            if (!string.IsNullOrEmpty(language_textBox.Text) && !string.IsNullOrWhiteSpace(language_textBox.Text))
            {
                book.Language = language_textBox.Text;
            }
            if (unknownPublish_checkBox.Checked)
            {
                book.PublishDateString = Book.DEFAULT;
            } else
            {
                book.PublishDate = publish_dateTimePicker.Value;
            }
            if (add_checkBox.Checked)
            {
                book.AddedToMyLibraryString = Book.DEFAULT;
            }
            else
            {
                book.AddedToMyLibrary = publish_dateTimePicker.Value;
            }
            if (!string.IsNullOrEmpty(rank_textBox.Text) && !string.IsNullOrWhiteSpace(rank_textBox.Text))
            {
                if (Colboinik.StringNumberBounds(rank_textBox.Text) == CoreReturns.SUCCESS)
                {
                    book.Rank = rank_textBox.Text;
                }
            }
            if (!string.IsNullOrEmpty(lentTo_textBox.Text) && !string.IsNullOrWhiteSpace(lentTo_textBox.Text))
            {
                book.LentTo = lentTo_textBox.Text;
            }
            book.ForeignId = Login.LoggedUser?.Id;
            if (await DBManager.Instance().Insert(book.InsertQuery()) == CoreReturns.SUCCESS)
            {
                MessageBox.Show("Book Added Seccessfully!", "Seccessfully Book Add!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } else
            {
                MessageBox.Show("Book Add Failed!", "Failed To Add Book!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
