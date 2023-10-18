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
    public partial class Edit : Form, ITable
    {
        public Edit()
        {
            InitializeComponent();
        }

        public void ColumnsInit()
        {
            throw new NotImplementedException();
        }

        public void ReInit()
        {
            throw new NotImplementedException();
        }
    }
}
