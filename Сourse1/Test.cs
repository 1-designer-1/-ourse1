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

        int _count1;
        List<int> ArrayUser = new List<int>();
        List<int> ArrayRnd = new List<int>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Удаление чисел по заданию
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = Class1.RadomNumber();
            Class1.RadomNumberArray(count, out int[] array);
            for (int i = 0; i < array.Length; i++)
            {
                listBox1.Items.Add(array[i].ToString());//показ чисел пользователю

            }
            timer1.Enabled = true;//запуск таймера
            button1.Enabled = false;//чтобы пользователь не мог посмотреть числа еще раз
            Rezuit.сollNumberRandom = Class1.RadomNumber();// Вывод кол-ва показаных чисел в конце теста
            ArrayRnd = array.ToList();
            _count1 = count;


        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] sNum = textBox1.Text.Split(' ');
                if (_count1 > sNum.Length) { };
                int[] Nums1 = Class1.userArray(sNum, _count1);
                ArrayUser = Nums1.ToList();

            }  
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] array1 = ArrayRnd.ToArray();
            int[] array2 = ArrayUser.ToArray();
            Rezuit.сollNumberUserTrue = Class1.Examination(array2, array1);
            label2.Text = Convert.ToString(Rezuit.сollNumberUserTrue);
            label1.Text = Convert.ToString(Rezuit.сollNumberRandom);

            //  Rezult rezult = new Rezult();
            // rezult.ShowDialog();
        }
    }
}
