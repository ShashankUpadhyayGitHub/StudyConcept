using BusinessObject;
using CommonStudy;
using FactoryDesignPattern;
using System;
using System.Threading;

namespace InterviewConceptApp
{
    public class Program
    {
        static Thread firstThread = new Thread(new ThreadStart(ThreadStudy.fun1));
        static Thread secondThread = new Thread(new ThreadStart(ThreadStudy.fun2));

        static void Main(string[] args)
        {
            //--------Factory Design pattern--------//

            if (args.Length > 0)
            {
                foreach (string item in args)
                {
                    ICreditCard cardInfo = CreditCardFactory.GetCreditCard(item);

                    if (cardInfo != null)
                    {
                        Console.WriteLine("CardType : " + cardInfo.GetCardType());
                        Console.WriteLine("CreditLimit : " + cardInfo.GetCreditLimit());
                        Console.WriteLine("AnnualCharge :" + cardInfo.GetAnnualCharge());
                    }
                    else
                    {
                        Console.Write("Invalid Card Type");
                    }
                }
            }
            else
            {
                Console.Write("Oops! Invalid Selection");
            }

            //--------Factory Design pattern--------//

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

        public void ExecuteMethod()
        {
            //LogicalStudy.FibonacciSeries(20);

            //SwitchCaseStatement();

            //Factorial(5);

            //BindLogic();
        }
    }
}