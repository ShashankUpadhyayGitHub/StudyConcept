using BusinessObject;
using CommonStudy;
using FactoryDesignPattern;
using SingletonPattern;
using SolidPrinciples;
using System;
using System.Threading;

namespace InterviewConceptApp
{
    public class Program
    {
        static Thread firstThread = new Thread(new ThreadStart(ThreadStudy.fun1));
        static Thread secondThread = new Thread(new ThreadStart(ThreadStudy.fun2));
        static AbstractStudy objAbstract = new AbstractStudy();

        static void Main(string[] args)
        {
            //--------Factory Design pattern--------//

            if (args.Length > 0)
            {
                foreach (string item in args)
                {
                    ICreditCard objCardInfo = FactoryInfo.GetCreditCard(item);

                    ICarSupplier objCarInfo = FactoryInfo.GetCarInfo(item);

                    if (objCardInfo != null)
                    {
                        Console.WriteLine("CardType : " + objCardInfo.GetCardType());
                        Console.WriteLine("CreditLimit : " + objCardInfo.GetCreditLimit());
                        Console.WriteLine("AnnualCharge : " + objCardInfo.GetAnnualCharge());
                    }
                    else if (objCarInfo != null)
                    {
                        Console.WriteLine(String.Format("{0} And Coloar is {1}.", objCarInfo.GetCarModel(), objCarInfo.CarColor));
                    }
                    else
                    {
                        Console.Write("Sorry! Invalid Selection");
                    }
                }
            }
            else
            {
                Console.Write("Oops! something went wrong.");
            }

            //--------Factory Design pattern--------//

            //--------Singleton Pattern--------//

            SingletonInfo.GetSingletonClass();

            //--------Singleton Pattern--------//

            //--------Dependency Inversion--------//

            //---UI Layer-- -
            MiddleLayer objML = new MiddleLayer(new SQLServerDAL());

            objML.PersonName = "Shashank Upadhyay";

            objML.Add();

            //--------Dependency Inversion--------//

            //--------Abstract Example--------//

            objAbstract.Add(1, 2);

            //--------Abstract Example--------//

            //--------Delegate Example--------//

            DelegateStudy.BindPerson();

            //--------Delegate Example--------//


            //--------Sealed Class Example--------//

            SealedClass sealedCls = new CommonStudy.SealedClass();
            int total = sealedCls.Add(4, 5);
            Console.WriteLine("Total = " + total.ToString());

            //--------Sealed Class Example--------//

            //--------Thread Example--------//

            firstThread.Start();
            secondThread.Start();

            ThreadStudy.Method1();
            ThreadStudy.Method2();
            ThreadStudy.Method3();

            //--------Thread Example--------//

            //--------enumerations Days example--------//

            int WeekdayStart = (int)EnumDays.Monday;
            int WeekdayEnd = (int)EnumDays.Friday;
            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);

            //--------enumerations Days example--------//

            Console.ReadLine();
        }

        public void IsPrime()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = LogicalStudy.PrimeNumberByInput(number);
            if (result == 0)
            {
                Console.WriteLine("{0} is not a prime number", number);
            }
            else
            {
                Console.WriteLine("{0} is  a prime number", number);
            }
            Console.Read();
        }

        public void ExecuteMethod()
        {
            int[] Num = { 20, 10, 50, 46, 26, 87, 25, 5, 97, 24 };

            //LogicalStudy.FibonacciSeries(20);

            //SwitchCaseStatement();

            //Factorial(5);

            //BindLogic();

            //FindDuplicateArray();

            //BindReverse();

            //BindTriangle();

            //BindStar();

            //BindStarPyramid();

            //PrimeNumber();

            //AscendingArray(Num);
        }
    }
}