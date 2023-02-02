using BusinessObject;

namespace FactoryDesignPattern
{
    //------------------Start Credit Card Example------------------//

    /// <summary>
    /// 'ConcreteProduct' class
    /// </summary>
    public class Rupay : ICreditCard
    {
        public string GetCardType()
        {
            return EnumCardType.Rupay.ToString();
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
            return EnumCardType.Titanium.ToString(); //"Titanium Edge";
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
            return EnumCardType.Platinum.ToString(); //"Platinum Plus";
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

    //------------------End Credit Card Example------------------//


    //------------------Start Car Example------------------//

    /// <summary>
    /// 'ConcreteProduct' class
    /// </summary>
    class Honda : ICarSupplier
    {
        public string CarColor
        {
            get { return EnumColor.RED.ToString(); }
        }

        public string GetCarModel()
        {
            return "Honda Car Model is Honda 2014";
        }
    }

    /// <summary>
    /// 'ConcreteProduct' class
    /// </summary>
    class BMW : ICarSupplier
    {
        public string CarColor
        {
            get { return EnumColor.WHITE.ToString(); }
        }

        public string GetCarModel()
        {
            return "BMW Car Model is BMW 2000";
        }
    }

    /// <summary>
    /// 'ConcreteProduct' class
    /// </summary>
    class Tata : ICarSupplier
    {
        public string CarColor
        {
            get { return EnumColor.YELLOW.ToString(); }
        }

        public string GetCarModel()
        {
            return "Tata Car Model is Tata 2016";
        }
    }

    /// <summary>
    /// 'ConcreteProduct' class
    /// </summary>
    class Suzuki : ICarSupplier
    {
        public string CarColor
        {
            get { return EnumColor.Orange.ToString(); }
        }
        public string GetCarModel()
        {
            return "Suzuki Car Model is Suzuki 2006";
        }
    }

    //------------------End Car Example------------------//
}
