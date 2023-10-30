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

namespace MyLibrary.Forms
{
    public partial class Edit : Form
    {
        private static ListViewItem? Book = null;
        public Edit(ListViewItem book)
        {
            Book = book;
            this.InitializeComponent();
            this.DisplayValues(book);
            //this.InitEdit();
            //this.DisplayValues(book);
        }

        private void DisplayValues (ListViewItem book)
        {
            this.title_textBox.PlaceholderText = book.SubItems[0].Text;
            this.author_textBox.PlaceholderText = book.SubItems[1].Text;
            this.type_textBox.PlaceholderText = book.SubItems[2].Text;
            this.language_textBox.PlaceholderText = book.SubItems[3].Text;
            this.added_dateTimePicker.Value = Colboinik.ConvertStringToDate(book.SubItems[6].Text);
            this.rank_textBox.PlaceholderText = book.SubItems[5].Text;
            this.lentTo_textBox.PlaceholderText = book.SubItems[7].Text;
        }

        private async void editBook_button_Click(object sender, EventArgs e)
        {
            bool changed = false;
            if (Book?.SubItems[0].Text != this.title_textBox.Text && !string.IsNullOrEmpty(this.title_textBox.Text))
            {
                changed = true;
                Book.SubItems[0].Text = this.title_textBox.Text;
            }
            if (Book?.SubItems[1].Text != this.author_textBox.Text && !string.IsNullOrEmpty(this.author_textBox.Text))
            {
                changed = true;
                Book.SubItems[1].Text = this.author_textBox.Text;
            }
            if (Book?.SubItems[2].Text != this.language_textBox.Text && !string.IsNullOrEmpty(this.language_textBox.Text))
            {
                changed = true;
                Book.SubItems[2].Text = this.language_textBox.Text;
            }
            if (Book?.SubItems[3].Text != this.type_textBox.Text && !string.IsNullOrEmpty(this.type_textBox.Text))
            {
                changed = true;
                Book.SubItems[3].Text = this.type_textBox.Text;
            }
            if (Book?.SubItems[5].Text != this.rank_textBox.Text && !string.IsNullOrEmpty(this.rank_textBox.Text))
            {
                changed = true;
                Book.SubItems[5].Text = this.rank_textBox.Text;
            }
            if (Colboinik.ConvertStringToDate(Book?.SubItems[6].Text) != Colboinik.ConvertStringToDate(this.added_dateTimePicker.Text))
            {
                changed = true;
                Book.SubItems[6].Text = this.added_dateTimePicker.Text;
            }
            if (Book?.SubItems[7].Text != this.lentTo_textBox.Text && !string.IsNullOrEmpty(this.lentTo_textBox.Text))
            {
                changed = true;
                Book.SubItems[7].Text = this.lentTo_textBox.Text;
            }
            if (changed == false)
            {
                MessageBox.Show("No parameters are changed!", "Edit Book", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (changed)
            {
                if (await DBManager.Instance().Update(@$"UPDATE public.books SET title ='{Book.SubItems[0].Text}', last_change ='{DateTime.Now}', author ='{Book.SubItems[1].Text}', language ='{Book.SubItems[3].Text}', type ='{Book.SubItems[2].Text}', add_to_my_library ='{Book.SubItems[6].Text}', lent_to ='{Book.SubItems[7].Text}', rank ='{Book.SubItems[5].Text}' WHERE internal_id = '{Book.SubItems[9].Text}';") == CoreReturns.SUCCESS)
                {
                    MessageBox.Show("The Book Eddited Seccessfully!", "Seccessfully Book Edit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                } else
                {
                    MessageBox.Show("Failure in book editting!", "Faild in Book Edit", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}
