﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMemory
{
    public class Class1
    {
        /// <summary>
        /// Количество чисел в тесте
        /// </summary>
        /// <returns></returns>
        public int RadomNumber()
        {
            Random random = new Random();
            int number = random.Next(5, 10);
            return number;
        }

        /// <summary>
        /// Массив с случайными значениями для теста
        /// </summary>
        /// <param name="numeral">Количкство чисел в тесте</param>
        /// <param name="array">Вывод массива с числами</param>
        /// <param name="koll">Вывод количества показаных чисел</param>
        public void RadomNumberArray(int numeral, out int[] array)
        {
            Random random = new Random();
            array = new int[numeral];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 1000);
            }
            array.Distinct().ToArray();

        }

        /// <summary>
        /// Сравнение 
        /// </summary>
        /// <param name="userResponse"></param>
        /// <param name="arrayRandom"></param>
        /// <returns></returns>
        public int Examination(int[] userResponse, int[] arrayRandom) 
        {

            int coll = 0;
            for (int i = 0; i < userResponse.Length; i++)
            {
                if (userResponse[i] == arrayRandom[i]) coll++;
            }
            // contains c# сравнивание 

            return coll;

        }










        //private IEnumerable dfgdgfd()
        //{
        //    RadomNumberArray();
        //    yield return new wait
        //}






    }
}
