namespace FactoryDesignPattern
{
    /// <summary>
    /// 'ConcreteProduct' class
    /// </summary>
    class CreditCardProduct
    {

    }

    /// <summary>
    /// 'ConcreteProduct' class
    /// </summary>
    public class Rupay : ICreditCard
    {
        public string GetCardType()
        {
            return "Rupay";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }

    /// <summary>
    /// 'ConcreteProduct' class
    /// </summary>
    public class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }

    /// <summary>
    /// 'ConcreteProduct' class
    /// </summary>
    public class Platinum : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum Plus";
        }
        public int GetCreditLimit()
        {
            return 35000;
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}
