﻿using Microsoft.EntityFrameworkCore.Metadata;
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
    public partial class Main : Form, MyITable
    {
        public Label MainTitleLabel { get; set; } = new Label();
        public Main()
        {
            InitializeComponent();
            ColumnsInit();
            Login login = new Login(); // Creates a new instance of login screen.
            login.ShowDialog(); // Shows the login instance above all screens.

            if (login.DialogResult == DialogResult.OK && Login.LoggedUser.Username != null)
            {
                this.MainTitleLabel = new Label();
                this.MainTitleLabel.Size = new Size(250, 50);
                this.MainTitleLabel.Text = $"Welcome, {Login.LoggedUser.Username}!";
                this.MainTitleLabel.Location = new Point(10, 10); // Set the position of the label.
                this.Controls.Add(this.MainTitleLabel);
                this.Show();
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Are you sure you want to delete?");
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        public void ReInit()
        {
            throw new NotImplementedException();
        }

        public void ColumnsInit()
        {
            userBooksList.View = View.Details;

            userBooksList.Columns.Add("", 50);
            userBooksList.Columns.Add("Number", 50);
            userBooksList.Columns.Add("Name", 250);
            userBooksList.Columns.Add("Author", 100);
            userBooksList.Columns.Add("Type", 100);
            userBooksList.Columns.Add("Language", 100);
            userBooksList.Columns.Add("Publish Date", 100);

        }
    }
}
