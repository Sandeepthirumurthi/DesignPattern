using DesignPatternFactory.Implementation;
using DesignPatternFactory.Interface;

namespace DesignPatternFactory
{
    public class DesignPatternFactory
    {
        public static void Main(string[] args)
        {
            ICreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

            if(cardDetails != null)
            {
                Console.WriteLine("Card Type: " + cardDetails.GetCardType());
                Console.WriteLine("Credit limit: " + cardDetails.GetCardLimit());
                Console.WriteLine("Annual charge: " + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
        }
    }
}