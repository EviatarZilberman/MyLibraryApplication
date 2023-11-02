using MyLibraryApp.Models;
using PostgreSQLDBManager;
using Utilities;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.UserNameBox.Text) || string.IsNullOrWhiteSpace(this.UserNameBox.Text))
            {
                MessageBox.Show("Username is invalid!");
            }
            if (string.IsNullOrEmpty(this.firstNameBox.Text) || string.IsNullOrWhiteSpace(this.firstNameBox.Text))
            {
                MessageBox.Show("First name is invalid!");
            }
            if (string.IsNullOrEmpty(this.lastNameBox.Text) || string.IsNullOrWhiteSpace(this.lastNameBox.Text))
            {
                MessageBox.Show("Last name is invalid!");
            }
            if (string.IsNullOrEmpty(this.firstNameBox.Text) || string.IsNullOrWhiteSpace(this.firstNameBox.Text))
            {
                MessageBox.Show("First name is invalid!");
            }
            if (string.IsNullOrEmpty(this.emailBox.Text) || string.IsNullOrWhiteSpace(this.emailBox.Text) || !this.emailBox.Text.Contains("@"))
            {
                MessageBox.Show("Email is invalid!");
            }
            if (string.IsNullOrEmpty(this.passwordBox.Text) || string.IsNullOrWhiteSpace(this.passwordBox.Text) || this.passwordBox.Text.Length < 8)
            {
                MessageBox.Show("Password is invalid!");
            }
            if (string.IsNullOrEmpty(this.confirmPasswordBox.Text) || string.IsNullOrWhiteSpace(this.confirmPasswordBox.Text) || this.passwordBox.Text.Length < 8)
            {
                MessageBox.Show("Confirm password is invalid!");
            }
            if (this.confirmedPassword.Text != this.passwordBox.Text)
            {
                MessageBox.Show("Password not confirmed!");
            }
            /*  if (this.birthDateOnlyBox.Value == null)
              {
                  MessageBox.Show("Birth date is invalid!");
              }*/
            User user = new User(firstNameBox.Text,
                lastNameBox.Text, emailBox.Text,
                passwordBox.Text,
                UserNameBox.Text, birthDateOnlyBox.Value);
            CoreReturns result = await DBManager.Instance().Insert(user.InsertQuery());

            if (result == CoreReturns.SUCCESS)
            {
                MessageBox.Show("Success!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
