using BusinessObject;

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

            if (cardType == EnumCardType.Rupay.ToString())
            {
                cardDetails = new Rupay();
            }
            else if (cardType == EnumCardType.Titanium.ToString())
            {
                cardDetails = new Titanium();
            }
            else if (cardType == EnumCardType.Platinum.ToString())
            {
                cardDetails = new Platinum();
            }

            return cardDetails;
        }
    }
}
