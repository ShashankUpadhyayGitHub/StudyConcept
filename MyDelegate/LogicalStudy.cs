using System;
using System.Linq;

namespace CommonStudy
{
    public class LogicalStudy
    {
        public string ToopCenterStar, ToopStar, ToopStarPyramid, ToopTriangle, ToopReverseArray, ToopDuplicateArray, ToopPrimeNumber = string.Empty;

        public string ToopFibonacci, ToopSwitchCase = string.Empty;

        public string Reverse(string text)
        {
            if (text == null) return null;

            char[] nn = text.ToCharArray();
            // this was posted by petebob as well 
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }

        private static int Check_Prime(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return 0;
                }
            }
            if (i == number)
            {
                return 1;
            }
            return 0;
        }

        //-------------------Example Arranging values of array in Ascending order-----------------------//

        /// <summary>
        /// Sorting string values without using any method/function
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int[] AscendingArray(int[] number)
        {
            //http://programcall.com/4/interview/program-to-reverse-a-number-using-csnet.aspx
            //http://stackoverflow.com/questions/14768010/simple-bubble-sort-c-sharp
            //http://stackoverflow.com/questions/13817045/how-to-sort-elements-of-an-array-using-nested-for-loops

            //

            string[] Names = { "Flag", "Nest", "Cup", "Burg", "Yatch", "Next" };

            for (int i = 0; i < Names.Length; i++)
            {
                var x = Names[i];
                var y = i;

                while (y > 0 && Names[y - 1].CompareTo(x) > 0)
                {
                    var z = Names[y - 1];

                    Names[y] = Names[y - 1];

                    y = y - 1;
                }

                Names[y] = x;
            }

            //------------------------------------------------------

            string[] Color = new string[] { "Red", "Blue", "Orange", "Green", "Purple", "White" };

            var Sort = from S in Color orderby S select S;

            foreach (string c in Sort)
            {
                Console.WriteLine(c);
            }

            //------------------------------------------------------

            int[] GetNum = { 20, 10, 50, 46, 26, 87, 25, 5, 97, 24 };

            for (int i = 0; i < GetNum.Length; i++)
            {
                for (int j = i; j < GetNum.Length; j++)
                {
                    if (GetNum[i] > GetNum[j])
                    {
                        int Temp = GetNum[i];
                        GetNum[i] = GetNum[j];
                        GetNum[j] = Temp;
                    }
                }
            }

            return number;
        }

        public void BindReverse()
        {
            string GetName = "Shashank Upadhyay";

            //string GetTopic = "BLAH BLAH CODE TO ADD PRINTER VIA WINDOWS EXEC";

            ToopReverseArray = string.Empty;

            ToopReverseArray = ToopReverseArray + "<h1>Reverse Name Using Array</h1><br />";

            char[] Get = GetName.ToCharArray();

            int len = Get.Length;

            for (int G = Get.Length; G > 0; G--)
            {
                len--;

                ToopReverseArray = ToopReverseArray + Get[len];
            }
        }

        public void BindStarPyramid()
        {
            //http://stackoverflow.com/questions/22901673/making-a-star-pyramid-in-c-sharp

            int SpacesNumber = 10;//the number of spaces

            int NumberOfLines = 10;//the number of lines

            for (int I = 1; I <= NumberOfLines; I++)
            {
                //loop to print spaces
                for (int j = 1; j < SpacesNumber; j++)
                {
                    ToopStarPyramid = ToopStarPyramid + " ";
                }

                SpacesNumber--;

                //loop to print stars
                for (int K = 1; K < I * 2; K++)
                {
                    ToopStarPyramid = ToopStarPyramid + "*";
                }

                //create a new Line
                ToopStarPyramid = ToopStarPyramid + Environment.NewLine;
                ToopStarPyramid = ToopStarPyramid + "<br />";
            }

            ToopStarPyramid.ToString();
        }

        public void BindStar()
        {
            //http://stackoverflow.com/questions/22901673/making-a-star-pyramid-in-c-sharp
            int rows, star, spaces;
            int number_of_stars = 6;
            int number_of_rows = number_of_stars;

            ToopStar = ToopStar + "<h1>Bind Star</h1><br />";

            for (rows = 1; rows <= number_of_rows; rows++)
            {
                for (spaces = 1; spaces <= number_of_stars; spaces++)
                {
                    ToopStar = ToopStar + " ";
                }
                for (star = 1; star <= rows; star++)
                {
                    ToopStar = ToopStar + "*";
                    ToopStar = ToopStar + " ";
                }

                ToopStar = ToopStar + "<br />";

                number_of_stars = number_of_stars - 1;
            }
        }

        public void BindTriangle()
        {
            int i, c, length;

            char[] arr = "Hello Everybody!".ToCharArray();

            length = arr.Length;

            ToopTriangle = ToopTriangle + "<h1>Triangle Function</h1>";

            for (i = length; i >= 0; i--)
            {
                ToopTriangle = ToopTriangle + "<br />";

                for (c = 0; c < i; c++)
                {
                    ToopTriangle = ToopTriangle + arr[c];
                }
            }
        }

        public bool IsArrayExist(int[] MyArray, int Value)
        {
            bool Exist = false;

            //return Array.IndexOf(a, val) != -1;

            //foreach (string x in MyArray)
            //{
            //    if (x.Equals(Value))
            //    {
            //    }
            //}

            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] == Value)
                {
                    Exist = true;
                    break;
                }
            }

            return Exist;
        }

        public void FindDuplicateArray()
        {
            bool GetExist = false;

            int[] GetNum = { 1, 2, 2, 3, 4, 4, 5, 6, 7, 8 };

            int[] GetArray = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };

            ToopDuplicateArray = ToopDuplicateArray + "<h1>Duplicate In Array</h1><div class='clear'>&nbsp;</div>";

            //int[] values = new int[] { 4, 5, 6, 7 };

            //var output = from i in values where i < 4 orderby i select i;

            //foreach (int j in values) Response.Write(j); 

            int[] DistinctArray = new int[20];

            for (int D = 0; D < GetArray.Length; D++)
            {
                GetExist = IsArrayExist(DistinctArray, GetArray[D]);

                //GetExist = Array.Exists(GetArray, element => element == GetArray[D]);

                if (GetExist == false)
                {
                    DistinctArray[D] = GetArray[D];
                }
            }

            for (int i = 0; i < GetArray.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < GetArray.Length; j++)
                {
                    if (GetArray[i] == GetArray[j])
                    {
                        count = count + 1;
                    }
                }

                ToopDuplicateArray = ToopDuplicateArray + "" + GetArray[i] + " occurs " + count + " times <div class='clear'>&nbsp;</div>";
            }
        }

        public bool CheckForDuplicates(string[] Array)
        {
            var duplicates = Array.GroupBy(p => p).Where(g => g.Count() > 1).Select(g => g.Key);

            return (duplicates.Count() > 0);
        }

        public void DiamondPattern()
        {
            //Recursive Function/Method ??
            //pascal triangle program ??
            System.Console.WriteLine("Pascal Triangle Program");
            System.Console.Write("Enter the number of rows: ");
            string input = System.Console.ReadLine();

            int n = Convert.ToInt32(10);


            for (int y = 0; y < n; y++)
            {
                int c = 1;
                for (int q = 0; q < n - y; q++)
                {
                    System.Console.Write("   ");
                }

                for (int x = 0; x <= y; x++)
                {
                    System.Console.Write("   {0:D} ", c);
                    c = c * (y - x) / (x + 1);
                }
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }

        public void DiamondPatternn()
        {
            int n = Convert.ToInt32("8");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                for (int k = 1; k < i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 0; j < (n - i); j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                for (int k = 1; k < i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        public void PrimeNumber()
        {
            int a = Convert.ToInt32(4);
            bool isPrime = true;

            for (int i = 1; i <= a; i++)
            {
                for (int j = 2; j <= a; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;

                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("Prime:" + i);
                }

                isPrime = true;
            }

            for (int i = 0; i < 10; i++)
            {
                if (IsPrimeNumber(i) == true)
                    ToopPrimeNumber = ToopPrimeNumber + "'{0,8:n}\t', " + i + "";
            }
        }

        public bool IsPrimeNumber(int num)
        {
            bool Prime = true;

            int factor = num / 2;

            int i = 0;

            for (i = 2; i <= factor; i++)
            {
                if ((num % i) == 0)

                    Prime = false;
            }

            return Prime;
        }

        public void FibonacciSeries(int FinalNumber)
        {
            //-------------------Fibonacci Series (For Loop)-----------------------//

            int First = 0;
            int Second = 1;
            int Next = 1;

            for (int i = 0; i < FinalNumber; i++)
            {
                Next = First + Second;
                First = Second;
                Second = Next;

                ToopFibonacci = ToopFibonacci + Second + ",";
            }
        }

        public void SwitchCaseStatement()
        {
            int age = Convert.ToInt32(40);
            int flag;
            if (age >= 1 && age <= 8)
            {
                flag = 1;
            }
            else if (age >= 9 && age <= 15)
            {
                flag = 2;
            }
            else if (age >= 16 && age <= 100)
            {
                flag = 3;
            }
            else
            {
                flag = 4;
            }
            switch (flag)
            {
                case 1:
                    ToopSwitchCase = ToopSwitchCase + ("You are only " + age + " years old\n You must be kidding right.\nPlease fill in your *real* age.");
                    break;
                case 2:
                    ToopSwitchCase = ToopSwitchCase + ("You are only " + age + " years old\n That's too young!");
                    break;
                case 3:
                    ToopSwitchCase = ToopSwitchCase + ("You are " + age + " years old\n Perfect.");
                    break;
                default:
                    ToopSwitchCase = ToopSwitchCase + ("You an old person.");
                    break;
            }

            //-----------------------------------------------------------------------------------//

            //string input = "Do you enjoy C# ? (yes/no/maybe)";

            string GetInput = "yes";

            switch (GetInput.ToLower())
            {
                case "yes":
                case "maybe":
                    Console.WriteLine("Great!");
                    break;
                case "no":
                    Console.WriteLine("Too bad!");
                    break;
            }
        }

        //-------------------Example Recursive Function(For Loop)-----------------------//

        public long Factorial(int n)
        {
            if (n == 0)
                return 1;
            long value = 1;
            for (int i = n; i > 0; i--)
            {
                value *= i;
            }
            return value;
        }

        //-------------------Example Recursive Function(For Loop)-----------------------//

        public void BindLogic()
        {
            int GetBal = 0;

            int Get = 0;

            for (Get = 0; Get++ < 5; Get++)
            {
                GetBal = Get;
            }

            GetBal = Get;

            int[] GetNumber = { 2, 5, 6, 3, 4, 8, 9, 7, 52, 63, 47, 52, 10, 99, 75, 58 };

            int ThirdNumber = GetNumber[3];

            int CalNumber = GetNumber.Count() - 1;

            int CalNumbers = GetNumber.Length - 1;

            int SecondLast = GetNumber[GetNumber.Length - 2];

            //----------Count length of word without using Inbuilt functions----------//

            string GetWord = "Shashank Upadhyay";

            int CountLetter = 0;

            foreach (var c in GetWord)
            {
                CountLetter++;
            }

            //----------Count length of word without using Inbuilt functions----------//
        }
    }
}


