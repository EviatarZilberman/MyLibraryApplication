using MyLibrary.Interfaces;
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
        public Edit(ListViewItem book)
        {
            InitializeComponent();
            this.title_textBox.Text = book.SubItems[0].Text;
            this.author_textBox.Text = book.SubItems[1].Text;
            this.type_textBox.Text = book.SubItems[2].Text;
            this.language_textBox.Text = book.SubItems[3].Text;
            this.added_dateTimePicker = new DateTimePicker(); // 6
            this.rank_textBox.Text = book.SubItems[5].Text;
            this.lentTo_textBox.Text = book.SubItems[7].Text;
            this.InitEdit();

        }
        public Edit()
        {
            InitializeComponent();
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
    }
}
