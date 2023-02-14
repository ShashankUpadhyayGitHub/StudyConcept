using System;
using System.Collections.Generic;

namespace CommonStudy
{
    // Yield keyboard help to do custom and stateful iteration over a collection
    class YieldStudy
    {
        public List<int> listNumber = new List<int>();

        public void AddNumber()
        {
            listNumber.Add(1);
            listNumber.Add(2);
            listNumber.Add(3);
            listNumber.Add(4);
            listNumber.Add(5);
        }

        public void PrintNumber()
        {
            AddNumber();

            //Approach 1 > Filter data without using the third variable or temp collection
            foreach (int number in YieldFilter(listNumber))
            {
                Console.WriteLine("Number is: ", number);
            }

            //Approach 2 > Filter data using temp collection
            foreach (int number in Filter(listNumber))
            {
                Console.WriteLine("Number is: ", number);
            }
        }

        /// <summary>
        /// Approach 1 > Filter the number which is greator then 3 using yield keyboard = stateful iteration
        /// </summary>
        /// <param name="listNumber"></param>
        /// <returns></returns>
        public IEnumerable<int> YieldFilter(List<int> listNumber)
        {
            foreach (var number in listNumber)
            {
                if (number > 3)
                {
                    yield return number;
                }
            }
        }

        /// <summary>
        /// Approach 2 > Filter the number which is greator then 3 using hold the values into temp collection = custom iteration
        /// </summary>
        /// <param name="listNumber"></param>
        /// <returns></returns>
        public IEnumerable<int> Filter(List<int> listNumber)
        {
            List<int> temp = new List<int>();

            foreach (var number in listNumber)
            {
                if(number > 3)
                {
                    temp.Add(number);
                }
            }

            return temp;
        }
    }
}
