using DesignPatternFactory.Implementation;
using DesignPatternFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFactory
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard cardDetails = null;

            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }

            if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }

            if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }

            return cardDetails;
        } 
    }
}
