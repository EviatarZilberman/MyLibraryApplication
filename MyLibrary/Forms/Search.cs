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
            }


        }
    }
}
