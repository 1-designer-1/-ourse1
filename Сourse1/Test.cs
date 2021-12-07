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
        ClassTest Class1 = new ClassTest();

        public Test()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
            button3.Enabled = false;
        }

        List<int> arrayUserList = new List<int>();
        List<int> arrayRndList = new List<int>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Удаление чисел по заданию
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int countRandomNumeral = Class1.RadomNumber();
            Class1.RadomNumberArray(countRandomNumeral, out int[] array);
            for (int i = 0; i < array.Length; i++)
            {
                listBox1.Items.Add(array[i].ToString());//показ чисел пользователю

            }
            timer1.Enabled = true;//запуск таймера
            button1.Enabled = false;//чтобы пользователь не мог посмотреть числа еще раз
            Rezuit.сollNumberRandom = countRandomNumeral;// Вывод кол-ва показаных чисел в конце теста
            arrayRndList = array.ToList();
            groupBox2.Enabled = true;
            button3.Enabled = true;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] strMassNumber = textBox1.Text.Split(' ', '/', ',', ':', ';', '-', '+', '"','?',
                    '*', '.', '!', '@', '<', '>', '#', '$', '%', '^', '&', '=', '(', ')','{','}','[',']');
                int[] intMassTrans = Class1.UserArray(strMassNumber);
                arrayUserList = intMassTrans.ToList();
                Rezuit.сollNumberUser = strMassNumber.Length;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Clear();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] examinationArrayRnd = arrayRndList.ToArray();
            int[] examinationArrayUser = arrayUserList.ToArray();
            Rezuit.сollNumberUserTrue = Class1.Examination(examinationArrayUser, examinationArrayRnd);
            Rezult rezult = new Rezult();
            rezult.ShowDialog();
        }
    }
}
