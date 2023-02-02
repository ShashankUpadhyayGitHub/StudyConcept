using BusinessObject;

namespace FactoryDesignPattern
{
    public class FactoryInfo
    {
        //------------------Start Credit Card Factory------------------//

        /// <summary>
        /// The Creator Class
        /// </summary>
        /// <param name="cardType"></param>
        /// <returns></returns>
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard cardDetails = null;

            if (cardType.ToLower() == EnumCardType.Rupay.ToString().ToLower())
            {
                cardDetails = new Rupay();
            }
            else if (cardType == EnumCardType.Titanium.ToString().ToLower())
            {
                cardDetails = new Titanium();
            }
            else if (cardType == EnumCardType.Platinum.ToString().ToLower())
            {
                cardDetails = new Platinum();
            }

            return cardDetails;
        }

        //------------------End Credit Card Factory------------------//


        //------------------Start Car Factory------------------//

        public static ICarSupplier GetCarInfo(string carType)
        {
            switch (carType.ToLower())
            {
                case "honda":
                    return new Honda();
                case "bmw":
                    return new BMW();
                case "tata":
                    return new Tata();
                case "suzuki":
                    return new Suzuki();
                default:
                    return null;
            }
        }

        //------------------End Car Factory------------------//
    }
}
