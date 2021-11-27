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
        }
    }
}
