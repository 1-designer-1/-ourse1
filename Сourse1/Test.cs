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
    public partial class Test : Form
    {
        Class1 Class1 = new Class1();
        public Test()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();// для теста
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.RadomNumberArray(Class1.RadomNumber(), out int[] array);
            for (int i = 0; i < array.Length; i++)
            {
                listBox1.Items.Add(array[i].ToString());

            }
            timer1.Enabled = true;//запуск таймера
            button1.Enabled = false;//чтобы пользователь не мог посмотреть числа еще раз

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {
                int[] array = Class1.userArray(Convert.ToInt32(textBox1.Text));
                textBox1.Clear();
                textBox1.Focus();
                timer1.Enabled = false;
                for (int i = 0; i < array.Length; i++)
                {
                    listBox1.Items.Add(Convert.ToString(array[i]));

                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }






        }
    }
}
