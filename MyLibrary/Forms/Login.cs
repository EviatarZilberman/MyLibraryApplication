using Microsoft.VisualBasic.Logging;
using MyLibraryApp.Models;
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
    public partial class Login : Form
    {
        public static User? LoggedUser { get; set; } = null;
        public string Username { get; set; } = string.Empty;

        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(usernameBox.Text) || !string.IsNullOrWhiteSpace(usernameBox.Text)) && (!string.IsNullOrEmpty(passwordBox.Text) || !string.IsNullOrWhiteSpace(passwordBox.Text)))
            {
                this.Username = usernameBox.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password are invalid!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
