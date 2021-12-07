using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestMemory;

namespace Сourse1
{
    public partial class Rezult : Form
    {

        public Rezult()
        {
            InitializeComponent();
            label1.Text = Convert.ToString(Rezuit.сollNumberRandom);
            label2.Text = Convert.ToString(Rezuit.сollNumberUserTrue);
            label3.Text = Convert.ToString(Rezuit.сollNumberUser);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Rezult_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
