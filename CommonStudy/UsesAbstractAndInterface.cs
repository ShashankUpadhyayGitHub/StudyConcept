using System;

namespace CommonStudy
{
    //When we need some common variable, method (abstract and non-abstract method) in base class then use abstract class
    //When we need some method in base class but implementation in child class based as per the requirment then use interface, also use interface for multiple inheritance. 

    public abstract class BankingService
    {
        public void GetPersonInfo()
        {
            Console.WriteLine("Name: Shashank Upadhyay");
        }

        public abstract void CreditSummary();

        public abstract void DebitSummary();
    }

    public interface IMutualFund
    {
        void MutualFund();
    }

    public interface IInsurance
    {
        void Insurance();
    }

    public class SBIBank : BankingService, IMutualFund, IInsurance
    {
        public override void CreditSummary()
        {
            //throw new NotImplementedException();
            Console.WriteLine("SBI Credit Summary: Shashank Upadhyay");
        }

        public override void DebitSummary()
        {
            Console.WriteLine("SBI Debit Summary: Shashank Upadhyay");
        }

        public void MutualFund()
        {
            Console.WriteLine("SBI Mutual Fund: Shashank Upadhyay");
        }

        public void Insurance()
        {
            Console.WriteLine("SBI Insurance: Shashank Upadhyay");
        }
    }

    public class ICICIBank: BankingService, IMutualFund
    {
        public override void CreditSummary()
        {
            Console.WriteLine("ICICI Credit Summary: Shashank Upadhyay");
        }

        public override void DebitSummary()
        {
            Console.WriteLine("ICICI Debit Summary: Shashank Upadhyay");
        }

        public void MutualFund()
        {
            Console.WriteLine("ICICI Insurance: Shashank Upadhyay");
        }
    }

    public class AxisBank: BankingService, IInsurance
    {
        public override void CreditSummary()
        {
            Console.WriteLine("ICICI Credit Summary: Shashank Upadhyay");
        }

        public override void DebitSummary()
        {
            Console.WriteLine("ICICI Debit Summary: Shashank Upadhyay");
        }

        public void Insurance()
        {
            Console.WriteLine("Axis Insurance: Shashank Upadhyay");
        }
    }
}
