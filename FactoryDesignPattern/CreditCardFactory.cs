namespace FactoryDesignPattern
{
    public class CreditCardFactory
    {
        /// <summary>
        /// The Creator Class
        /// </summary>
        /// <param name="cardType"></param>
        /// <returns></returns>
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard cardDetails = null;

            if (cardType == "Rupay")
            {
                cardDetails = new Rupay();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }

            return cardDetails;
        }
    }
}
