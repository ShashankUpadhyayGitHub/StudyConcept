namespace FactoryDesignPattern
{
    /// <summary>
    /// The 'Product' interface
    /// </summary>
    public interface ICreditCard
    {
        string GetCardType();

        int GetCreditLimit();

        int GetAnnualCharge();
    }
}
