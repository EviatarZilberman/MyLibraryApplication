using Microsoft.VisualBasic.Logging;
using MyLibraryApp.Models;
using PostgreSQLDBManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyLibrary.Forms
{
    public partial class Login : Form
    {
        [AllowNull]
        public static User? LoggedUser { get; set; } = null;

        public Login()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {

            if ((!string.IsNullOrEmpty(usernameBox.Text) ||
                !string.IsNullOrWhiteSpace(usernameBox.Text)) &&
                (!string.IsNullOrEmpty(passwordBox.Text) ||
                !string.IsNullOrWhiteSpace(passwordBox.Text)))
            {
                CoreReturns result = await User.SelectUserFromTable($"SELECT internal_id, creation_date, last_change, first_name, last_name, email, password, birth_date, username FROM public.users WHERE username = '{usernameBox.Text}' AND password = '{passwordBox.Text}'");
                if (result == CoreReturns.SUCCESS)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Try again!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Username or password are invalid!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
