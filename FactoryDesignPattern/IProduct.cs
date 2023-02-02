namespace FactoryDesignPattern
{
    //------------------Credit Card Example------------------//

    /// <summary>
    /// The 'Product' interface
    /// </summary>
    public interface ICreditCard
    {
        string GetCardType();

        int GetCreditLimit();

        int GetAnnualCharge();
    }


    //------------------Car Example------------------//

    /// <summary>
    /// The 'Product' interface
    /// </summary>
    public interface ICarSupplier
    {
        string CarColor
        {
            get;
        }

        string GetCarModel();
    }
}
