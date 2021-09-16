using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMemory
{
    public class Class1
    {
        public int[] RadomNumberArray(int numeral)//переделать в void
        {
            Random random = new Random();
            int koll = 0;
            int[] Array = new int[numeral];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(0, 1000);
                koll++;
            }

            return Array;

        }

        public int Examination(int[] ArrayUser, int[] ArrayRandom)
        {

        }






    }
}
