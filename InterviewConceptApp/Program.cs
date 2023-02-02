using FactoryDesignPattern;
using System;

namespace InterviewConceptApp
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.ReadLine();
        }
    }
}