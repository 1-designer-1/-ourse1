using System;
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
            int number = random.Next(2, 10);
            return number;
        }

        /// <summary>
        /// Массив с случайными значениями для теста
        /// </summary>
        /// <param name="numeral">Количкство чисел в тесте</param>
        /// <param name="array">Вывод массива с числами</param>
        public void RadomNumberArray(int numeral, out int[] array)
        {
            Random random = new Random();
            array = new int[numeral];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 1000);
            }
            array.Distinct();

        }


        /// <summary>
        /// Значения от пользователя 
        /// </summary>
        /// <param name="numeral">Массив строковый</param>
        /// <param name="countNumberArray">Кол-во чисел</param>
        /// <returns>Массив с числами</returns>
        public int[] userArray(string[] sNumeral)
        {
            int countNumberArray = sNumeral.Length;
            int[] Nums = new int[countNumberArray];
            for (int i = 0; i < countNumberArray; i++)
            {
                Nums[i] = int.Parse(sNumeral[i]);
            }
            return Nums;

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
                
                for (int j = 0; j < arrayRandom.Length ; j++)
                {
                    if (userResponse[i] == arrayRandom[j]) coll++;
                }
                                 
            }

           return coll ;

        }



    }




}
