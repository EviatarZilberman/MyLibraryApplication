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
    public partial class Main : Form
    {
        public Main()
        {
            Login login = new Login(); // Creates a new instance of login screen.
            login.ShowDialog(); // Shows the login instance above all screens.
            if (login.DialogResult == DialogResult.OK && login.Username != null)
            {
                mainTitleLabel.Text = $"Welcome {login.Username}!";
                this.Show();
            }
            InitializeComponent();
            
        }
    }
}
