using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd;

namespace FrontEnd
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Test1ButtonClick(object sender, EventArgs e)
        {
            var empl = StaticDataStorage.Data.Employees.FirstOrDefault();
            test1Button.Text = empl.Name;
        }

        private void Test2ButtonClick(object sender, EventArgs e)
        {
            var empl = StaticDataStorage.Data.Employees.LastOrDefault();
            test2Button.Text = empl.Name;
        }
    }
}
