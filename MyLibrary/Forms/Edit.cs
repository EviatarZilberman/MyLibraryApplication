using MyLibrary.Interfaces;
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

namespace MyLibrary.Forms
{
    public partial class Edit : Form
    {
        private static ListViewItem? Book = null;
        public Edit(ListViewItem book)
        {
            Book = book;
            InitializeComponent();
            this.title_textBox.Text = book.SubItems[0].Text;
            this.author_textBox.Text = book.SubItems[1].Text;
            this.type_textBox.Text = book.SubItems[2].Text;
            this.language_textBox.Text = book.SubItems[3].Text;
            this.added_dateTimePicker = new DateTimePicker(); //book.SubItems[6].Text; // 6
            this.rank_textBox.Text = book.SubItems[5].Text;
            this.lentTo_textBox.Text = book.SubItems[7].Text;
            this.InitEdit();
        }

        private void InitEdit()
        {
            this.title_textBox = new TextBox();
            this.author_textBox = new TextBox();
            this.rank_textBox = new TextBox();
            this.lentTo_textBox = new TextBox();
            this.language_textBox = new TextBox();
            this.type_textBox = new TextBox();
            this.added_dateTimePicker = new DateTimePicker();
        }

        private void editBook_button_Click(object sender, EventArgs e)
        {
            bool changed = false;
            if (Book.SubItems[0].Text != this.title_textBox.Text)
            {
                changed = true;
                Book.SubItems[0].Text = this.title_textBox.Text;
            }
            if (changed == false)
            {
                MessageBox.Show("No parameters are changed!", "Edit Book", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (changed)
            {
                DBManager.Instance().Insert(@$"UPDATE public.books SET last_change ={DateTime.Now}, title =?, author =?, language =?, type =?, publish_date =?, add_to_my_library =?, lent_to =?, foreign_id =?, rank =? WHERE foreign_id = '{Book.SubItems[8].Text}';");
            }
        }
    }
}
