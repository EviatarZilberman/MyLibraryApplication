﻿using System;
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
    public partial class Main : Form
    {
        public static int MainTitleLength { get; set; } = "Welcome,".Length;
        public Label MainTitleLabel { get; set; } = new Label();
        public Main()
        {
            InitializeComponent();
            Login login = new Login(); // Creates a new instance of login screen.
            login.ShowDialog(); // Shows the login instance above all screens.
            
            if (login.DialogResult == DialogResult.OK && login.Username != null)
            {
                //this.Username = login.Username;
                this.MainTitleLabel = new Label();
                this.MainTitleLabel.Size = new Size(250, 50);
                this.MainTitleLabel.Text = $"Welcome, {login.Username}!";
                this.MainTitleLabel.Location = new Point(10, 10); // Set the position of the label.
                this.Controls.Add(this.MainTitleLabel);
                this.Show();
            }

        }
    }
}