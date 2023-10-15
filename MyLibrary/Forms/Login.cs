using Microsoft.VisualBasic.Logging;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            if ((!string.IsNullOrEmpty(usernameBox.Text) ||
                !string.IsNullOrWhiteSpace(usernameBox.Text)) &&
                (!string.IsNullOrEmpty(passwordBox.Text) ||
                !string.IsNullOrWhiteSpace(passwordBox.Text)))
            {
                User? user = null;
                User.SelectFromTable($"SELECT username, password FROM public.users WHERE username = '{usernameBox.Text}' AND password = '{passwordBox.Text}';", user);
                if (user != null)
                {
                this.DialogResult = DialogResult.OK;
                this.Close();
                }
                else
                {
                    MessageBox.Show("Try again!");

                }
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
