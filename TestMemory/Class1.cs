using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMemory
{
    public class Class1
    {
        public void RadomNumberArray(int numeral, out int[] Array, out int koll)
        {
            Random random = new Random();
            koll = 0;
            Array = new int[numeral];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(0, 1000);
                koll++;
            }

        }

        //public int Examination(int[] ArrayUser, int[] ArrayRandom)
        //{

        //}






    }
}
