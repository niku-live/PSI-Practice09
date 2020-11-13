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
        ILogic logic;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(ILogic logic): this()
        {
            this.logic = logic;
        }

        private void Test1ButtonClick(object sender, EventArgs e)
        {
            test1Button.Text = logic.GetFirstEmployeeName();
        }

        private void Test2ButtonClick(object sender, EventArgs e)
        {
            test2Button.Text = logic.GetLastEmployeeName();
        }
    }
}
