using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сourse1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.ShowDialog();
        }
    }
}
